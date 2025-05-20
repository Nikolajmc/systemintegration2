namespace SystemInteg
{
    partial class AddFormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormTeacher));
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel9 = new SystemInteg.RoundPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel1 = new SystemInteg.RoundPanel();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnClear_Teacher = new SystemInteg.RoundButton();
            this.btnConfirm_Teacher = new SystemInteg.RoundButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Student Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(715, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 44;
            this.label12.Text = "SafeCheck";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(642, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Stay In Check, Stay On Track";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(809, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Class Name :";
            // 
            // roundPanel9
            // 
            this.roundPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.roundPanel9.BorderColor = System.Drawing.Color.Black;
            this.roundPanel9.BorderWidth = 1;
            this.roundPanel9.CornerRadius = 5;
            this.roundPanel9.Location = new System.Drawing.Point(24, 220);
            this.roundPanel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundPanel9.Name = "roundPanel9";
            this.roundPanel9.Size = new System.Drawing.Size(835, 34);
            this.roundPanel9.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Teacher Name :";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundPanel1.BorderWidth = 1;
            this.roundPanel1.CornerRadius = 5;
            this.roundPanel1.Location = new System.Drawing.Point(24, 150);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(835, 34);
            this.roundPanel1.TabIndex = 50;
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassName.Location = new System.Drawing.Point(35, 229);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(815, 20);
            this.txtClassName.TabIndex = 51;
            this.txtClassName.Enter += new System.EventHandler(this.txtClassName_Enter);
            this.txtClassName.Leave += new System.EventHandler(this.txtClassName_Leave);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherName.Location = new System.Drawing.Point(35, 159);
            this.txtTeacherName.Multiline = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(815, 20);
            this.txtTeacherName.TabIndex = 52;
            this.txtTeacherName.Enter += new System.EventHandler(this.txtTeacherName_Enter);
            this.txtTeacherName.Leave += new System.EventHandler(this.txtTeacherName_Leave);
            // 
            // btnClear_Teacher
            // 
            this.btnClear_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnClear_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnClear_Teacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnClear_Teacher.BorderRadius = 10;
            this.btnClear_Teacher.BorderSize = 1;
            this.btnClear_Teacher.FlatAppearance.BorderSize = 0;
            this.btnClear_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_Teacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_Teacher.ForeColor = System.Drawing.Color.White;
            this.btnClear_Teacher.Location = new System.Drawing.Point(554, 265);
            this.btnClear_Teacher.Name = "btnClear_Teacher";
            this.btnClear_Teacher.Size = new System.Drawing.Size(150, 34);
            this.btnClear_Teacher.TabIndex = 53;
            this.btnClear_Teacher.Text = "Clear";
            this.btnClear_Teacher.TextColor = System.Drawing.Color.White;
            this.btnClear_Teacher.UseVisualStyleBackColor = false;
            this.btnClear_Teacher.Click += new System.EventHandler(this.btnClear_Teacher_Click);
            // 
            // btnConfirm_Teacher
            // 
            this.btnConfirm_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnConfirm_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnConfirm_Teacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnConfirm_Teacher.BorderRadius = 10;
            this.btnConfirm_Teacher.BorderSize = 1;
            this.btnConfirm_Teacher.FlatAppearance.BorderSize = 0;
            this.btnConfirm_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm_Teacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm_Teacher.ForeColor = System.Drawing.Color.White;
            this.btnConfirm_Teacher.Location = new System.Drawing.Point(710, 265);
            this.btnConfirm_Teacher.Name = "btnConfirm_Teacher";
            this.btnConfirm_Teacher.Size = new System.Drawing.Size(150, 34);
            this.btnConfirm_Teacher.TabIndex = 54;
            this.btnConfirm_Teacher.Text = "Confirm";
            this.btnConfirm_Teacher.TextColor = System.Drawing.Color.White;
            this.btnConfirm_Teacher.UseVisualStyleBackColor = false;
            this.btnConfirm_Teacher.Click += new System.EventHandler(this.btnConfirm_Teacher_Click);
            // 
            // AddFormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(884, 312);
            this.Controls.Add(this.btnConfirm_Teacher);
            this.Controls.Add(this.btnClear_Teacher);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roundPanel9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddFormTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RoundPanel roundPanel9;
        private System.Windows.Forms.Label label2;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private RoundButton btnClear_Teacher;
        private RoundButton btnConfirm_Teacher;
    }
}