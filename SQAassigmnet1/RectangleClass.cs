using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAassigmnet1
{
    public class rectangleClass
    {
        private int length;
        private int width;
        public rectangleClass()
        {
            length = 1;
            width = 1;
        }

        public rectangleClass(int length, int width)//default consturctor
        {
            this.length = length;
            this.width = width;
        }
        public int getLength()
        {
            return length;
        }
        public int getWidth()
        {
            return width;
        }
        public int setWidth(int width)// non-default constructor
        {
            this.width = width;
            return this.width;
        }
        public int getPerimeter()
        {
            return (width * 2) + (length * 2);// returns the perimeter of the rectangle
        }
        public int getArea()
        {
            return length * width;//returns the area of rectangle
        }
    }
}
    
