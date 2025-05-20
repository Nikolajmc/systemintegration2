namespace SystemInteg
{
    partial class Teachers
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
            this.roundPanel1 = new SystemInteg.RoundPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd_Teacher = new SystemInteg.RoundButton();
            this.btnEdit_Teacher = new SystemInteg.RoundButton();
            this.btnDelete_Teacher = new SystemInteg.RoundButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoFenceDBDataSet2 = new SystemInteg.GeoFenceDBDataSet2();
            this.geoFenceDBDataSet = new SystemInteg.GeoFenceDBDataSet();
            this.geoFenceDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new SystemInteg.GeoFenceDBDataSetTableAdapters.StudentsTableAdapter();
            this.teachersTableAdapter = new SystemInteg.GeoFenceDBDataSet2TableAdapters.TeachersTableAdapter();
            this.btnBack_Teacher = new SystemInteg.RoundButton();
            this.txtId_Teacher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.roundPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundPanel1.BorderWidth = 1;
            this.roundPanel1.CornerRadius = 5;
            this.roundPanel1.Location = new System.Drawing.Point(20, 20);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(889, 34);
            this.roundPanel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(30, 29);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(867, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search";
            // 
            // btnAdd_Teacher
            // 
            this.btnAdd_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnAdd_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnAdd_Teacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnAdd_Teacher.BorderRadius = 10;
            this.btnAdd_Teacher.BorderSize = 1;
            this.btnAdd_Teacher.FlatAppearance.BorderSize = 0;
            this.btnAdd_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Teacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Teacher.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Teacher.Location = new System.Drawing.Point(445, 65);
            this.btnAdd_Teacher.Name = "btnAdd_Teacher";
            this.btnAdd_Teacher.Size = new System.Drawing.Size(150, 34);
            this.btnAdd_Teacher.TabIndex = 6;
            this.btnAdd_Teacher.Text = "Add";
            this.btnAdd_Teacher.TextColor = System.Drawing.Color.White;
            this.btnAdd_Teacher.UseVisualStyleBackColor = false;
            this.btnAdd_Teacher.Click += new System.EventHandler(this.btnAdd_Teacher_Click);
            // 
            // btnEdit_Teacher
            // 
            this.btnEdit_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnEdit_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnEdit_Teacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnEdit_Teacher.BorderRadius = 10;
            this.btnEdit_Teacher.BorderSize = 1;
            this.btnEdit_Teacher.FlatAppearance.BorderSize = 0;
            this.btnEdit_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_Teacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Teacher.ForeColor = System.Drawing.Color.White;
            this.btnEdit_Teacher.Location = new System.Drawing.Point(602, 65);
            this.btnEdit_Teacher.Name = "btnEdit_Teacher";
            this.btnEdit_Teacher.Size = new System.Drawing.Size(150, 34);
            this.btnEdit_Teacher.TabIndex = 7;
            this.btnEdit_Teacher.Text = "Edit";
            this.btnEdit_Teacher.TextColor = System.Drawing.Color.White;
            this.btnEdit_Teacher.UseVisualStyleBackColor = false;
            this.btnEdit_Teacher.Click += new System.EventHandler(this.btnEdit_Teacher_Click);
            // 
            // btnDelete_Teacher
            // 
            this.btnDelete_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnDelete_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnDelete_Teacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnDelete_Teacher.BorderRadius = 10;
            this.btnDelete_Teacher.BorderSize = 1;
            this.btnDelete_Teacher.FlatAppearance.BorderSize = 0;
            this.btnDelete_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Teacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Teacher.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Teacher.Location = new System.Drawing.Point(759, 65);
            this.btnDelete_Teacher.Name = "btnDelete_Teacher";
            this.btnDelete_Teacher.Size = new System.Drawing.Size(150, 34);
            this.btnDelete_Teacher.TabIndex = 8;
            this.btnDelete_Teacher.Text = "Delete";
            this.btnDelete_Teacher.TextColor = System.Drawing.Color.White;
            this.btnDelete_Teacher.UseVisualStyleBackColor = false;
            this.btnDelete_Teacher.Click += new System.EventHandler(this.btnDelete_Teacher_Click);
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
            this.teacherNameDataGridViewTextBoxColumn,
            this.classesDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.teachersBindingSource;
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
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "Teacher_Name";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "Teacher_Name";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            // 
            // classesDataGridViewTextBoxColumn
            // 
            this.classesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classesDataGridViewTextBoxColumn.DataPropertyName = "Classes";
            this.classesDataGridViewTextBoxColumn.HeaderText = "Classes";
            this.classesDataGridViewTextBoxColumn.Name = "classesDataGridViewTextBoxColumn";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.geoFenceDBDataSet2;
            // 
            // geoFenceDBDataSet2
            // 
            this.geoFenceDBDataSet2.DataSetName = "GeoFenceDBDataSet2";
            this.geoFenceDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geoFenceDBDataSet
            // 
            this.geoFenceDBDataSet.DataSetName = "GeoFenceDBDataSet";
            this.geoFenceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geoFenceDBDataSetBindingSource
            // 
            this.geoFenceDBDataSetBindingSource.DataSource = this.geoFenceDBDataSet;
            this.geoFenceDBDataSetBindingSource.Position = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.geoFenceDBDataSetBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack_Teacher
            // 
            this.btnBack_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnBack_Teacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnBack_Teacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.btnBack_Teacher.BorderRadius = 10;
            this.btnBack_Teacher.BorderSize = 1;
            this.btnBack_Teacher.FlatAppearance.BorderSize = 0;
            this.btnBack_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack_Teacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_Teacher.ForeColor = System.Drawing.Color.White;
            this.btnBack_Teacher.Location = new System.Drawing.Point(759, 615);
            this.btnBack_Teacher.Name = "btnBack_Teacher";
            this.btnBack_Teacher.Size = new System.Drawing.Size(150, 34);
            this.btnBack_Teacher.TabIndex = 10;
            this.btnBack_Teacher.Text = "Back";
            this.btnBack_Teacher.TextColor = System.Drawing.Color.White;
            this.btnBack_Teacher.UseVisualStyleBackColor = false;
            this.btnBack_Teacher.Click += new System.EventHandler(this.btnBack_Teacher_Click);
            // 
            // txtId_Teacher
            // 
            this.txtId_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtId_Teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_Teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.txtId_Teacher.Location = new System.Drawing.Point(20, 65);
            this.txtId_Teacher.Multiline = true;
            this.txtId_Teacher.Name = "txtId_Teacher";
            this.txtId_Teacher.Size = new System.Drawing.Size(27, 20);
            this.txtId_Teacher.TabIndex = 11;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.ControlBox = false;
            this.Controls.Add(this.txtId_Teacher);
            this.Controls.Add(this.btnBack_Teacher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete_Teacher);
            this.Controls.Add(this.btnEdit_Teacher);
            this.Controls.Add(this.btnAdd_Teacher);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.roundPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoFenceDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private RoundButton btnAdd_Teacher;
        private RoundButton btnEdit_Teacher;
        private RoundButton btnDelete_Teacher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GeoFenceDBDataSet geoFenceDBDataSet;
        private System.Windows.Forms.BindingSource geoFenceDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private GeoFenceDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private GeoFenceDBDataSet2 geoFenceDBDataSet2;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private GeoFenceDBDataSet2TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classesDataGridViewTextBoxColumn;
        private RoundButton btnBack_Teacher;
        private System.Windows.Forms.TextBox txtId_Teacher;
    }
}