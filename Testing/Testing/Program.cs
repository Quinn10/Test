using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Classes;
using Testing.Interfaces;

namespace Testing
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                MoveObjects(new Car("Ferrari"));
                MoveObjects(new Person("User"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movableObjetcs"></param>
        private static void MoveObjects(IMove movableObjetcs)
        {
            movableObjetcs.Move();
        }
    }
}
