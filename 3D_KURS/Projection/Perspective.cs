using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Perspective : Projection
    {
        private float d, tetta, fi, ro;

        public Perspective(float inD, float inTetta, float inFi, float inRo)
            : base()
        {
            d = inD;
            tetta = inTetta;
            fi = inFi;
            ro = inRo;
        }

        public override Point3[] CreateProjection(Point3[] points)
        {
            Point3[] outMas = new Point3[points.Length];

            Matrix R = new Matrix(4, 4);
            /*R[0, 0] = -Math.Sin(tetta); R[0, 1] = -Math.Cos(fi) * Math.Cos(tetta); R[0, 2] = -Math.Sin(fi) * Math.Cos(tetta); R[0, 3] = 0;
            R[1, 0] = Math.Cos(tetta); R[1, 1] = -Math.Cos(fi) * Math.Sin(tetta); R[1, 2] = -Math.Sin(fi) * Math.Sin(tetta); R[1, 3] = 0;
            R[2, 0] = 0; R[2, 1] = Math.Sin(fi); R[2, 2] = -Math.Cos(fi); R[2, 3] = 0;
            R[3, 0] = 0; R[3, 1] = 0; R[3, 2] = ro; R[3, 3] = 1;*/

            R[0, 0] = (float)Math.Cos(tetta); R[0, 1] = (float)-Math.Cos(fi) * (float)Math.Sin(tetta); R[0, 2] = (float)-Math.Sin(fi) * (float)Math.Sin(tetta); R[0, 3] = 0;
            R[1, 0] = (float)Math.Sin(tetta); R[1, 1] = (float)Math.Cos(fi) * (float)Math.Cos(tetta); R[1, 2] = (float)Math.Sin(fi) * (float)Math.Cos(tetta); R[1, 3] = 0;
            R[2, 0] = 0; R[2, 1] = (float)Math.Sin(fi); R[2, 2] = (float)-Math.Cos(fi); R[2, 3] = 0;
            R[3, 0] = 0; R[3, 1] = 0; R[3, 2] = ro; R[3, 3] = 1;

            for (int i = 0; i < points.Length; i++)
            {
                Matrix s = new Matrix(1, 4);
                s[0, 0] = points[i].X;
                s[0, 1] = points[i].Y;
                s[0, 2] = points[i].Z;
                s[0, 3] = 1;

                Matrix outM = Matrix.Multiply(s, R);
                if (outM[0, 2] == 0)
                {
                    outM[0, 2] = 0.1F;
                }
                outMas[i] = new Point3(outM[0, 0] * d / outM[0, 2], outM[0, 1] * d / outM[0, 2], outM[0, 2] * d / outM[0, 2]);
            }
            return outMas;
        }
    }
}
