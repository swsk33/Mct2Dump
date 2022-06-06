using Swsk33.Mct2Dump.Model;
using Swsk33.ReadAndWriteSharp.FileUtil;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.Mct2Dump.Strategy.Impl
{
	/// <summary>
	/// dump文件写入策略
	/// </summary>
	public class DumpWriteStrategy : WriteStrategy
	{
		public string SetSavePath()
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "dump文件|*.dump|bin文件|*.bin|mfd文件|*.mfd";
			dialog.Title = "保存为dump/bin/mfd文件";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}
			return null;
		}

		public bool SaveDataToFile(ICCardData data, string filePath)
		{
			List<byte> result = new List<byte>();
			// 16个扇区逐个处理
			for (int i = 0; i < 16; i++)
			{
				// 加入数据
				result.AddRange(data.Sectors[i].Contents);
				// 加入访问控制和密钥
				string keyA = data.Sectors[i].KeyA;
				if (keyA.Contains("-"))
				{
					MessageBox.Show("扇区" + i + "的keyA包含未知密钥！将全部替换成0导出！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					keyA = keyA.Replace('-', '0');
				}
				string keyB = data.Sectors[i].KeyB;
				if (keyB.Contains("-"))
				{
					MessageBox.Show("扇区" + i + "的keyB包含未知密钥！将全部替换成0导出！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					keyB = keyB.Replace('-', '0');
				}
				string keyAndControl = keyA + data.Sectors[i].Control + keyB;
				for (int j = 0; j < keyAndControl.Length; j += 2)
				{
					result.Add(byte.Parse(keyAndControl.Substring(j, 2), NumberStyles.HexNumber));
				}
			}
			BinaryUtils.WriteBinaryFile(filePath, result.ToArray());
			return File.Exists(filePath);
		}
	}
}