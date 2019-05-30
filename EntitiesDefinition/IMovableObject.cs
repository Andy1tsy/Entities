using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public interface IMovableObject : IGameObject
    {
        int Weight { get;  }
    }
}
