using boSolution.Core.Module;
using System.Windows;

namespace boSolution.Application.boCalc
{

	public partial class App : System.Windows.Application
	{
		
		#region protected method

		protected override void OnStartup (StartupEventArgs e)
		{
			base.OnStartup(e);
			InitializeModules();
		}

		#endregion

		#region private method

		private void InitializeModules()
		{
			var provider = ModuleProvider.Default;
			provider.Import(Constant.Module_Paths);
		}

		#endregion

	}

}
