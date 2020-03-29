using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication
{
    public interface ICar
    {
        public int Wheels { get; set; }
        public string Name { get; set; }

        public string GetOwner(string owner);
       
    }
}
