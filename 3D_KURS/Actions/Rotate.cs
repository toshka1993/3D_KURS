using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    class Rotate
    {
        public Point3[] points;
        private int angleX, angleY, angleZ;

        public Rotate(Figure obj, int inAnX, int inAnY, int inAnZ)
        {
            points = obj.points;
            angleX = inAnX;
            angleY = inAnY;
            angleZ = inAnZ;

            points = RotateX();
            points = RotateY();
            points = RotateZ();

            obj.points = points;

            obj.UpdateFigure();
            obj.DrawFigure();
        }

        private Point3[] RotateX()
        {
            Point3[] outMas = new Point3[points.Length];

            double radians = Math.PI * angleX / 180;
            Matrix R = new Matrix(4, 4);
            R[0, 0] = 1;
            R[0, 1] = 0;
            R[0, 2] = 0;
            R[0, 3] = 0;
            R[1, 0] = 0;
            R[1, 1] = (float)Math.Cos(radians);
            R[1, 2] = (float)Math.Sin(radians);
            R[1, 3] = 0;
            R[2, 0] = 0;
            R[2, 1] = (float)-Math.Sin(radians);
            R[2, 2] = (float)Math.Cos(radians);
            R[2, 3] = 0;
            R[3, 0] = 0;
            R[3, 1] = 0;
            R[3, 2] = 0;
            R[3, 3] = 1;

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
        private Point3[] RotateY()
        {
            Point3[] outMas = new Point3[points.Length];

            double radians = Math.PI * angleY / 180;
            Matrix R = new Matrix(4, 4);
            R[0, 0] = (float)Math.Cos(radians);
            R[0, 1] = 0;
            R[0, 2] = (float)-Math.Sin(radians);
            R[0, 3] = 0;
            R[1, 0] = 0;
            R[1, 1] = 1;
            R[1, 2] = 0;
            R[1, 3] = 0;
            R[2, 0] = (float)Math.Sin(radians);
            R[2, 1] = 0;
            R[2, 2] = (float)Math.Cos(radians);
            R[2, 3] = 0;
            R[3, 0] = 0;
            R[3, 1] = 0;
            R[3, 2] = 0;
            R[3, 3] = 1;

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
        private Point3[] RotateZ()
        {
            Point3[] outMas = new Point3[points.Length];

            double radians = Math.PI * angleZ / 180;
            Matrix R = new Matrix(4, 4);
            R[0, 0] = (float)Math.Cos(radians);
            R[0, 1] = (float)Math.Sin(radians);
            R[0, 2] = 0;
            R[0, 3] = 0;
            R[1, 0] = (float)-Math.Sin(radians);
            R[1, 1] = (float)Math.Cos(radians);
            R[1, 2] = 0;
            R[1, 3] = 0;
            R[2, 0] = 0;
            R[2, 1] = 0;
            R[2, 2] = 1;
            R[2, 3] = 0;
            R[3, 0] = 0;
            R[3, 1] = 0;
            R[3, 2] = 0;
            R[3, 3] = 1;

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
