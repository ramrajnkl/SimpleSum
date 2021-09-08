using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Add()
        {
            var a = 100;
            var b = 100;

            int Result = a + b;

            Assert.AreEqual(200, Result);
                       
        }

        [TestMethod]
        public void Sub()
        {
            var a = 100;
            var b = 100;

            int Result = a - b;

            Assert.AreEqual(0, Result);

        }

        [TestMethod]
        public void Mul()
        {
            var a = 100;
            var b = 100;

            int Result = a * b;

            Assert.AreEqual(10000, Result);

        }


        [TestMethod]
        public void Div()
        {
            var a = 100;
            var b = 100;

            int Result = a / b;

            Assert.AreEqual(1, Result);

        }
        
    }
}
