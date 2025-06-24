using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public interface IShape
    {
        double CalculateArea();
    }

    public class Square : Shape
    {
        public double SideLength { get; set; }
        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    public class Triangle : Shape
    {
        //..
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }

}
