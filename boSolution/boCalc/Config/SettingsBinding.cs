using boSolution.Application.boCalc.Properties;
using System.Windows.Data;

namespace boSolution.Application.boCalc
{

	public class SettingsBinding : Binding
	{

		#region const

		private const BindingMode DefaultMode = BindingMode.TwoWay;

		#endregion

		#region constructor

		public SettingsBinding () : base()
		{
			Source = Setting    ;
			Mode   = DefaultMode;
		}
		public SettingsBinding (string path) : base(path)
		{
			Source = Setting    ;
			Mode   = DefaultMode;
		}

		#endregion

		#region property

		private static Settings Setting { get; } = Settings.Default;

		#endregion

		#region public method

		public static void Reset ()
		{
			Setting.Reset ();
			Setting.Reload();
		}
		public static void Save ()
		{
			Setting.Save();
		}

		#endregion

	}

}
