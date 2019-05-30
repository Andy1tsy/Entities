using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    interface IActingEntity : ILiveEntity
    {
        int Level { get; set; }
        void Attack();
        void Block();
    }
}
