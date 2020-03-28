using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMExercise.Models
{
    class Contact
    {
		public class Contact
		{
			[PrimaryKey, AutoIncrement]
			public int Id { get; set; }

			[MaxLength(255)]
			public string FirstName { get; set; }

			[MaxLength(255)]
			public string LastName { get; set; }

			[MaxLength(255)]
			public string Phone { get; set; }

			[MaxLength(255)]
			public string Email { get; set; }

			public bool IsBlocked { get; set; }
		}
	}
}
