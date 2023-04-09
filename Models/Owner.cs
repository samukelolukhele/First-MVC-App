using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC_App.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Gym { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}