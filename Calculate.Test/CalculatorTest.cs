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

        [TestCase(2,5,17)]
        [TestCase(8, 11, 107)]
        [TestCase(1, 2, 5)]
        public void Test_Accumulator(double v1, double v2, double result)
        {
            uut.Add(v1, v2);
            uut.Multiply(v1, v2);

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        //********************** Clear-Method *****************************

        [Test]
        public void Test_Clear_Method()
        {
            // Act
            uut.Add(2, 5);
            uut.Clear();

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }


        //********************** AddTooAccumulator-Method *****************************


        [TestCase(2, 5, 12)]
        [TestCase(22, 2, 26)]
        [TestCase(4, 23, 50)]
        public void Add_Numbers_to_accumulator(double v1, double v2, double result)
        {
            // Act + Assert
            uut.Add(v1, v2);

          double testValue = uut.AddTooAcumulator(v2);

            Assert.That(testValue,Is.EqualTo(result));
        }


        //********************** SubtractFromAccumulator-Method *****************************

        [TestCase(3, 5, 1,7)]
        [TestCase(22, 4, 7,19)]
        [TestCase(4, 25, 10,19)]
        public void Subtract_Numbers_from_accumulator(double v1, double v2, double v3, double result)
        {
            // Act + Assert
            uut.Add(v1, v2);

            double testValue = uut.SubtractFromAcumulator(v3);

            Assert.That(testValue, Is.EqualTo(result));
        }

        //********************** MultiplyAccumulator-Method *****************************

        [TestCase(3, 5, 5, 40)]
        [TestCase(22, 4, 2, 52)]
        [TestCase(4, 25, 10, 290)]
        public void Multiply_accumulator(double v1, double v2, double v3, double result)
        {
            // Act + Assert
            uut.Add(v1, v2);

            double testValue = uut.MultiplyAcumulator(v3);

            Assert.That(testValue, Is.EqualTo(result));
        }

        //********************** PowerOffAccumulator-Method *****************************

        [TestCase(3, 5, 5, 32768)]
        [TestCase(22, 4, 2, 676)]
        [TestCase(4, 25, 3, 24389)]
        public void Power_Off_accumulator(double v1, double v2, double v3, double result)
        {
            // Act + Assert
            uut.Add(v1, v2);

            double testValue = uut.PowerAcumulator(v3);

            Assert.That(testValue, Is.EqualTo(result));
        }

        //********************** DevideAccumulator-Method *****************************

        [TestCase(3, 5, 5, 1.6)]
        [TestCase(22, 4, 2, 13)]
        [TestCase(3, 12, 3, 5 )]
        public void Devide_accumulator(double v1, double v2, double v3, double result)
        {
            // Act + Assert
            uut.Add(v1, v2);

            double testValue = uut.DevideAcumulator(v3);

            Assert.That(testValue, Is.EqualTo(result));
        }


    }

}

