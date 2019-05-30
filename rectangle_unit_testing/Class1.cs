using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQAassign1;
using NUnit.Framework;

namespace rectangle_unit_testing
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void testing_getLength_input7_expected7() //Testing for getLength() Method
        {
            int l = 7, w = 7;
            rectangleClass rectangleTest = new rectangleClass(l, w);
            int length = rectangleTest.getLength();
            Assert.AreEqual(length, l);
        }
        [Test]
        public void testing_setLength_input7_expected7() //Testing SetLength() Method
        {
            int l = 7, w = 4;
            rectangleClass rectangleTest = new rectangleClass(l, w);
            int length = rectangleTest.setLength(l);
            Assert.AreEqual(length, l);
        }

        [Test]
        public void testing_getWidth_input7_expected7() //Testing GetWidth() Method
        {
            int l = 4, w = 7;
            rectangleClass rectangleTest = new rectangleClass(l, w);
            int width = rectangleTest.getWidth();
            Assert.AreEqual(width, w);
        }

        [Test]
        public void testing_setWidth_input7_expected7() //Testing SetWidth() Method
        {
            int l = 4, w = 7;
            rectangleClass rectangleTest = new rectangleClass(l, w);
            int width = rectangleTest.setWidth(w);
            Assert.AreEqual(width, w);
        }

        [Test]
        public void testing_perimeter_input4_6_expected20() //Testing GetPerimeter() Method
        {
            int l = 4, w = 6, p = 20;
            rectangleClass rectangleTest = new rectangleClass(l, w);
            int perimeter = rectangleTest.getPerimeter();
            Assert.AreEqual(perimeter, p);
        }

        [Test]
        public void testing_area_input4_6_expected24() //Testing GetArea() Method
        {
            int l = 4, w = 6, a = 24;
            rectangleClass rectangleTest = new rectangleClass(l, w);
            int area = rectangleTest.getArea();
            Assert.AreEqual(area, a);
        }

    }
}
