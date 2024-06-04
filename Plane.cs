using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    class Plane : Transport
    {
        #region VARIABLES
        private int _capacity;
        private string _color;
        public string Color { get { return _color; } }
        public int Capacity { get { return _capacity; } }
        #endregion
        #region METHODS
        public override void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Имя самолёта: {Name}.");
            Console.WriteLine($"Скорость самолёта: {Speed}.");
            Console.WriteLine($"Цвет самолёта: {Color}.");
            Console.WriteLine($"Вместимость самолёта: {Capacity}.");
            Console.WriteLine();
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} летит со скоростью {Speed}км/час.");
        }
        #endregion
        #region CONSTRUCTORS
        public Plane()
        {
            Console.WriteLine("Вместимость самолета: ");
            _capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Цвет самолета: ");
            _color = Console.ReadLine();
        }
        public Plane(int capacity, string color)
        {
            _capacity = capacity;
            _color = color;
        }
        #endregion
    }
}
