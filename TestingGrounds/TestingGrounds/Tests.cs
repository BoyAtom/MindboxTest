using FigureActions;

namespace TestingGrounds
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Radius_10_Result_314_16()
        {
            //arrange
            Circle circle = new Circle("Circle", 10);
            double EstimatedResult = 314.16;

            //act
            double result = circle.CalculateSquare();

            //assert
            Assert.AreEqual(EstimatedResult, result);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Sides_1_3_3_Result_1_47()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 1, 3, 3);
            double EstimatedResult = 1.48;

            //act
            double result = triangle.CalculateSquare();

            //assert
            Assert.AreEqual(EstimatedResult, result);
        }
    }

    [TestClass]
    public class IsRectangularTrianleTest
    {
        [TestMethod]
        public void Sides_2_3_4_Result_False()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 2, 3, 4);
            bool EstimatedResult = false;

            //act
            bool result = triangle.IsRectangular();

            //assert
            Assert.AreEqual(EstimatedResult, result);
        }
    }
}