using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public class Point
    {
        public double x, y;

        public Point (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double x, double y)
        {
            this.x += x;
            this.y += y;
        }
    }

    public class Point3D : Point
    {
        public double z;
        public Point3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public void Move(double x, double y, double z)
        {/*
            this.x += x;
            this.y += y;*/
            Move(x, y);
            this.z += z;
        }

    }

    public class Figure
    {
        private List<Point> Points = new List<Point>();

        public double Gx;
        public double Gy;
        public double Gz;

        public Figure(Point one, Point two , Point three)
        {
            Points.Add(one);
            Points.Add(two);
            Points.Add(three);
            Gx = this.GetGx();
            Gy = this.GetGy();
        }

        public Figure(Point3D one, Point3D two, Point3D three)
        {
            Points.Add(one);
            Points.Add(two);
            Points.Add(three);
            Gx = this.GetGx();
            Gy = this.GetGy();
            Gz = this.GetGz();
        }
        public void AddPoint(Point point)
        {
            Points.Add(point);
            Gx = this.GetGx();
            Gy = this.GetGy();
            try
            {
                Gz = this.GetGz();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        public double GetGx()
        {
            double X = 0;
            foreach (Point p in Points)
                X += p.x;
            return X/Points.Count;
        }
        public double GetGz()
        {
            double Z = 0;
            foreach (Point3D p in Points)
                Z += p.z;
            return Z / Points.Count;
        }
        public double GetGy()
        {
            double Y = 0;
            foreach (Point p in Points)
                Y += p.y;
            return Y / Points.Count;
        }

        public void Move(int one, int two)
        {
            foreach (Point p in Points)
                p.Move(one, two);
            Gx = this.GetGx();
            Gy = this.GetGy();
            try
            {
                Gz = this.GetGz();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        public void Zome(int size)
        {
            double tmpx;
            double tmpy;
            double tmpz;
            foreach (Point p in Points)
            {
                if (p is Point3D d3)
                {
                    tmpx = Gx + size * (p.x - Gx);
                    p.x = tmpx;
                    tmpy = Gy + size * (p.y - Gy);
                    p.y = tmpy;
                    tmpz = Gz + size * (d3.z  - Gz);
                    d3.z = tmpz;
                }
                else
                {
                    tmpx = Gx + size * (p.x - Gx);
                    p.x = tmpx;
                    tmpy = Gy + size * (p.y - Gy);
                    p.y = tmpy;
                }
            }
        }
        public void Vive()
        {
            int i = 0;
            foreach (Point p in Points)
            {
                i++;
                if (p is Point3D d3)
                    Console.WriteLine($"point {i} x :{p.x}  y :{p.y}  z :{d3.z}");
                else
                    Console.WriteLine($"point {i} x :{p.x}  y :{p.y}");
            }
            
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Point one = new Point(2, 4);
            Point two = new Point(6, 8);
            Point three = new Point(10, 2);
            Point foru = new Point(10, 2);

            Point3D one3D = new Point3D(2, 3, 5);
            Point3D two3D = new Point3D(1, 3, 4);
            Point3D three3D = new Point3D(1, 3, 6);

            Figure figure = new Figure(one, two , three );
            figure.Vive();
            figure.Zome(3);
            figure.Vive();
            Console.WriteLine($"\n3D Figure \n");
            Figure figure3D = new Figure(one3D, two3D, three3D);
            figure3D.Vive();
            figure3D.Move(7, 4);
            Console.WriteLine($"\n3D Figure New \n");
            figure3D.Vive();
        }
    }
}
