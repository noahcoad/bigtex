using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using bigtex.Properties;

namespace bigtex
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = this;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// select all the text
			txt.Focus();
			txt.SelectAll();

			// auto paste clipboard option
			if (Settings.Default.AutoPasteClipboard && !String.IsNullOrEmpty(Clipboard.GetText()))
				txt.Text = Clipboard.GetText();

			// make sure we are activated
			new Thread(new ThreadStart(() => { Thread.Sleep(300);
			Dispatcher.Invoke(new Action(() => { this.Activate(); this.Focus(); })); })).Start();
		}

		private void txt_KeyDown(object sender, KeyEventArgs e)
		{
			// close app if ESC is pressed
			if (e.Key == Key.Escape) this.Close();
		}

		public double BoxOpacity
		{ get { return Settings.Default.BoxText ? 1 : 0; } }
		
		public double MaxTextBoxWidth
		{ get { return this.ActualWidth - 100; } }
	}
}
