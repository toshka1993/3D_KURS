using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_KURS
{
    // класс масштабирования фигуры
    class Scale
    {
        public Point3[] points;
        private float scX, scY, scZ;

        public Scale(Figure obj, float inScX, float inScY, float inScZ)
        {
            points = obj.points;
            scX = inScX;
            scY = inScY;
            scZ = inScZ;

            points = ScaleObj();

            obj.points = points;
            obj.UpdateFigure();
        }
        private Point3[] ScaleObj()
        {
            Point3[] outMas = new Point3[points.Length];

            Matrix R = new Matrix(4, 4);            // матрица масшитабирования
            R[0, 0] = scX; R[0, 1] = 0; R[0, 2] = 0; R[0, 3] = 0;
            R[1, 0] = 0; R[1, 1] = scY; R[1, 2] = 0; R[1, 3] = 0;
            R[2, 0] = 0; R[2, 1] = 0; R[2, 2] = scZ; R[2, 3] = 0;
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
