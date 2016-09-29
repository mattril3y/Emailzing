using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.Model
{
	public class Email
	{
		public string From { get; set; }

		public string Title { get; set; }

		public string Content { get; set; }

		public string Day { get; set; }
		public string To { get; set; }
		public string FullTime { get; set; }
	}
}
