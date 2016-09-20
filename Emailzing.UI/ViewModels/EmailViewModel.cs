using System;

namespace Emailzing.UI.ViewModels
{
	public class EmailViewModel : IEmailViewModel
	{
		public EmailViewModel(
			string title, 
			string from, 
			string day, 
			string content)
		{
			Title = title;
			From = from;
			Day = day;
			Content = content;
		}

		public string Title { get; private set; }
		public string From { get; private set; }
		public string Day { get; private set; }
		public string Content { get; private set; }
	}
}
