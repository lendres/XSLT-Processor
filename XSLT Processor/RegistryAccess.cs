using DigitalProduction.Forms;
using DigitalProduction.Registry;

namespace DigitalProduction.XSTProcessor
{
	/// <summary>
	/// Provides presistent settings between instances.
	/// 
	/// Saves settings so the software can be closed, then reopened and the settings restored.
	/// </summary>
	public class RegistryAccess : FormWinRegistryAccess
    {
		#region Construction

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="owner">Owner of this registry access.</param>
		public RegistryAccess(DPMForm owner) :
			base(owner)
		{
			this.Install += this.OnInstall;
		}

		#endregion

		#region Installation

		/// <summary>
		/// Installation routine, mainly used for debugging.
		/// </summary>
		public void OnInstall()
		{
		}

		#endregion

		#region Registry Key Access


		#endregion

		#region Properties

		/// <summary>
		/// The path (location) of the input file.
		/// </summary>
		public string InputFile
		{
			get
			{
				return GetValue(AppKey(), "Input File", "");
			}

			set
			{
				SetValue(AppKey(), "Input File", value);
			}
		}

		/// <summary>
		/// The XSLT file.
		/// </summary>
		public string XsltFile
		{
			get
			{
				return GetValue(AppKey(), "XSLT File", "");
			}

			set
			{
				SetValue(AppKey(), "XSLT File", value);
			}
		}

		/// <summary>
		/// The output file.
		/// </summary>
		public string OutputFile
		{
			get
			{
				return GetValue(AppKey(), "Output File", "");
			}

			set
			{
				SetValue(AppKey(), "Output File", value);
			}
		}

		/// <summary>
		/// Should the post processor be run.
		/// </summary>
		public bool RunPostProcessor
		{
			get
			{
				return GetValue(AppKey(), "Run Post Processor", false);
			}

			set
			{
				SetValue(AppKey(), "Run Post Processor", value);
			}
		}

		/// <summary>
		/// The post processor file (batch file, executable, et cetera).
		/// </summary>
		public string PostProcessorFile
		{
			get
			{
				return GetValue(AppKey(), "Post Processor File", "");
			}

			set
			{
				SetValue(AppKey(), "Post Processor File", value);
			}
		}

		#endregion

	} // End class.
} // End namespace.