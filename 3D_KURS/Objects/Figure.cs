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
        protected Edge[] edges;               // ребра фигуры
        public Facet[] facets;                // грани фигуры
        protected Projection proj;            //проекция

        private Graphics gr;                 // переменная графической панели
        private PointF Zero;                 //начало координат

        public Figure(Graphics inGr, PointF inZero)
        {
            gr = inGr;
            Zero = inZero;
        }

        // функции абстрактные, т.к. для каждой фигуры они реализуются по-разному и их выполнение реализовано 
        // в наследуемых классах, т.е. в классах конкретных фигур (цилиндра и параллелепипеда

        abstract protected void SetPoints();         // задание точек фигуры

        abstract protected void SetEdges();          // задание ребер фигуры

        abstract protected void SetFacets();         // задание граней фигуры

        public void DrawFigure()                    // отрисовка фигуры по граням
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

        public void GetFigure()              // обновление фигуры
        {
            points = proj.CreateProjection(points);     // получение точек проекции фигуры

            UpdateFigure();
        }

        public void UpdateFigure()              // обновление фигуры
        {
            SetEdges();
            SetFacets();
            DrawFigure();
        }
    }
}
