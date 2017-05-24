using System.ComponentModel;
using System.Windows;

namespace boCalc
{

	public partial class MainWindow : Window
	{
		
		#region constructor

		public MainWindow ()
		{
			InitializeComponent();

			Title = "BoCalc";
		}
		
		#endregion
		
		#region event

		protected override void OnClosing (CancelEventArgs e)
		{
			SettingsBinding.Save();
			base.OnClosing(e);
		}

		#endregion

	}

}
