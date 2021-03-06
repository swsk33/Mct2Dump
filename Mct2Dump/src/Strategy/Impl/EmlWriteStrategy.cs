using Swsk33.Mct2Dump.Model;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// EML写入策略
	/// </summary>
	public class EmlWriteStrategy : WriteStrategy
	{
		public string SetSavePath()
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "eml文件|*.eml";
			dialog.Title = "保存为eml文件";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}
			return null;
		}

		public bool SaveDataToFile(ICCardData data, string filePath)
		{
			string result = "";
			// 16个扇区依次处理
			for (int i = 0; i < 16; i++)
			{
				// 先处理数据行，每行16字节，共3行
				for (int j = 0; j < 3; j++)
				{
					string eachLine = "";
					for (int k = 0; k < 16; k++)
					{
						eachLine += data.Sectors[i].Contents[j * 16 + k].ToString("X2");
					}
					result += eachLine + "\n";
				}
				// 再处理访问控制和密钥
				result += data.Sectors[i].KeyA + data.Sectors[i].Control + data.Sectors[i].KeyB + "\n";
			}
			File.WriteAllText(filePath, result.Substring(0, result.Length - 1));
			return File.Exists(filePath);
		}
	}
}