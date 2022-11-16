using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;

namespace ShapeLib_Tests
{
    [TestClass]
    public class Shape_Tests
    {
        [TestMethod]
        public void Test_UnitCircleArea_EqualsPi()
        {
            // Arrange
            Circle circle = new(1);

            // Act
            float actualArea = circle.Area;
            float expectedArea = MathF.PI;

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Test_CircleAreaWithRadius5_Equals25Pi()
        {
            // Arrange
            Circle circle = new(5);

            // Act
            float actualArea = circle.Area;
            float expectedArea = 25 * MathF.PI;

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Test_EgyptTriangleArea_Equals6()
        {
            // Arrange
            Triangle tri = new(5, 4, 3);

            // Act
            float actualArea = tri.Area;
            float expectedArea = 6;

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Test_HypotenuseIsTheLongestsideOfTriangle()
        {
            // Arrange
            Triangle tri = new(3, 5, 4);

            // Act
            float actual = tri.Hypotenuse;
            float expected = 5;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsRightTriangle_EqualsTrue()
        {
            // Arrange
            Triangle tri = new(5, 4, 3);

            // Act
            bool actual = tri.IsRight;
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsRightTriangle_EqualsFalse()
        {
            // Arrange
            Triangle tri = new(6, 4, 3);

            // Act
            bool actual = tri.IsRight;
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
