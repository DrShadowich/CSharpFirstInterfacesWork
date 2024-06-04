using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    abstract class Animal : Object, IMovable
    {
        #region VARIABLES
        protected string _class;
        protected int _speed;
        public int Speed { get { return _speed; } }
        public string Class {  get { return _class; } }
        #endregion
        #region METHODS
        public virtual void Move()
        {
            Console.WriteLine($"{Name} передвигается со скоростью {Speed}км/час.") ;
        }
        #endregion
        #region CONSTRUCTORS
        public Animal()
        {
            Console.WriteLine("Вид животного: ");
            _class = Console.ReadLine();
            Console.WriteLine("Скорость животного (км/час): ");
            _speed = int.Parse(Console.ReadLine());
        }
        public Animal(string @class, int speed)
        {
            _class = @class;
            _speed = speed;
        }
        #endregion
    }
}
