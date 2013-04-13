using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using bigtex.Properties;

namespace bigtex
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_Deactivated(object sender, EventArgs e)
		{
			// close app if it looses focus
			this.Shutdown();
		}
	}
}
