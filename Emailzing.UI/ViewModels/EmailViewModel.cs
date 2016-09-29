using Emailzing.Model;
using Emailzing.UI.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace Emailzing.UI.ViewModels
{
	public class EmailViewModel
	{
		private IContentViewModel _contentViewModel;

		public EmailViewModel(
			Email email,
			IContentViewModel contentViewModel)
		{
			Email = email;
			Title = email.Title;
			From = email.From;
			Day = email.Day;
			Content = email.Content;

			_contentViewModel = contentViewModel;

			OpenEmailCommand = new DelegateCommand(OnOpenEmailCommandExecute);
		}

		public Email Email { get; private set; }
		public string Title { get; private set; }
		public string From { get; private set; }
		public string Day { get; private set; }
		public string Content { get; private set; }
		public ICommand OpenEmailCommand { get; private set; }

		private void OnOpenEmailCommandExecute(object obj)
		{
			_contentViewModel.Update(Email);
		}
	}
}
