using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2.Exercise1
{
    class Circle : GeometricInterface
    {

        private double radius;
        private double pi = Math.PI;

        public Circle(double radius){
            this.radius = radius;
        }

        public double calculateArea()
        {
            return pi * radius * radius;
        }

        public double calculatePerimeter()
        {
            return 2 * pi * radius;
        }
    }
}
