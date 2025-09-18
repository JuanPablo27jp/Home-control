namespace Par
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RBvoz = new System.Windows.Forms.RadioButton();
            this.RBman = new System.Windows.Forms.RadioButton();
            this.GBman = new System.Windows.Forms.GroupBox();
            this.TBcoch = new System.Windows.Forms.TrackBar();
            this.TBpuer = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBluz = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBvoz = new System.Windows.Forms.GroupBox();
            this.Lmen = new System.Windows.Forms.Label();
            this.Escuchar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.coch = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.RS2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.puer = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ven2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ven1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.groupBox1.SuspendLayout();
            this.GBman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBcoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBpuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBluz)).BeginInit();
            this.GBvoz.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RBvoz);
            this.groupBox1.Controls.Add(this.RBman);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBvoz
            // 
            this.RBvoz.AutoSize = true;
            this.RBvoz.Location = new System.Drawing.Point(7, 53);
            this.RBvoz.Name = "RBvoz";
            this.RBvoz.Size = new System.Drawing.Size(43, 17);
            this.RBvoz.TabIndex = 1;
            this.RBvoz.Text = "Voz";
            this.RBvoz.UseVisualStyleBackColor = true;
            this.RBvoz.CheckedChanged += new System.EventHandler(this.RBvoz_CheckedChanged);
            // 
            // RBman
            // 
            this.RBman.AutoSize = true;
            this.RBman.Checked = true;
            this.RBman.Location = new System.Drawing.Point(7, 20);
            this.RBman.Name = "RBman";
            this.RBman.Size = new System.Drawing.Size(60, 17);
            this.RBman.TabIndex = 0;
            this.RBman.TabStop = true;
            this.RBman.Text = "Manual";
            this.RBman.UseVisualStyleBackColor = true;
            // 
            // GBman
            // 
            this.GBman.Controls.Add(this.TBcoch);
            this.GBman.Controls.Add(this.TBpuer);
            this.GBman.Controls.Add(this.label5);
            this.GBman.Controls.Add(this.label4);
            this.GBman.Controls.Add(this.TBluz);
            this.GBman.Controls.Add(this.label3);
            this.GBman.Controls.Add(this.label2);
            this.GBman.Controls.Add(this.label1);
            this.GBman.Location = new System.Drawing.Point(13, 135);
            this.GBman.Name = "GBman";
            this.GBman.Size = new System.Drawing.Size(200, 198);
            this.GBman.TabIndex = 1;
            this.GBman.TabStop = false;
            this.GBman.Text = "Control Manual";
            // 
            // TBcoch
            // 
            this.TBcoch.Location = new System.Drawing.Point(72, 139);
            this.TBcoch.Maximum = 1;
            this.TBcoch.Name = "TBcoch";
            this.TBcoch.Size = new System.Drawing.Size(104, 45);
            this.TBcoch.TabIndex = 7;
            this.TBcoch.Scroll += new System.EventHandler(this.TBcoch_Scroll);
            // 
            // TBpuer
            // 
            this.TBpuer.Location = new System.Drawing.Point(72, 88);
            this.TBpuer.Maximum = 1;
            this.TBpuer.Name = "TBpuer";
            this.TBpuer.Size = new System.Drawing.Size(104, 45);
            this.TBpuer.TabIndex = 6;
            this.TBpuer.Scroll += new System.EventHandler(this.TBpuer_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "On";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Off";
            // 
            // TBluz
            // 
            this.TBluz.Location = new System.Drawing.Point(72, 39);
            this.TBluz.Maximum = 1;
            this.TBluz.Name = "TBluz";
            this.TBluz.Size = new System.Drawing.Size(104, 45);
            this.TBluz.TabIndex = 3;
            this.TBluz.Scroll += new System.EventHandler(this.TBluz_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cochera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luz";
            // 
            // GBvoz
            // 
            this.GBvoz.Controls.Add(this.Lmen);
            this.GBvoz.Controls.Add(this.Escuchar);
            this.GBvoz.Location = new System.Drawing.Point(13, 355);
            this.GBvoz.Name = "GBvoz";
            this.GBvoz.Size = new System.Drawing.Size(200, 100);
            this.GBvoz.TabIndex = 2;
            this.GBvoz.TabStop = false;
            this.GBvoz.Text = "Control por Voz";
            this.GBvoz.Visible = false;
            // 
            // Lmen
            // 
            this.Lmen.AutoSize = true;
            this.Lmen.Location = new System.Drawing.Point(104, 47);
            this.Lmen.Name = "Lmen";
            this.Lmen.Size = new System.Drawing.Size(45, 13);
            this.Lmen.TabIndex = 1;
            this.Lmen.Text = "Element";
            // 
            // Escuchar
            // 
            this.Escuchar.Location = new System.Drawing.Point(23, 42);
            this.Escuchar.Name = "Escuchar";
            this.Escuchar.Size = new System.Drawing.Size(75, 23);
            this.Escuchar.TabIndex = 0;
            this.Escuchar.Text = "Escuchar";
            this.Escuchar.UseVisualStyleBackColor = true;
            this.Escuchar.Click += new System.EventHandler(this.Escuchar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.coch,
            this.RS2,
            this.puer,
            this.ven2,
            this.ven1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 467);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // coch
            // 
            this.coch.FillColor = System.Drawing.Color.Gray;
            this.coch.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.coch.Location = new System.Drawing.Point(669, 319);
            this.coch.Name = "coch";
            this.coch.Size = new System.Drawing.Size(160, 135);
            // 
            // RS2
            // 
            this.RS2.FillColor = System.Drawing.Color.MintCream;
            this.RS2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.RS2.Location = new System.Drawing.Point(614, 229);
            this.RS2.Name = "RS2";
            this.RS2.Size = new System.Drawing.Size(270, 226);
            this.RS2.Click += new System.EventHandler(this.RScochera_Click);
            // 
            // puer
            // 
            this.puer.FillColor = System.Drawing.Color.Sienna;
            this.puer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.puer.Location = new System.Drawing.Point(414, 341);
            this.puer.Name = "puer";
            this.puer.Size = new System.Drawing.Size(129, 114);
            // 
            // ven2
            // 
            this.ven2.FillColor = System.Drawing.Color.PaleTurquoise;
            this.ven2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ven2.Location = new System.Drawing.Point(271, 295);
            this.ven2.Name = "ven2";
            this.ven2.Size = new System.Drawing.Size(96, 107);
            // 
            // ven1
            // 
            this.ven1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.ven1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ven1.Location = new System.Drawing.Point(271, 184);
            this.ven1.Name = "ven1";
            this.ven1.Size = new System.Drawing.Size(304, 92);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillColor = System.Drawing.Color.MintCream;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(232, 145);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(381, 310);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 467);
            this.ControlBox = false;
            this.Controls.Add(this.GBvoz);
            this.Controls.Add(this.GBman);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form2";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBman.ResumeLayout(false);
            this.GBman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBcoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBpuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBluz)).EndInit();
            this.GBvoz.ResumeLayout(false);
            this.GBvoz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBvoz;
        private System.Windows.Forms.RadioButton RBman;
        private System.Windows.Forms.GroupBox GBman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TBluz;
        private System.Windows.Forms.GroupBox GBvoz;
        private System.Windows.Forms.Button Escuchar;
        private System.Windows.Forms.Label Lmen;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TrackBar TBcoch;
        public System.Windows.Forms.TrackBar TBpuer;
        private System.IO.Ports.SerialPort serialPort1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape coch;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RS2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape puer;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape ven2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape ven1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}