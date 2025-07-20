using ConsoleApp_StepIND_FirstLab.Models;

namespace ConsoleApp_StepIND_FirstLab.Models
{
    internal class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        {
            Vector3D result = new Vector3D()
            {
                X = vector1.X + vector2.X,
                Y = vector1.Y + vector2.Y,
                Z = vector1.Z + vector2.Z
            };

            return result;
        }

        public void Print()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }

        public Vector3D ScalarMultiply(double scalar)
        {
            Vector3D result = new Vector3D()
            {
                X = X * scalar,
                Y = Y * scalar,
                Z = Z * scalar
            };

            return result;
        }
    }
}

//using ConsoleApp_StepIND_FirstLab.Models;

//Vector3D vector1 = new Vector3D(1, 2, 3);
//Vector3D vector2 = new Vector3D(4, 5, 6);

//Vector3D result = vector1 + vector2;
//Vector3D scalarMult = vector2.ScalarMultiply(2);

//result.Print();
