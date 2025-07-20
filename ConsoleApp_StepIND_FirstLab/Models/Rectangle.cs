namespace ConsoleApp_StepIND_FirstLab.Models
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Length cannot be negative!");
                }
                else
                {
                    _length = value;
                    UpdatePerimeterAndArea();
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Width cannot be negative!");
                }
                else
                {
                    _width = value;
                    UpdatePerimeterAndArea();
                }
            }
        }
        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        private void UpdatePerimeterAndArea()
        {
            Area = Length * Width;
            Perimeter = 2 * (Length + Width);
        }
    }
}

//Rectangle rectangle = new Rectangle(3, 4);
//rectangle.Length = 5.0;
//rectangle.Width = 3.0;
