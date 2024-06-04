using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    class Tumbleweed : Object, IMovable
    {
        #region VARIABLES
        private int _speed;
        public int Speed { get { return _speed; } }
        #endregion
        #region METHODS
        public override void GetInfo()
        {
            Console.WriteLine($"Название перекати-поле: {Name}");
            Console.WriteLine($"Скорость перекати-поле: {Speed}");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} перекатывается со скоростью {Speed}км/час");
        }
        #endregion
        #region CONSTRUCTORS
        public Tumbleweed()
        {
            Console.WriteLine("Скорость перекати-поле: ");
            _speed = int.Parse(Console.ReadLine());   
        }
        public Tumbleweed(int speed)
        {
            _speed = speed;
        }
        #endregion
    }
}
