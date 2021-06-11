namespace MS_Paint_Clone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyOpenedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.pencilButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.editColorsButton = new System.Windows.Forms.Button();
            this.pencilThicknessNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.brushThicknessNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.currentColor = new System.Windows.Forms.Label();
            this.currentColorLabel = new System.Windows.Forms.Label();
            this.lineButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilThicknessNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushThicknessNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.recentlyOpenedToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // recentlyOpenedToolStripMenuItem
            // 
            this.recentlyOpenedToolStripMenuItem.Name = "recentlyOpenedToolStripMenuItem";
            this.recentlyOpenedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.recentlyOpenedToolStripMenuItem.Text = "Recently Opened";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(0, 90);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1267, 697);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // pencilButton
            // 
            this.pencilButton.Location = new System.Drawing.Point(75, 32);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(98, 23);
            this.pencilButton.TabIndex = 4;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.Location = new System.Drawing.Point(179, 32);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(98, 23);
            this.brushButton.TabIndex = 5;
            this.brushButton.Text = "Brush";
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Location = new System.Drawing.Point(283, 32);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(62, 46);
            this.eraserButton.TabIndex = 6;
            this.eraserButton.Text = "Eraser";
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // editColorsButton
            // 
            this.editColorsButton.Location = new System.Drawing.Point(762, 34);
            this.editColorsButton.Name = "editColorsButton";
            this.editColorsButton.Size = new System.Drawing.Size(61, 46);
            this.editColorsButton.TabIndex = 35;
            this.editColorsButton.Text = "Edit Colors";
            this.editColorsButton.UseVisualStyleBackColor = true;
            this.editColorsButton.Click += new System.EventHandler(this.editColorsButton_Click);
            // 
            // pencilThicknessNumUpDown
            // 
            this.pencilThicknessNumUpDown.DecimalPlaces = 1;
            this.pencilThicknessNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.pencilThicknessNumUpDown.Location = new System.Drawing.Point(132, 57);
            this.pencilThicknessNumUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.pencilThicknessNumUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.pencilThicknessNumUpDown.Name = "pencilThicknessNumUpDown";
            this.pencilThicknessNumUpDown.Size = new System.Drawing.Size(41, 20);
            this.pencilThicknessNumUpDown.TabIndex = 36;
            this.pencilThicknessNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // brushThicknessNumUpDown
            // 
            this.brushThicknessNumUpDown.DecimalPlaces = 1;
            this.brushThicknessNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.brushThicknessNumUpDown.Location = new System.Drawing.Point(236, 58);
            this.brushThicknessNumUpDown.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            65536});
            this.brushThicknessNumUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.brushThicknessNumUpDown.Name = "brushThicknessNumUpDown";
            this.brushThicknessNumUpDown.Size = new System.Drawing.Size(41, 20);
            this.brushThicknessNumUpDown.TabIndex = 37;
            this.brushThicknessNumUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Thickness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Thickness";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(397, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 40;
            this.label3.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(397, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 41;
            this.label4.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(423, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 43;
            this.label5.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(423, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 42;
            this.label6.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(449, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 45;
            this.label7.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(449, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 44;
            this.label8.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(475, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 47;
            this.label9.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Olive;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(475, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 46;
            this.label10.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Lime;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(501, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 20);
            this.label11.TabIndex = 49;
            this.label11.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Green;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(501, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 20);
            this.label12.TabIndex = 48;
            this.label12.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Aqua;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(527, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 20);
            this.label13.TabIndex = 51;
            this.label13.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Teal;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(527, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 20);
            this.label14.TabIndex = 50;
            this.label14.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Blue;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(553, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 20);
            this.label15.TabIndex = 53;
            this.label15.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Navy;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(553, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 20);
            this.label16.TabIndex = 52;
            this.label16.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Fuchsia;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(579, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 20);
            this.label17.TabIndex = 55;
            this.label17.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Purple;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(579, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 20);
            this.label18.TabIndex = 54;
            this.label18.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LemonChiffon;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(605, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 20);
            this.label19.TabIndex = 57;
            this.label19.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.DarkKhaki;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(605, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 20);
            this.label20.TabIndex = 56;
            this.label20.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.SpringGreen;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(631, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 20);
            this.label21.TabIndex = 59;
            this.label21.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(631, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 20);
            this.label22.TabIndex = 58;
            this.label22.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.PowderBlue;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(657, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 20);
            this.label23.TabIndex = 61;
            this.label23.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(657, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 20);
            this.label24.TabIndex = 60;
            this.label24.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Location = new System.Drawing.Point(683, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 20);
            this.label25.TabIndex = 63;
            this.label25.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.SteelBlue;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Location = new System.Drawing.Point(683, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 20);
            this.label26.TabIndex = 62;
            this.label26.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.DeepPink;
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Location = new System.Drawing.Point(709, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 20);
            this.label27.TabIndex = 65;
            this.label27.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.BlueViolet;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.Location = new System.Drawing.Point(709, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 20);
            this.label28.TabIndex = 64;
            this.label28.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.SandyBrown;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Location = new System.Drawing.Point(735, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 20);
            this.label29.TabIndex = 67;
            this.label29.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Sienna;
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.Location = new System.Drawing.Point(735, 34);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 20);
            this.label30.TabIndex = 66;
            this.label30.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // currentColor
            // 
            this.currentColor.BackColor = System.Drawing.Color.Black;
            this.currentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColor.Location = new System.Drawing.Point(354, 34);
            this.currentColor.Name = "currentColor";
            this.currentColor.Size = new System.Drawing.Size(25, 25);
            this.currentColor.TabIndex = 68;
            this.currentColor.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // currentColorLabel
            // 
            this.currentColorLabel.Location = new System.Drawing.Point(349, 61);
            this.currentColorLabel.Name = "currentColorLabel";
            this.currentColorLabel.Size = new System.Drawing.Size(40, 21);
            this.currentColorLabel.TabIndex = 69;
            this.currentColorLabel.Text = "Color 1";
            this.currentColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(7, 33);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(62, 47);
            this.lineButton.TabIndex = 71;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 788);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.currentColorLabel);
            this.Controls.Add(this.currentColor);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brushThicknessNumUpDown);
            this.Controls.Add(this.pencilThicknessNumUpDown);
            this.Controls.Add(this.editColorsButton);
            this.Controls.Add(this.eraserButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.pencilButton);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ahmed_Kevin\'s Ode to Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilThicknessNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushThicknessNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button editColorsButton;
        private System.Windows.Forms.NumericUpDown pencilThicknessNumUpDown;
        private System.Windows.Forms.NumericUpDown brushThicknessNumUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label currentColor;
        private System.Windows.Forms.Label currentColorLabel;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentlyOpenedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button lineButton;
    }
}

