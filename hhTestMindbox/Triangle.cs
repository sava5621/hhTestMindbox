using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhTestMindbox
{
    public class Triangle : IFigureStrategy
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double GetSquare()
        {
            if (_firstSide <= 0 || _secondSide <= 0 || _thirdSide <= 0)
            {
                throw new Exception("Треугольника не существует");
            }

            double p = (_firstSide + _secondSide + _thirdSide) / 2;
            double result = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));

            if (result <= 0 ) 
            {
                throw new Exception("Треугольника не существует");
            }
            else
            {
                return result;
            }    
            
        }

        public string GetInfo()
        {
            bool isRectangular = false;

            //c^2 = a^2 +b^2

            if (_firstSide > _secondSide && _firstSide > _thirdSide)
            {
                isRectangular = _firstSide * _firstSide == _secondSide * _secondSide + _thirdSide * _thirdSide;
            }
            else if (_secondSide > _firstSide && _secondSide > _thirdSide)
            {
                isRectangular = _secondSide * _secondSide == _firstSide * _firstSide + _thirdSide * _thirdSide;
            }
            else if (_thirdSide > _secondSide && _thirdSide > _firstSide)
            {
                isRectangular = _thirdSide * _thirdSide == _firstSide * _firstSide + _secondSide * _secondSide;
            }

            if (isRectangular) 
            {
                return "прямоугольный треугольник";
            }
            else
            {
                return "треугольник";
            }

        }
    }
}
