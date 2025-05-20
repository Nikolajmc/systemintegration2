namespace SystemInteg
{
    partial class RecordsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsPanel));
            this.roundPanel1 = new SystemInteg.RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.roundPanel2 = new SystemInteg.RoundPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.roundPanel1.BorderWidth = 3;
            this.roundPanel1.CornerRadius = 5;
            this.roundPanel1.Location = new System.Drawing.Point(50, 50);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(370, 155);
            this.roundPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(179, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Students";
            // 
            // lblStudents
            // 
            this.lblStudents.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.lblStudents.Location = new System.Drawing.Point(175, 63);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(120, 85);
            this.lblStudents.TabIndex = 12;
            this.lblStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudents.UseCompatibleTextRendering = true;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.roundPanel2.BorderWidth = 3;
            this.roundPanel2.CornerRadius = 5;
            this.roundPanel2.Location = new System.Drawing.Point(514, 50);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(370, 155);
            this.roundPanel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(643, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Teachers";
            // 
            // lblTeachers
            // 
            this.lblTeachers.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.lblTeachers.Location = new System.Drawing.Point(639, 63);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(120, 85);
            this.lblTeachers.TabIndex = 15;
            this.lblTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTeachers.UseCompatibleTextRendering = true;
            // 
            // RecordsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.ControlBox = false;
            this.Controls.Add(this.lblTeachers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecordsPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudents;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTeachers;
    }
}