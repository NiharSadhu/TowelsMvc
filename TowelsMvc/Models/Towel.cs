using System;
using System.ComponentModel.DataAnnotations;

namespace TowelsMvc.Models
{
    public class Towel
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }

        public string Design { get; set; }

        public string Softness { get; set; }

        public string Durability { get; set; }

    }
}
