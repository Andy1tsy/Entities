using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    public class Bag
    {
        public int MaxWeight { get; private set; }
        public int CurrentWeight {
            get => CurrentWeight;
            set => CurrentWeight = value; }

        public List<ICargo> cargos;

        public void Equip(ICargo cargo)
        {
            if (CurrentWeight < MaxWeight)
            {
                cargos.Add(cargo);
                CurrentWeight += cargo.Weight;
                 
            }
        }

       public void Drop(ICargo cargo)
        {
            if(cargos.Count > 0)
            {
                cargos.Remove(cargo);
            }
        }

        public Bag()
        {
            MaxWeight = 250;
            CurrentWeight = 0;
            cargos = new List<ICargo>();
        }

    }
}
