using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public abstract class Person
	{
		public int ID { get; set; }

		[Required]
		[StringLength(50)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
