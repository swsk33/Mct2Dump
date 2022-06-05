using Newtonsoft.Json;
using Swsk33.Mct2Dump.Model;
using System.Collections.Generic;
using System.Globalization;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// JSON数据读取策略
	/// </summary>
	public class JSONReadStrategy : ReadStrategy
	{
		/// <summary>
		/// 读取JSON数据
		/// </summary>
		/// <param name="data">原JSON字符串</param>
		/// <returns>解析后的IC卡类型数据</returns>
		public ICCardData ReadData(object data)
		{
			ICCardData result = new ICCardData();
			Dictionary<string, object> total = JsonConvert.DeserializeObject<Dictionary<string, object>>((string)data);
			Dictionary<string, string> blocks = JsonConvert.DeserializeObject<Dictionary<string, string>>(total["blocks"].ToString());
			// 共十六个扇区，逐一读取
			for (int i = 0; i < 16; i++)
			{
				SectorData sector = new SectorData();
				List<byte> bytes = new List<byte>();
				// 先读取这个扇区前三行数据
				for (int j = 0; j < 3; j++)
				{
					// 取每一行字符串，每行按照两个字符读取
					string eachLine = blocks[(i * 4 + j).ToString()];
					for (int k = 0; k < eachLine.Length; k += 2)
					{
						bytes.Add(byte.Parse(eachLine.Substring(k, 2), NumberStyles.HexNumber));
					}
				}
				sector.Contents = bytes.ToArray();
				// 然后读取密钥和访问控制
				string keyAndControl = blocks[(i * 4 + 3).ToString()];
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