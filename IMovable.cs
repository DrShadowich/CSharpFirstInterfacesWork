using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW2
{
    interface IMovable
    {
        int Speed { get; }
        void Move();
    }
}
