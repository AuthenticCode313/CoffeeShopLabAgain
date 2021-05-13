using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopAgainLab.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string LastName { get; set; }
        [StringLength(40)]
        public string Tele { get; set; }
        [StringLength(40)]
        public string DrinkType { get; set; }
    }
}
