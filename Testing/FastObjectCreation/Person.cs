using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastObjectCreation
{
    public class Person : INamable
    {
        public Person()
        {

        }

        public Person(string name)
        {
            _name = name;
        }
        private string _name;
        public string Name
        {
            get { return _name + " Person"; }
            set { if (_name != value) _name = value; }
        }
    }
}
