﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Components
{
	[DataContract(IsReference=true)]
	public class TwitchEmote
	{
		[DataMember]
		public int EmoteId { get; set; }
		[DataMember]
		public String EmoteName { get; set; }
		[DataMember]
		public int Amount { get; private set; }

		public TwitchEmote(String EmoteName, int EmoteId, int Amount)
		{
			this.EmoteName = EmoteName;
			this.EmoteId = EmoteId;
			this.Amount = Amount;
			//Console.WriteLine("New Emote: {0} x{1}", EmoteName, Amount);
		}

		public void UseEmote(int Amount = 1)
		{
			this.Amount += Amount;
			//Console.WriteLine("Used emote. {0}", this.Amount);
		}

		public static IEnumerable<TwitchEmote> QuickSort(IEnumerable<TwitchEmote> i)
		{
			if (!i.Any())
				return i;
			var p = i.Last().EmoteId;
			return QuickSort(i.Where(x => x.EmoteId < p)).Concat(i.Where(x => x.EmoteId == p).Concat(QuickSort(i.Where(x => x.EmoteId > p))));
		}
	}
}
