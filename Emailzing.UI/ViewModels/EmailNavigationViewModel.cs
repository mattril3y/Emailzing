using Emailzing.UI.DataProviders;
using System.Collections.ObjectModel;

namespace Emailzing.UI.ViewModels
{
	public class EmailNavigationViewModel : IEmailNavigationViewModel
	{
		private readonly INavigationDataProvider _navigationDataProvider;

		public EmailNavigationViewModel(
			INavigationDataProvider navigationDataProvider)
		{
			Emails = new ObservableCollection<EmailViewModel>();
			_navigationDataProvider = navigationDataProvider;
		}

		public void Load()
		{
			foreach (var email in _navigationDataProvider.GetEmails())
			{
				Emails.Add(
					new EmailViewModel(
						email.Title, 
						email.From, 
						email.Day, 
						email.Content));
			}
		}

		public ObservableCollection<EmailViewModel> Emails { get; private set; }
	}
}
