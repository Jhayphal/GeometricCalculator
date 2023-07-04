using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricCalculator.Shapes.Tests
{
	[TestClass]
	public class TriangleTests
	{
		[DataTestMethod]
		[DataRow(0.5, 0.5, 0.5, 0.108253)]
		[DataRow(5, 5, 5, 10.825317)]
		[DataRow(100000, 100000, 100000, 4330127018.922194)]
		public void CalculateArea_FineTest(double sideA, double sideB, double sideC, double expected)
		{
			Triangle triangle = new(sideA, sideB, sideC);

			var actual = triangle.CalculateArea();

			Assert.AreEqual(expected, actual, 0.000001);
		}

		[DataTestMethod]
		[DataRow(0, 0, 0)]
		[DataRow(-5, -5, -5)]
		[DataRow(-0.5, -0.5, -0.5)]
		[DataRow(-100000, -100000, -100000)]
		public void CalculateArea_ArgumentExceptionTest(double sideA, double sideB, double sideC)
		{
			Triangle triangle = new();

			Assert.ThrowsException<ArgumentException>(() => triangle.SideA = sideA);
			Assert.ThrowsException<ArgumentException>(() => triangle.SideB = sideB);
			Assert.ThrowsException<ArgumentException>(() => triangle.SideC = sideC);
		}

		[DataTestMethod]
		[DataRow(0.5, 0.5, 0.5, false)]
		[DataRow(5, 5, 5, false)]
		[DataRow(100000, 100000, 100000, false)]
		[DataRow(3, 4, 5, true)]
		public void IsRightTest(double sideA, double sideB, double sideC, bool expected)
		{
			Triangle triangle = new(sideA, sideB, sideC);

			var actual = triangle.IsRight();

			Assert.AreEqual(expected, actual);
		}
	}
}