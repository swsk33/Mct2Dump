using Swsk33.ReadAndWriteSharp.FileUtil;
using System;
using System.IO;
using System.Windows.Forms;

namespace Swsk33.Mct2Dump
{
	public partial class MainGUI : Form
	{
		public MainGUI()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
		}

		/// <summary>
		/// 操纵界面按钮和提示文件自
		/// </summary>
		/// <param name="enable">是否全部启用或者禁用，提示文字和按钮相反</param>
		private void operateButtonsAndTip(bool enable)
		{
			openInputFile.Enabled = enable;
			setSaveFile.Enabled = enable;
			convert.Enabled = enable;
			tip.Visible = !enable;
		}

		private void openInputFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (mctToDumpOption.Checked)
			{
				dialog.Filter = "文本数据文件|*.mct;*.txt";
			}
			else
			{
				dialog.Filter = "二进制数据文件|*.dump;*.bin";
			}
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				inputFilePath.Text = dialog.FileName;
			}
		}

		private void setSaveFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			if (dumpToMctOption.Checked)
			{
				dialog.Filter = "文本数据文件|*.mct;*.txt";
			}
			else
			{
				dialog.Filter = "二进制数据文件|*.dump;*.bin";
			}
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				outputFilePath.Text = dialog.FileName;
			}
		}

		private void convert_Click(object sender, EventArgs e)
		{
			// 输入校验
			if (!File.Exists(inputFilePath.Text))
			{
				MessageBox.Show("指定文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (outputFilePath.Text.Equals(""))
			{
				MessageBox.Show("输出路径不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (mctToDumpOption.Checked && BinaryUtils.IsBinaryFile(inputFilePath.Text))
			{
				MessageBox.Show("指定的文件不是个文本类型文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (dumpToMctOption.Checked && !BinaryUtils.IsBinaryFile(inputFilePath.Text))
			{
				MessageBox.Show("指定的文件不是个二进制类型文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// 执行转换
			operateButtonsAndTip(false);
		}
	}
}