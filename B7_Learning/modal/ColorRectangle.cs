using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Learning.modal
{
    internal class ColorRectangle : Rectangle
    {
        string rColor;

        public ColorRectangle(string rColor, string style, double width, double leght) : base(style, width, leght)
        {
            this.rColor = rColor;
        }

        public string DisplayColor()
        {
            return "Color is " + this.rColor;
        }

    }
}
