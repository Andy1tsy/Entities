using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public interface IEquipment
    {
        string Name { get; set; }
        int Durability { get; set; }
        int Weight { get; }
    }
}
