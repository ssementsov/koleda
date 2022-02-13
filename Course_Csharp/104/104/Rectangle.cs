using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104
{
    public class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimetr;

        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public double AreaCalculator(double s1, double s2)
        {
            area = (side1 * side2);
            return area;
        }
        public double PerimetrCalculator(double s1, double s2)
        {
            perimetr = (side1 + side2) * 2;
            return perimetr;
        }

        public double Perimetr
        {
            get { return perimetr; }
        }

        public double Area
        {
            get { return area; }
        }
    }
}
