using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Point3
    {
        public float X;
        public float Y;
        public float Z;

        public Point3(float inX, float inY, float inZ)
        {
            X = inX;
            Y = inY;
            Z = inZ;
        }
    }

    class Edge
    {
        public Point3 A;
        public Point3 B;

        public Edge(Point3 inA, Point3 inB)
        {
            A = inA;
            B = inB;
        }
    }

    class Facet
    {
        public List<Point3> Points;
        public Facet()
        {
            Points = new List<Point3>();
        }
    }

}
