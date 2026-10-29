namespace plane2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            buttonOnesOff = new System.Windows.Forms.Button();
            btnEnishHazirligi = new System.Windows.Forms.Button();
            btnTurbulans = new System.Windows.Forms.Button();
            btnKemerler = new System.Windows.Forms.Button();
            btnTesekkurler = new System.Windows.Forms.Button();
            btnBeep = new System.Windows.Forms.Button();
            plane = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)plane).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Green;
            button1.Location = new System.Drawing.Point(412, 338);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 62);
            button1.TabIndex = 0;
            button1.Text = "GAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Location = new System.Drawing.Point(579, 338);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 62);
            button2.TabIndex = 1;
            button2.Text = "Break";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(0, 0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 0;
            button3.Click += button3_Click;
            // 
            // buttonOnesOff
            // 
            buttonOnesOff.BackColor = System.Drawing.Color.Blue;
            buttonOnesOff.ForeColor = System.Drawing.Color.White;
            buttonOnesOff.Location = new System.Drawing.Point(447, 421);
            buttonOnesOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonOnesOff.Name = "buttonOnesOff";
            buttonOnesOff.Size = new System.Drawing.Size(220, 50);
            buttonOnesOff.TabIndex = 2;
            buttonOnesOff.Text = "ON/OFF";
            buttonOnesOff.UseVisualStyleBackColor = false;
            buttonOnesOff.Click += buttonOnesOff_Click;
            // 
            // btnEnishHazirligi
            // 
            btnEnishHazirligi.BackColor = System.Drawing.Color.DarkOrange;
            btnEnishHazirligi.Location = new System.Drawing.Point(447, 24);
            btnEnishHazirligi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEnishHazirligi.Name = "btnEnishHazirligi";
            btnEnishHazirligi.Size = new System.Drawing.Size(220, 50);
            btnEnishHazirligi.TabIndex = 4;
            btnEnishHazirligi.Text = "Eniş hazırlığı";
            btnEnishHazirligi.UseVisualStyleBackColor = false;
            btnEnishHazirligi.Click += btnEnishHazirligi_Click;
            // 
            // btnTurbulans
            // 
            btnTurbulans.BackColor = System.Drawing.Color.DarkOrange;
            btnTurbulans.Location = new System.Drawing.Point(447, 82);
            btnTurbulans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTurbulans.Name = "btnTurbulans";
            btnTurbulans.Size = new System.Drawing.Size(220, 50);
            btnTurbulans.TabIndex = 3;
            btnTurbulans.Text = "Turbulans";
            btnTurbulans.UseVisualStyleBackColor = false;
            btnTurbulans.Click += btnTurbulans_Click;
            // 
            // btnKemerler
            // 
            btnKemerler.BackColor = System.Drawing.Color.DarkOrange;
            btnKemerler.Location = new System.Drawing.Point(447, 140);
            btnKemerler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnKemerler.Name = "btnKemerler";
            btnKemerler.Size = new System.Drawing.Size(220, 50);
            btnKemerler.TabIndex = 2;
            btnKemerler.Text = "Kəmərlər";
            btnKemerler.UseVisualStyleBackColor = false;
            btnKemerler.Click += btnKemerler_Click;
            // 
            // btnTesekkurler
            // 
            btnTesekkurler.BackColor = System.Drawing.Color.DarkOrange;
            btnTesekkurler.Location = new System.Drawing.Point(447, 198);
            btnTesekkurler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTesekkurler.Name = "btnTesekkurler";
            btnTesekkurler.Size = new System.Drawing.Size(220, 50);
            btnTesekkurler.TabIndex = 1;
            btnTesekkurler.Text = "Təşəkkürlər";
            btnTesekkurler.UseVisualStyleBackColor = false;
            btnTesekkurler.Click += btnTesekkurler_Click;
            // 
            // btnBeep
            // 
            btnBeep.BackColor = System.Drawing.Color.DarkOrange;
            btnBeep.Location = new System.Drawing.Point(447, 256);
            btnBeep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new System.Drawing.Size(220, 50);
            btnBeep.TabIndex = 0;
            btnBeep.Text = "Beep";
            btnBeep.UseVisualStyleBackColor = false;
            btnBeep.Click += btnBeep_Click;
            // 
            // plane
            // 
            plane.Image = (System.Drawing.Image)resources.GetObject("plane.Image");
            plane.Location = new System.Drawing.Point(130, 378);
            plane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            plane.Name = "plane";
            plane.Size = new System.Drawing.Size(87, 93);
            plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            plane.TabIndex = 10;
            plane.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(plane);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1037);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(149, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 33);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(720, 478);
            Controls.Add(panel1);
            Controls.Add(btnBeep);
            Controls.Add(btnTesekkurler);
            Controls.Add(btnKemerler);
            Controls.Add(btnTurbulans);
            Controls.Add(btnEnishHazirligi);
            Controls.Add(buttonOnesOff);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Plane";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)plane).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonOnesOff;
        private System.Windows.Forms.Button btnEnishHazirligi;
        private System.Windows.Forms.Button btnTurbulans;
        private System.Windows.Forms.Button btnKemerler;
        private System.Windows.Forms.Button btnTesekkurler;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}