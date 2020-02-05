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

        //********************** Add-Method *****************************

        [TestCase(2, 3, 5)]
        [TestCase(22, 2, 24)]
        [TestCase(4, 23, 27)]
        public void Add_Two_Numbers(double v1, double v2, double result)
        {
            // Act + Assert
            Assert.That(uut.Add(v1, v2), Is.EqualTo(result));
        }

        //********************** Subtract-Method *****************************

        [TestCase(5, 3, 2)]
        [TestCase(8, 2, 6)]
        [TestCase(22, 2, 20)]
        public void Subtract_Two_Numbers(double v1, double v2, double result)
        {
            // Act + Assert
            Assert.That(uut.Subtract(v1, v2), Is.EqualTo(result));
        }

        //********************** Multiply-Method *****************************

        [TestCase(2, 3, 6)]
        [TestCase(3, 4, 12)]
        [TestCase(4, 6, 24)]
        public void Multiply_Two_Numbers(double v1, double v2, double result)
        {
            // Act + Assert
            Assert.That(uut.Multiply(v1, v2), Is.EqualTo(result));
        }

        //********************** Power-Method *****************************

        [TestCase(2, 3, 8)]
        [TestCase(3, 2, 9)]
        [TestCase(4, 2, 16)]
        public void Power_Two_Numbers(double v1, double v2, double result)
        {
            // Act + Assert
            Assert.That(uut.Power(v1, v2), Is.EqualTo(result));
        }

        //********************** Divide-Method *****************************

        [TestCase(10, 5, 2)]
        [TestCase(5, 2, 2.5)]
        [TestCase(18, 3, 6)]
        public void Divide_Two_Numbers(double v1, double v2, double result)
        {
            // Act + Assert
            Assert.That(uut.Divide(v1, v2), Is.EqualTo(result));
        }

        [Test]
        public void Test_DivideByZero_ThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(3, 0));
        }

        //********************** Accumulator *****************************

        [Test]
        public void Test_Accumulator()
        {
            // Act
            double result = uut.Add(2, 5) + uut.Multiply(2, 5);

            // Assert
            Assert.That(result, Is.EqualTo(17));
        }

        //********************** Clear-Method *****************************

        [Test]
        public void Test_Clear_Method()
        {
            // Act
            uut.Clear();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

    }

}

