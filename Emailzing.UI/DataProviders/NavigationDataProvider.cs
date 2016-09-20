using Emailzing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.UI.DataProviders
{
	public class NavigationDataProvider : INavigationDataProvider
	{
		private readonly IService _service;

		public NavigationDataProvider(IService service)
		{
			_service = service;
		}

		public IEnumerable<Email> GetEmails()
		{
			return _service.GetEmails();
		}
	}
}
