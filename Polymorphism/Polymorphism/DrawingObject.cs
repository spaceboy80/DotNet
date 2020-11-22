using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am drawing an object.");
        }
    }
}
