﻿using Order.Domain.Models;

namespace Order.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
    }
}
