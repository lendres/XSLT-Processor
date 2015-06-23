using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalProduction.XSTProcessor
{
	/// <summary>
	/// Main program entry.
	/// </summary>
	static class Program
	{
		#region Main.

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Transformer());
		}

		#endregion

	} // End class.
} // End namespace.