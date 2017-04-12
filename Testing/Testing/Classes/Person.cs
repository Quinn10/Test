using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Interfaces;

namespace Testing.Classes
{
    public class Person : IMove
    {
        public Person()
        {
        }

        public Person(string name) : this()
        {
            _name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        private string _name;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _canMove;

        /// <summary>
        /// 
        /// </summary>
        public bool CanMove
        {
            get
            {
                return _canMove;
            }

            set
            {
                if (_canMove != value)
                    _canMove = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Move()
        {
            try
            {
                Console.WriteLine(string.Format("{0} {1} moving", this.GetType().Name, Name));
            }
            catch (Exception ex)
            {






                throw ex;
            }
        }

    }
}
