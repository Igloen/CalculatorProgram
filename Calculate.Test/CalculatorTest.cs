using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorProgram;
using NUnit.Framework;

namespace Calculate.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Add_Two_Numbers()
        {
            // Act 
            double result = uut.Add(2, 5);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Subtract_Two_Numbers()
        {
            // Act 
            double result = uut.Subtract(2, 5);

            // Assert
            Assert.That(result, Is.EqualTo(-3));
        }
        [Test]
        public void Multiply_Two_Numbers()
        {
            // Act 
            double result = uut.Multiply(2, 5);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Power_Two_Numbers()
        {
            // Act 
            double result = uut.Power(2, 2);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [TestCase(2,3, 8)]
        [TestCase(3,2,9)]
        [TestCase(4, 2, 16)]
        public void Power_Two_Numbers_2(double v1, double v2, double result)
        {
            // Act + Assert
            Assert.That(uut.Power(v1, v2), Is.EqualTo(result));
        }

        [Test]
        public void Test_DivideByZero_ThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(3,0));
        }

        

    }
}
