namespace Login_Register_System
{
    partial class HomePageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnCalorieIntake = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to PeakMuscles!";
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.IndianRed;
            this.btnTrainer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrainer.Location = new System.Drawing.Point(119, 572);
            this.btnTrainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(174, 70);
            this.btnTrainer.TabIndex = 1;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.UseVisualStyleBackColor = false;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnCalorieIntake
            // 
            this.btnCalorieIntake.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalorieIntake.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalorieIntake.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalorieIntake.Location = new System.Drawing.Point(454, 572);
            this.btnCalorieIntake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalorieIntake.Name = "btnCalorieIntake";
            this.btnCalorieIntake.Size = new System.Drawing.Size(174, 70);
            this.btnCalorieIntake.TabIndex = 2;
            this.btnCalorieIntake.Text = "Calories Intake";
            this.btnCalorieIntake.UseVisualStyleBackColor = false;
            this.btnCalorieIntake.Click += new System.EventHandler(this.btnCalorieIntake_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_Register_System.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(44, 195);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login_Register_System.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(392, 195);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(738, 692);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalorieIntake);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePageForm_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnTrainer;
        private Button btnCalorieIntake;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}