using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication
{
    public class SportCar : ICar
    {
        
        
        //public int Wheels;
        //public string Name;

        public SportCar()
        {
            Wheels = 4;
            Name = "Ferrari";
        }

        public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
