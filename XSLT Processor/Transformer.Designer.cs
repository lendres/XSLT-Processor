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
			this.SuspendLayout();
			// 
			// buttonProcess
			// 
			this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonProcess.Location = new System.Drawing.Point(413, 163);
			this.buttonProcess.Name = "buttonProcess";
			this.buttonProcess.Size = new System.Drawing.Size(75, 23);
			this.buttonProcess.TabIndex = 0;
			this.buttonProcess.Text = "&Process";
			this.buttonProcess.UseVisualStyleBackColor = true;
			this.buttonProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClose.Location = new System.Drawing.Point(494, 163);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "&Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// textBoxInputFile
			// 
			this.textBoxInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInputFile.Location = new System.Drawing.Point(12, 25);
			this.textBoxInputFile.Name = "textBoxInputFile";
			this.textBoxInputFile.Size = new System.Drawing.Size(471, 20);
			this.textBoxInputFile.TabIndex = 14;
			// 
			// buttonBrowseInputFile
			// 
			this.buttonBrowseInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseInputFile.Location = new System.Drawing.Point(489, 23);
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
			this.labelInputFile.Location = new System.Drawing.Point(12, 9);
			this.labelInputFile.Name = "labelInputFile";
			this.labelInputFile.Size = new System.Drawing.Size(75, 13);
			this.labelInputFile.TabIndex = 12;
			this.labelInputFile.Text = "XML Input File";
			// 
			// textBoxXsltFile
			// 
			this.textBoxXsltFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxXsltFile.Location = new System.Drawing.Point(12, 72);
			this.textBoxXsltFile.Name = "textBoxXsltFile";
			this.textBoxXsltFile.Size = new System.Drawing.Size(471, 20);
			this.textBoxXsltFile.TabIndex = 17;
			// 
			// buttonBrowseXsltFile
			// 
			this.buttonBrowseXsltFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseXsltFile.Location = new System.Drawing.Point(489, 70);
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
			this.labelXsltFile.Location = new System.Drawing.Point(12, 56);
			this.labelXsltFile.Name = "labelXsltFile";
			this.labelXsltFile.Size = new System.Drawing.Size(53, 13);
			this.labelXsltFile.TabIndex = 15;
			this.labelXsltFile.Text = "XSLT File";
			// 
			// textBoxOutputFile
			// 
			this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutputFile.Location = new System.Drawing.Point(12, 117);
			this.textBoxOutputFile.Name = "textBoxOutputFile";
			this.textBoxOutputFile.Size = new System.Drawing.Size(471, 20);
			this.textBoxOutputFile.TabIndex = 20;
			// 
			// buttonBrowseOutputFile
			// 
			this.buttonBrowseOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseOutputFile.Location = new System.Drawing.Point(489, 115);
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
			this.labelOutputFile.Location = new System.Drawing.Point(12, 101);
			this.labelOutputFile.Name = "labelOutputFile";
			this.labelOutputFile.Size = new System.Drawing.Size(58, 13);
			this.labelOutputFile.TabIndex = 18;
			this.labelOutputFile.Text = "Output File";
			// 
			// Transformer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(581, 198);
			this.Controls.Add(this.textBoxOutputFile);
			this.Controls.Add(this.buttonBrowseOutputFile);
			this.Controls.Add(this.labelOutputFile);
			this.Controls.Add(this.textBoxXsltFile);
			this.Controls.Add(this.buttonBrowseXsltFile);
			this.Controls.Add(this.labelXsltFile);
			this.Controls.Add(this.textBoxInputFile);
			this.Controls.Add(this.buttonBrowseInputFile);
			this.Controls.Add(this.labelInputFile);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonProcess);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(5000, 240);
			this.MinimumSize = new System.Drawing.Size(20, 240);
			this.Name = "Transformer";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "XST Processor";
			this.ResumeLayout(false);
			this.PerformLayout();

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

	} // End class.
} // End namespace.