using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 

    public struct Point3D
    {
        //2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
        //Add a static property to return the point O.
        private static readonly Point3D pointZero = new Point3D(0, 0, 0);
        public static Point3D PointZero
        {
            get { return pointZero; }
        }
        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        //1. Implement the ToString() to enable printing a 3D point.
        public override string ToString()
        {
            return string.Format("{{X = {0} Y = {1} Z = {2}}}", this.X, this.Y, this.Z);
        }
    }
    //3. Write a static class with a static method to calculate the distance between two points in the 3D space.
    static class DistCalcClass
    {
        public static double Distance(Point3D a, Point3D b)
        {
            //d = sqrt[(x1-x2)^2 + (y1-y2)^2 + (z1-z2)^2] 
            return Math.Sqrt( ((a.X-b.X)*(a.X-b.X)) + ((a.Y-b.Y)*(a.Y-b.Y)) + ((a.Z-b.Z)*(a.Z-b.Z)) );
        }
    }
    class Path
    {
        public readonly List<Point3D> nPoints = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.nPoints;
            }
        }
        public void AddPoint(Point3D point)
        {
            nPoints.Add(point);
        }
    }
    static class PathStorage
    {
        public static List<Path> LoadPath()
        {
            Path loadApath = new Path();
            List<Path> loadedPaths = new List<Path>();
            using (StreamReader reader = new StreamReader(@"../../LoadPaths.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line != ".")//a dot delimeter to make sure that we take all different paths
                    {
                        Point3D point = new Point3D();
                        string[] points = line.Split(',');
                        //taking the x, y and z by splitting the string
                        point.X = int.Parse(points[0]);
                        point.Y = int.Parse(points[1]);
                        point.Z = int.Parse(points[2]);

                        loadApath.AddPoint(point);
                    }
                    else
                    {
                        loadedPaths.Add(loadApath);
                        loadApath = new Path();
                    }
                    line = reader.ReadLine();
                }
            }
            return loadedPaths;
        }
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../SavePaths.txt"))
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
            }
        }
    }
    class thePoint3D
    {
        static void Main(string[] args)
        {
            Point3D pointOne = new Point3D(2, 5, 4);
            Point3D pointTwo = new Point3D(2, 5, 3);
            //Console.WriteLine(pointOne);
            //Console.WriteLine(Point3D.PointZero);
            //3. displaying part 3.
            //Console.WriteLine(DistCalcClass.Distance(pointOne, pointTwo));

            //part 4 bellow:
            Path pathOne = new Path();
            pathOne.AddPoint(pointTwo);
            pathOne.AddPoint(pointOne);
            pathOne.AddPoint(pointTwo);
            pathOne.AddPoint(pointOne);

            PathStorage.SavePath(pathOne);
            List<Path> listOfPaths = PathStorage.LoadPath();
            foreach (var path in listOfPaths)
            {
                Console.WriteLine("......Path Beginning......");
                foreach (var points in path.Paths)
                {
                    Console.WriteLine(points);
                }
                Console.WriteLine("......Path Ending......");
                Console.WriteLine();
            }
        }
    }