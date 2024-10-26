using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARPex2_1
{
    class Geometry
    {
        static public decimal SquareArea(decimal _length)
        {
            return _length * _length;
        }

        static public decimal CircleArea(decimal _radius)
        {
            return _radius * _radius * (decimal)3.14;
        }

        static public decimal RectangleArea(decimal _length, decimal _width)
        {
            return _length * _width;
        }

        static public decimal TrapezoidArea(decimal _height, decimal _fbase, decimal _sbase)
        {
            return (decimal)0.5 * _height * (_fbase + _sbase);
        }
    }
}
