﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TwitchSharp.EventArguments
{
	public class MessageReceivedEventArgs : EventArgs
	{
		// PRIVMSG
		// @color=#1E0ACC;display-name=3ventic;emotes=25:0-4,12-16/1902:6-10;subscriber=0;turbo=1;user-type=mod;user_type=mod :3ventic!3ventic@3ventic.tmi.twitch.tv PRIVMSG #gophergaming :Kappa Keepo Kappa

		/*
			Tags to check for:

			TAG				TYPE		EXAMPLE_VALUE
			color			#RGB		#123456
			display-name	string		imthe666st			Use this as nick instead of that host stuff
			emotes			bunch		see above
			subscriber		boolean		0; 1
			turbo			boolean		0; 1
			user-type		enum		mod, admin, staff, globalmod, empty
			user_type		see above?

			color is hexadecimal RGB color code, which can be empty if the user never set it.
			display-name is the user's display name, escaped as described as described in the IRCv3 spec. Empty if it's never been set.
			emotes contains information to replace text in the message with the emote images and can be empty. The format is as follows:
			emote_id:first_index-last_index,another_first-another-last/another_emote_id:first_index-last_index
			emote_id is the number to use in this URL: http://static-cdn.jtvnw.net/emoticons/v1/:emote_id/:size (size is 1.0, 2.0 or 3.0)
			Emote indexes are simply character indexes. \001ACTION  does not count and indexing starts from the first character that is part of the user's "actual message". In the example message, the first Kappa (emote id 25) is from character 0 (K) to character 4 (a), and the other Kappa is from 12 to 16.
			subscriberand turbo are either 0 or 1 depending on whether the user has sub or turbo badge or not.
			user-type is either empty, mod, global_mod, admin or staff

			@badges=subscriber/0,premium/1;color=#15497A;display-name=jc5ive1;emotes=;id=9070c710-b524-499c-af00-b785ed910faf;login=jc5ive1;mod=0;msg-id=resub;msg-param-months=6;room-id=20702886;subscriber=1;system-msg=jc5ive1\ssubscribed\sfor\s6\smonths\sin\sa\srow!;tmi-sent-ts=1482031770322;turbo=0;user-id=118126696;user-type= :tmi.twitch.tv USERNOTICE #carlsagan42
		
			Regex: ([\w\d\-]+=[\w\d\/\,a-f0-9\-\\#]*)
			matches with every tag.
		*/

		public MessageType Type { get; }
		public Dictionary<String, String> Tags { get; }

		public String Message { get; }
		public String Channel { get; }
		public String RawMessage { get; }

		public String Nick { get { return Tags["display-name"]; } }
		public String Badges { get { return Tags["badges"]; } }

		public UInt32 Color { get { return UInt32.Parse(Tags["color"]); } }

		public Boolean IsSubscriber { get { return Tags["subscriber"] == "1"; } }
		public Boolean IsTurbo { get { return Tags["turbo"] == "1"; } }
		public Boolean IsModerator { get { return Tags["mod"] == "1"; } }

		public MessageReceivedEventArgs(String Message)
		{
			//Console.WriteLine("Starting to evaluate message...");
			this.Tags = new Dictionary<string, string>();
			this.RawMessage = Message;
			this.Type = MessageType.UNDEFINED;

            if (Message.StartsWith(@"PING"))
			{
				this.Type = MessageType.Ping;
				return;
			} else
			{
				String[] SpaceSplit = Message.Split(' ');
				// stuff
				this.Channel = SpaceSplit[3].Substring(1);

				// Tags
				String[] TagSplit = SpaceSplit[0].Substring(1).Split(';');
				foreach (String TagExpression in TagSplit)
				{
					String[] TagExpressionSplit = TagExpression.Split('=');
					//Console.WriteLine("TAG: {0}: {1}", TagExpressionSplit[0], TagExpressionSplit[1]);
					Tags.Add(TagExpressionSplit[0], TagExpressionSplit[1]);
				}

				if (String.IsNullOrWhiteSpace(this.Tags["display-name"]))
				{
					Tags["display-name"] = SpaceSplit[1].Substring(1).Split('!')[0];
				}

				if (SpaceSplit[2] == @"PRIVMSG")
				{
					this.Type = MessageType.Chat;

					String m = String.Empty;
					for (int i=4; i<SpaceSplit.Length; i++)
					{
						m += SpaceSplit[i];
						if (i < SpaceSplit.Length - 1) m += " ";
					}

					this.Message = m.Substring(1);



				}
				else if (SpaceSplit[2] == @"USERSTATE")
				{
					this.Type = MessageType.Userstate;
				}
				else if (SpaceSplit[2] == @"ROOMSTATE")
				{
					this.Type = MessageType.Roomstate;
				}
				else if (SpaceSplit[2] == @"USERNOTICE")
				{
					this.Type = MessageType.Usernotice;
					Console.WriteLine(RawMessage);
				}
				else
				{
					this.Type = MessageType.Server;
				}
			}

			//Console.WriteLine("Finished, hope cthis works...");
		}
	}

    public enum MessageType
    {
		UNDEFINED = -1,
		Server = 0,
		Ping = 1,
		Chat = 2,
		Whisper = 3,
		TwitchNotify = 4,
		Usernotice = 5,
		Userstate = 6,
		Roomstate = 7,
    }
}
