namespace Swsk33.Mct2Dump
{
	partial class MainGUI
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
			this.mctToDumpOption = new System.Windows.Forms.RadioButton();
			this.dumpToMctOption = new System.Windows.Forms.RadioButton();
			this.openInputFile = new System.Windows.Forms.Button();
			this.inputFilePath = new System.Windows.Forms.TextBox();
			this.inputLabel = new System.Windows.Forms.Label();
			this.setSaveFile = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.outputFilePath = new System.Windows.Forms.TextBox();
			this.convert = new System.Windows.Forms.Button();
			this.tip = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// mctToDumpOption
			// 
			this.mctToDumpOption.AutoSize = true;
			this.mctToDumpOption.Checked = true;
			this.mctToDumpOption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mctToDumpOption.Location = new System.Drawing.Point(23, 21);
			this.mctToDumpOption.Name = "mctToDumpOption";
			this.mctToDumpOption.Size = new System.Drawing.Size(144, 18);
			this.mctToDumpOption.TabIndex = 0;
			this.mctToDumpOption.TabStop = true;
			this.mctToDumpOption.Text = "mct/txt转dump/bin";
			this.mctToDumpOption.UseVisualStyleBackColor = true;
			// 
			// dumpToMctOption
			// 
			this.dumpToMctOption.AutoSize = true;
			this.dumpToMctOption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dumpToMctOption.Location = new System.Drawing.Point(173, 21);
			this.dumpToMctOption.Name = "dumpToMctOption";
			this.dumpToMctOption.Size = new System.Drawing.Size(144, 18);
			this.dumpToMctOption.TabIndex = 0;
			this.dumpToMctOption.Text = "dump/bin转mct/txt";
			this.dumpToMctOption.UseVisualStyleBackColor = true;
			// 
			// openInputFile
			// 
			this.openInputFile.Location = new System.Drawing.Point(242, 54);
			this.openInputFile.Name = "openInputFile";
			this.openInputFile.Size = new System.Drawing.Size(75, 23);
			this.openInputFile.TabIndex = 1;
			this.openInputFile.Text = "浏览";
			this.openInputFile.UseVisualStyleBackColor = true;
			this.openInputFile.Click += new System.EventHandler(this.openInputFile_Click);
			// 
			// inputFilePath
			// 
			this.inputFilePath.Location = new System.Drawing.Point(103, 54);
			this.inputFilePath.Name = "inputFilePath";
			this.inputFilePath.Size = new System.Drawing.Size(133, 21);
			this.inputFilePath.TabIndex = 2;
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputLabel.Location = new System.Drawing.Point(17, 58);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(91, 14);
			this.inputLabel.TabIndex = 3;
			this.inputLabel.Text = "待转换文件：";
			// 
			// setSaveFile
			// 
			this.setSaveFile.Location = new System.Drawing.Point(242, 86);
			this.setSaveFile.Name = "setSaveFile";
			this.setSaveFile.Size = new System.Drawing.Size(75, 23);
			this.setSaveFile.TabIndex = 1;
			this.setSaveFile.Text = "浏览";
			this.setSaveFile.UseVisualStyleBackColor = true;
			this.setSaveFile.Click += new System.EventHandler(this.setSaveFile_Click);
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.outputLabel.Location = new System.Drawing.Point(31, 89);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(77, 14);
			this.outputLabel.TabIndex = 3;
			this.outputLabel.Text = "输出位置：";
			// 
			// outputFilePath
			// 
			this.outputFilePath.Location = new System.Drawing.Point(103, 86);
			this.outputFilePath.Name = "outputFilePath";
			this.outputFilePath.Size = new System.Drawing.Size(133, 21);
			this.outputFilePath.TabIndex = 2;
			// 
			// convert
			// 
			this.convert.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.convert.Location = new System.Drawing.Point(132, 118);
			this.convert.Name = "convert";
			this.convert.Size = new System.Drawing.Size(70, 30);
			this.convert.TabIndex = 1;
			this.convert.Text = "转换";
			this.convert.UseVisualStyleBackColor = true;
			this.convert.Click += new System.EventHandler(this.convert_Click);
			// 
			// tip
			// 
			this.tip.AutoSize = true;
			this.tip.ForeColor = System.Drawing.Color.Red;
			this.tip.Location = new System.Drawing.Point(3, 144);
			this.tip.Name = "tip";
			this.tip.Size = new System.Drawing.Size(71, 12);
			this.tip.TabIndex = 4;
			this.tip.Text = "正在转换...";
			this.tip.Visible = false;
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 160);
			this.Controls.Add(this.tip);
			this.Controls.Add(this.outputFilePath);
			this.Controls.Add(this.inputFilePath);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.convert);
			this.Controls.Add(this.setSaveFile);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.openInputFile);
			this.Controls.Add(this.dumpToMctOption);
			this.Controls.Add(this.mctToDumpOption);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "mct和dump互转";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton mctToDumpOption;
		private System.Windows.Forms.RadioButton dumpToMctOption;
		private System.Windows.Forms.Button openInputFile;
		private System.Windows.Forms.TextBox inputFilePath;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Button setSaveFile;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.TextBox outputFilePath;
		private System.Windows.Forms.Button convert;
		private System.Windows.Forms.Label tip;
	}
}

