namespace DigitalProduction.XSTProcessor
{
	partial class Transformer
	{
		#region Members / Variables.

		private System.Windows.Forms.Button				buttonProcess;
		private System.Windows.Forms.Button				buttonClose;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer		components = null;

		#endregion

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonProcess = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.textBoxInputFile = new System.Windows.Forms.TextBox();
			this.buttonBrowseInputFile = new System.Windows.Forms.Button();
			this.labelInputFile = new System.Windows.Forms.Label();
			this.textBoxXsltFile = new System.Windows.Forms.TextBox();
			this.buttonBrowseXsltFile = new System.Windows.Forms.Button();
			this.labelXsltFile = new System.Windows.Forms.Label();
			this.textBoxOutputFile = new System.Windows.Forms.TextBox();
			this.buttonBrowseOutputFile = new System.Windows.Forms.Button();
			this.labelOutputFile = new System.Windows.Forms.Label();
			this.textBoxPostProcessor = new System.Windows.Forms.TextBox();
			this.buttonBrowsePostProcessor = new System.Windows.Forms.Button();
			this.checkBoxPostProcessor = new System.Windows.Forms.CheckBox();
			this.groupBoxProcessor = new System.Windows.Forms.GroupBox();
			this.groupBoxPostProcessing = new System.Windows.Forms.GroupBox();
			this.groupBoxProcessor.SuspendLayout();
			this.groupBoxPostProcessing.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonProcess
			// 
			this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonProcess.Location = new System.Drawing.Point(413, 273);
			this.buttonProcess.Name = "buttonProcess";
			this.buttonProcess.Size = new System.Drawing.Size(75, 23);
			this.buttonProcess.TabIndex = 0;
			this.buttonProcess.Text = "&Process";
			this.buttonProcess.UseVisualStyleBackColor = true;
			this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClose.Location = new System.Drawing.Point(494, 273);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "&Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// textBoxInputFile
			// 
			this.textBoxInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInputFile.Location = new System.Drawing.Point(12, 36);
			this.textBoxInputFile.Name = "textBoxInputFile";
			this.textBoxInputFile.Size = new System.Drawing.Size(449, 20);
			this.textBoxInputFile.TabIndex = 14;
			// 
			// buttonBrowseInputFile
			// 
			this.buttonBrowseInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseInputFile.Location = new System.Drawing.Point(467, 34);
			this.buttonBrowseInputFile.Name = "buttonBrowseInputFile";
			this.buttonBrowseInputFile.Size = new System.Drawing.Size(80, 23);
			this.buttonBrowseInputFile.TabIndex = 13;
			this.buttonBrowseInputFile.Text = "Browse...";
			this.buttonBrowseInputFile.UseVisualStyleBackColor = true;
			this.buttonBrowseInputFile.Click += new System.EventHandler(this.buttonBrowseInputFile_Click);
			// 
			// labelInputFile
			// 
			this.labelInputFile.AutoSize = true;
			this.labelInputFile.Location = new System.Drawing.Point(12, 20);
			this.labelInputFile.Name = "labelInputFile";
			this.labelInputFile.Size = new System.Drawing.Size(75, 13);
			this.labelInputFile.TabIndex = 12;
			this.labelInputFile.Text = "XML Input File";
			// 
			// textBoxXsltFile
			// 
			this.textBoxXsltFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxXsltFile.Location = new System.Drawing.Point(12, 83);
			this.textBoxXsltFile.Name = "textBoxXsltFile";
			this.textBoxXsltFile.Size = new System.Drawing.Size(449, 20);
			this.textBoxXsltFile.TabIndex = 17;
			// 
			// buttonBrowseXsltFile
			// 
			this.buttonBrowseXsltFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseXsltFile.Location = new System.Drawing.Point(467, 81);
			this.buttonBrowseXsltFile.Name = "buttonBrowseXsltFile";
			this.buttonBrowseXsltFile.Size = new System.Drawing.Size(80, 23);
			this.buttonBrowseXsltFile.TabIndex = 16;
			this.buttonBrowseXsltFile.Text = "Browse...";
			this.buttonBrowseXsltFile.UseVisualStyleBackColor = true;
			this.buttonBrowseXsltFile.Click += new System.EventHandler(this.buttonBrowseXsltFile_Click);
			// 
			// labelXsltFile
			// 
			this.labelXsltFile.AutoSize = true;
			this.labelXsltFile.Location = new System.Drawing.Point(12, 67);
			this.labelXsltFile.Name = "labelXsltFile";
			this.labelXsltFile.Size = new System.Drawing.Size(53, 13);
			this.labelXsltFile.TabIndex = 15;
			this.labelXsltFile.Text = "XSLT File";
			// 
			// textBoxOutputFile
			// 
			this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutputFile.Location = new System.Drawing.Point(12, 128);
			this.textBoxOutputFile.Name = "textBoxOutputFile";
			this.textBoxOutputFile.Size = new System.Drawing.Size(449, 20);
			this.textBoxOutputFile.TabIndex = 20;
			// 
			// buttonBrowseOutputFile
			// 
			this.buttonBrowseOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseOutputFile.Location = new System.Drawing.Point(467, 126);
			this.buttonBrowseOutputFile.Name = "buttonBrowseOutputFile";
			this.buttonBrowseOutputFile.Size = new System.Drawing.Size(80, 23);
			this.buttonBrowseOutputFile.TabIndex = 19;
			this.buttonBrowseOutputFile.Text = "Browse...";
			this.buttonBrowseOutputFile.UseVisualStyleBackColor = true;
			this.buttonBrowseOutputFile.Click += new System.EventHandler(this.buttonBrowseOutputFile_Click);
			// 
			// labelOutputFile
			// 
			this.labelOutputFile.AutoSize = true;
			this.labelOutputFile.Location = new System.Drawing.Point(12, 112);
			this.labelOutputFile.Name = "labelOutputFile";
			this.labelOutputFile.Size = new System.Drawing.Size(58, 13);
			this.labelOutputFile.TabIndex = 18;
			this.labelOutputFile.Text = "Output File";
			// 
			// textBoxPostProcessor
			// 
			this.textBoxPostProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPostProcessor.Location = new System.Drawing.Point(12, 39);
			this.textBoxPostProcessor.Name = "textBoxPostProcessor";
			this.textBoxPostProcessor.Size = new System.Drawing.Size(449, 20);
			this.textBoxPostProcessor.TabIndex = 22;
			// 
			// buttonBrowsePostProcessor
			// 
			this.buttonBrowsePostProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowsePostProcessor.Location = new System.Drawing.Point(467, 37);
			this.buttonBrowsePostProcessor.Name = "buttonBrowsePostProcessor";
			this.buttonBrowsePostProcessor.Size = new System.Drawing.Size(80, 23);
			this.buttonBrowsePostProcessor.TabIndex = 21;
			this.buttonBrowsePostProcessor.Text = "Browse...";
			this.buttonBrowsePostProcessor.UseVisualStyleBackColor = true;
			// 
			// checkBoxPostProcessor
			// 
			this.checkBoxPostProcessor.AutoSize = true;
			this.checkBoxPostProcessor.Location = new System.Drawing.Point(12, 20);
			this.checkBoxPostProcessor.Name = "checkBoxPostProcessor";
			this.checkBoxPostProcessor.Size = new System.Drawing.Size(120, 17);
			this.checkBoxPostProcessor.TabIndex = 23;
			this.checkBoxPostProcessor.Text = "Run Post Processor";
			this.checkBoxPostProcessor.UseVisualStyleBackColor = true;
			this.checkBoxPostProcessor.CheckedChanged += new System.EventHandler(this.checkBoxPostProcessor_CheckedChanged);
			// 
			// groupBoxProcessor
			// 
			this.groupBoxProcessor.Controls.Add(this.labelInputFile);
			this.groupBoxProcessor.Controls.Add(this.buttonBrowseInputFile);
			this.groupBoxProcessor.Controls.Add(this.textBoxInputFile);
			this.groupBoxProcessor.Controls.Add(this.labelXsltFile);
			this.groupBoxProcessor.Controls.Add(this.textBoxOutputFile);
			this.groupBoxProcessor.Controls.Add(this.buttonBrowseXsltFile);
			this.groupBoxProcessor.Controls.Add(this.buttonBrowseOutputFile);
			this.groupBoxProcessor.Controls.Add(this.textBoxXsltFile);
			this.groupBoxProcessor.Controls.Add(this.labelOutputFile);
			this.groupBoxProcessor.Location = new System.Drawing.Point(10, 8);
			this.groupBoxProcessor.Name = "groupBoxProcessor";
			this.groupBoxProcessor.Size = new System.Drawing.Size(559, 162);
			this.groupBoxProcessor.TabIndex = 24;
			this.groupBoxProcessor.TabStop = false;
			this.groupBoxProcessor.Text = "XSLT Processing";
			// 
			// groupBoxPostProcessing
			// 
			this.groupBoxPostProcessing.Controls.Add(this.checkBoxPostProcessor);
			this.groupBoxPostProcessing.Controls.Add(this.buttonBrowsePostProcessor);
			this.groupBoxPostProcessing.Controls.Add(this.textBoxPostProcessor);
			this.groupBoxPostProcessing.Location = new System.Drawing.Point(10, 183);
			this.groupBoxPostProcessing.Name = "groupBoxPostProcessing";
			this.groupBoxPostProcessing.Size = new System.Drawing.Size(559, 74);
			this.groupBoxPostProcessing.TabIndex = 25;
			this.groupBoxPostProcessing.TabStop = false;
			this.groupBoxPostProcessing.Text = "Post Processing";
			// 
			// Transformer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(581, 307);
			this.Controls.Add(this.groupBoxPostProcessing);
			this.Controls.Add(this.groupBoxProcessor);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonProcess);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Transformer";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "XST Processor";
			this.groupBoxProcessor.ResumeLayout(false);
			this.groupBoxProcessor.PerformLayout();
			this.groupBoxPostProcessing.ResumeLayout(false);
			this.groupBoxPostProcessing.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInputFile;
		private System.Windows.Forms.Button buttonBrowseInputFile;
		private System.Windows.Forms.Label labelInputFile;
		private System.Windows.Forms.TextBox textBoxXsltFile;
		private System.Windows.Forms.Button buttonBrowseXsltFile;
		private System.Windows.Forms.Label labelXsltFile;
		private System.Windows.Forms.TextBox textBoxOutputFile;
		private System.Windows.Forms.Button buttonBrowseOutputFile;
		private System.Windows.Forms.Label labelOutputFile;
		private System.Windows.Forms.TextBox textBoxPostProcessor;
		private System.Windows.Forms.Button buttonBrowsePostProcessor;
		private System.Windows.Forms.CheckBox checkBoxPostProcessor;
		private System.Windows.Forms.GroupBox groupBoxProcessor;
		private System.Windows.Forms.GroupBox groupBoxPostProcessing;
	} // End class.
} // End namespace.