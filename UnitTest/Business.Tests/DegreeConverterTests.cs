using NUnit.Framework;
using System;

namespace Business.Tests
{
    [TestFixture]
    public class DegreeConverterTests
    {


        [Test]
        public void ToFarenheit_ZeroCelsius_REturns32()
        {
            var converter = new DegreeConverter();
            double result = converter.ToFarenheit(0);
            Assert.That(result,Is.EqualTo(32));
        }



        [Test]
        public void ToCelsius_1Farenheit_REturns0()
        {
            var converter = new DegreeConverter();
            double result = converter.ToCelsius(1);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
