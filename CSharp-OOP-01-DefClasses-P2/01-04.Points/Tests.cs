namespace _01_04.Points
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            var point = new Point3D();

            point.X = 1;
            point.Y = 1;
            point.Z = 1;

            Console.WriteLine(point);
            Console.WriteLine(Point3D.O);


            Console.WriteLine("Distance between " + point + " and O is "+Distance.Between(point, Point3D.O));
        }
    }
}
