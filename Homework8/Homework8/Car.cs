using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{//3
    public class Car : Vehicle, IDriveable
    {
        private int _Mileage;

        public Car(int id, string model, int Mileage) : base (id, model)
        {
            _Mileage = Mileage;
        }

        public int GetMileage()
        {
            return _Mileage;
        }

        public void SetMileage(int Mileage)
        {
            _Mileage = Mileage;
        }

        public override void Drive()
        {
            Console.WriteLine("Car ID " + GetID());
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Kilometres driven: {_Mileage}");
        }
    }
}

