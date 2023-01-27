using NUnit.Framework;
using Ejercicio01;

namespace Ejercicio01.Tests
{
    [TestFixture]
    public class CirculoTests
    {
        [Test]
        public void Area_Success()
        {
            // Arrange
            Circulo circulo = new Circulo(0.0, 0.0, 15.0);

            // Act
            double area = Math.Round(circulo.Area, 2);

            // Assert
            Assert.AreEqual(706.86, area);
        }

        [Test]
        public void Perimetro_Success()
        {
            // Arrange
            Circulo circulo = new Circulo(0.0, 0.0, 15.0);

            // Act
            double perimetro = Math.Round(circulo.Perimetro, 2);

            // Assert
            Assert.AreEqual(94.25, perimetro);
        }
    }
}
