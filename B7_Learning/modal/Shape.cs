using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Learning.modal
{
    internal class Shape
    {
        private double width;
        private double length;

        public double Width { get => this.width; set => this.width = value < 0 ? -value : value; }
        public double Length { get => this.length; set => this.length = value < 0 ? -value : value; }

        public Shape()
        {
            this.width = this.length = 0;
        }

        public Shape(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Shape(double y)
        {
            this.width = this.length = y;
        }

        public double Area()
        {
            return this.width * this.length;
        }

        public string DisplayDim()
        {
            return "W: " + this.width + "; L:" + this.length;
        }

        public override string ToString()
        {
            return "Area: " + this.Area();
        }
    }
}
