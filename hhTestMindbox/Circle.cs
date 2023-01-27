using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhTestMindbox
{
    public class Circle : IFigureStrategy
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;

        }

        public string GetInfo()
        {
            return "круг";
        }

        public double GetSquare()
        {
            if (_radius <= 0)
            {
                throw new Exception("Круга не существует");
            }
            return Math.PI * _radius * _radius;
        }
    }
}
