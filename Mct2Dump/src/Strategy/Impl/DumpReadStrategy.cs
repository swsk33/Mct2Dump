using Swsk33.Mct2Dump.Model;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// dump文件读取策略
	/// </summary>
	public class DumpReadStrategy : ReadStrategy
	{
		/// <summary>
		/// 读取dump文件
		/// </summary>
		/// <param name="data">原始dump文件数据，byte数组（二进制字节数据）</param>
		/// <returns>解析后的IC卡类型数据</returns>
		public ICCardData ReadData(object data)
		{
			byte[] originData = (byte[])data;
			ICCardData result = new ICCardData();
			// 16个扇区逐个读取，也就是一次读取64字节
			for (int i = 0; i < 16; i++)
			{
				SectorData sector = new SectorData();
				sector.Contents = new byte[48];
				// 先读取前三行，也就是48个字节
				for (int j = 0; j < 48; j++)
				{
					sector.Contents[j] = originData[i * 64 + j];
				}
				// 然后读取密钥和访问控制
				string keyAndControl = "";
				for (int j = 0; j < 16; j++)
				{
					keyAndControl += originData[i * 64 + 48 + j].ToString("X2");
				}
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