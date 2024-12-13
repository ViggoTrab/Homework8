using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{//3
    public class Motorcycle : Vehicle, IDriveable
    {
        private int _Year;

        public Motorcycle(int id, string model, int Year) : base(id, model)
        {
            _Year = Year;
        }

        public int GetYear()
        {
            return _Year;
        }

        public void SetYear(int Year)
        {
            _Year = Year;
        }

        public override void Drive()
        {
            Console.WriteLine("Motorcycle ID " + GetID());
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorcycle ID: {GetID()}, " + $"Model: {_Model}, " + $"Year: {_Year}");
        }
    }

}
