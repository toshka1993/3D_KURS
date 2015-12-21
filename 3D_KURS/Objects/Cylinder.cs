using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Cylinder : Figure
    {
        private float R, H;             //радиус и высота
        private int A;                  //значение апроксимации
        private Point3 pOrigin;

        public Cylinder(float inR, float inH, int inA, Point3 inpOrigin, Graphics inGr, PointF inZero, Projection inProj)
            : base(inGr, inZero)
        {
            R = inR;
            H = inH;
            A = inA;

            proj = inProj;                        // проекция

            points = new Point3[A * 2];          // массив для A * 2 точек цилиндра
            edges = new Edge[A * 3];             // массив для A * 3 ребер цилиндра
            facets = new Facet[A + 2];           // массив для A + 2 граней цилиндра

            pOrigin = inpOrigin;                 // точка начала построения цилиндра       

            SetPoints();
            GetFigure();

        }
        
        protected override void SetPoints()                 // фунцкция задает точки цилиндра
        {
            var angle = Math.PI * 2 / A;

            var bufP = Enumerable.Range(0, A)
                  .Select(i => PointF.Add(new PointF(pOrigin.X, pOrigin.Y), new SizeF((float)Math.Sin(i * angle) * (float)R,
                      (float)Math.Cos(i * angle) * (float)R)));

            //Координаты нижнего основания цилиндра
            PointF[] bufPoint = new PointF[bufP.Count()];
            bufPoint = bufP.ToArray();

            for (int i = 0; i < bufP.Count(); i++)
            {
                points[i]  = new Point3(bufPoint[i].X, pOrigin.Y, bufPoint[i].Y - pOrigin.Z);
            }

            //Координаты верхнего основания цилиндра
            bufP = Enumerable.Range(0, A)
                  .Select(i => PointF.Add(new PointF(pOrigin.X, pOrigin.Y + H), new SizeF((float)Math.Sin(i * angle) * (float)R,
                      (float)Math.Cos(i * angle) * (float)R)));

            //Координаты цилиндра
            bufPoint = new PointF[bufP.Count()];
            bufPoint = bufP.ToArray();

            for (int i = 0; i < bufP.Count(); i++)
            {
                points[i + A] = new Point3(bufPoint[i].X, pOrigin.Y + H, bufPoint[i].Y - pOrigin.Z - H);
            }

      //      points = points;
        }

        protected override void SetEdges()                  // фунцкция задает ребра цилиндра
        {
            for (int i = 0; i < A - 1; i++)
            {
                edges[i] = new Edge(points[i], points[i + 1]);                         //
            }

            edges[A - 1] = new Edge(points[A - 1], points[0]);                         // нижнее основание

            for (int i = A; i < A * 2 - 1; i++)
            {
                edges[i] = new Edge(points[i], points[i + 1]);                         //
            }

            edges[A * 2 - 1] = new Edge(points[A * 2 - 1], points[A]);                 // верхнее основание

            for (int i = A * 2; i < A * 3; i++)
            {
                edges[i] = new Edge(points[i - A], points[i - A * 2]);                   // основания между собой
            }
        }

        protected override void SetFacets()                         // фунцкция задает грани цилиндра
        {
            for (int i = 0; i < facets.Length; i++)
                facets[i] = new Facet();

            for (int i = 0; i < facets.Length; i++)
            {
                facets[i].Points.Clear();
                facets[i].avZ = 0;
            }

            for (int i = 0; i < A; i++)
            {
                facets[0].Points.Add(points[i]); // нижнее основание
                facets[0].avZ += points[i].Z;
            }

            facets[0].avZ = facets[0].avZ / A;

            for (int i = A * 2 - 1; i > A; i--)
            {
                facets[1].Points.Add(points[i]); // верхнее основание
                facets[1].avZ += points[i].Z;
            }
            facets[1].avZ = facets[1].avZ / A;

            for (int i = 2; i < facets.Length - 1; i++)
            {
                facets[i].Points.Add(points[i - 2]);
                facets[i].Points.Add(points[A + i - 2]);
                facets[i].Points.Add(points[A + i + 1 - 2]);
                facets[i].Points.Add(points[i - 1]);

                facets[i].avZ = (points[i - 2].Z + points[A + i - 2].Z + points[A + i + 1 - 2].Z + points[i - 1].Z) / 4;
            }

            facets[facets.Length - 1].Points.Add(points[A - 1]);
            facets[facets.Length - 1].Points.Add(points[points.Length - 1]);
            facets[facets.Length - 1].Points.Add(points[A]);
            facets[facets.Length - 1].Points.Add(points[0]);

            facets[facets.Length - 1].avZ = (points[A - 1].Z + points[points.Length - 1].Z + points[A].Z + points[0].Z) / 4;

            for (int i = 0; i < facets.Length; i++)
            {
                facets[i].color = Color.Salmon;
                facets[i].colorFill = Color.Salmon;
            }
        }
    }
}
