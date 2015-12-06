using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    abstract class Projection
    {

        public Projection()
        {
        }

        abstract public Point3[] CreateProjection(Point3[] points);
    }
}
