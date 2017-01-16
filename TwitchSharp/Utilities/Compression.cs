﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Utilities.Hashing;

namespace TwitchSharp.Utilities
{
	public static class Compression
	{
		public static byte[] Compress(byte[] Data)
		{
			List<byte> Adler32Checksum = BitConverter.GetBytes(Adler32.CalculateAdler32(Data)).ToList();
			Adler32Checksum.Reverse();
			using (MemoryStream ms = new MemoryStream())
			{
				using (DeflateStream gs = new DeflateStream(ms, CompressionMode.Compress))
				{
					gs.Write(Data, 0, Data.Length);

				}

				List<byte> lData = ms.ToArray().ToList();
				// Add a zlib header. 

				lData.InsertRange(0, new byte[] { 0x78, 0x9C }); // I'll add a different header generation later

				// Add ADLER32
				lData.AddRange(Adler32Checksum);


				return lData.ToArray();
			}
		}
		public static byte[] Decompress(byte[] Data)
		{
			using (MemoryStream ms = new MemoryStream(Data))
			{
				MemoryStream msInner = new MemoryStream();

				// Read past the first two bytes of the zlib header
				ms.Seek(2, SeekOrigin.Begin);


				using (DeflateStream z = new DeflateStream(ms, CompressionMode.Decompress))
				{
					z.CopyTo(msInner);

				}
				return msInner.ToArray();
			}
		}
	}
}
