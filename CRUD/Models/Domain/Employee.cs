﻿namespace CRUD.Models.Domain
{
    public class Employee
    {

        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public int  Age { get; set; }

    }
}
