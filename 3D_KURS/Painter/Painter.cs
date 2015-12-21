using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Painter
    {
        private Graphics gr;                 // переменная графической панел
        private PointF Zero;                 // начало координат
        private bool isColor;
        private bool isLight;
        Point3 lightPoint;

        protected List<Facet> facetsAll = new List<Facet>();

        public Painter(Graphics inGr, PointF inZero, List<Figure> ObjList, bool iColor, bool iLight, Point3 iLightPoint)
        {
            gr = inGr;
            Zero = inZero;
            isColor = iColor;
            isLight = iLight;
            lightPoint = iLightPoint;

            for (int i = 0; i < ObjList.Count; i++)
            {
                for (int j = 0; j < ObjList[i].facets.Length; j++)
                {
                    facetsAll.Add(ObjList[i].facets[j]);
                }
            }

            SortFacets();
            DrawPainter();
        }


        private void SortFacets()
        {
            for (int i = 0; i < facetsAll.Count - 1; i++)
            {
                for (int j = 0; j < facetsAll.Count - i - 1; j++)
                {
                    if (facetsAll[j].avZ > facetsAll[j + 1].avZ)
                    {
                        Facet f = facetsAll[j]; //change for elements
                        facetsAll[j] = facetsAll[j + 1];
                        facetsAll[j + 1] = f;
                    }
                }
            }
        }

        private void DrawPainter()
        {
            for (int i = 0; i < facetsAll.Count; i++)
            {
                List<PointF> lP = new List<PointF>();

                IsVisible(facetsAll[i]);

               // if (IsVisible(facetsAll[i]))
                //{
                //   List<PointF> lP = new List<PointF>();
                //    foreach (Point3 point3 in facetsAll[i].Points)
                //    {
                //        lP.Add(new PointF(Zero.X + (float)point3.X,
                //                          Zero.Y - (float)point3.Y));
                //    }
                //    if (isColor)
                //    {
                //        if (isLight)
                //            gr.FillPolygon(new SolidBrush(facetsAll[i].color), lP.ToArray());
                //        else
                //            gr.FillPolygon(new SolidBrush(facetsAll[i].colorFill), lP.ToArray());
                //    }
                //    else
                //        gr.FillPolygon(new SolidBrush(Color.White), lP.ToArray());
                //    if (!isColor || !isLight)
                //        gr.DrawPolygon(new Pen(Color.Black, 1), lP.ToArray());
                //}

                foreach (Point3 point3 in facetsAll[i].Points)
                {
                    lP.Add(new PointF(Zero.X + (float)point3.X,
                                      Zero.Y - (float)point3.Y));
                }
                if (isColor)
                {
                    if (isLight)
                    {
                        gr.FillPolygon(new SolidBrush(facetsAll[i].colorFill), lP.ToArray());
                    }
                    else
                    {
                        gr.FillPolygon(new SolidBrush(facetsAll[i].color), lP.ToArray());
                    }
                }
                else {
                    gr.FillPolygon(new SolidBrush(Color.White), lP.ToArray());
                }
                gr.DrawPolygon(new Pen(Color.Black, 1), lP.ToArray());
            }
        }

        public void IsVisible(Facet curGr)
        {
            Point3 VecA = new Point3(0, 0, 0);
            Point3 VecB = new Point3(0, 0, 0);
            Point3 norm = new Point3(0, 0, 0);
            Point3 Vis = new Point3(0, 0, 0);
            double normL, visL, ResVis;

            VecA.X = curGr.Points[1].X - curGr.Points[0].X;
            VecA.Y = curGr.Points[1].Y - curGr.Points[0].Y;
            VecA.Z = curGr.Points[1].Z - curGr.Points[0].Z;

            VecB.X = curGr.Points[2].X - curGr.Points[1].X;
            VecB.Y = curGr.Points[2].Y - curGr.Points[1].Y;
            VecB.Z = curGr.Points[2].Z - curGr.Points[1].Z;

            norm.X = VecA.Y * VecB.Z - VecA.Z * VecB.Y;
            norm.Y = VecA.X * VecB.Z - VecA.Z * VecB.X;
            norm.Z = VecA.X * VecB.Y - VecA.Y * VecB.X;

            Vis.X = 0; Vis.Y = 0; Vis.Z = -1000;

            normL = Math.Sqrt(Math.Pow(norm.X, 2) +
                    Math.Pow(norm.Y, 2) +
                    Math.Pow(norm.Z, 2));

            visL = Math.Sqrt(Math.Pow(Vis.X, 2) +
                   Math.Pow(Vis.Y, 2) +
                   Math.Pow(Vis.Z, 2));

            if (isLight)
            {
                visL = Math.Sqrt(Math.Pow(lightPoint.X, 2) +
                    Math.Pow(lightPoint.Y, 2) +
                    Math.Pow(lightPoint.Z, 2));

           //     normL = normL == 0 ? 0.0001 : normL;
           //     visL = visL == 0 ? 0.0001 : visL;

                ResVis = (norm.X * lightPoint.X + norm.Y * lightPoint.Y + norm.Z * lightPoint.Z) / (normL * visL);

                curGr.colorFill = Color.FromArgb((int)(curGr.color.R * (0.5 + 0.5 * ResVis)),
                                       (int)(curGr.color.G * (0.5 + 0.5 * ResVis)),
                                       (int)(curGr.color.B * (0.5 + 0.5 * ResVis)));
            }
        }
    }
}
