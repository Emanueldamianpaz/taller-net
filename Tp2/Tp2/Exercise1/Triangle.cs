using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2.Exercise1
{
    class Triangle : GeometricInterface
    {
        private double Base;
        private double height;
        private double diagonal;

        public Triangle(double Base, double height, double diagonal)
        {
            this.Base = Base;
            this.height = height;
            this.diagonal = diagonal;
        }

        public double calculateArea(){
            return (Base * height) / 2;
        }

        public double calculatePerimeter(){
            return Base + height + diagonal;
        }
    }
}
