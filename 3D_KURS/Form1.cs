using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_KURS
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        Graphics gr;
        List<Figure> ObjList;

        private void create_model()
        {

            Parallelepiped Par;
            Cylinder Cyl;
            float parL, parW, parH;
            PointF Zero;
            float cylR, cylH;
            int cylA;
            Point3 pOrigin;

            ObjList = new List<Figure>();

            // параметры параллелепипеда
            parL = float.Parse(tbParL.Text);
            parW = float.Parse(tbParW.Text);
            parH = float.Parse(tbParH.Text);

            // параметры цилиндра
            cylR = float.Parse(tbCylR.Text);
            cylH = float.Parse(tbCylH.Text);
            cylA = int.Parse(tbCylA.Text);
            pOrigin = new Point3(parL / 2, parH, parW / 2);

            Zero = new PointF((float)(pDraw.Size.Width / 2 - parL / 2),
               (float)(pDraw.Size.Height / 2 + parH / 2));

            gr = pDraw.CreateGraphics();

            clear_panel();

            Projection proj = create_proj(cbProj.SelectedIndex);

            Par = new Parallelepiped(parL, parW, parH, gr, Zero, proj);
            ObjList.Add(Par);

            Cyl = new Cylinder(cylR, cylH, cylA, pOrigin, gr, Zero, proj);
            ObjList.Add(Cyl);
        }

        private Projection create_proj(int i)
        {
            Projection proj = null;

            switch (i)
            {
                case 0:
                    //фронтальная
                    proj = new Front();
                    break;
                case 1:
                    // горизонтальная
                    proj = new Horizontal();
                    break;
                case 2:
                    // профильная
                    proj = new Profile();
                    break;
                case 3:
                    // аксонометрическая
                    proj = new Axonometric(float.Parse(tbAksFi.Text), float.Parse(tbAksPsi.Text));
                    break;
                case 4:
                    proj = new Oblique(float.Parse(tbOblL.Text), float.Parse(tbOblAlfa.Text));
                    break;
                case 5:
                    // перспективная
                    proj = new Perspective(float.Parse(tbPerD.Text), float.Parse(tbPerTetta.Text), float.Parse(tbPerFi.Text), float.Parse(tbPerRo.Text));
                    break;
            }
            return proj;
        }

        private void butDrawModel_Click(object sender, EventArgs e)
        {
            create_model();
           

        }

        private void butRotate_Click(object sender, EventArgs e)
        {
            clear_panel();

            for (int i = 0; i < ObjList.Count; i++)
            {
                Rotate rot = new Rotate(ObjList[i], int.Parse(tbRotX.Text), int.Parse(tbRotY.Text), int.Parse(tbRotZ.Text));
            }

        }

        private void butMove_Click(object sender, EventArgs e)
        {
            clear_panel();
            for (int i = 0; i < ObjList.Count; i++)
            {
                Move move = new Move(ObjList[i], int.Parse(tbMoveX.Text), int.Parse(tbMoveY.Text), int.Parse(tbMoveZ.Text));
            }
        }

        private void butScale_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ObjList.Count; i++)
            {
                Scale scale = new Scale(ObjList[i], (float)tbScaleX.Value, (float)tbScaleY.Value, (float)tbScaleZ.Value);
            }
        }


        private void clear_panel()
        {
            Color col = Color.White;
            gr.Clear(col);
        }

        private void butDrawProj_Click(object sender, EventArgs e)
        {
            
        }

        private void cbProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProj.SelectedIndex)
            {
                case 0:
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Hide();
                    break;
                case 1:
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Hide();
                    break;
                case 2:
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Hide();
                    break;
                case 3:
                    grAks.Show();
                    grObl.Hide();
                    grPer.Hide();
                    break;
                case 4:
                    grAks.Hide();
                    grObl.Show();
                    grPer.Hide();
                    break;
                case 5:
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Show();
                    break;
            }
        }

    }
}
