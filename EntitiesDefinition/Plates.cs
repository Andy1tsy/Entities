using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public class Plates : IArmor
    {
        public string Name { get => Name; set  { if (!String.IsNullOrWhiteSpace(value) ) Name = value ; } }

        public int Durability { get => Durability; set => Durability = value; }
        public int DamageReduced { get => DamageReduced; set => DamageReduced = value; }
        public int Weight { get => Weight; set => Weight = value; }

        public Plates()
        {
            Name = "Raven";
            Weight = 20;
            Durability = 450;
            DamageReduced = 20;
           
        }
       
}
}
