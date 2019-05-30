using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public class Sword : IWeapon
    {
        public int Damage { get => Damage;  set => Damage = value; }

        public int Range { get => Range;  set => Range = value; }

        public string Name { get => Name; set { if (!String.IsNullOrWhiteSpace(value)) Name = value; } }
        public int Durability { get => Durability; set => Durability = value; }

        public int Weight { get => Weight;  set => Weight = value; }
        public Sword()
        {
            Name = "Rose";
            Weight = 2;
            Durability = 150;
            Damage = 20;
            Range = 3;

        }
    }
}
