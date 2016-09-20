using Emailzing.Model;
using System.Collections.Generic;

namespace Emailzing.UI.DataProviders
{
	public interface INavigationDataProvider
	{
		IEnumerable<Email> GetEmails();
	}
}