    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2.Exercise1
{
    class Square : GeometricInterface
    {
        private double side;

        public Square(double side){
            this.side = side;
        }

        public double calculateArea(){
            return side * side;
        }

        public double calculatePerimeter(){
            return side * 4;
        }
    }
}
