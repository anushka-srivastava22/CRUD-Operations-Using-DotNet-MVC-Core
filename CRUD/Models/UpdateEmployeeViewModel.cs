﻿namespace CRUD.Models
{
	public class UpdateEmployeeViewModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Address { get; set; }
		public int Age { get; set; }
	}
}
