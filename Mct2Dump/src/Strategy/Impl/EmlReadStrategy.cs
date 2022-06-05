using Swsk33.Mct2Dump.Model;
using System.Collections.Generic;
using System.Globalization;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// EML格式读取策略
	/// </summary>
	public class EmlReadStrategy : ReadStrategy
	{
		/// <summary>
		/// 读取EML文件
		/// </summary>
		/// <param name="data">原EML文件内容，为字符串数组（元素是每行）</param>
		/// <returns>解析后的IC卡数据类型</returns>
		public ICCardData ReadData(object data)
		{
			string[] originData = (string[])data;
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
				sector.KeyA = keyAndControl.Substring(0, 14);
				sector.Control = keyAndControl.Substring(14, 6);
				sector.KeyB = keyAndControl.Substring(20);
				// 保存该扇区
				result.Sectors[i] = sector;
			}
			return result;
		}
	}
}