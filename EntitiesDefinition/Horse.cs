using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public class Horse : ICavalry
    {
        public string Name { get => Name; set { if (!String.IsNullOrWhiteSpace(value)) Name = value; } }

        public Bag bag;

        public int CoordX
        {
            get
            {
                return CoordX;
            }
            set
            {
                CoordX = value;
            }
        }

        public int CoordY
        {
            get
            {
                return CoordY;
            }
            set
            {
                CoordY = value;
            }
        }

        public int Direction
        {
            get
            {
                return Direction;
            }
            set
            {
                Direction = value;
            }
        }

        public void MoveForward(int distance)
        {
            CoordX += (int)(distance * Math.Cos(Direction));
            CoordY += (int)(distance * Math.Sin(Direction));

        }

        public void MoveBack(int distance)
        {
            CoordX -= (int)(distance * Math.Cos(Direction));
            CoordY -= (int)(distance * Math.Sin(Direction));
        }

        public void Turn(int angle)
        {
            Direction += angle;
            if (Direction > 360) { Direction -= 360; }
            if (Direction < 0) { Direction += 360; }
        }

        public Horse()
        {
            Name = "Thunder";
            bag = new Bag();
            CoordX = 100;
            CoordY = 100;
            Direction = 0;
        }
    }
}
