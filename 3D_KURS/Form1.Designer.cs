namespace _3D_KURS
{
    partial class ModelForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grPar = new System.Windows.Forms.GroupBox();
            this.tbParH = new System.Windows.Forms.TextBox();
            this.tbParW = new System.Windows.Forms.TextBox();
            this.lab_ParH = new System.Windows.Forms.Label();
            this.lab_ParW = new System.Windows.Forms.Label();
            this.tbParL = new System.Windows.Forms.TextBox();
            this.lab_ParL = new System.Windows.Forms.Label();
            this.grCyl = new System.Windows.Forms.GroupBox();
            this.lab_CylA = new System.Windows.Forms.Label();
            this.tbCylA = new System.Windows.Forms.NumericUpDown();
            this.tbCylH = new System.Windows.Forms.TextBox();
            this.lab_CylH = new System.Windows.Forms.Label();
            this.lab_CylR = new System.Windows.Forms.Label();
            this.tbCylR = new System.Windows.Forms.TextBox();
            this.butDrawModel = new System.Windows.Forms.Button();
            this.pDraw = new System.Windows.Forms.Panel();
            this.grRotate = new System.Windows.Forms.GroupBox();
            this.butRotate = new System.Windows.Forms.Button();
            this.tbRotZ = new System.Windows.Forms.TextBox();
            this.tbRotY = new System.Windows.Forms.TextBox();
            this.tbRotX = new System.Windows.Forms.TextBox();
            this.lab_RotZ = new System.Windows.Forms.Label();
            this.lab_RotY = new System.Windows.Forms.Label();
            this.lab_RotX = new System.Windows.Forms.Label();
            this.grMove = new System.Windows.Forms.GroupBox();
            this.butMove = new System.Windows.Forms.Button();
            this.tbMoveZ = new System.Windows.Forms.TextBox();
            this.tbMoveY = new System.Windows.Forms.TextBox();
            this.tbMoveX = new System.Windows.Forms.TextBox();
            this.lab_MoveZ = new System.Windows.Forms.Label();
            this.lab_MoveY = new System.Windows.Forms.Label();
            this.lab_MoveX = new System.Windows.Forms.Label();
            this.grScale = new System.Windows.Forms.GroupBox();
            this.tbScaleZ = new System.Windows.Forms.NumericUpDown();
            this.tbScaleY = new System.Windows.Forms.NumericUpDown();
            this.tbScaleX = new System.Windows.Forms.NumericUpDown();
            this.butScale = new System.Windows.Forms.Button();
            this.lab_ScaleZ = new System.Windows.Forms.Label();
            this.lab_ScaleY = new System.Windows.Forms.Label();
            this.lab_ScaleX = new System.Windows.Forms.Label();
            this.grProj = new System.Windows.Forms.GroupBox();
            this.grAks = new System.Windows.Forms.GroupBox();
            this.tbAksPsi = new System.Windows.Forms.TextBox();
            this.lab_AksPsi = new System.Windows.Forms.Label();
            this.tbAksFi = new System.Windows.Forms.TextBox();
            this.lab_AksFi = new System.Windows.Forms.Label();
            this.grPer = new System.Windows.Forms.GroupBox();
            this.tbPerRo = new System.Windows.Forms.TextBox();
            this.lab_PerRo = new System.Windows.Forms.Label();
            this.tbPerTetta = new System.Windows.Forms.TextBox();
            this.lab_PerTetta = new System.Windows.Forms.Label();
            this.tbPerFi = new System.Windows.Forms.TextBox();
            this.lab_PerFi = new System.Windows.Forms.Label();
            this.tbPerD = new System.Windows.Forms.TextBox();
            this.lab_PerD = new System.Windows.Forms.Label();
            this.grObl = new System.Windows.Forms.GroupBox();
            this.tbOblAlfa = new System.Windows.Forms.TextBox();
            this.lab_OblAlfa = new System.Windows.Forms.Label();
            this.tbOblL = new System.Windows.Forms.TextBox();
            this.lab_OblL = new System.Windows.Forms.Label();
            this.cbProj = new System.Windows.Forms.ComboBox();
            this.grPar.SuspendLayout();
            this.grCyl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCylA)).BeginInit();
            this.grRotate.SuspendLayout();
            this.grMove.SuspendLayout();
            this.grScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleX)).BeginInit();
            this.grProj.SuspendLayout();
            this.grAks.SuspendLayout();
            this.grPer.SuspendLayout();
            this.grObl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grPar
            // 
            this.grPar.Controls.Add(this.tbParH);
            this.grPar.Controls.Add(this.tbParW);
            this.grPar.Controls.Add(this.lab_ParH);
            this.grPar.Controls.Add(this.lab_ParW);
            this.grPar.Controls.Add(this.tbParL);
            this.grPar.Controls.Add(this.lab_ParL);
            this.grPar.Location = new System.Drawing.Point(12, 12);
            this.grPar.Name = "grPar";
            this.grPar.Size = new System.Drawing.Size(149, 100);
            this.grPar.TabIndex = 0;
            this.grPar.TabStop = false;
            this.grPar.Text = "Параметры параллел-да";
            // 
            // tbParH
            // 
            this.tbParH.Location = new System.Drawing.Point(75, 71);
            this.tbParH.Name = "tbParH";
            this.tbParH.Size = new System.Drawing.Size(55, 20);
            this.tbParH.TabIndex = 5;
            this.tbParH.Text = "100";
            // 
            // tbParW
            // 
            this.tbParW.Location = new System.Drawing.Point(75, 44);
            this.tbParW.Name = "tbParW";
            this.tbParW.Size = new System.Drawing.Size(55, 20);
            this.tbParW.TabIndex = 4;
            this.tbParW.Text = "100";
            // 
            // lab_ParH
            // 
            this.lab_ParH.AutoSize = true;
            this.lab_ParH.Location = new System.Drawing.Point(17, 74);
            this.lab_ParH.Name = "lab_ParH";
            this.lab_ParH.Size = new System.Drawing.Size(44, 13);
            this.lab_ParH.TabIndex = 3;
            this.lab_ParH.Text = "высота";
            // 
            // lab_ParW
            // 
            this.lab_ParW.AutoSize = true;
            this.lab_ParW.Location = new System.Drawing.Point(17, 47);
            this.lab_ParW.Name = "lab_ParW";
            this.lab_ParW.Size = new System.Drawing.Size(45, 13);
            this.lab_ParW.TabIndex = 2;
            this.lab_ParW.Text = "ширина";
            // 
            // tbParL
            // 
            this.tbParL.Location = new System.Drawing.Point(75, 20);
            this.tbParL.Name = "tbParL";
            this.tbParL.Size = new System.Drawing.Size(55, 20);
            this.tbParL.TabIndex = 1;
            this.tbParL.Text = "100";
            // 
            // lab_ParL
            // 
            this.lab_ParL.AutoSize = true;
            this.lab_ParL.Location = new System.Drawing.Point(17, 23);
            this.lab_ParL.Name = "lab_ParL";
            this.lab_ParL.Size = new System.Drawing.Size(37, 13);
            this.lab_ParL.TabIndex = 0;
            this.lab_ParL.Text = "длина";
            // 
            // grCyl
            // 
            this.grCyl.Controls.Add(this.lab_CylA);
            this.grCyl.Controls.Add(this.tbCylA);
            this.grCyl.Controls.Add(this.tbCylH);
            this.grCyl.Controls.Add(this.lab_CylH);
            this.grCyl.Controls.Add(this.lab_CylR);
            this.grCyl.Controls.Add(this.tbCylR);
            this.grCyl.Location = new System.Drawing.Point(13, 119);
            this.grCyl.Name = "grCyl";
            this.grCyl.Size = new System.Drawing.Size(148, 112);
            this.grCyl.TabIndex = 1;
            this.grCyl.TabStop = false;
            this.grCyl.Text = "Параметры цилиндра";
            // 
            // lab_CylA
            // 
            this.lab_CylA.AutoSize = true;
            this.lab_CylA.Location = new System.Drawing.Point(16, 86);
            this.lab_CylA.Name = "lab_CylA";
            this.lab_CylA.Size = new System.Drawing.Size(46, 13);
            this.lab_CylA.TabIndex = 5;
            this.lab_CylA.Text = "апрокс.";
            // 
            // tbCylA
            // 
            this.tbCylA.Location = new System.Drawing.Point(74, 84);
            this.tbCylA.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbCylA.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.tbCylA.Name = "tbCylA";
            this.tbCylA.Size = new System.Drawing.Size(55, 20);
            this.tbCylA.TabIndex = 4;
            this.tbCylA.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tbCylH
            // 
            this.tbCylH.Location = new System.Drawing.Point(74, 57);
            this.tbCylH.Name = "tbCylH";
            this.tbCylH.Size = new System.Drawing.Size(55, 20);
            this.tbCylH.TabIndex = 3;
            this.tbCylH.Text = "50";
            // 
            // lab_CylH
            // 
            this.lab_CylH.AutoSize = true;
            this.lab_CylH.Location = new System.Drawing.Point(18, 60);
            this.lab_CylH.Name = "lab_CylH";
            this.lab_CylH.Size = new System.Drawing.Size(44, 13);
            this.lab_CylH.TabIndex = 2;
            this.lab_CylH.Text = "высота";
            // 
            // lab_CylR
            // 
            this.lab_CylR.AutoSize = true;
            this.lab_CylR.Location = new System.Drawing.Point(18, 33);
            this.lab_CylR.Name = "lab_CylR";
            this.lab_CylR.Size = new System.Drawing.Size(42, 13);
            this.lab_CylR.TabIndex = 1;
            this.lab_CylR.Text = "радиус";
            // 
            // tbCylR
            // 
            this.tbCylR.Location = new System.Drawing.Point(74, 30);
            this.tbCylR.Name = "tbCylR";
            this.tbCylR.Size = new System.Drawing.Size(55, 20);
            this.tbCylR.TabIndex = 0;
            this.tbCylR.Text = "20";
            // 
            // butDrawModel
            // 
            this.butDrawModel.Location = new System.Drawing.Point(6, 107);
            this.butDrawModel.Name = "butDrawModel";
            this.butDrawModel.Size = new System.Drawing.Size(140, 23);
            this.butDrawModel.TabIndex = 2;
            this.butDrawModel.Text = "Построить";
            this.butDrawModel.UseVisualStyleBackColor = true;
            this.butDrawModel.Click += new System.EventHandler(this.butDrawModel_Click);
            // 
            // pDraw
            // 
            this.pDraw.BackColor = System.Drawing.Color.White;
            this.pDraw.Location = new System.Drawing.Point(167, 0);
            this.pDraw.Name = "pDraw";
            this.pDraw.Size = new System.Drawing.Size(747, 673);
            this.pDraw.TabIndex = 3;
            // 
            // grRotate
            // 
            this.grRotate.Controls.Add(this.butRotate);
            this.grRotate.Controls.Add(this.tbRotZ);
            this.grRotate.Controls.Add(this.tbRotY);
            this.grRotate.Controls.Add(this.tbRotX);
            this.grRotate.Controls.Add(this.lab_RotZ);
            this.grRotate.Controls.Add(this.lab_RotY);
            this.grRotate.Controls.Add(this.lab_RotX);
            this.grRotate.Enabled = false;
            this.grRotate.Location = new System.Drawing.Point(13, 379);
            this.grRotate.Name = "grRotate";
            this.grRotate.Size = new System.Drawing.Size(148, 94);
            this.grRotate.TabIndex = 4;
            this.grRotate.TabStop = false;
            this.grRotate.Text = "Поворот";
            // 
            // butRotate
            // 
            this.butRotate.Location = new System.Drawing.Point(91, 20);
            this.butRotate.Name = "butRotate";
            this.butRotate.Size = new System.Drawing.Size(51, 64);
            this.butRotate.TabIndex = 6;
            this.butRotate.Text = "Повернуть";
            this.butRotate.UseVisualStyleBackColor = true;
            this.butRotate.Click += new System.EventHandler(this.butRotate_Click);
            // 
            // tbRotZ
            // 
            this.tbRotZ.Location = new System.Drawing.Point(26, 68);
            this.tbRotZ.Name = "tbRotZ";
            this.tbRotZ.Size = new System.Drawing.Size(46, 20);
            this.tbRotZ.TabIndex = 5;
            this.tbRotZ.Text = "15";
            // 
            // tbRotY
            // 
            this.tbRotY.Location = new System.Drawing.Point(26, 42);
            this.tbRotY.Name = "tbRotY";
            this.tbRotY.Size = new System.Drawing.Size(46, 20);
            this.tbRotY.TabIndex = 4;
            this.tbRotY.Text = "15";
            // 
            // tbRotX
            // 
            this.tbRotX.Location = new System.Drawing.Point(26, 16);
            this.tbRotX.Name = "tbRotX";
            this.tbRotX.Size = new System.Drawing.Size(46, 20);
            this.tbRotX.TabIndex = 3;
            this.tbRotX.Text = "15";
            // 
            // lab_RotZ
            // 
            this.lab_RotZ.AutoSize = true;
            this.lab_RotZ.Location = new System.Drawing.Point(6, 71);
            this.lab_RotZ.Name = "lab_RotZ";
            this.lab_RotZ.Size = new System.Drawing.Size(14, 13);
            this.lab_RotZ.TabIndex = 2;
            this.lab_RotZ.Text = "Z";
            // 
            // lab_RotY
            // 
            this.lab_RotY.AutoSize = true;
            this.lab_RotY.Location = new System.Drawing.Point(6, 45);
            this.lab_RotY.Name = "lab_RotY";
            this.lab_RotY.Size = new System.Drawing.Size(14, 13);
            this.lab_RotY.TabIndex = 1;
            this.lab_RotY.Text = "Y";
            // 
            // lab_RotX
            // 
            this.lab_RotX.AutoSize = true;
            this.lab_RotX.Location = new System.Drawing.Point(6, 19);
            this.lab_RotX.Name = "lab_RotX";
            this.lab_RotX.Size = new System.Drawing.Size(14, 13);
            this.lab_RotX.TabIndex = 0;
            this.lab_RotX.Text = "X";
            // 
            // grMove
            // 
            this.grMove.Controls.Add(this.butMove);
            this.grMove.Controls.Add(this.tbMoveZ);
            this.grMove.Controls.Add(this.tbMoveY);
            this.grMove.Controls.Add(this.tbMoveX);
            this.grMove.Controls.Add(this.lab_MoveZ);
            this.grMove.Controls.Add(this.lab_MoveY);
            this.grMove.Controls.Add(this.lab_MoveX);
            this.grMove.Enabled = false;
            this.grMove.Location = new System.Drawing.Point(14, 479);
            this.grMove.Name = "grMove";
            this.grMove.Size = new System.Drawing.Size(148, 94);
            this.grMove.TabIndex = 7;
            this.grMove.TabStop = false;
            this.grMove.Text = "Перенос";
            // 
            // butMove
            // 
            this.butMove.Location = new System.Drawing.Point(91, 20);
            this.butMove.Name = "butMove";
            this.butMove.Size = new System.Drawing.Size(51, 64);
            this.butMove.TabIndex = 6;
            this.butMove.Text = "Перенести";
            this.butMove.UseVisualStyleBackColor = true;
            this.butMove.Click += new System.EventHandler(this.butMove_Click);
            // 
            // tbMoveZ
            // 
            this.tbMoveZ.Location = new System.Drawing.Point(26, 68);
            this.tbMoveZ.Name = "tbMoveZ";
            this.tbMoveZ.Size = new System.Drawing.Size(46, 20);
            this.tbMoveZ.TabIndex = 5;
            this.tbMoveZ.Text = "20";
            // 
            // tbMoveY
            // 
            this.tbMoveY.Location = new System.Drawing.Point(26, 42);
            this.tbMoveY.Name = "tbMoveY";
            this.tbMoveY.Size = new System.Drawing.Size(46, 20);
            this.tbMoveY.TabIndex = 4;
            this.tbMoveY.Text = "20";
            // 
            // tbMoveX
            // 
            this.tbMoveX.Location = new System.Drawing.Point(26, 16);
            this.tbMoveX.Name = "tbMoveX";
            this.tbMoveX.Size = new System.Drawing.Size(46, 20);
            this.tbMoveX.TabIndex = 3;
            this.tbMoveX.Text = "20";
            // 
            // lab_MoveZ
            // 
            this.lab_MoveZ.AutoSize = true;
            this.lab_MoveZ.Location = new System.Drawing.Point(6, 71);
            this.lab_MoveZ.Name = "lab_MoveZ";
            this.lab_MoveZ.Size = new System.Drawing.Size(14, 13);
            this.lab_MoveZ.TabIndex = 2;
            this.lab_MoveZ.Text = "Z";
            // 
            // lab_MoveY
            // 
            this.lab_MoveY.AutoSize = true;
            this.lab_MoveY.Location = new System.Drawing.Point(6, 45);
            this.lab_MoveY.Name = "lab_MoveY";
            this.lab_MoveY.Size = new System.Drawing.Size(14, 13);
            this.lab_MoveY.TabIndex = 1;
            this.lab_MoveY.Text = "Y";
            // 
            // lab_MoveX
            // 
            this.lab_MoveX.AutoSize = true;
            this.lab_MoveX.Location = new System.Drawing.Point(6, 19);
            this.lab_MoveX.Name = "lab_MoveX";
            this.lab_MoveX.Size = new System.Drawing.Size(14, 13);
            this.lab_MoveX.TabIndex = 0;
            this.lab_MoveX.Text = "X";
            // 
            // grScale
            // 
            this.grScale.Controls.Add(this.tbScaleZ);
            this.grScale.Controls.Add(this.tbScaleY);
            this.grScale.Controls.Add(this.tbScaleX);
            this.grScale.Controls.Add(this.butScale);
            this.grScale.Controls.Add(this.lab_ScaleZ);
            this.grScale.Controls.Add(this.lab_ScaleY);
            this.grScale.Controls.Add(this.lab_ScaleX);
            this.grScale.Enabled = false;
            this.grScale.Location = new System.Drawing.Point(14, 579);
            this.grScale.Name = "grScale";
            this.grScale.Size = new System.Drawing.Size(148, 94);
            this.grScale.TabIndex = 8;
            this.grScale.TabStop = false;
            this.grScale.Text = "Масштабирование";
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.DecimalPlaces = 1;
            this.tbScaleZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbScaleZ.Location = new System.Drawing.Point(26, 69);
            this.tbScaleZ.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tbScaleZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(46, 20);
            this.tbScaleZ.TabIndex = 14;
            this.tbScaleZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbScaleY
            // 
            this.tbScaleY.DecimalPlaces = 1;
            this.tbScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbScaleY.Location = new System.Drawing.Point(25, 43);
            this.tbScaleY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tbScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(46, 20);
            this.tbScaleY.TabIndex = 13;
            this.tbScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbScaleX
            // 
            this.tbScaleX.DecimalPlaces = 1;
            this.tbScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbScaleX.Location = new System.Drawing.Point(25, 17);
            this.tbScaleX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tbScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(46, 20);
            this.tbScaleX.TabIndex = 12;
            this.tbScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butScale
            // 
            this.butScale.Location = new System.Drawing.Point(91, 20);
            this.butScale.Name = "butScale";
            this.butScale.Size = new System.Drawing.Size(51, 64);
            this.butScale.TabIndex = 6;
            this.butScale.Text = "Масштабировать";
            this.butScale.UseVisualStyleBackColor = true;
            this.butScale.Click += new System.EventHandler(this.butScale_Click);
            // 
            // lab_ScaleZ
            // 
            this.lab_ScaleZ.AutoSize = true;
            this.lab_ScaleZ.Location = new System.Drawing.Point(6, 71);
            this.lab_ScaleZ.Name = "lab_ScaleZ";
            this.lab_ScaleZ.Size = new System.Drawing.Size(14, 13);
            this.lab_ScaleZ.TabIndex = 2;
            this.lab_ScaleZ.Text = "Z";
            // 
            // lab_ScaleY
            // 
            this.lab_ScaleY.AutoSize = true;
            this.lab_ScaleY.Location = new System.Drawing.Point(6, 45);
            this.lab_ScaleY.Name = "lab_ScaleY";
            this.lab_ScaleY.Size = new System.Drawing.Size(14, 13);
            this.lab_ScaleY.TabIndex = 1;
            this.lab_ScaleY.Text = "Y";
            // 
            // lab_ScaleX
            // 
            this.lab_ScaleX.AutoSize = true;
            this.lab_ScaleX.Location = new System.Drawing.Point(6, 19);
            this.lab_ScaleX.Name = "lab_ScaleX";
            this.lab_ScaleX.Size = new System.Drawing.Size(14, 13);
            this.lab_ScaleX.TabIndex = 0;
            this.lab_ScaleX.Text = "X";
            // 
            // grProj
            // 
            this.grProj.Controls.Add(this.grAks);
            this.grProj.Controls.Add(this.grPer);
            this.grProj.Controls.Add(this.grObl);
            this.grProj.Controls.Add(this.cbProj);
            this.grProj.Controls.Add(this.butDrawModel);
            this.grProj.Location = new System.Drawing.Point(12, 237);
            this.grProj.Name = "grProj";
            this.grProj.Size = new System.Drawing.Size(151, 136);
            this.grProj.TabIndex = 9;
            this.grProj.TabStop = false;
            this.grProj.Text = "Проекции";
            // 
            // grAks
            // 
            this.grAks.Controls.Add(this.tbAksPsi);
            this.grAks.Controls.Add(this.lab_AksPsi);
            this.grAks.Controls.Add(this.tbAksFi);
            this.grAks.Controls.Add(this.lab_AksFi);
            this.grAks.Location = new System.Drawing.Point(6, 45);
            this.grAks.Name = "grAks";
            this.grAks.Size = new System.Drawing.Size(148, 56);
            this.grAks.TabIndex = 2;
            this.grAks.TabStop = false;
            this.grAks.Visible = false;
            // 
            // tbAksPsi
            // 
            this.tbAksPsi.Location = new System.Drawing.Point(96, 19);
            this.tbAksPsi.Name = "tbAksPsi";
            this.tbAksPsi.Size = new System.Drawing.Size(43, 20);
            this.tbAksPsi.TabIndex = 7;
            this.tbAksPsi.Text = "35";
            // 
            // lab_AksPsi
            // 
            this.lab_AksPsi.AutoSize = true;
            this.lab_AksPsi.Location = new System.Drawing.Point(75, 22);
            this.lab_AksPsi.Name = "lab_AksPsi";
            this.lab_AksPsi.Size = new System.Drawing.Size(15, 13);
            this.lab_AksPsi.TabIndex = 6;
            this.lab_AksPsi.Text = "ψ";
            // 
            // tbAksFi
            // 
            this.tbAksFi.Location = new System.Drawing.Point(26, 19);
            this.tbAksFi.Name = "tbAksFi";
            this.tbAksFi.Size = new System.Drawing.Size(43, 20);
            this.tbAksFi.TabIndex = 5;
            this.tbAksFi.Text = "20";
            // 
            // lab_AksFi
            // 
            this.lab_AksFi.AutoSize = true;
            this.lab_AksFi.Location = new System.Drawing.Point(5, 22);
            this.lab_AksFi.Name = "lab_AksFi";
            this.lab_AksFi.Size = new System.Drawing.Size(15, 13);
            this.lab_AksFi.TabIndex = 4;
            this.lab_AksFi.Text = "φ";
            // 
            // grPer
            // 
            this.grPer.Controls.Add(this.tbPerRo);
            this.grPer.Controls.Add(this.lab_PerRo);
            this.grPer.Controls.Add(this.tbPerTetta);
            this.grPer.Controls.Add(this.lab_PerTetta);
            this.grPer.Controls.Add(this.tbPerFi);
            this.grPer.Controls.Add(this.lab_PerFi);
            this.grPer.Controls.Add(this.tbPerD);
            this.grPer.Controls.Add(this.lab_PerD);
            this.grPer.Location = new System.Drawing.Point(10, 40);
            this.grPer.Name = "grPer";
            this.grPer.Size = new System.Drawing.Size(141, 62);
            this.grPer.TabIndex = 10;
            this.grPer.TabStop = false;
            this.grPer.Visible = false;
            // 
            // tbPerRo
            // 
            this.tbPerRo.Location = new System.Drawing.Point(91, 36);
            this.tbPerRo.Name = "tbPerRo";
            this.tbPerRo.Size = new System.Drawing.Size(43, 20);
            this.tbPerRo.TabIndex = 14;
            this.tbPerRo.Text = "900";
            // 
            // lab_PerRo
            // 
            this.lab_PerRo.AutoSize = true;
            this.lab_PerRo.Location = new System.Drawing.Point(75, 40);
            this.lab_PerRo.Name = "lab_PerRo";
            this.lab_PerRo.Size = new System.Drawing.Size(13, 13);
            this.lab_PerRo.TabIndex = 13;
            this.lab_PerRo.Text = "ρ";
            // 
            // tbPerTetta
            // 
            this.tbPerTetta.Location = new System.Drawing.Point(21, 36);
            this.tbPerTetta.Name = "tbPerTetta";
            this.tbPerTetta.Size = new System.Drawing.Size(43, 20);
            this.tbPerTetta.TabIndex = 12;
            this.tbPerTetta.Text = "0";
            // 
            // lab_PerTetta
            // 
            this.lab_PerTetta.AutoSize = true;
            this.lab_PerTetta.Location = new System.Drawing.Point(5, 40);
            this.lab_PerTetta.Name = "lab_PerTetta";
            this.lab_PerTetta.Size = new System.Drawing.Size(13, 13);
            this.lab_PerTetta.TabIndex = 11;
            this.lab_PerTetta.Text = "θ";
            // 
            // tbPerFi
            // 
            this.tbPerFi.Location = new System.Drawing.Point(21, 10);
            this.tbPerFi.Name = "tbPerFi";
            this.tbPerFi.Size = new System.Drawing.Size(43, 20);
            this.tbPerFi.TabIndex = 10;
            this.tbPerFi.Text = "0";
            // 
            // lab_PerFi
            // 
            this.lab_PerFi.AutoSize = true;
            this.lab_PerFi.Location = new System.Drawing.Point(5, 14);
            this.lab_PerFi.Name = "lab_PerFi";
            this.lab_PerFi.Size = new System.Drawing.Size(15, 13);
            this.lab_PerFi.TabIndex = 9;
            this.lab_PerFi.Text = "φ";
            // 
            // tbPerD
            // 
            this.tbPerD.Location = new System.Drawing.Point(91, 10);
            this.tbPerD.Name = "tbPerD";
            this.tbPerD.Size = new System.Drawing.Size(43, 20);
            this.tbPerD.TabIndex = 5;
            this.tbPerD.Text = "800";
            // 
            // lab_PerD
            // 
            this.lab_PerD.AutoSize = true;
            this.lab_PerD.Location = new System.Drawing.Point(75, 15);
            this.lab_PerD.Name = "lab_PerD";
            this.lab_PerD.Size = new System.Drawing.Size(13, 13);
            this.lab_PerD.TabIndex = 4;
            this.lab_PerD.Text = "d";
            // 
            // grObl
            // 
            this.grObl.Controls.Add(this.tbOblAlfa);
            this.grObl.Controls.Add(this.lab_OblAlfa);
            this.grObl.Controls.Add(this.tbOblL);
            this.grObl.Controls.Add(this.lab_OblL);
            this.grObl.Location = new System.Drawing.Point(8, 46);
            this.grObl.Name = "grObl";
            this.grObl.Size = new System.Drawing.Size(144, 56);
            this.grObl.TabIndex = 8;
            this.grObl.TabStop = false;
            this.grObl.Visible = false;
            // 
            // tbOblAlfa
            // 
            this.tbOblAlfa.Location = new System.Drawing.Point(95, 18);
            this.tbOblAlfa.Name = "tbOblAlfa";
            this.tbOblAlfa.Size = new System.Drawing.Size(43, 20);
            this.tbOblAlfa.TabIndex = 7;
            this.tbOblAlfa.Text = "60";
            // 
            // lab_OblAlfa
            // 
            this.lab_OblAlfa.AutoSize = true;
            this.lab_OblAlfa.Location = new System.Drawing.Point(74, 21);
            this.lab_OblAlfa.Name = "lab_OblAlfa";
            this.lab_OblAlfa.Size = new System.Drawing.Size(14, 13);
            this.lab_OblAlfa.TabIndex = 6;
            this.lab_OblAlfa.Text = "α";
            // 
            // tbOblL
            // 
            this.tbOblL.Location = new System.Drawing.Point(25, 18);
            this.tbOblL.Name = "tbOblL";
            this.tbOblL.Size = new System.Drawing.Size(43, 20);
            this.tbOblL.TabIndex = 5;
            this.tbOblL.Text = "0,5";
            // 
            // lab_OblL
            // 
            this.lab_OblL.AutoSize = true;
            this.lab_OblL.Location = new System.Drawing.Point(4, 21);
            this.lab_OblL.Name = "lab_OblL";
            this.lab_OblL.Size = new System.Drawing.Size(13, 13);
            this.lab_OblL.TabIndex = 4;
            this.lab_OblL.Text = "L";
            // 
            // cbProj
            // 
            this.cbProj.FormattingEnabled = true;
            this.cbProj.Items.AddRange(new object[] {
            "Фронтальная",
            "Горизонтальная",
            "Профильная",
            "Аксонометрическая",
            "Косоугольная",
            "Перспективная"});
            this.cbProj.Location = new System.Drawing.Point(9, 19);
            this.cbProj.Name = "cbProj";
            this.cbProj.Size = new System.Drawing.Size(139, 21);
            this.cbProj.TabIndex = 3;
            this.cbProj.Text = "Фронтальная";
            this.cbProj.SelectedIndexChanged += new System.EventHandler(this.cbProj_SelectedIndexChanged);
            // 
            // ModelForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 691);
            this.Controls.Add(this.grProj);
            this.Controls.Add(this.grScale);
            this.Controls.Add(this.grMove);
            this.Controls.Add(this.grRotate);
            this.Controls.Add(this.pDraw);
            this.Controls.Add(this.grCyl);
            this.Controls.Add(this.grPar);
            this.Name = "ModelForm";
            this.Text = "Модель";
            this.grPar.ResumeLayout(false);
            this.grPar.PerformLayout();
            this.grCyl.ResumeLayout(false);
            this.grCyl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCylA)).EndInit();
            this.grRotate.ResumeLayout(false);
            this.grRotate.PerformLayout();
            this.grMove.ResumeLayout(false);
            this.grMove.PerformLayout();
            this.grScale.ResumeLayout(false);
            this.grScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleX)).EndInit();
            this.grProj.ResumeLayout(false);
            this.grAks.ResumeLayout(false);
            this.grAks.PerformLayout();
            this.grPer.ResumeLayout(false);
            this.grPer.PerformLayout();
            this.grObl.ResumeLayout(false);
            this.grObl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grPar;
        private System.Windows.Forms.TextBox tbParH;
        private System.Windows.Forms.TextBox tbParW;
        private System.Windows.Forms.Label lab_ParH;
        private System.Windows.Forms.Label lab_ParW;
        private System.Windows.Forms.TextBox tbParL;
        private System.Windows.Forms.Label lab_ParL;
        private System.Windows.Forms.GroupBox grCyl;
        private System.Windows.Forms.Label lab_CylA;
        private System.Windows.Forms.NumericUpDown tbCylA;
        private System.Windows.Forms.TextBox tbCylH;
        private System.Windows.Forms.Label lab_CylH;
        private System.Windows.Forms.Label lab_CylR;
        private System.Windows.Forms.TextBox tbCylR;
        private System.Windows.Forms.Button butDrawModel;
        private System.Windows.Forms.Panel pDraw;
        private System.Windows.Forms.GroupBox grRotate;
        private System.Windows.Forms.TextBox tbRotZ;
        private System.Windows.Forms.TextBox tbRotY;
        private System.Windows.Forms.TextBox tbRotX;
        private System.Windows.Forms.Label lab_RotZ;
        private System.Windows.Forms.Label lab_RotY;
        private System.Windows.Forms.Label lab_RotX;
        private System.Windows.Forms.Button butRotate;
        private System.Windows.Forms.GroupBox grMove;
        private System.Windows.Forms.Button butMove;
        private System.Windows.Forms.TextBox tbMoveZ;
        private System.Windows.Forms.TextBox tbMoveY;
        private System.Windows.Forms.TextBox tbMoveX;
        private System.Windows.Forms.Label lab_MoveZ;
        private System.Windows.Forms.Label lab_MoveY;
        private System.Windows.Forms.Label lab_MoveX;
        private System.Windows.Forms.GroupBox grScale;
        private System.Windows.Forms.NumericUpDown tbScaleZ;
        private System.Windows.Forms.NumericUpDown tbScaleY;
        private System.Windows.Forms.NumericUpDown tbScaleX;
        private System.Windows.Forms.Button butScale;
        private System.Windows.Forms.Label lab_ScaleZ;
        private System.Windows.Forms.Label lab_ScaleY;
        private System.Windows.Forms.Label lab_ScaleX;
        private System.Windows.Forms.GroupBox grProj;
        private System.Windows.Forms.GroupBox grAks;
        private System.Windows.Forms.TextBox tbAksPsi;
        private System.Windows.Forms.Label lab_AksPsi;
        private System.Windows.Forms.TextBox tbAksFi;
        private System.Windows.Forms.Label lab_AksFi;
        private System.Windows.Forms.GroupBox grPer;
        private System.Windows.Forms.GroupBox grObl;
        private System.Windows.Forms.TextBox tbOblAlfa;
        private System.Windows.Forms.Label lab_OblAlfa;
        private System.Windows.Forms.TextBox tbOblL;
        private System.Windows.Forms.Label lab_OblL;
        private System.Windows.Forms.TextBox tbPerRo;
        private System.Windows.Forms.Label lab_PerRo;
        private System.Windows.Forms.TextBox tbPerTetta;
        private System.Windows.Forms.Label lab_PerTetta;
        private System.Windows.Forms.TextBox tbPerFi;
        private System.Windows.Forms.Label lab_PerFi;
        private System.Windows.Forms.TextBox tbPerD;
        private System.Windows.Forms.Label lab_PerD;
        private System.Windows.Forms.ComboBox cbProj;
    }
}

