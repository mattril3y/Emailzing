using Emailzing.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Emailzing.UI.ViewModels
{
	public class ContentViewModel : IContentViewModel, INotifyPropertyChanged
	{
		public ContentViewModel(
			Email email)
		{
			From = email.From;
			To = email.To;
			Title = email.Title;
			FullTime = email.FullTime;
			Content = email.Content;
		}

		public void Update(Email email)
		{
			From = email.From;
			To = email.To;
			Title = email.Title;
			FullTime = email.FullTime;
			Content = email.Content;
		}

		private string _from;

		public string From
		{
			get { return _from; }
			set
			{
				_from = value;
				NotifyPropertyChanged();
			}
		}


		private string _to;

		public string To
		{
			get { return _to; }
			set
			{
				_to = value;
				NotifyPropertyChanged();
			}
		}


		private string _title;

		public string Title
		{
			get { return _title; }
			set
			{
				_title = value;
				NotifyPropertyChanged();
			}
		}


		private string _fullTime;

		public string FullTime
		{
			get { return _fullTime; }
			set
			{
				_fullTime = value;
				NotifyPropertyChanged();
			}
		}

		private string _content;

		public string Content
		{
			get { return _content; }
			set
			{
				_content = value;
				NotifyPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
