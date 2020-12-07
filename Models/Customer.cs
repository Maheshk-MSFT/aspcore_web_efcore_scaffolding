using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Customer
    {
#nullable enable 
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
#nullable disable
        public ICollection<Order> Orders { get; set; }
    }
}
