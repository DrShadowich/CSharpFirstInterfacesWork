using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    class Bird : Animal
    {
        #region VARIABLES
        private string _species;
        public string Species { get { return _species; } }
        #endregion
        #region METHODS
        public override void GetInfo()
        {
            Console.WriteLine($"Имя птицы: {Name}.");
            Console.WriteLine($"Класс птицы: {Class}.");
            Console.WriteLine($"Вид птицы: {Species}.");
        }
        public override void Move()
        {
            Console.WriteLine($"{Class} {Name} {Species} летит со скоростью {Speed}км/час");
        }
        #endregion
        #region CONSTRUCTORS
        public Bird()
        {
            Console.WriteLine("Вид птицы: ");
            _species = Console.ReadLine();
        }
        public Bird(string species)
        {
            _species = species;
        }
        #endregion
    }
}
