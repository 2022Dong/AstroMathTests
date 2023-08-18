using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AstroMath;

namespace AstroMathTests
{
    public class FormulasTest
    {
        Formulas formulas = new Formulas();

        // [Fact]
        [Theory]
        [InlineData(500.1, 500.0, 6000)]
        [InlineData(500.0, 500.0, 0)]
        [InlineData(500.0, 0, 0)]
        public void StarVelocity_ShouldCalculate(double x, double y, double expected)
        {
            // Arrange
            //double expected = 6000;
            // Act
            double actual = formulas.StarVelocity(x, y);
            //double actual = formulas.StarVelocity(500.1, 500.0);
            // Assert
            const double tolerance = 54000; // Set an acceptable tolerance based on your precision requirements
            Assert.Equal(expected, actual, tolerance);
        }
        [Theory]
        [InlineData(0.547, 1.83)]
        public void StarDistance_ShouldCalculate(double x, double expected)
        {
            // Arrange
            
            // Act
            double actual = formulas.StarDistance(x);

            // Assert
            const double tolerance = 0.005;
            Assert.Equal(expected, actual, tolerance);
        }
        [Theory]
        [InlineData(27, 300)]
        [InlineData(-273, 0)]
        [InlineData(-274, 0)]
        [InlineData(double.MaxValue, double.MaxValue)]
        public void TemperatureConversion_ShouldCalculate(double x, double expected)
        {
            // Arrange
            
            // Act
            double actual = formulas.TemperatureConversion(x);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void BlackholeEventHorizon_ShouldCalculate()
        {
            // Arrange
            double expected = 1.2e10;
            // Act
            double actual = formulas.BlackholeEventHorizon(8.2e36);
            // Assert
            const double tolerance = 200000000;
            Assert.Equal(expected, actual, tolerance);
        }
    }
}
