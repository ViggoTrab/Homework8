using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework8

{   //1
    public abstract class Vehicle
    {
        public int _ID;
        public string _Model;
        
        public Vehicle(int Id, string model)
        {
            _ID = Id;
            _Model = model;
            
        }

        // 1a
        public abstract void Drive();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {_ID}, " + $"Model: {_Model}, ");
        }

        //1b
        public int GetID()
        {
            return _ID;
        }

        public void SetId(int Id)
        {
            _ID = Id;
        }

    }

    //2
    public interface IDriveable
    {
        void Drive();
    }

}
