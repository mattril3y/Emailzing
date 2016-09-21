using Emailzing.Model;
using Emailzing.UI.DataProviders;
using Emailzing.UI.Startup;
using Microsoft.Practices.Unity;
using System.Windows;

namespace Emailzing.UI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var container = Bootstrapper.RegisterTypes();
			container.Resolve<Views.MainWindow>().Show();
		}
	}
}
