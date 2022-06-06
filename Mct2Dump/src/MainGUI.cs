using Swsk33.Mct2Dump.Model;
using Swsk33.Mct2Dump.Param;
using Swsk33.Mct2Dump.Strategy;
using Swsk33.ReadAndWriteSharp.Util;
using System;
using System.Threading;
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
		/// 启用或者禁用所有按钮
		/// </summary>
		/// <param name="enable">启用还是禁用按钮</param>
		private void operateButtons(bool enable)
		{
			inputTypeValue.Enabled = enable;
			outputTypeValue.Enabled = enable;
			openInputFile.Enabled = enable;
			setSaveFile.Enabled = enable;
			convert.Enabled = enable;
			tip.Visible = !enable;
		}

		private void openInputFile_Click(object sender, EventArgs e)
		{
			inputFilePath.Text = StrategyContext.GetInputFilePath(inputTypeValue.SelectedItem.ToString());
		}

		private void setSaveFile_Click(object sender, EventArgs e)
		{
			outputFilePath.Text = StrategyContext.GetSaveFilePath(outputTypeValue.SelectedItem.ToString());
		}

		private void convert_Click(object sender, EventArgs e)
		{
			if (StringUtils.IsEmpty(inputFilePath.Text) || StringUtils.IsEmpty(outputFilePath.Text))
			{
				MessageBox.Show("待转换文件或者输出文件路径不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			operateButtons(false);
			new Thread(() =>
			{
				ICCardData inputData = null;
				try
				{
					inputData = StrategyContext.ReadICDataFile(inputTypeValue.SelectedItem.ToString(), inputFilePath.Text);
				}
				catch (Exception)
				{
					MessageBox.Show("输入文件格式错误或者不完整或者过大！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					operateButtons(true);
					return;
				}
				bool success;
				try
				{
					success = StrategyContext.WriteICDataToFile(outputTypeValue.SelectedItem.ToString(), inputData, outputFilePath.Text);
				}
				catch (Exception)
				{
					MessageBox.Show("转换出现错误！请检查原文件是否完整！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					operateButtons(true);
					return;
				}
				if (success)
				{
					MessageBox.Show("转换完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("转换出现错误！请检查写入位置是否有权限！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				operateButtons(true);
			}).Start();
		}

		private void MainGUI_Load(object sender, EventArgs e)
		{
			// 初始化下拉容器
			inputTypeValue.Items.Add(DataType.MCT);
			inputTypeValue.Items.Add(DataType.EML);
			inputTypeValue.Items.Add(DataType.JSON);
			inputTypeValue.Items.Add(DataType.DUMP);
			inputTypeValue.SelectedIndex = 0;
			outputTypeValue.Items.Add(DataType.MCT);
			outputTypeValue.Items.Add(DataType.EML);
			outputTypeValue.Items.Add(DataType.JSON);
			outputTypeValue.Items.Add(DataType.DUMP);
			outputTypeValue.SelectedIndex = 0;
		}

		private void inputTypeValue_SelectedIndexChanged(object sender, EventArgs e)
		{
			inputFilePath.Text = "";
		}

		private void outputTypeValue_SelectedIndexChanged(object sender, EventArgs e)
		{
			outputFilePath.Text = "";
		}
	}
}