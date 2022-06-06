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
			this.openInputFile = new System.Windows.Forms.Button();
			this.inputFilePath = new System.Windows.Forms.TextBox();
			this.inputLabel = new System.Windows.Forms.Label();
			this.setSaveFile = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.outputFilePath = new System.Windows.Forms.TextBox();
			this.convert = new System.Windows.Forms.Button();
			this.tip = new System.Windows.Forms.Label();
			this.inputTypeLabel = new System.Windows.Forms.Label();
			this.inputTypeValue = new System.Windows.Forms.ComboBox();
			this.outputTypeLabel = new System.Windows.Forms.Label();
			this.outputTypeValue = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// openInputFile
			// 
			this.openInputFile.Location = new System.Drawing.Point(259, 48);
			this.openInputFile.Name = "openInputFile";
			this.openInputFile.Size = new System.Drawing.Size(75, 23);
			this.openInputFile.TabIndex = 1;
			this.openInputFile.Text = "浏览";
			this.openInputFile.UseVisualStyleBackColor = true;
			this.openInputFile.Click += new System.EventHandler(this.openInputFile_Click);
			// 
			// inputFilePath
			// 
			this.inputFilePath.Location = new System.Drawing.Point(132, 49);
			this.inputFilePath.Name = "inputFilePath";
			this.inputFilePath.ReadOnly = true;
			this.inputFilePath.Size = new System.Drawing.Size(121, 21);
			this.inputFilePath.TabIndex = 2;
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputLabel.Location = new System.Drawing.Point(45, 51);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(91, 14);
			this.inputLabel.TabIndex = 3;
			this.inputLabel.Text = "待转换文件：";
			// 
			// setSaveFile
			// 
			this.setSaveFile.Location = new System.Drawing.Point(259, 123);
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
			this.outputLabel.Location = new System.Drawing.Point(59, 126);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(77, 14);
			this.outputLabel.TabIndex = 3;
			this.outputLabel.Text = "输出位置：";
			// 
			// outputFilePath
			// 
			this.outputFilePath.Location = new System.Drawing.Point(132, 124);
			this.outputFilePath.Name = "outputFilePath";
			this.outputFilePath.ReadOnly = true;
			this.outputFilePath.Size = new System.Drawing.Size(121, 21);
			this.outputFilePath.TabIndex = 2;
			// 
			// convert
			// 
			this.convert.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.convert.Location = new System.Drawing.Point(141, 159);
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
			this.tip.Location = new System.Drawing.Point(2, 184);
			this.tip.Name = "tip";
			this.tip.Size = new System.Drawing.Size(71, 12);
			this.tip.TabIndex = 4;
			this.tip.Text = "正在转换...";
			this.tip.Visible = false;
			// 
			// inputTypeLabel
			// 
			this.inputTypeLabel.AutoSize = true;
			this.inputTypeLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.inputTypeLabel.Location = new System.Drawing.Point(17, 22);
			this.inputTypeLabel.Name = "inputTypeLabel";
			this.inputTypeLabel.Size = new System.Drawing.Size(119, 14);
			this.inputTypeLabel.TabIndex = 3;
			this.inputTypeLabel.Text = "待转换文件类型：";
			// 
			// inputTypeValue
			// 
			this.inputTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inputTypeValue.FormattingEnabled = true;
			this.inputTypeValue.Location = new System.Drawing.Point(132, 20);
			this.inputTypeValue.Name = "inputTypeValue";
			this.inputTypeValue.Size = new System.Drawing.Size(121, 20);
			this.inputTypeValue.TabIndex = 5;
			this.inputTypeValue.SelectedIndexChanged += new System.EventHandler(this.inputTypeValue_SelectedIndexChanged);
			// 
			// outputTypeLabel
			// 
			this.outputTypeLabel.AutoSize = true;
			this.outputTypeLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.outputTypeLabel.Location = new System.Drawing.Point(31, 95);
			this.outputTypeLabel.Name = "outputTypeLabel";
			this.outputTypeLabel.Size = new System.Drawing.Size(105, 14);
			this.outputTypeLabel.TabIndex = 3;
			this.outputTypeLabel.Text = "输出文件类型：";
			// 
			// outputTypeValue
			// 
			this.outputTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.outputTypeValue.FormattingEnabled = true;
			this.outputTypeValue.Location = new System.Drawing.Point(132, 93);
			this.outputTypeValue.Name = "outputTypeValue";
			this.outputTypeValue.Size = new System.Drawing.Size(121, 20);
			this.outputTypeValue.TabIndex = 5;
			this.outputTypeValue.SelectedIndexChanged += new System.EventHandler(this.outputTypeValue_SelectedIndexChanged);
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 200);
			this.Controls.Add(this.outputTypeValue);
			this.Controls.Add(this.inputTypeValue);
			this.Controls.Add(this.outputFilePath);
			this.Controls.Add(this.inputFilePath);
			this.Controls.Add(this.tip);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.convert);
			this.Controls.Add(this.setSaveFile);
			this.Controls.Add(this.outputTypeLabel);
			this.Controls.Add(this.inputTypeLabel);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.openInputFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IC卡数据文件格式转换";
			this.Load += new System.EventHandler(this.MainGUI_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button openInputFile;
		private System.Windows.Forms.TextBox inputFilePath;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Button setSaveFile;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.TextBox outputFilePath;
		private System.Windows.Forms.Button convert;
		private System.Windows.Forms.Label tip;
		private System.Windows.Forms.Label inputTypeLabel;
		private System.Windows.Forms.ComboBox inputTypeValue;
		private System.Windows.Forms.Label outputTypeLabel;
		private System.Windows.Forms.ComboBox outputTypeValue;
	}
}

