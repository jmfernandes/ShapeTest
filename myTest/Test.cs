using NUnit.Framework;
using System;
using MyProgram;

namespace myTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestAreaOfRectangle()
        {
            Rectangle myTestRectangle = new Rectangle(2, 5);
            Assert.AreEqual(10, myTestRectangle.Area());
        }

        [Test()]
        public void TestPerimeterOfRectangle()
        {
            Rectangle myTestRectangle = new Rectangle(2, 5);
            Assert.AreEqual(14, myTestRectangle.Perimeter());
        }
    }
}
