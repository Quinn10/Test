using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastObjectCreation
{
    class Car : INamable
    {
        public Car()
        {
        }

        public Car(string name)
        {
            _name = name;
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name + " Car";
            }

            set
            {
                if (_name != value)
                    _name = value;
            }
        }
    }
}
