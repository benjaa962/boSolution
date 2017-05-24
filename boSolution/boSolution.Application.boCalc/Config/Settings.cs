using System.Configuration;
using System.Diagnostics;
using System.Windows;

namespace boSolution.Application.boCalc.Properties
{

	internal sealed partial class Settings : ApplicationSettingsBase
	{

		#region const

		public const string MainWindow_DefaultLeft   = "100"   ;
		public const string MainWindow_DefaultTop    = "100"   ;
		public const string MainWindow_DefaultWidth  = "500"   ;
		public const string MainWindow_DefaultHeight = "300"   ;
		public const string MainWindow_DefaultState  = "Normal";

		#endregion

		#region property

		[UserScopedSetting()]
		[DebuggerNonUserCode()]
		[DefaultSettingValue(MainWindow_DefaultLeft)]
		public double MainWindow_Left
		{
			get { return (double)this[nameof(MainWindow_Left)]; }
			set { this[nameof(MainWindow_Left)] = value;        }
		}

		[UserScopedSetting()]
		[DebuggerNonUserCode()]
		[DefaultSettingValue(MainWindow_DefaultTop)]
		public double MainWindow_Top
		{
			get { return (double)this[nameof(MainWindow_Top)]; }
			set { this[nameof(MainWindow_Top)] = value;        }
		}

		[UserScopedSetting()]
		[DebuggerNonUserCode()]
		[DefaultSettingValue(MainWindow_DefaultWidth)]
		public double MainWindow_Width
		{
			get { return (double)this[nameof(MainWindow_Width)]; }
			set { this[nameof(MainWindow_Width)] = value;        }
		}

		[UserScopedSetting()]
		[DebuggerNonUserCode()]
		[DefaultSettingValue(MainWindow_DefaultHeight)]
		public double MainWindow_Height
		{
			get { return (double)this[nameof(MainWindow_Height)]; }
			set { this[nameof(MainWindow_Height)] = value;        }
		}

		[UserScopedSetting()]
		[DebuggerNonUserCode()]
		[DefaultSettingValue(MainWindow_DefaultState)]
		public WindowState MainWindow_State
		{
			get { return (WindowState)this[nameof(MainWindow_State)]; }
			set { this[nameof(MainWindow_State)] = value;             }
		}

		#endregion

	}

}
