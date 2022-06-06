using Newtonsoft.Json;
using Swsk33.Mct2Dump.Model;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// JSON文件保存策略
	/// </summary>
	public class JSONWriteStrategy : WriteStrategy
	{
		public string SetSavePath()
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "json文件|*.json";
			dialog.Title = "保存为json文件";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}
			return null;
		}

		public bool SaveDataToFile(ICCardData data, string filePath)
		{
			Dictionary<string, object> resultData = new Dictionary<string, object>();
			resultData.Add("Created", "Mct2Dump");
			resultData.Add("FileType", "mfcard");
			Dictionary<string, string> blocks = new Dictionary<string, string>();
			// 16个扇区依次处理
			for (int i = 0; i < 16; i++)
			{
				// 先处理数据行，一行16个字节，共3行48个字节
				for (int j = 0; j < 3; j++)
				{
					string eachLine = "";
					for (int k = 0; k < 16; k++)
					{
						eachLine += data.Sectors[i].Contents[j * 16 + k].ToString("X2");
					}
					blocks.Add((i * 4 + j).ToString(), eachLine);
				}
				// 再处理密钥和访问控制
				blocks.Add((i * 4 + 3).ToString(), data.Sectors[i].KeyA + data.Sectors[i].Control + data.Sectors[i].KeyB);
			}
			resultData.Add("blocks", blocks);
			File.WriteAllText(filePath, JsonConvert.SerializeObject(resultData, Formatting.Indented));
			return File.Exists(filePath);
		}
	}
}