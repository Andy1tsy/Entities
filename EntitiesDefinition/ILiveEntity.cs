using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public interface ILiveEntity : IGameObject
    {
        string Name  { get; set; }
        int Direction { get; set; }
        void MoveForward(int distance);
        void MoveBack(int distance);
        void Turn(int angle);
        
    }
}
