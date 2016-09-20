using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailzing.Model
{
	public interface IService
	{
		ReadOnlyCollection<Email> GetEmails();
	}
}
