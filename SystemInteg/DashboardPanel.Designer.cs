namespace SystemInteg
{
    partial class DashboardPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPanel));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentYearlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBirthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGuardianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoFenceDBDataSet = new SystemInteg.GeoFenceDBDataSet();
            this.studentsTableAdapter = new SystemInteg.GeoFenceDBDataSetTableAdapters.StudentsTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.roundButton4 = new SystemInteg.RoundButton();
            this.btnEdit_Dashboard = new SystemInteg.RoundButton();
            this.btnDelete_Dashboard = new SystemInteg.RoundButton();
            this.roundPanel1 = new SystemInteg.RoundPanel();
            this.btnBack = new SystemInteg.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(30, 29);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(867, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentPasswordDataGridViewTextBoxColumn,
            this.studentYearlevelDataGridViewTextBoxColumn,
            this.studentSectionDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.studentTeacherDataGridViewTextBoxColumn,
            this.studentBirthdateDataGridViewTextBoxColumn,
            this.studentGuardianNameDataGridViewTextBoxColumn,
            this.guardianNumberDataGridViewTextBoxColumn,
            this.guardianAddressDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.studentsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 110);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(889, 499);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentPasswordDataGridViewTextBoxColumn
            // 
            this.studentPasswordDataGridViewTextBoxColumn.DataPropertyName = "Student_Password";
            this.studentPasswordDataGridViewTextBoxColumn.HeaderText = "Student_Password";
            this.studentPasswordDataGridViewTextBoxColumn.Name = "studentPasswordDataGridViewTextBoxColumn";
            // 
            // studentYearlevelDataGridViewTextBoxColumn
            // 
            this.studentYearlevelDataGridViewTextBoxColumn.DataPropertyName = "Student_Yearlevel";
            this.studentYearlevelDataGridViewTextBoxColumn.HeaderText = "Student_Yearlevel";
            this.studentYearlevelDataGridViewTextBoxColumn.Name = "studentYearlevelDataGridViewTextBoxColumn";
            // 
            // studentSectionDataGridViewTextBoxColumn
            // 
            this.studentSectionDataGridViewTextBoxColumn.DataPropertyName = "Student_Section";
            this.studentSectionDataGridViewTextBoxColumn.HeaderText = "Student_Section";
            this.studentSectionDataGridViewTextBoxColumn.Name = "studentSectionDataGridViewTextBoxColumn";
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "Student_Number";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "Student_Number";
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            // 
            // studentTeacherDataGridViewTextBoxColumn
            // 
            this.studentTeacherDataGridViewTextBoxColumn.DataPropertyName = "Student_Teacher";
            this.studentTeacherDataGridViewTextBoxColumn.HeaderText = "Student_Teacher";
            this.studentTeacherDataGridViewTextBoxColumn.Name = "studentTeacherDataGridViewTextBoxColumn";
            // 
            // studentBirthdateDataGridViewTextBoxColumn
            // 
            this.studentBirthdateDataGridViewTextBoxColumn.DataPropertyName = "Student_Birthdate";
            this.studentBirthdateDataGridViewTextBoxColumn.HeaderText = "Student_Birthdate";
            this.studentBirthdateDataGridViewTextBoxColumn.Name = "studentBirthdateDataGridViewTextBoxColumn";
            // 
            // studentGuardianNameDataGridViewTextBoxColumn
            // 
            this.studentGuardianNameDataGridViewTextBoxColumn.DataPropertyName = "Student_GuardianName";
            this.studentGuardianNameDataGridViewTextBoxColumn.HeaderText = "Student_GuardianName";
            this.studentGuardianNameDataGridViewTextBoxColumn.Name = "studentGuardianNameDataGridViewTextBoxColumn";
            // 
            // guardianNumberDataGridViewTextBoxColumn
            // 
            this.guardianNumberDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Number";
            this.guardianNumberDataGridViewTextBoxColumn.HeaderText = "Guardian_Number";
            this.guardianNumberDataGridViewTextBoxColumn.Name = "guardianNumberDataGridViewTextBoxColumn";
            // 
            // guardianAddressDataGridViewTextBoxColumn
            // 
            this.guardianAddressDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Address";
            this.guardianAddressDataGridViewTextBoxColumn.HeaderText = "Guardian_Address";
            this.guardianAddressDataGridViewTextBoxColumn.Name = "guardianAddressDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.geoFenceDBDataSet;
            // 
            // geoFenceDBDataSet
            // 
            this.geoFenceDBDataSet.DataSetName = "GeoFenceDBDataSet";
            this.geoFenceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtId.Location = new System.Drawing.Point(20, 65);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 20);
            this.txtId.TabIndex = 7;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.roundButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.roundButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.roundButton4.BorderRadius = 10;
            this.roundButton4.BorderSize = 1;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.Location = new System.Drawing.Point(445, 65);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(150, 34);
            this.roundButton4.TabIndex = 5;
            this.roundButton4.Text = "Add";
            this.roundButton4.TextColor = System.Drawing.Color.White;
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // btnEdit_Dashboard
            // 
            this.btnEdit_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnEdit_Dashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnEdit_Dashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnEdit_Dashboard.BorderRadius = 10;
            this.btnEdit_Dashboard.BorderSize = 1;
            this.btnEdit_Dashboard.FlatAppearance.BorderSize = 0;
            this.btnEdit_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_Dashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btnEdit_Dashboard.Location = new System.Drawing.Point(602, 65);
            this.btnEdit_Dashboard.Name = "btnEdit_Dashboard";
            this.btnEdit_Dashboard.Size = new System.Drawing.Size(150, 34);
            this.btnEdit_Dashboard.TabIndex = 4;
            this.btnEdit_Dashboard.Text = "Edit";
            this.btnEdit_Dashboard.TextColor = System.Drawing.Color.White;
            this.btnEdit_Dashboard.UseVisualStyleBackColor = false;
            this.btnEdit_Dashboard.Click += new System.EventHandler(this.btnEdit_Dashboard_Click);
            // 
            // btnDelete_Dashboard
            // 
            this.btnDelete_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnDelete_Dashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnDelete_Dashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnDelete_Dashboard.BorderRadius = 10;
            this.btnDelete_Dashboard.BorderSize = 1;
            this.btnDelete_Dashboard.FlatAppearance.BorderSize = 0;
            this.btnDelete_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Dashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Dashboard.Location = new System.Drawing.Point(759, 65);
            this.btnDelete_Dashboard.Name = "btnDelete_Dashboard";
            this.btnDelete_Dashboard.Size = new System.Drawing.Size(150, 34);
            this.btnDelete_Dashboard.TabIndex = 3;
            this.btnDelete_Dashboard.Text = "Delete";
            this.btnDelete_Dashboard.TextColor = System.Drawing.Color.White;
            this.btnDelete_Dashboard.UseVisualStyleBackColor = false;
            this.btnDelete_Dashboard.Click += new System.EventHandler(this.btnDelete_Dashboard_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundPanel1.BorderWidth = 1;
            this.roundPanel1.CornerRadius = 5;
            this.roundPanel1.Location = new System.Drawing.Point(20, 20);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(889, 34);
            this.roundPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnBack.BorderRadius = 10;
            this.btnBack.BorderSize = 1;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(759, 615);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 34);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.btnEdit_Dashboard);
            this.Controls.Add(this.btnDelete_Dashboard);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.roundPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private RoundButton btnDelete_Dashboard;
        private RoundButton btnEdit_Dashboard;
        private RoundButton roundButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GeoFenceDBDataSet geoFenceDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private GeoFenceDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private RoundButton btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentYearlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentBirthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGuardianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianAddressDataGridViewTextBoxColumn;
    }
}