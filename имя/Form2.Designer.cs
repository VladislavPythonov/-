namespace имя
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OLDuser = new System.Windows.Forms.Button();
            this.NEWuser = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 607);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1087, 51);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "MARATHON SKILLS 2015";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OLDuser
            // 
            this.OLDuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OLDuser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OLDuser.Location = new System.Drawing.Point(331, 191);
            this.OLDuser.Name = "OLDuser";
            this.OLDuser.Size = new System.Drawing.Size(430, 120);
            this.OLDuser.TabIndex = 5;
            this.OLDuser.Text = "Я учавствовал ранее";
            this.OLDuser.UseVisualStyleBackColor = true;
            this.OLDuser.Click += new System.EventHandler(this.button3_Click);
            // 
            // NEWuser
            // 
            this.NEWuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NEWuser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NEWuser.Location = new System.Drawing.Point(331, 326);
            this.NEWuser.Name = "NEWuser";
            this.NEWuser.Size = new System.Drawing.Size(430, 120);
            this.NEWuser.TabIndex = 6;
            this.NEWuser.Text = "Я новый участник";
            this.NEWuser.UseVisualStyleBackColor = true;
            this.NEWuser.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(930, 554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(316, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "18 дней 8 часов и 17 минут до старата марафона!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NEWuser);
            this.Controls.Add(this.OLDuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Marathon Skills - Register as a runner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OLDuser;
        private System.Windows.Forms.Button NEWuser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}