namespace Swsk33.Mct2Dump.Model
{
	/// <summary>
	/// IC卡数据类
	/// </summary>
	public class ICCardData
	{
		private SectorData[] sectors = new SectorData[16];

		/// <summary>
		/// IC卡扇区数据，共十六个扇区
		/// </summary>
		public SectorData[] Sectors { get => sectors; set => sectors = value; }

		public override string ToString()
		{
			string result = "";
			// 逐个扇区输出
			for (int i = 0; i < sectors.Length; i++)
			{
				result += "扇区" + i + "数据：\r\n";
				SectorData eachSector = sectors[i];
				// 内容为16字节一行，共3行
				for (int j = 0; j < 3; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						result += eachSector.Contents[j * 16 + k].ToString("X2");
					}
					result += "\r\n";
				}
				result += "密钥A：" + eachSector.KeyA + "\r\n";
				result += "密钥B：" + eachSector.KeyB + "\r\n";
				result += "访问控制：" + eachSector.Control + "\r\n\r\n";
			}
			return result;
		}
	}
}