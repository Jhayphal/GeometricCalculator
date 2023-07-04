namespace GeometricCalculator.Shapes
{
	public sealed class Triangle : IShape
	{
		private double _sideA;
		private double _sideB;
		private double _sideC;

		public Triangle() : this(double.Epsilon, double.Epsilon, double.Epsilon) { }

		public Triangle(double sideA, double sideB, double sideC) 
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public double SideA
		{ 
			get => _sideA; 
			set
			{
				if (value < double.Epsilon)
				{
					throw new ArgumentException(nameof(SideA));
				}

				_sideA = value;
			}
		}

		public double SideB
		{
			get => _sideB;
			set
			{
				if (value < double.Epsilon)
				{
					throw new ArgumentException(nameof(SideB));
				}

				_sideB = value;
			}
		}

		public double SideC
		{
			get => _sideC;
			set
			{
				if (value < double.Epsilon)
				{
					throw new ArgumentException(nameof(SideC));
				}

				_sideC = value;
			}
		}

		public double CalculateArea()
		{
			var p = (SideA + SideB + SideC) / 2;

			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}

		public bool IsRight()
		{
			double hypotenuse, cathetusA, cathetusB;

			if (SideA > SideB && SideA > SideC)
			{
				hypotenuse = SideA;
				cathetusA = SideB;
				cathetusB = SideC;
			}
			else if (SideB > SideA && SideB > SideC)
			{
				hypotenuse = SideB;
				cathetusA = SideA;
				cathetusB = SideC;
			}
			else
			{
				hypotenuse = SideC;
				cathetusA = SideB;
				cathetusB = SideA;
			}

			return hypotenuse * hypotenuse == cathetusA * cathetusA + cathetusB * cathetusB;
		}
	}
}