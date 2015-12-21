using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Parallelepiped : Figure
    {
        private float L, W, H;

        public Parallelepiped(float inL, float inW, float inH, Graphics inGr, PointF inZero, Projection inProj)
            : base(inGr, inZero)
        {
            L = inL;
            W = inW;
            H = inH;


            proj = inProj;                    // прокция

            points = new Point3[8];           // массив для 8 точек параллелепипеда
        //    pointsProj = new Point3[8];       // массив для 8 точек параллелепипеда
            edges = new Edge[12];             // массив для 12 ребер параллелепипеда
            facets = new Facet[6];            // массив для 6 граней параллелепипеда

            SetPoints();
            GetFigure();

        }

        protected override void SetPoints()                     // фунцкция задает точки параллелепипеда
        {
            points[0] = new Point3(0, 0, 0);
            points[1] = new Point3(0, H, 0);
            points[2] = new Point3(L, H, 0);
            points[3] = new Point3(L, 0, 0);

            points[4] = new Point3(0, 0, W);
            points[5] = new Point3(0, H, W);
            points[6] = new Point3(L, H,  W);
            points[7] = new Point3(L, 0, W);

         //   pointsProj = points;
        }

        protected override void SetEdges()                          // фунцкция задает ребра параллелепипеда
        {
            edges[0] = new Edge(points[0], points[1]);
            edges[1] = new Edge(points[1], points[2]);
            edges[2] = new Edge(points[2], points[3]);
            edges[3] = new Edge(points[3], points[0]);
            edges[4] = new Edge(points[4], points[5]);
            edges[5] = new Edge(points[5], points[6]);
            edges[6] = new Edge(points[6], points[7]);
            edges[7] = new Edge(points[7], points[4]);
            edges[8] = new Edge(points[0], points[4]);
            edges[9] = new Edge(points[1], points[5]);
            edges[10] = new Edge(points[2], points[6]);
            edges[11] = new Edge(points[3], points[7]);
        }

        protected override void SetFacets()                                 // фунцкция задает грани параллелепипеда
        {
            for (int i = 0; i < facets.Length; i++)
                facets[i] = new Facet();

            for (int i = 0; i < facets.Length; i++)
                if (facets[i] != null)
                {
                    facets[i].Points.Clear();
                    facets[i].avZ = 0;
                }

            facets[0].Points.Add(points[0]); facets[0].Points.Add(points[3]);
            facets[0].Points.Add(points[2]); facets[0].Points.Add(points[1]);
            facets[0].avZ = (points[0].Z + points[1].Z + points[2].Z + points[3].Z) / 4;

            facets[1].Points.Add(points[7]); facets[1].Points.Add(points[4]);
            facets[1].Points.Add(points[5]); facets[1].Points.Add(points[6]);
            facets[1].avZ = (points[4].Z + points[5].Z + points[6].Z + points[7].Z) / 4;

            facets[2].Points.Add(points[0]); facets[2].Points.Add(points[4]);
            facets[2].Points.Add(points[5]); facets[2].Points.Add(points[1]);
            facets[2].avZ = (points[0].Z + points[1].Z + points[4].Z + points[5].Z) / 4;

            facets[3].Points.Add(points[1]); facets[3].Points.Add(points[2]);
            facets[3].Points.Add(points[6]); facets[3].Points.Add(points[5]);
            facets[3].avZ = (points[1].Z + points[2].Z + points[5].Z + points[6].Z) / 4;

            facets[4].Points.Add(points[3]); facets[4].Points.Add(points[7]);
            facets[4].Points.Add(points[6]); facets[4].Points.Add(points[2]);
            facets[4].avZ = (points[2].Z + points[3].Z + points[4].Z + points[7].Z) / 4;

            facets[5].Points.Add(points[0]); facets[5].Points.Add(points[3]);
            facets[5].Points.Add(points[7]); facets[5].Points.Add(points[4]);
            facets[5].avZ = (points[0].Z + points[3].Z + points[4].Z + points[7].Z) / 4;

            for (int i = 0; i < facets.Length; i++)
            {
                facets[i].color = Color.RoyalBlue;
                facets[i].colorFill = Color.RoyalBlue;
            }
        }
    }
}
