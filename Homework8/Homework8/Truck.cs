using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{//3
    public class Truck : Vehicle, IDriveable
    {
        private int _Parcels;

        public Truck(int id, string model, int parcels) : base(id, model)
        {
            _Parcels = parcels;
        }

        public int GetNumberOfDoors()
        {
            return _Parcels;
        }

        public void SetCargoCapacity(int parcels)
        {
            _Parcels = parcels;
        }

        public override void Drive()
        {
            Console.WriteLine("Truck ID " + GetID());
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Amount of parcels being transported: {_Parcels} ");
        }
    }
}
