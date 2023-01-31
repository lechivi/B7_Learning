using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Learning.modal
{
    internal class Rectangle : Shape
    {
        string style;

        public Rectangle()
        {
            style = null;
        }

        //Constructor
        public Rectangle(string style, double width, double height) : base(width, height)
        {
            this.style = style;
        }

        public Rectangle(double y) : base(y)
        {
            this.style = "square";
        }

        public string DisplayStyle()
        {
            return "Style is " + this.style;
        }
    }
}
