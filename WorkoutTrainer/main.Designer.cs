namespace WorkoutTrainer
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.bgPict = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pbGerakan = new System.Windows.Forms.PictureBox();
            this.lblNamaGerakan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgPict)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGerakan)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPict
            // 
            this.bgPict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPict.Image = ((System.Drawing.Image)(resources.GetObject("bgPict.Image")));
            this.bgPict.Location = new System.Drawing.Point(0, 0);
            this.bgPict.Name = "bgPict";
            this.bgPict.Size = new System.Drawing.Size(800, 450);
            this.bgPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgPict.TabIndex = 0;
            this.bgPict.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 55);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Airbnb Cereal App", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Chest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Legs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Triceps";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "Biceps";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(197, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "Shoulder";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(197, 253);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 2;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(197, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 2;
            this.button8.Text = "Glutes";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Location = new System.Drawing.Point(632, 366);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.Location = new System.Drawing.Point(485, 366);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pbGerakan
            // 
            this.pbGerakan.Location = new System.Drawing.Point(485, 124);
            this.pbGerakan.Name = "pbGerakan";
            this.pbGerakan.Size = new System.Drawing.Size(241, 211);
            this.pbGerakan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGerakan.TabIndex = 3;
            this.pbGerakan.TabStop = false;
            // 
            // lblNamaGerakan
            // 
            this.lblNamaGerakan.AutoSize = true;
            this.lblNamaGerakan.Font = new System.Drawing.Font("Airbnb Cereal App", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamaGerakan.Location = new System.Drawing.Point(485, 76);
            this.lblNamaGerakan.Name = "lblNamaGerakan";
            this.lblNamaGerakan.Size = new System.Drawing.Size(61, 23);
            this.lblNamaGerakan.TabIndex = 0;
            this.lblNamaGerakan.Text = "label1";
            this.lblNamaGerakan.Click += new System.EventHandler(this.label1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNamaGerakan);
            this.Controls.Add(this.pbGerakan);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bgPict);
            this.Name = "main";
            this.Text = "Trainer Workout ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgPict)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGerakan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox bgPict;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnNext;
        private Button btnPrev;
        private PictureBox pbGerakan;
        private Label lblNamaGerakan;
    }
}