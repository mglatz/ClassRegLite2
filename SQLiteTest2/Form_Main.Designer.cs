namespace SQLiteTest2
{
    partial class Form_Main
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
            this.button_test = new System.Windows.Forms.Button();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.button_refreshStudent = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(33, 328);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 0;
            this.button_test.Text = "test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.AutoGenerateColumns = false;
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.jmenoDataGridViewTextBoxColumn,
            this.prijmeniDataGridViewTextBoxColumn,
            this.vekDataGridViewTextBoxColumn});
            this.dataGridView_Student.DataSource = this.studentBindingSource;
            this.dataGridView_Student.Location = new System.Drawing.Point(157, 29);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(444, 136);
            this.dataGridView_Student.TabIndex = 1;
            
            // 
            // button_refreshStudent
            // 
            this.button_refreshStudent.Location = new System.Drawing.Point(144, 328);
            this.button_refreshStudent.Name = "button_refreshStudent";
            this.button_refreshStudent.Size = new System.Drawing.Size(75, 23);
            this.button_refreshStudent.TabIndex = 2;
            this.button_refreshStudent.Text = "refresh";
            this.button_refreshStudent.UseVisualStyleBackColor = true;
            this.button_refreshStudent.Click += new System.EventHandler(this.button_refreshStudent_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // jmenoDataGridViewTextBoxColumn
            // 
            this.jmenoDataGridViewTextBoxColumn.DataPropertyName = "Jmeno";
            this.jmenoDataGridViewTextBoxColumn.HeaderText = "Jmeno";
            this.jmenoDataGridViewTextBoxColumn.Name = "jmenoDataGridViewTextBoxColumn";
            // 
            // prijmeniDataGridViewTextBoxColumn
            // 
            this.prijmeniDataGridViewTextBoxColumn.DataPropertyName = "Prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.HeaderText = "Prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.Name = "prijmeniDataGridViewTextBoxColumn";
            // 
            // vekDataGridViewTextBoxColumn
            // 
            this.vekDataGridViewTextBoxColumn.DataPropertyName = "Vek";
            this.vekDataGridViewTextBoxColumn.HeaderText = "Vek";
            this.vekDataGridViewTextBoxColumn.Name = "vekDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SQLiteTest2.Database.Student);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 395);
            this.Controls.Add(this.button_refreshStudent);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.button_test);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vekDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button button_refreshStudent;
    }
}