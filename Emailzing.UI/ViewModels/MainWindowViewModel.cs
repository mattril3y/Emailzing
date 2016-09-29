namespace Emailzing.UI.ViewModels
{
	public class MainWindowViewModel
	{
		public MainWindowViewModel(
			IEmailNavigationViewModel emailNavigationViewModel,
			IContentViewModel contentViewModel)
		{
			EmailNavigationViewModel = emailNavigationViewModel;
			ContentViewModel = contentViewModel;
		}

		public void Load()
		{
			EmailNavigationViewModel.Load(ContentViewModel);
		}

		public IEmailNavigationViewModel EmailNavigationViewModel { get; private set; }
		public IContentViewModel ContentViewModel { get; set; }
	}
}
