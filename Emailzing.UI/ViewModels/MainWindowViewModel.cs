namespace Emailzing.UI.ViewModels
{
	public class MainWindowViewModel
	{
		public MainWindowViewModel(IEmailNavigationViewModel emailNavigationViewModel)
		{
			EmailNavigationViewModel = emailNavigationViewModel;
		}

		internal void Load()
		{
			EmailNavigationViewModel.Load();
		}

		public IEmailNavigationViewModel EmailNavigationViewModel { get; private set; }
	}
}
