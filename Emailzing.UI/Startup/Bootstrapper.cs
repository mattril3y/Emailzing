using Emailzing.Model;
using Emailzing.UI.DataProviders;
using Microsoft.Practices.Unity;

namespace Emailzing.UI.Startup
{
	public class Bootstrapper
	{
		public static IUnityContainer RegisterTypes()
		{
			var container = new UnityContainer();
			container.RegisterType<Views.MainWindow>();
			container.RegisterType<ViewModels.MainWindowViewModel>();
			container.RegisterType<ViewModels.IEmailNavigationViewModel, ViewModels.EmailNavigationViewModel>();
			container.RegisterType<INavigationDataProvider, NavigationDataProvider>();
			container.RegisterType<IService, Service>();

			return container;
		}
	}
}
