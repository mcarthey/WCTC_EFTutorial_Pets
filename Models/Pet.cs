using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTutorial.Models
{
    public class Pet
    {
        public int PetId {get;set;}
        public string Name { get; set; }
        public string Type { get; set; }

        public int PersonId {get;set;}
        public virtual Person Person {get;set;}
    }
}