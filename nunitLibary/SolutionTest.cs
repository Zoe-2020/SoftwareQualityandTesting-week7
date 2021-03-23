using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace nunitLibary
{
    [TestFixture]
    class SolutionTest
    {
        CustomMath cm = new CustomMath();
        [Test]
        
        public void Add()
        {
            Assert.AreEqual(20, cm.multiply(5, 4));
        }
        
        [Test]
        public void div()
        {
            Assert.AreEqual(true, cm.divisible(3, 1, 3));
            Assert.AreEqual(true, cm.divisible(12, 2, 6));
            Assert.AreEqual(false, cm.divisible(100, 5, 3));
            Assert.AreEqual(false, cm.divisible(12, 5, 3));
            
        }

        [Test]
        public void watermelonsDiv()
        {
            Assert.AreEqual(true, cm.Q2Div(2, 6));
            Assert.AreEqual(true, cm.Q2Div(4, 4));
            Assert.AreEqual(false, cm.Q2Div(3, 5));
            Assert.AreEqual(false, cm.Q2Div(7, 1));
        }
    }
}
