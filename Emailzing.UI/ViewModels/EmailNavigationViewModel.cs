using Emailzing.UI.ViewModels.DataProviders;
using Emailzing.UI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.UI.ViewModels
{
	public class EmailNavigationViewModel : IEmailNavigationViewModel
	{
		private readonly INavigationDataProvider _navigationDataProvider;

		public EmailNavigationViewModel(
			INavigationDataProvider navigationDataProvider)
		{
			_navigationDataProvider = navigationDataProvider;
		}

		public void Load()
		{

		}

		public ReadOnlyCollection<Email> Emails { get; private set; }
	}
}
