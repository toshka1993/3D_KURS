using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    // интерфейс фигуры
    abstract class Figure 
    {
        public Point3[] points;               // точки фигуры

        protected Point3[] pointsProj;        // точки проекции фигуры
        protected Edge[] edges;               // ребра фигуры
        protected Facet[] facets;             // грани фигуры
        protected Projection proj;            //проекция

        private Graphics gr;
        private PointF Zero;                 //начало координат

        public Figure(Graphics inGr, PointF inZero)
        {
            gr = inGr;
            Zero = inZero;
        }

        abstract protected void SetPoints();

        abstract protected void SetEdges();

        abstract protected void SetFacets();


        public void DrawFigure() 
        {
            foreach (Facet fat in facets)
            {
                List<PointF> lP = new List<PointF>();
                foreach (Point3 point3 in fat.Points)
                {
                    lP.Add(new PointF(Zero.X + (float)point3.X,
                                      Zero.Y - (float)point3.Y));
                }
                gr.DrawPolygon(new Pen(Color.Black, 1), lP.ToArray());
            }
        }
        public void UpdateFigure()
        {
            pointsProj = proj.CreateProjection(points);

            SetEdges();
            SetFacets();
            DrawFigure();
        }
    }
}
