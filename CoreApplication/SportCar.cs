using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication
{
    public class SportCar : ICar
    {
        public int Wheels { get; set; }
        public string Name { get; set; }


        public SportCar(int _wheels, string _name)
        {
            Wheels = _wheels;
            Name = _name;
        }

        public string GetOwner(string owner)
        {
            return string.Format("This car owner is {0}", owner);
        }
    }
}
