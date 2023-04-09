using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC_App.Models
{
    public class PokemonOwner
    {
        public int id { get; set; }
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }
    }
}