using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricCalculator.Shapes.Tests
{
	[TestClass]
	public class CircleTests
	{
		[DataTestMethod]
		[DataRow(0.5, 0.785398)]
		[DataRow(5, 78.539816)]
		[DataRow(100000, 31415926535.89793)]
		public void CalculateArea_FineTest(double radius, double expected)
		{
			Circle circle = new(radius);

			var actual = circle.CalculateArea();

			Assert.AreEqual(expected, actual, 0.000001);
		}

		[DataTestMethod]
		[DataRow(0)]
		[DataRow(-0.5)]
		[DataRow(-5)]
		[DataRow(-100000)]
		public void CalculateArea_ArgumentExceptionTest(double radius)
		{
			Circle circle = new();

			Assert.ThrowsException<ArgumentException>(() => circle.Radius = radius);
		}
	}
}