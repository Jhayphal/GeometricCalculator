namespace GeometricCalculator.Shapes
{
	public sealed class Circle : IShape
	{
		private double _radius;

		public Circle() : this(double.Epsilon) { }

		public Circle(double radius) 
		{
			Radius = radius;
		}

		public double Radius
		{
			get => _radius;
			set
			{
				if (value < double.Epsilon)
				{
					throw new ArgumentException(nameof(Radius));
				}

				_radius = value;
			}
		}

		public double CalculateArea() => Math.PI * Radius * Radius;
	}
}