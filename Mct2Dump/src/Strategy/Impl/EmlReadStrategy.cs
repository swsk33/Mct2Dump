using Swsk33.Mct2Dump.Model;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// EML格式读取策略
	/// </summary>
	public class EmlReadStrategy : ReadStrategy
	{
		public string OpenFile()
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "eml文件|*.eml";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}
			return null;
		}

		public ICCardData ReadData(string filePath)
		{
			string[] originData = File.ReadAllLines(filePath);
			ICCardData result = new ICCardData();
			// 16个扇区逐个读取
			for (int i = 0; i < 16; i++)
			{
				SectorData sector = new SectorData();
				List<byte> bytes = new List<byte>();
				// 先读取前三行数据区
				for (int j = 0; j < 3; j++)
				{
					string eachLine = originData[i * 4 + j];
					// 每两个字符读取一次
					for (int k = 0; k < eachLine.Length; k += 2)
					{
						bytes.Add(byte.Parse(eachLine.Substring(k, 2), NumberStyles.HexNumber));
					}
				}
				sector.Contents = bytes.ToArray();
				// 读取密钥区和访问控制
				string keyAndControl = originData[i * 4 + 3];
				sector.KeyA = keyAndControl.Substring(0, 12);
				sector.Control = keyAndControl.Substring(12, 8);
				sector.KeyB = keyAndControl.Substring(20);
				// 保存该扇区
				result.Sectors[i] = sector;
			}
			return result;
		}
	}
}