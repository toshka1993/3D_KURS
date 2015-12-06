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
        private float R, H;
        private int A;
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
            UpdateFigure();

        }
        
        protected override void SetPoints() 
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

            pointsProj = points;
        }

        protected override void SetEdges()
        {
            for (int i = 0; i < A - 1; i++)
            {
                edges[i] = new Edge(pointsProj[i], pointsProj[i + 1]);                         //
            }

            edges[A - 1] = new Edge(pointsProj[A - 1], pointsProj[0]);                         // нижнее основание

            for (int i = A; i < A * 2 - 1; i++)
            {
                edges[i] = new Edge(pointsProj[i], pointsProj[i + 1]);                         //
            }

            edges[A * 2 - 1] = new Edge(pointsProj[A * 2 - 1], pointsProj[A]);                 // верхнее основание

            for (int i = A * 2; i < A * 3; i++)
            {
                edges[i] = new Edge(pointsProj[i - A], pointsProj[i - A * 2]);                   // основания между собой
            }
        }

        protected override void SetFacets()
        {
            for (int i = 0; i < facets.Length; i++)
                facets[i] = new Facet();

            for (int i = 0; i < facets.Length; i++)
                facets[i].Points.Clear();

            for (int i = 0; i < A; i++)
            {
                facets[0].Points.Add(pointsProj[i]); // нижнее основание
            }

            for (int i = A; i < A*2; i++)
            {
                facets[1].Points.Add(pointsProj[i]); // верхнее основание
            }

            for (int i = 2; i < facets.Length - 1; i++)
            {
                facets[i].Points.Add(pointsProj[i - 2]);
                facets[i].Points.Add(pointsProj[A + i - 2]);
                facets[i].Points.Add(pointsProj[A + i + 1 - 2]);
                facets[i].Points.Add(pointsProj[i - 1]);
            }

            facets[facets.Length - 1].Points.Add(pointsProj[A - 1]);
            facets[facets.Length - 1].Points.Add(pointsProj[points.Length - 1]);
            facets[facets.Length - 1].Points.Add(pointsProj[A]);
            facets[facets.Length - 1].Points.Add(pointsProj[0]);
        }
    }
}
