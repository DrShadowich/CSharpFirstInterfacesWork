using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    abstract class Object
    {
        #region VARIABLES
        protected string _name;
        public string Name { get { return _name; } }
        #endregion
        #region METHODS
        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя объекта: {Name}.");
        }
        #endregion
        #region CONSTRUCTORS
        public Object()
        {
            Console.WriteLine("Имя объекта: ");
            _name = Console.ReadLine();
        }
        public Object(string name)
        {
            _name = name;
        }
        #endregion
    }
}
