using Swsk33.Mct2Dump.Model;
using Swsk33.ReadAndWriteSharp.FileUtil;
using System.Windows.Forms;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// dump文件读取策略
	/// </summary>
	public class DumpReadStrategy : ReadStrategy
	{
		public string OpenFile()
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "dump文件/bin文件/mfd文件|*.dump;*.bin;*.mfd";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}
			return null;
		}

		public ICCardData ReadData(string filePath)
		{
			byte[] originData = BinaryUtils.ReadBinaryFile(filePath);
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