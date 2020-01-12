namespace dbms
{
    partial class Employee
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
            System.Windows.Forms.Label emp_IDLabel;
            System.Windows.Forms.Label emp_NameLabel;
            System.Windows.Forms.Label phone_NoLabel;
            System.Windows.Forms.Label cNICLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label login_IdLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Store_ManagementDataSet = new dbms.Medical_Store_ManagementDataSet();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Emp_Reset = new System.Windows.Forms.Button();
            this.btn_Emp_Del = new System.Windows.Forms.Button();
            this.btn_Emp_Upd = new System.Windows.Forms.Button();
            this.btn_Emp_Ins = new System.Windows.Forms.Button();
            this.emp_IDTextBox = new System.Windows.Forms.TextBox();
            this.emp_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NoTextBox = new System.Windows.Forms.TextBox();
            this.cNICTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.login_IdTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new dbms.Medical_Store_ManagementDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager();
            this.btn_Close = new System.Windows.Forms.Button();
            emp_IDLabel = new System.Windows.Forms.Label();
            emp_NameLabel = new System.Windows.Forms.Label();
            phone_NoLabel = new System.Windows.Forms.Label();
            cNICLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            login_IdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_IDLabel
            // 
            emp_IDLabel.AutoSize = true;
            emp_IDLabel.BackColor = System.Drawing.Color.Transparent;
            emp_IDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_IDLabel.Location = new System.Drawing.Point(68, 67);
            emp_IDLabel.Name = "emp_IDLabel";
            emp_IDLabel.Size = new System.Drawing.Size(86, 23);
            emp_IDLabel.TabIndex = 23;
            emp_IDLabel.Text = "Emp ID:";
            // 
            // emp_NameLabel
            // 
            emp_NameLabel.AutoSize = true;
            emp_NameLabel.BackColor = System.Drawing.Color.Transparent;
            emp_NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_NameLabel.Location = new System.Drawing.Point(68, 95);
            emp_NameLabel.Name = "emp_NameLabel";
            emp_NameLabel.Size = new System.Drawing.Size(122, 23);
            emp_NameLabel.TabIndex = 25;
            emp_NameLabel.Text = "Emp Name:";
            // 
            // phone_NoLabel
            // 
            phone_NoLabel.AutoSize = true;
            phone_NoLabel.BackColor = System.Drawing.Color.Transparent;
            phone_NoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_NoLabel.Location = new System.Drawing.Point(68, 123);
            phone_NoLabel.Name = "phone_NoLabel";
            phone_NoLabel.Size = new System.Drawing.Size(109, 23);
            phone_NoLabel.TabIndex = 27;
            phone_NoLabel.Text = "Phone No:";
            // 
            // cNICLabel
            // 
            cNICLabel.AutoSize = true;
            cNICLabel.BackColor = System.Drawing.Color.Transparent;
            cNICLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNICLabel.Location = new System.Drawing.Point(438, 69);
            cNICLabel.Name = "cNICLabel";
            cNICLabel.Size = new System.Drawing.Size(67, 23);
            cNICLabel.TabIndex = 29;
            cNICLabel.Text = "CNIC:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.BackColor = System.Drawing.Color.Transparent;
            salaryLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaryLabel.Location = new System.Drawing.Point(438, 97);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(78, 23);
            salaryLabel.TabIndex = 31;
            salaryLabel.Text = "Salary:";
            // 
            // login_IdLabel
            // 
            login_IdLabel.AutoSize = true;
            login_IdLabel.BackColor = System.Drawing.Color.Transparent;
            login_IdLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            login_IdLabel.Location = new System.Drawing.Point(438, 125);
            login_IdLabel.Name = "login_IdLabel";
            login_IdLabel.Size = new System.Drawing.Size(94, 23);
            login_IdLabel.TabIndex = 33;
            login_IdLabel.Text = "Login Id:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.Transparent;
            statusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(438, 153);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(78, 23);
            statusLabel.TabIndex = 35;
            statusLabel.Text = "Status:";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.medical_Store_ManagementDataSet;
            // 
            // medical_Store_ManagementDataSet
            // 
            this.medical_Store_ManagementDataSet.DataSetName = "Medical_Store_ManagementDataSet";
            this.medical_Store_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Status});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(99, 365);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(742, 220);
            this.employeeDataGridView.TabIndex = 1;
            this.employeeDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeeDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Emp_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Emp_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Emp_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emp_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone_No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CNIC";
            this.dataGridViewTextBoxColumn4.HeaderText = "CNIC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Login_Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Login_Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btn_Emp_Reset
            // 
            this.btn_Emp_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Reset.Location = new System.Drawing.Point(727, 217);
            this.btn_Emp_Reset.Name = "btn_Emp_Reset";
            this.btn_Emp_Reset.Size = new System.Drawing.Size(92, 40);
            this.btn_Emp_Reset.TabIndex = 23;
            this.btn_Emp_Reset.Text = "Reset";
            this.btn_Emp_Reset.UseVisualStyleBackColor = true;
            this.btn_Emp_Reset.Click += new System.EventHandler(this.btn_Emp_Reset_Click);
            // 
            // btn_Emp_Del
            // 
            this.btn_Emp_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Del.Location = new System.Drawing.Point(629, 217);
            this.btn_Emp_Del.Name = "btn_Emp_Del";
            this.btn_Emp_Del.Size = new System.Drawing.Size(92, 40);
            this.btn_Emp_Del.TabIndex = 22;
            this.btn_Emp_Del.Text = "Delete";
            this.btn_Emp_Del.UseVisualStyleBackColor = true;
            this.btn_Emp_Del.Click += new System.EventHandler(this.btn_Emp_Del_Click);
            // 
            // btn_Emp_Upd
            // 
            this.btn_Emp_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Upd.Location = new System.Drawing.Point(523, 217);
            this.btn_Emp_Upd.Name = "btn_Emp_Upd";
            this.btn_Emp_Upd.Size = new System.Drawing.Size(100, 40);
            this.btn_Emp_Upd.TabIndex = 21;
            this.btn_Emp_Upd.Text = "Update";
            this.btn_Emp_Upd.UseVisualStyleBackColor = true;
            this.btn_Emp_Upd.Click += new System.EventHandler(this.btn_Emp_Upd_Click);
            // 
            // btn_Emp_Ins
            // 
            this.btn_Emp_Ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp_Ins.Location = new System.Drawing.Point(429, 217);
            this.btn_Emp_Ins.Name = "btn_Emp_Ins";
            this.btn_Emp_Ins.Size = new System.Drawing.Size(92, 40);
            this.btn_Emp_Ins.TabIndex = 20;
            this.btn_Emp_Ins.Text = "Insert";
            this.btn_Emp_Ins.UseVisualStyleBackColor = true;
            this.btn_Emp_Ins.Click += new System.EventHandler(this.btn_Emp_Ins_Click);
            // 
            // emp_IDTextBox
            // 
            this.emp_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Emp_ID", true));
            this.emp_IDTextBox.Location = new System.Drawing.Point(224, 70);
            this.emp_IDTextBox.Name = "emp_IDTextBox";
            this.emp_IDTextBox.Size = new System.Drawing.Size(153, 22);
            this.emp_IDTextBox.TabIndex = 24;
            // 
            // emp_NameTextBox
            // 
            this.emp_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Emp_Name", true));
            this.emp_NameTextBox.Location = new System.Drawing.Point(224, 98);
            this.emp_NameTextBox.Name = "emp_NameTextBox";
            this.emp_NameTextBox.Size = new System.Drawing.Size(153, 22);
            this.emp_NameTextBox.TabIndex = 26;
            // 
            // phone_NoTextBox
            // 
            this.phone_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone_No", true));
            this.phone_NoTextBox.Location = new System.Drawing.Point(224, 126);
            this.phone_NoTextBox.Name = "phone_NoTextBox";
            this.phone_NoTextBox.Size = new System.Drawing.Size(153, 22);
            this.phone_NoTextBox.TabIndex = 28;
            // 
            // cNICTextBox
            // 
            this.cNICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CNIC", true));
            this.cNICTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNICTextBox.Location = new System.Drawing.Point(566, 67);
            this.cNICTextBox.Name = "cNICTextBox";
            this.cNICTextBox.Size = new System.Drawing.Size(211, 22);
            this.cNICTextBox.TabIndex = 30;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Salary", true));
            this.salaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTextBox.Location = new System.Drawing.Point(566, 95);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(211, 22);
            this.salaryTextBox.TabIndex = 32;
            // 
            // login_IdTextBox
            // 
            this.login_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Login_Id", true));
            this.login_IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_IdTextBox.Location = new System.Drawing.Point(566, 123);
            this.login_IdTextBox.Name = "login_IdTextBox";
            this.login_IdTextBox.Size = new System.Drawing.Size(211, 22);
            this.login_IdTextBox.TabIndex = 34;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Status", true));
            this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(566, 151);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(211, 22);
            this.statusTextBox.TabIndex = 36;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_BillTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Store_StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(866, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 27);
            this.btn_Close.TabIndex = 37;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 605);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(emp_IDLabel);
            this.Controls.Add(this.emp_IDTextBox);
            this.Controls.Add(emp_NameLabel);
            this.Controls.Add(this.emp_NameTextBox);
            this.Controls.Add(phone_NoLabel);
            this.Controls.Add(this.phone_NoTextBox);
            this.Controls.Add(cNICLabel);
            this.Controls.Add(this.cNICTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(login_IdLabel);
            this.Controls.Add(this.login_IdTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.btn_Emp_Reset);
            this.Controls.Add(this.btn_Emp_Del);
            this.Controls.Add(this.btn_Emp_Upd);
            this.Controls.Add(this.btn_Emp_Ins);
            this.Controls.Add(this.employeeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Medical_Store_ManagementDataSet medical_Store_ManagementDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Medical_Store_ManagementDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btn_Emp_Reset;
        private System.Windows.Forms.Button btn_Emp_Del;
        private System.Windows.Forms.Button btn_Emp_Upd;
        private System.Windows.Forms.Button btn_Emp_Ins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox emp_IDTextBox;
        private System.Windows.Forms.TextBox emp_NameTextBox;
        private System.Windows.Forms.TextBox phone_NoTextBox;
        private System.Windows.Forms.TextBox cNICTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox login_IdTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button btn_Close;
    }
}