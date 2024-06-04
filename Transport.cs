using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    abstract class Transport : Object, IMovable
    {
        #region VARIABLES
        protected int _speed;
        public int Speed { get { return _speed; } }
        #endregion
        #region METHODS
        public virtual void Move()
        {
            Console.WriteLine($"Транспорт передвигается со скоростью {Speed}км/час");
        }
        #endregion
        #region CONSTRUCTORS
        public Transport()
        {
            Console.WriteLine("Скорость транспорта: ");
            _speed = int.Parse(Console.ReadLine());
        }
        public Transport(int speed)
        {
            _speed = speed;
        }
        #endregion
    }
}
