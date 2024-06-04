using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    class Cat : Animal
    {
        #region VARIABLES
        private string _breed;
        private int _lives;
        public string Breed { get { return _breed; } }
        public int Lives { get { return _lives;} }
        #endregion
        #region METHODS
        public override void GetInfo()
        {
            Console.WriteLine($"Имя кошки: {Name}");
            Console.WriteLine($"Порода кошки: {Breed}");
            Console.WriteLine($"Жизней у кошки: {Lives}");
            Console.WriteLine($"Скорость кошки: {Speed}");
        }
        public override void Move()
        {
            Console.WriteLine($"Кошка бежит со скоростью {Speed}км/час."); ;
        }
        #endregion
        #region CONSTRUCTORS
        public Cat()
        {
            Console.WriteLine("Порода кошки: ");
            _breed = Console.ReadLine();
            Console.WriteLine("Сколько жизней у кошки: ");
            _lives = int.Parse(Console.ReadLine());
        }
        public Cat(string breed, int lives)
        {
            _breed = breed;
            _lives = lives;
        }
        #endregion
    }
}
