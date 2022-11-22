namespace FigureActions
{
    public abstract class FigureShape
    {
        public string figure_name { get; private set; }
        public FigureShape(string name)
        {
            this.figure_name = name;
        }

        public abstract double CalculateSquare();
    }

    public class Triangle : FigureShape
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            if (a <= 0 || b <= 0 || c <= 0) 
            {
                throw new ArgumentException("One of the sides value lower than 0.");
            }
            else if ((a + b) < c || (a + c) < b || (b + c) < a) 
            {
                throw new ArgumentException("One of the sides value higher then other combined.");
            }
            else 
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public bool IsRectangular()
        {
            bool result =((a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))) ||
                          (b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))) ||
                          (c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
            return result;
        }

        public override double CalculateSquare()
        {
            double p = (a + b + c) / 2;
            double square = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            return square;
        }
    }

    public class Circle : FigureShape
    {
        public double radius {get; private set;}
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double CalculateSquare()
        {
            double square = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            return square;
        }
    }
}