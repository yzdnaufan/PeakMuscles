namespace Login_Register_System
{
    partial class AddNutrition
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictboxHome = new System.Windows.Forms.PictureBox();
            this.pbCalorie = new System.Windows.Forms.ProgressBar();
            this.lblCalOut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCalStart = new System.Windows.Forms.Label();
            this.btnResetFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictboxHome);
            this.panel1.Controls.Add(this.pbCalorie);
            this.panel1.Controls.Add(this.lblCalOut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 113);
            this.panel1.TabIndex = 7;
            // 
            // pictboxHome
            // 
            this.pictboxHome.BackgroundImage = global::Login_Register_System.Properties.Resources.home_button;
            this.pictboxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictboxHome.Location = new System.Drawing.Point(705, 2);
            this.pictboxHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictboxHome.Name = "pictboxHome";
            this.pictboxHome.Size = new System.Drawing.Size(31, 26);
            this.pictboxHome.TabIndex = 8;
            this.pictboxHome.TabStop = false;
            this.pictboxHome.Click += new System.EventHandler(this.pictboxHome_Click);
            // 
            // pbCalorie
            // 
            this.pbCalorie.Location = new System.Drawing.Point(251, 76);
            this.pbCalorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCalorie.Name = "pbCalorie";
            this.pbCalorie.Size = new System.Drawing.Size(257, 27);
            this.pbCalorie.TabIndex = 7;
            // 
            // lblCalOut
            // 
            this.lblCalOut.AutoSize = true;
            this.lblCalOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalOut.Location = new System.Drawing.Point(380, 48);
            this.lblCalOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalOut.Name = "lblCalOut";
            this.lblCalOut.Size = new System.Drawing.Size(42, 19);
            this.lblCalOut.TabIndex = 6;
            this.lblCalOut.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calorie Target:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(206, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Calorie Intake";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Login_Register_System.Properties.Resources.calorie_background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnResetFood);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Controls.Add(this.dgvFood);
            this.panel2.Location = new System.Drawing.Point(8, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 436);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblCalStart);
            this.panel3.Location = new System.Drawing.Point(340, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 43);
            this.panel3.TabIndex = 3;
            // 
            // lblCalStart
            // 
            this.lblCalStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalStart.AutoSize = true;
            this.lblCalStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalStart.Location = new System.Drawing.Point(24, 13);
            this.lblCalStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalStart.Name = "lblCalStart";
            this.lblCalStart.Size = new System.Drawing.Size(0, 19);
            this.lblCalStart.TabIndex = 0;
            this.lblCalStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetFood
            // 
            this.btnResetFood.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetFood.Location = new System.Drawing.Point(386, 357);
            this.btnResetFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetFood.Name = "btnResetFood";
            this.btnResetFood.Size = new System.Drawing.Size(99, 35);
            this.btnResetFood.TabIndex = 2;
            this.btnResetFood.Text = "Reset";
            this.btnResetFood.UseVisualStyleBackColor = true;
            this.btnResetFood.Click += new System.EventHandler(this.btnResetFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(284, 357);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(99, 35);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(204, 70);
            this.dgvFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersWidth = 62;
            this.dgvFood.RowTemplate.Height = 33;
            this.dgvFood.Size = new System.Drawing.Size(360, 274);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // AddNutrition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNutrition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Intake";
            this.Load += new System.EventHandler(this.AddNutrition_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ProgressBar pbCalorie;
        private Label lblCalOut;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnResetFood;
        private Button btnAddFood;
        private DataGridView dgvFood;
        private Panel panel3;
        private Label lblCalStart;
        private PictureBox pictboxHome;
    }
}