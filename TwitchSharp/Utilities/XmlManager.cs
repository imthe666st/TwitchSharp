﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TwitchSharp.Utilities
{

	[DataContract(IsReference = true)]
	public abstract class XmlManager
	{
		public XmlManager()
		{
			Init();
		}
		protected abstract void Init();

		public static void SaveToXml(string FilePath, XmlManager SourceObject)
		{
			try
			{
				new FileInfo(FilePath).Directory.Create();
				using (FileStream writer = File.Create(FilePath))
				{
					DataContractSerializer xmlSerializer = new DataContractSerializer(SourceObject.GetType());
					xmlSerializer.WriteObject(writer, SourceObject);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unable to save file\t{0}", FilePath);
				Console.WriteLine(ex.StackTrace);
			}
		}

		public static XmlManager LoadFromXml(string FilePath)
		{
			
			try
			{
				using (FileStream stream = File.OpenRead(FilePath))
				{
					DataContractSerializer xmlSerializer = new DataContractSerializer(MethodBase.GetCurrentMethod().DeclaringType);
					var asd = xmlSerializer.ReadObject(stream);
                    return (XmlManager)asd;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unable to load file\t{0}", FilePath);
				Console.WriteLine(ex.Message);
				return null;
			}
		}
	}

}
