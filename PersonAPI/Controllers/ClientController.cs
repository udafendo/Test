using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ClassLibrary1;
using ClassLibrary1.Models;
using ClassLibrary1.Manager;

namespace PersonAPI.Controllers
{
	[RoutePrefix("api/Client")]
	public class ClientController : ApiController
    {
		private ClientManager _clientManager = new ClientManager();

		[HttpPost]
		[Route("New")]
		public string New(Client client)
		{
			int result;
			try
			{
				if (ModelState.IsValid)
				{
					result = _clientManager.New(client);
				}
				else
				{

					return "0";

				}

			}
			catch (Exception ex)
			{
				return ( ex.Message);

			}

			return result.ToString();
		}


		[HttpGet]
		[Route("List")]
		public IQueryable<Person> List()
		{
			return _clientManager.GetPeople();
		}
    }
}
