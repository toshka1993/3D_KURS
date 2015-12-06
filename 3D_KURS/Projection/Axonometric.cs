using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Axonometric : Projection
    {
        private float fi, psi;

        public Axonometric(float inFi, float inPsi)
            : base()
        {
            fi = (float)Math.PI * inFi / 180;
            psi = (float)Math.PI * inPsi / 180;
        }

        public override Point3[] CreateProjection(Point3[] points)
        {
            Point3[] outMas = new Point3[points.Length];

            Matrix R = new Matrix(4, 4);                    // матрица проекции
            R[0, 0] = (float)Math.Cos(psi); R[0, 1] = (float)Math.Sin(fi) * (float)Math.Sin(psi); R[0, 2] = 0; R[0, 3] = 0;
            R[1, 0] = 0; R[1, 1] = (float)Math.Cos(fi); R[1, 2] = 0; R[1, 3] = 0;
            R[2, 0] = (float)Math.Sin(psi); R[2, 1] = -1 * (float)Math.Sin(fi) * (float)Math.Cos(psi); R[2, 2] = 0; R[2, 3] = 0;
            R[3, 0] = 0; R[3, 1] = 0; R[3, 2] = 0; R[3, 3] = 1;

            for (int i = 0; i < points.Length; i++)
            {
                Matrix s = new Matrix(1, 4);
                s[0, 0] = points[i].X;
                s[0, 1] = points[i].Y;
                s[0, 2] = points[i].Z;
                s[0, 3] = 1;

                Matrix outM = Matrix.Multiply(s, R);
                outMas[i] = new Point3(outM[0, 0], outM[0, 1], outM[0, 2]);
            }
            return outMas;
        }
    }
}
