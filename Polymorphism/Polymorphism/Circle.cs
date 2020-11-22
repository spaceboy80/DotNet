using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Circle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a circle.");
        }
    }
}
