using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.Service
{
	public class Service : IService
	{
		public ReadOnlyCollection<Email> GetEmails()
		{
			List<Email> emails = new List<Email>();
			emails.Add(
				new Email
				{
					Title = "Urgent information",
					Day = "Friday",
					From = "HSBC",
					Content = "Your email address needs to be updated in our records, please contact us as soon as possible"
				});

			emails.Add(
				new Email
				{
					Title = "Urgent information",
					Day = "Thursday",
					From = "HSBC",
					Content = "Your email address needs to be updated in our records, please contact us as soon as possible"
				});

			emails.Add(
				new Email
				{
					Title = "Urgent information",
					Day = "Wednesday",
					From = "HSBC",
					Content = "Your email address needs to be updated in our records, please contact us as soon as possible"
				});

			return 
				new ReadOnlyCollection<Email>(emails);
		}
	}
}
