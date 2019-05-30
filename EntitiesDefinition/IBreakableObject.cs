using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    interface IBreakableObject : IGameObject
    {
        int Durability { get; set; }
        void Break(int damage);
    }
}
