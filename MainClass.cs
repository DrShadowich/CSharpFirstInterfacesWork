using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    internal class MainClass
    {
        static void Main()
        {
            List<IMovable> movablesObjects = new List<IMovable>();
            Animal bird = new Bird();
            Animal cat = new Cat();
            Object tumbleweed = new Tumbleweed();
            Transport car = new Car();
            Transport plane = new Plane();
            movablesObjects.Add(bird);
            movablesObjects.Add(cat);
            movablesObjects.Add((Tumbleweed)tumbleweed);
            movablesObjects.Add(car);
            movablesObjects.Add(plane);

            foreach(IMovable movableObject in movablesObjects)
            {
                movableObject.Move();
            }

        }
    }
}
