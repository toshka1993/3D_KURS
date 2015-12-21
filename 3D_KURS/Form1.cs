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

        Graphics gr;                                                    // графическая переменная
        PointF Zero;
        List<Figure> ObjList;                                           // список фигур

        private void create_model(int i)                                     // метод построения модели
        {

            Parallelepiped Par;
            Cylinder Cyl;
            float parL, parW, parH;
            float cylR, cylH;
            int cylA;
            Point3 pOrigin;

            ObjList = new List<Figure>();                               // список фигур

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

            gr = pDraw.CreateGraphics();                // графическая панель

            clear_panel();

            Projection proj = create_proj(i);                // метод получения объекта нужной проекции (в зависимости от выбранной)

            Par = new Parallelepiped(parL, parW, parH, gr, Zero, proj);         // создание параллелепипеда
            ObjList.Add(Par);                                                   // добавление объекта в список фигур

            Cyl = new Cylinder(cylR, cylH, cylA, pOrigin, gr, Zero, proj);      // создание цилиндра
            ObjList.Add(Cyl);                                                   // добавление объекта в список фигур
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
                    // косоугольная
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
            create_model(cbProj.SelectedIndex);

            grMove.Enabled = true;
            grScale.Enabled = true;
            grRotate.Enabled = true;
            isFill.Enabled = true;
        }

        private void butRotate_Click(object sender, EventArgs e)     // поворот
        {
            clear_panel();

            for (int i = 0; i < ObjList.Count; i++)
            {
                Rotate rot = new Rotate(ObjList[i], int.Parse(tbRotX.Text), int.Parse(tbRotY.Text), int.Parse(tbRotZ.Text));
            }

            if (isFill.Checked)
            {
                clear_panel();
                Painter p = new Painter(gr, Zero, ObjList, isColor.Enabled && isColor.Checked, cbLight.Enabled && cbLight.Checked, 
                    new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));
            }
        }

        private void butMove_Click(object sender, EventArgs e)   // перемещение
        {
            clear_panel();

            for (int i = 0; i < ObjList.Count; i++)
            {
                Move move = new Move(ObjList[i], int.Parse(tbMoveX.Text), int.Parse(tbMoveY.Text), int.Parse(tbMoveZ.Text));
            }

            if (isFill.Checked)
            {
                clear_panel();
                Painter p = new Painter(gr, Zero, ObjList, isColor.Enabled && isColor.Checked, cbLight.Enabled && cbLight.Checked,
                    new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));
            }
        }

        private void butScale_Click(object sender, EventArgs e)  // масштабирование
        {
            clear_panel();

            for (int i = 0; i < ObjList.Count; i++)
            {
                Scale scale = new Scale(ObjList[i], (float)tbScaleX.Value, (float)tbScaleY.Value, (float)tbScaleZ.Value);
            }

            if (isFill.Checked)
            {
                clear_panel();
                Painter p = new Painter(gr, Zero, ObjList, isColor.Enabled && isColor.Checked, cbLight.Enabled && cbLight.Checked,
                    new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));
            }
        }


        private void clear_panel()              // очистка панели
        {
            Color col = Color.White;
            gr.Clear(col);

       //     gr.DrawLine(new Pen(Color.Red, 1), pDraw.Size.Width / 2, 0, pDraw.Size.Width / 2, pDraw.Size.Height);
       //     gr.DrawLine(new Pen(Color.Red, 1), 0, pDraw.Size.Height / 2, pDraw.Size.Width, pDraw.Size.Height / 2);
        }

        private void cbProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProj.SelectedIndex)
            {
                case 0:  //выбрана фронтальная проекция -> скрыть все параметры проекций
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Hide();

                    grMove.Show();
                    grRotate.Show();
                    grScale.Show();

                    isFill.Show();
                    isColor.Show();
                    cbLight.Show();
                    break;
                case 1:  //выбрана горизонтальная проекция -> скрыть все параметры проекций
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Hide();

                    grMove.Show();
                    grRotate.Show();
                    grScale.Show();

                    isFill.Show();
                    isColor.Show();
                    cbLight.Show();
                    break;
                case 2:  //выбрана профильная проекция -> скрыть все параметры проекций
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Hide();

                    grMove.Show();
                    grRotate.Show();
                    grScale.Show();

                    isFill.Show();
                    isColor.Show();
                    cbLight.Show();
                    break;
                case 3:  //выбрана аксонометрическая проекция -> показать для данной проекции параметры
                    grAks.Show();
                    grObl.Hide();
                    grPer.Hide();

                    grMove.Hide();
                    grRotate.Hide();
                    grScale.Hide();

                    isFill.Hide();
                    isColor.Hide();
                    cbLight.Hide();
                    break;
                case 4: //выбрана косоугольная проекция -> показать для данной проекции параметры
                    grAks.Hide();
                    grObl.Show();
                    grPer.Hide();

                    grMove.Hide();
                    grRotate.Hide();
                    grScale.Hide();

                    isFill.Hide();
                    isColor.Hide();
                    cbLight.Hide();
                    break;
                case 5: //выбрана перспективная проекция -> показать для данной проекции параметры
                    grAks.Hide();
                    grObl.Hide();
                    grPer.Show();

                    grMove.Hide();
                    grRotate.Hide();
                    grScale.Hide();

                    isFill.Hide();
                    isColor.Hide();
                    cbLight.Hide();
                    break;
            }
        }

        private void isFill_CheckedChanged(object sender, EventArgs e)
        {
            clear_panel();
            Painter p = new Painter(gr, Zero, ObjList, isColor.Enabled && isColor.Checked, cbLight.Enabled && cbLight.Checked,
                new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));

            isColor.Enabled = isFill.Checked;
            cbLight.Enabled = isColor.Enabled && isColor.Checked;
        }

        private void isColor_CheckedChanged(object sender, EventArgs e)
        {
            cbLight.Enabled = isColor.Checked;

            clear_panel();
            Painter p = new Painter(gr, Zero, ObjList, isColor.Checked, cbLight.Enabled && cbLight.Checked,
                new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));
        }

        private void cbLight_CheckedChanged(object sender, EventArgs e)
        {
            grLight.Visible = cbLight.Checked;

            clear_panel();
            Painter p = new Painter(gr, Zero, ObjList, isColor.Checked, cbLight.Enabled && cbLight.Checked,
                new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));
        }

        private void butLight_Click(object sender, EventArgs e)
        {
            clear_panel();
            Painter p = new Painter(gr, Zero, ObjList, isColor.Checked, cbLight.Enabled && cbLight.Checked,
                new Point3(int.Parse(tbLightX.Text),
                             -int.Parse(tbLightY.Text),
                             int.Parse(tbLightZ.Text)));
        }

    }
}
