using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Manager
{
	public class ClientManager : BaseManager
	{

		public int New(Client client)
		{
			_context.People.Add(client);
			_context.SaveChangesAsync();
			return 1;
		}

		public IQueryable<Person> GetPeople()
		{
			return _context.People;
		}

	}
}
