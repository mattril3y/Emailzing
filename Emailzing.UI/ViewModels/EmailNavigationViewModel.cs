using Emailzing.UI.DataProviders;
using System.Collections.ObjectModel;
using System;

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

		public void Load(IContentViewModel contentViewModel)
		{
			foreach (var email in _navigationDataProvider.GetEmails())
			{
				Emails.Add(
					new EmailViewModel(
						email,
						contentViewModel));
			}
		}

		public ObservableCollection<EmailViewModel> Emails { get; private set; }
	}
}
