namespace CircleMovement
{
    partial class CircleMovement
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Background = new System.Windows.Forms.PictureBox();
            this.btn_AddPlan = new System.Windows.Forms.Button();
            this.btn_AddSat = new System.Windows.Forms.Button();
            this.textBox_NamePlan1 = new System.Windows.Forms.TextBox();
            this.lbl_PlanName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NamePlan2 = new System.Windows.Forms.TextBox();
            this.btn_DelPlan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NamePlan3 = new System.Windows.Forms.TextBox();
            this.btnDelSat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.speedPlan_UpDown = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tColor_B = new System.Windows.Forms.TextBox();
            this.tColor_G = new System.Windows.Forms.TextBox();
            this.tColor_R = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EditPlan = new System.Windows.Forms.Button();
            this.PlanRad_UpDown = new System.Windows.Forms.DomainUpDown();
            this.PlanDist_UpDown = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_EditPlan = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_SeeSatData = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.t_NumPlanOfSat = new System.Windows.Forms.TextBox();
            this.upDown_SatSpeed = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.t_SatColor_B = new System.Windows.Forms.TextBox();
            this.t_SatColor_G = new System.Windows.Forms.TextBox();
            this.t_SatColor_R = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_EditSat = new System.Windows.Forms.Button();
            this.upDown_SatRad = new System.Windows.Forms.DomainUpDown();
            this.upDown_SatDist = new System.Windows.Forms.DomainUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.t_NumSat = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_ChangeStar = new System.Windows.Forms.Button();
            this.t_StarY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.t_StarX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.T_StarColor_B = new System.Windows.Forms.TextBox();
            this.T_StarColor_G = new System.Windows.Forms.TextBox();
            this.T_StarColor_R = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Background.Location = new System.Drawing.Point(-3, 2);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(724, 597);
            this.Background.TabIndex = 2;
            this.Background.TabStop = false;
            this.Background.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // btn_AddPlan
            // 
            this.btn_AddPlan.Location = new System.Drawing.Point(6, 19);
            this.btn_AddPlan.Name = "btn_AddPlan";
            this.btn_AddPlan.Size = new System.Drawing.Size(75, 40);
            this.btn_AddPlan.TabIndex = 3;
            this.btn_AddPlan.Text = "Добавить планету";
            this.btn_AddPlan.UseVisualStyleBackColor = true;
            this.btn_AddPlan.Click += new System.EventHandler(this.btn_AddPlan_Click);
            // 
            // btn_AddSat
            // 
            this.btn_AddSat.Location = new System.Drawing.Point(6, 66);
            this.btn_AddSat.Name = "btn_AddSat";
            this.btn_AddSat.Size = new System.Drawing.Size(76, 39);
            this.btn_AddSat.TabIndex = 4;
            this.btn_AddSat.Text = "Добавить спутник";
            this.btn_AddSat.UseVisualStyleBackColor = true;
            this.btn_AddSat.Click += new System.EventHandler(this.btn_AddSat_Click);
            // 
            // textBox_NamePlan1
            // 
            this.textBox_NamePlan1.Location = new System.Drawing.Point(105, 85);
            this.textBox_NamePlan1.Name = "textBox_NamePlan1";
            this.textBox_NamePlan1.Size = new System.Drawing.Size(87, 20);
            this.textBox_NamePlan1.TabIndex = 5;
            // 
            // lbl_PlanName
            // 
            this.lbl_PlanName.AutoSize = true;
            this.lbl_PlanName.Location = new System.Drawing.Point(102, 66);
            this.lbl_PlanName.Name = "lbl_PlanName";
            this.lbl_PlanName.Size = new System.Drawing.Size(90, 13);
            this.lbl_PlanName.TabIndex = 6;
            this.lbl_PlanName.Text = "Номер планеты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер планеты:";
            // 
            // textBox_NamePlan2
            // 
            this.textBox_NamePlan2.Location = new System.Drawing.Point(106, 38);
            this.textBox_NamePlan2.Name = "textBox_NamePlan2";
            this.textBox_NamePlan2.Size = new System.Drawing.Size(87, 20);
            this.textBox_NamePlan2.TabIndex = 8;
            // 
            // btn_DelPlan
            // 
            this.btn_DelPlan.Location = new System.Drawing.Point(6, 19);
            this.btn_DelPlan.Name = "btn_DelPlan";
            this.btn_DelPlan.Size = new System.Drawing.Size(75, 39);
            this.btn_DelPlan.TabIndex = 7;
            this.btn_DelPlan.Text = "Удалить планету";
            this.btn_DelPlan.UseVisualStyleBackColor = true;
            this.btn_DelPlan.Click += new System.EventHandler(this.btn_DelPlan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер планеты:";
            // 
            // textBox_NamePlan3
            // 
            this.textBox_NamePlan3.Location = new System.Drawing.Point(106, 96);
            this.textBox_NamePlan3.Name = "textBox_NamePlan3";
            this.textBox_NamePlan3.Size = new System.Drawing.Size(87, 20);
            this.textBox_NamePlan3.TabIndex = 11;
            // 
            // btnDelSat
            // 
            this.btnDelSat.Location = new System.Drawing.Point(7, 77);
            this.btnDelSat.Name = "btnDelSat";
            this.btnDelSat.Size = new System.Drawing.Size(75, 39);
            this.btnDelSat.TabIndex = 10;
            this.btnDelSat.Text = "Удалить спутник";
            this.btnDelSat.UseVisualStyleBackColor = true;
            this.btnDelSat.Click += new System.EventHandler(this.btnDelSat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddSat);
            this.groupBox1.Controls.Add(this.btn_AddPlan);
            this.groupBox1.Controls.Add(this.textBox_NamePlan1);
            this.groupBox1.Controls.Add(this.lbl_PlanName);
            this.groupBox1.Location = new System.Drawing.Point(727, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DelPlan);
            this.groupBox2.Controls.Add(this.textBox_NamePlan2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_NamePlan3);
            this.groupBox2.Controls.Add(this.btnDelSat);
            this.groupBox2.Location = new System.Drawing.Point(727, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(727, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 335);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(236, 229);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.speedPlan_UpDown);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tColor_B);
            this.tabPage1.Controls.Add(this.tColor_G);
            this.tabPage1.Controls.Add(this.tColor_R);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_EditPlan);
            this.tabPage1.Controls.Add(this.PlanRad_UpDown);
            this.tabPage1.Controls.Add(this.PlanDist_UpDown);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tBox_EditPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(228, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Планета";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // speedPlan_UpDown
            // 
            this.speedPlan_UpDown.Location = new System.Drawing.Point(145, 86);
            this.speedPlan_UpDown.Name = "speedPlan_UpDown";
            this.speedPlan_UpDown.Size = new System.Drawing.Size(45, 20);
            this.speedPlan_UpDown.TabIndex = 26;
            this.speedPlan_UpDown.Text = "0";
            this.speedPlan_UpDown.Wrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Орбитальная скорость:";
            // 
            // tColor_B
            // 
            this.tColor_B.Location = new System.Drawing.Point(141, 60);
            this.tColor_B.Name = "tColor_B";
            this.tColor_B.Size = new System.Drawing.Size(28, 20);
            this.tColor_B.TabIndex = 24;
            // 
            // tColor_G
            // 
            this.tColor_G.Location = new System.Drawing.Point(106, 60);
            this.tColor_G.Name = "tColor_G";
            this.tColor_G.Size = new System.Drawing.Size(28, 20);
            this.tColor_G.TabIndex = 23;
            // 
            // tColor_R
            // 
            this.tColor_R.Location = new System.Drawing.Point(69, 60);
            this.tColor_R.Name = "tColor_R";
            this.tColor_R.Size = new System.Drawing.Size(28, 20);
            this.tColor_R.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Цвет(rgb):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Радиус:";
            // 
            // btn_EditPlan
            // 
            this.btn_EditPlan.Location = new System.Drawing.Point(69, 121);
            this.btn_EditPlan.Name = "btn_EditPlan";
            this.btn_EditPlan.Size = new System.Drawing.Size(81, 23);
            this.btn_EditPlan.TabIndex = 1;
            this.btn_EditPlan.Text = "Изменить";
            this.btn_EditPlan.UseVisualStyleBackColor = true;
            this.btn_EditPlan.Click += new System.EventHandler(this.btn_EditPlan_Click);
            // 
            // PlanRad_UpDown
            // 
            this.PlanRad_UpDown.Location = new System.Drawing.Point(52, 37);
            this.PlanRad_UpDown.Name = "PlanRad_UpDown";
            this.PlanRad_UpDown.Size = new System.Drawing.Size(45, 20);
            this.PlanRad_UpDown.TabIndex = 1;
            this.PlanRad_UpDown.Text = "0";
            this.PlanRad_UpDown.Wrap = true;
            this.PlanRad_UpDown.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // PlanDist_UpDown
            // 
            this.PlanDist_UpDown.Location = new System.Drawing.Point(169, 37);
            this.PlanDist_UpDown.Name = "PlanDist_UpDown";
            this.PlanDist_UpDown.Size = new System.Drawing.Size(42, 20);
            this.PlanDist_UpDown.TabIndex = 13;
            this.PlanDist_UpDown.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер планеты:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дистанция:";
            // 
            // tBox_EditPlan
            // 
            this.tBox_EditPlan.Location = new System.Drawing.Point(101, 7);
            this.tBox_EditPlan.Name = "tBox_EditPlan";
            this.tBox_EditPlan.Size = new System.Drawing.Size(45, 20);
            this.tBox_EditPlan.TabIndex = 10;
            this.tBox_EditPlan.TextChanged += new System.EventHandler(this.tBox_EditPlan_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_SeeSatData);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.t_NumPlanOfSat);
            this.tabPage2.Controls.Add(this.upDown_SatSpeed);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.t_SatColor_B);
            this.tabPage2.Controls.Add(this.t_SatColor_G);
            this.tabPage2.Controls.Add(this.t_SatColor_R);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btn_EditSat);
            this.tabPage2.Controls.Add(this.upDown_SatRad);
            this.tabPage2.Controls.Add(this.upDown_SatDist);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.t_NumSat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(228, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спутник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_SeeSatData
            // 
            this.Btn_SeeSatData.Location = new System.Drawing.Point(67, 63);
            this.Btn_SeeSatData.Name = "Btn_SeeSatData";
            this.Btn_SeeSatData.Size = new System.Drawing.Size(89, 23);
            this.Btn_SeeSatData.TabIndex = 42;
            this.Btn_SeeSatData.Text = "Просмотреть";
            this.Btn_SeeSatData.UseVisualStyleBackColor = true;
            this.Btn_SeeSatData.Click += new System.EventHandler(this.Btn_SeeSatData_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Номер планеты спутника:";
            // 
            // t_NumPlanOfSat
            // 
            this.t_NumPlanOfSat.Location = new System.Drawing.Point(158, 36);
            this.t_NumPlanOfSat.Name = "t_NumPlanOfSat";
            this.t_NumPlanOfSat.Size = new System.Drawing.Size(38, 20);
            this.t_NumPlanOfSat.TabIndex = 40;
            // 
            // upDown_SatSpeed
            // 
            this.upDown_SatSpeed.Location = new System.Drawing.Point(155, 141);
            this.upDown_SatSpeed.Name = "upDown_SatSpeed";
            this.upDown_SatSpeed.Size = new System.Drawing.Size(45, 20);
            this.upDown_SatSpeed.TabIndex = 39;
            this.upDown_SatSpeed.Text = "0";
            this.upDown_SatSpeed.Wrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Орбитальная скорость:";
            // 
            // t_SatColor_B
            // 
            this.t_SatColor_B.Location = new System.Drawing.Point(151, 115);
            this.t_SatColor_B.Name = "t_SatColor_B";
            this.t_SatColor_B.Size = new System.Drawing.Size(28, 20);
            this.t_SatColor_B.TabIndex = 37;
            // 
            // t_SatColor_G
            // 
            this.t_SatColor_G.Location = new System.Drawing.Point(116, 115);
            this.t_SatColor_G.Name = "t_SatColor_G";
            this.t_SatColor_G.Size = new System.Drawing.Size(28, 20);
            this.t_SatColor_G.TabIndex = 36;
            // 
            // t_SatColor_R
            // 
            this.t_SatColor_R.Location = new System.Drawing.Point(79, 115);
            this.t_SatColor_R.Name = "t_SatColor_R";
            this.t_SatColor_R.Size = new System.Drawing.Size(28, 20);
            this.t_SatColor_R.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Цвет(rgb):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Радиус:";
            // 
            // btn_EditSat
            // 
            this.btn_EditSat.Location = new System.Drawing.Point(75, 174);
            this.btn_EditSat.Name = "btn_EditSat";
            this.btn_EditSat.Size = new System.Drawing.Size(81, 23);
            this.btn_EditSat.TabIndex = 28;
            this.btn_EditSat.Text = "Изменить";
            this.btn_EditSat.UseVisualStyleBackColor = true;
            this.btn_EditSat.Click += new System.EventHandler(this.btn_EditSat_Click);
            // 
            // upDown_SatRad
            // 
            this.upDown_SatRad.Location = new System.Drawing.Point(62, 92);
            this.upDown_SatRad.Name = "upDown_SatRad";
            this.upDown_SatRad.Size = new System.Drawing.Size(45, 20);
            this.upDown_SatRad.TabIndex = 29;
            this.upDown_SatRad.Text = "0";
            this.upDown_SatRad.Wrap = true;
            // 
            // upDown_SatDist
            // 
            this.upDown_SatDist.Location = new System.Drawing.Point(179, 92);
            this.upDown_SatDist.Name = "upDown_SatDist";
            this.upDown_SatDist.Size = new System.Drawing.Size(42, 20);
            this.upDown_SatDist.TabIndex = 33;
            this.upDown_SatDist.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Номер спутника:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Дистанция:";
            // 
            // t_NumSat
            // 
            this.t_NumSat.Location = new System.Drawing.Point(107, 7);
            this.t_NumSat.Name = "t_NumSat";
            this.t_NumSat.Size = new System.Drawing.Size(45, 20);
            this.t_NumSat.TabIndex = 30;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.T_StarColor_B);
            this.tabPage3.Controls.Add(this.T_StarColor_G);
            this.tabPage3.Controls.Add(this.T_StarColor_R);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.Btn_ChangeStar);
            this.tabPage3.Controls.Add(this.t_StarY);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.t_StarX);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(228, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Звезда";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_ChangeStar
            // 
            this.Btn_ChangeStar.Location = new System.Drawing.Point(81, 166);
            this.Btn_ChangeStar.Name = "Btn_ChangeStar";
            this.Btn_ChangeStar.Size = new System.Drawing.Size(81, 23);
            this.Btn_ChangeStar.TabIndex = 29;
            this.Btn_ChangeStar.Text = "Изменить";
            this.Btn_ChangeStar.UseVisualStyleBackColor = true;
            this.Btn_ChangeStar.Click += new System.EventHandler(this.Btn_ChangeStar_Click);
            // 
            // t_StarY
            // 
            this.t_StarY.Location = new System.Drawing.Point(147, 12);
            this.t_StarY.Name = "t_StarY";
            this.t_StarY.Size = new System.Drawing.Size(43, 20);
            this.t_StarY.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(124, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Y:";
            // 
            // t_StarX
            // 
            this.t_StarX.Location = new System.Drawing.Point(65, 12);
            this.t_StarX.Name = "t_StarX";
            this.t_StarX.Size = new System.Drawing.Size(43, 20);
            this.t_StarX.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "X:";
            // 
            // T_StarColor_B
            // 
            this.T_StarColor_B.Location = new System.Drawing.Point(164, 48);
            this.T_StarColor_B.Name = "T_StarColor_B";
            this.T_StarColor_B.Size = new System.Drawing.Size(28, 20);
            this.T_StarColor_B.TabIndex = 41;
            // 
            // T_StarColor_G
            // 
            this.T_StarColor_G.Location = new System.Drawing.Point(129, 48);
            this.T_StarColor_G.Name = "T_StarColor_G";
            this.T_StarColor_G.Size = new System.Drawing.Size(28, 20);
            this.T_StarColor_G.TabIndex = 40;
            // 
            // T_StarColor_R
            // 
            this.T_StarColor_R.Location = new System.Drawing.Point(92, 48);
            this.T_StarColor_R.Name = "T_StarColor_R";
            this.T_StarColor_R.Size = new System.Drawing.Size(28, 20);
            this.T_StarColor_R.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Цвет(rgb):";
            // 
            // CircleMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Background);
            this.KeyPreview = true;
            this.Name = "CircleMovement";
            this.Text = "CircleMovement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button btn_AddPlan;
        private System.Windows.Forms.Button btn_AddSat;
        private System.Windows.Forms.TextBox textBox_NamePlan1;
        private System.Windows.Forms.Label lbl_PlanName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NamePlan2;
        private System.Windows.Forms.Button btn_DelPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NamePlan3;
        private System.Windows.Forms.Button btnDelSat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBox_EditPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown PlanRad_UpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown PlanDist_UpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_EditPlan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tColor_B;
        private System.Windows.Forms.TextBox tColor_G;
        private System.Windows.Forms.TextBox tColor_R;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown speedPlan_UpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox t_NumPlanOfSat;
        private System.Windows.Forms.DomainUpDown upDown_SatSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_SatColor_B;
        private System.Windows.Forms.TextBox t_SatColor_G;
        private System.Windows.Forms.TextBox t_SatColor_R;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_EditSat;
        private System.Windows.Forms.DomainUpDown upDown_SatRad;
        private System.Windows.Forms.DomainUpDown upDown_SatDist;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_NumSat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btn_SeeSatData;
        private System.Windows.Forms.Button Btn_ChangeStar;
        private System.Windows.Forms.TextBox t_StarY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox t_StarX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox T_StarColor_B;
        private System.Windows.Forms.TextBox T_StarColor_G;
        private System.Windows.Forms.TextBox T_StarColor_R;
        private System.Windows.Forms.Label label16;
    }
}

