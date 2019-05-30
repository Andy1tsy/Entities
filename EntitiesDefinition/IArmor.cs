using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public interface IArmor : IEquipment
    {
       
        int DamageReduced { get; set; }
    }
}
