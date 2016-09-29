using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.Model
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
					From = "Virgin Money",
					Content = "Your credit card payment is now due.",
					To = "Matt Riley",
					FullTime = String.Concat(DateTime.Now.ToShortDateString(), " - " ,DateTime.Now.ToShortTimeString())
				});

			emails.Add(
				new Email
				{
					Title = "Urgent information",
					Day = "Thursday",
					From = "HSBC",
					Content = "Your email address needs to be updated in our records, please contact us as soon as possible",
					To = "Matt Riley",
					FullTime = String.Concat(DateTime.Now.ToShortDateString(), " - ",DateTime.Now.ToShortTimeString())
				});

			emails.Add(
				new Email
				{
					Title = "Urgent information",
					Day = "Wednesday",
					From = "CO-OP Bank",
					Content = "This is a spam email",
					To = "Matt Riley",
					FullTime = String.Concat(DateTime.Now.ToShortDateString(), " - ",DateTime.Now.ToShortTimeString())
				});

			return 
				new ReadOnlyCollection<Email>(emails);
		}
	}
}
