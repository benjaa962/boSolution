﻿using System.ComponentModel;
using System.Windows;

namespace boSolution.Application.boFile
{

	public partial class MainWindow : Window
	{
		
		#region constructor

		public MainWindow ()
		{
			InitializeComponent();

			Title = "BoFile";
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
