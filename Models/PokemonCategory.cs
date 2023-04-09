using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC_App.Models
{
    public class PokemonCategory
    {
        public int id { get; set; }
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Category Category { get; set; }
    }
}