using Swsk33.ReadAndWriteSharp.FileUtil;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Swsk33.Mct2Dump
{
	public class ICFileReader
	{
		/// <summary>
		/// 读取文本文件内容并解析为二进制形式
		/// </summary>
		/// <param name="filePath">待读取文件路径</param>
		/// <returns>解析完成的二进制内容</returns>
		public static byte[] ReadTextToByte(string filePath)
		{
			string[] data = File.ReadAllLines(filePath);
			List<byte> bytes = new List<byte>();
			foreach (string line in data)
			{
				string trimedLine = line.Trim();
				if (trimedLine.Contains("+"))
				{
					continue;
				}
				if (trimedLine.Contains("-"))
				{
					trimedLine = trimedLine.Replace('-', 'F');
				}
				// 把每一行按照两个字符读取
				for (int i = 0; i < trimedLine.Length; i += 2)
				{
					string eachByteString = trimedLine.Substring(i, 2);
					bytes.Add(byte.Parse(eachByteString, NumberStyles.HexNumber));
				}
			}
			return bytes.ToArray();
		}

		public static string ReadBinaryToText(string filePath)
		{
			string result = "";
			byte[] data = BinaryUtils.ReadBinaryFile(filePath);
			// 十六个扇区每次读取一个扇区数据，也就是64个字节
			for (int i = 0; i < 16; i++)
			{
				result += "+Sector: " + i + "\n";
				// 一个扇区4行
				for (int j = 0; j < 4; j++)
				{
					// 一行16个字节
					for (int k = 0; k < 16; k++)
					{
						result += data[i * 64 + j * 16 + k].ToString("X2");
					}
					result += "\n";
				}
			}
			return result.Substring(0, result.Length - 1);
		}
	}
}