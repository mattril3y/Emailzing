using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.UI.ViewModels
{
	public class MainWindowViewModel
	{
		private readonly IEmailNavigationViewModel _emailNavigationViewModel;

		public MainWindowViewModel(IEmailNavigationViewModel emailNavigationViewModel)
		{
			_emailNavigationViewModel = emailNavigationViewModel;
		}

		internal void Load()
		{
			_emailNavigationViewModel.Load();
		}
	}
}
