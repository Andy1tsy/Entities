using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public class Warrior : IActingEntity
    {
        public IWeapon weapon;
        public IArmor armor;
        public ICavalry horse;

        public int HP {
            get => HP;
            set => HP = value; }
        public string Name { get => Name; set { if (!String.IsNullOrWhiteSpace(value)) Name = value; } }

        public int CoordX {
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

        public int Level
        {
            get
            {
                return Level;
            }
            set
            {
                Level = value;
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
            if(Direction > 360) { Direction -= 360; }
            if(Direction < 0) { Direction += 360; }
        }

        public void Attack()
        {
            Console.WriteLine("Attack!!");
            // target CoordX = warrior.CoordX + Range * Math.Cos(direction);
            // target CoordY = warrior.CoordX + Range * Math.Sin(direction);
        }

        public void Block()
        {
            Console.WriteLine("Block!!");
            // armor.DamageReduced *= 2; temporally
        }
       
        public void GetDamage(int damage){
            if (damage < armor.DamageReduced) return;
            if (damage >= (HP + armor.DamageReduced)) HP = 0; // death
            else HP -= (damage - armor.DamageReduced);
        }
        public Warrior()
        {
            Name = "Arthur";
            weapon = new Sword();
            armor = new Plates();
            horse = new Horse();
            HP = 1000;
            Level = 1;
            CoordX = 99;
            CoordY = 99;
            Direction = 0;
        }
    }
}
