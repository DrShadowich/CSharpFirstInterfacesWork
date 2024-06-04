using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    class Car : Transport
    {
        #region VARIABLES
        private string _engine;
        private string _mark;
        public string Engine { get { return _engine; } }
        public string Mark { get { return _mark; } }
        #endregion
        #region METHODS
        public override void Move()
        {
            Console.WriteLine($"{Mark} {Name} едит со скоростью {Speed}км/час.");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Название машины: {Name}.");
            Console.WriteLine($"Тип движка: {Engine}.");
            Console.WriteLine($"Марка машины: {Mark}.");
        }
        #endregion
        #region CONSTRUCTORS
        public Car()
        {
            Console.WriteLine("Тип движка: ");
            _engine = Console.ReadLine();
            Console.WriteLine("Марка автомобиля: ");
            _mark = Console.ReadLine();
        }
        public Car(string engine, string mark)
        {
            _engine = engine;
            _mark = mark;
        }
        #endregion
    }
}
