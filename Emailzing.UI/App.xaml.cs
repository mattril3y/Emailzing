using Emailzing.Model;
using Emailzing.UI.DataProviders;
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

			//TODO: Replace this using unity to inject the dependencies
			var mainWindow = new Views.MainWindow(
				new ViewModels.MainWindowViewModel(
					new ViewModels.EmailNavigationViewModel(
						new NavigationDataProvider(
							new Service()))));

			mainWindow.Show();
		}
	}
}
