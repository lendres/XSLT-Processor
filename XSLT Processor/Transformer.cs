using DigitalProduction.Forms;
using GotDotNet.XInclude;
using Plossum.CommandLine;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace DigitalProduction.XSTProcessor
{
	/// <summary>
	/// A simple XSLT transformer.
	/// </summary>
	[CommandLineManager(ApplicationName = "XSLT Transformer", Copyright = "Copyright (c) Lance A. Endres.")]
	public partial class Transformer : Form
	{
		#region Members

		#endregion

		#region Construction

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Transformer()
		{
			InitializeComponent();

			SetPostProcessorControls();

			ParseCommandLine();
		}

		/// <summary>
		/// Parse the command line arguments.
		/// </summary>
		protected void ParseCommandLine()
		{
			// Create the parser to handle the command line arguments.  See the properties to determine valid command line arguments.
			CommandLineParser parser = new CommandLineParser(this);

			// We need to replace the existing quotation information because if we don't it replaces network address such as "\\computer" 
			// with "\computer" because it escapes the escape character.
			QuotationInfo quotationInfo = new QuotationInfo('\"');
			quotationInfo.AddEscapeCode('\"', '\"');
			parser.AddQuotation(quotationInfo);

			// Parse the command line arguments.  The parser will call Properties for each command line argument it finds with a matching
			// attribute.
			parser.Parse();
		}

		#endregion

		#region Properties

		/// <summary>
		/// The XML file the is the source material.
		/// </summary>
		[CommandLineOption(Name = "input", Description = "XML file that is the source material.")]
		public string InputFile
		{
			get
			{
				return this.textBoxInputFile.Text.Trim();
			}

			set
			{
				this.textBoxInputFile.Text	= value;
			}
		}

		/// <summary>
		/// The transformation sheet.
		/// </summary>
		[CommandLineOption(Name = "transform", Description = "Transformation file.")]
		public string XsltFile
		{
			get
			{
				return this.textBoxXsltFile.Text.Trim();
			}

			set
			{
				this.textBoxXsltFile.Text	= value;
			}
		}

		/// <summary>
		/// Output (destination) file.
		/// </summary>
		[CommandLineOption(Name = "output", Description = "Where the output is written to.")]
		public string OutputFile
		{
			get
			{
				return this.textBoxOutputFile.Text.Trim();
			}

			set
			{
				this.textBoxOutputFile.Text	= value;
			}
		}

		/// <summary>
		/// Output (destination) file.
		/// </summary>
		[CommandLineOption(Name = "runpostprocessor", BoolFunction = BoolFunction.TrueIfPresent, Description = "Specifies if the post processor should be run.")]
		public bool RunPostProcessor
		{
			get
			{
				return this.checkBoxPostProcessor.Checked;
			}

			set
			{
				this.checkBoxPostProcessor.Checked	= value;
			}
		}

		/// <summary>
		/// Output (destination) file.
		/// </summary>
		[CommandLineOption(Name = "postprocessor", Description = "Post processing routine to run after XSLT transformation is completed.")]
		public string PostProcessor
		{
			get
			{
				return this.textBoxPostProcessor.Text.Trim();
			}

			set
			{
				this.textBoxPostProcessor.Text	= value;
			}
		}

		#endregion

		#region Event Handlers

		#region XSLT Processing Section

		/// <summary>
		/// Browse for the input file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void buttonBrowseInputFile_Click(object sender, EventArgs eventArgs)
		{
			string path = FileSelect.BrowseForAnXMLFile(this, "Select the Input (XML) File");

			if (path != "")
			{
				this.InputFile = path;
			}
		}

		/// <summary>
		/// Browse for the transformation file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void buttonBrowseXsltFile_Click(object sender, EventArgs eventArgs)
		{
			string path = FileSelect.BrowseForAFile(this, "XSL Transformation files (*.xslt)|*.xslt|XML files (*.xml)|*.xml|Text files (*.txt)|*.txt|All files (*.*)|*.*");

			if (path != "")
			{
				this.XsltFile = path;
			}
		}

		/// <summary>
		/// Browse for the output file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void buttonBrowseOutputFile_Click(object sender, EventArgs eventArgs)
		{
			string path = FileSelect.BrowseForANewFileLocation(this, "All files (*.*)|*.*");

			if (path != "")
			{
				this.OutputFile = path;
			}
		}

		#endregion

		#region Post Processing Section

		/// <summary>
		/// Enable or disable post processing.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void checkBoxPostProcessor_CheckedChanged(object sender, EventArgs eventArgs)
		{
			SetPostProcessorControls();
		}

		/// <summary>
		/// Browse for the transformation file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void buttonBrowsePostProcessor_Click(object sender, EventArgs eventArgs)
		{
			string path = FileSelect.BrowseForAFile(this, "Executables (*.exe)|*.exe|Batch files (*.bat)|*.exe|All files (*.*)|*.*");

			if (path != "")
			{
				this.PostProcessor = path;
			}
		}

		#endregion

		#region Form

		/// <summary>
		/// Key up event handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="eventArgs">Event arguments.</param>
		private void Transformer_KeyUp(object sender, KeyEventArgs eventArgs)
		{
			switch (eventArgs.KeyCode)
			{
				case Keys.F5:
				{
					this.buttonProcess.PerformClick();
					eventArgs.Handled = true;
					break;
				}
			}
		}

		/// <summary>
		/// Process button click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonProcess_Click(object sender, EventArgs e)
		{
			string input		= this.textBoxInputFile.Text.Trim();
			string transform	= this.textBoxXsltFile.Text.Trim();
			string output		= this.textBoxOutputFile.Text.Trim();
			Transform(input, transform, output);
		}

		/// <summary>
		/// Close the application.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">Event arguments.</param>
		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		#endregion

		#region Methods

		/// <summary>
		/// Sets the enable/disable state of the post processor controls.
		/// </summary>
		private void SetPostProcessorControls()
		{
			bool enabled = this.checkBoxPostProcessor.Checked;
			this.textBoxPostProcessor.Enabled       = enabled;
			this.buttonBrowsePostProcessor.Enabled  = enabled;
		}


		/// <summary>
		/// Perform the transformation.
		/// </summary>
		/// <param name="inputFile">Input (XML) file.</param>
		/// <param name="xsltFile">Transformation (XSLT) file.</param>
		/// <param name="outputFile">Output file.</param>
		private void Transform(string inputFile, string xsltFile, string outputFile)
		{
			try
			{
				XIncludingReader xIncludingReader	= new XIncludingReader(inputFile);
		        XPathDocument xPathDocument			= new XPathDocument(xIncludingReader);

				XslCompiledTransform xslTransform	= new XslCompiledTransform(true);
				xslTransform.Load(xsltFile);
				
				System.IO.StreamWriter streamWriter = new StreamWriter(outputFile, false, System.Text.Encoding.ASCII);
				xslTransform.Transform(xPathDocument, new XsltArgumentList(), streamWriter);

				xIncludingReader.Close();
				streamWriter.Close();
			}
			catch (Exception exception)
			{
				// Add error handling here.
				MessageBox.Show(this, "Error running XSLT transformation.\n\n" + exception.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				return;
			}

			try
			{
				if (this.checkBoxPostProcessor.Checked)
				{
					ProcessStartInfo startinfo	= new ProcessStartInfo();
					startinfo.FileName			= System.IO.Path.GetFileName(this.PostProcessor);
					startinfo.WorkingDirectory	= System.IO.Path.GetDirectoryName(this.PostProcessor);
					//startinfo.Arguments			= "";

					Process process = Process.Start(startinfo);
				}
			}
			catch (Exception exception)
			{
				// Add error handling here.
				MessageBox.Show(this, "Error running post processor.\n\n" + exception.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
				return;
			}
		}

		#endregion

	} // End class.
} // End namespace.