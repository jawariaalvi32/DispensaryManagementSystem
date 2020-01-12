namespace dbms
{
    partial class Customer
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
            System.Windows.Forms.Label customer_IdLabel;
            System.Windows.Forms.Label customer_NameLabel;
            System.Windows.Forms.Label phone_NOLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.medical_Store_ManagementDataSet = new dbms.Medical_Store_ManagementDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new dbms.Medical_Store_ManagementDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager();
            this.customer_IdTextBox = new System.Windows.Forms.TextBox();
            this.customer_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NOTextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Cus_Ins = new System.Windows.Forms.Button();
            this.btn_Cus_Upd = new System.Windows.Forms.Button();
            this.btn_Cus_Del = new System.Windows.Forms.Button();
            this.btn_Customer_Reset = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Search_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            customer_IdLabel = new System.Windows.Forms.Label();
            customer_NameLabel = new System.Windows.Forms.Label();
            phone_NOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_IdLabel
            // 
            customer_IdLabel.AutoSize = true;
            customer_IdLabel.BackColor = System.Drawing.Color.Transparent;
            customer_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_IdLabel.Location = new System.Drawing.Point(145, 44);
            customer_IdLabel.Name = "customer_IdLabel";
            customer_IdLabel.Size = new System.Drawing.Size(136, 25);
            customer_IdLabel.TabIndex = 1;
            customer_IdLabel.Text = "Customer Id:";
            // 
            // customer_NameLabel
            // 
            customer_NameLabel.AutoSize = true;
            customer_NameLabel.BackColor = System.Drawing.Color.Transparent;
            customer_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_NameLabel.Location = new System.Drawing.Point(145, 72);
            customer_NameLabel.Name = "customer_NameLabel";
            customer_NameLabel.Size = new System.Drawing.Size(174, 25);
            customer_NameLabel.TabIndex = 3;
            customer_NameLabel.Text = "Customer Name:";
            // 
            // phone_NOLabel
            // 
            phone_NOLabel.AutoSize = true;
            phone_NOLabel.BackColor = System.Drawing.Color.Transparent;
            phone_NOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_NOLabel.Location = new System.Drawing.Point(145, 100);
            phone_NOLabel.Name = "phone_NOLabel";
            phone_NOLabel.Size = new System.Drawing.Size(119, 25);
            phone_NOLabel.TabIndex = 5;
            phone_NOLabel.Text = "Phone NO:";
            // 
            // medical_Store_ManagementDataSet
            // 
            this.medical_Store_ManagementDataSet.DataSetName = "Medical_Store_ManagementDataSet";
            this.medical_Store_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.medical_Store_ManagementDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_BillTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Store_StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customer_IdTextBox
            // 
            this.customer_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Customer_Id", true));
            this.customer_IdTextBox.Location = new System.Drawing.Point(342, 44);
            this.customer_IdTextBox.Name = "customer_IdTextBox";
            this.customer_IdTextBox.Size = new System.Drawing.Size(173, 22);
            this.customer_IdTextBox.TabIndex = 2;
            // 
            // customer_NameTextBox
            // 
            this.customer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Customer_Name", true));
            this.customer_NameTextBox.Location = new System.Drawing.Point(342, 72);
            this.customer_NameTextBox.Name = "customer_NameTextBox";
            this.customer_NameTextBox.Size = new System.Drawing.Size(173, 22);
            this.customer_NameTextBox.TabIndex = 4;
            // 
            // phone_NOTextBox
            // 
            this.phone_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone_NO", true));
            this.phone_NOTextBox.Location = new System.Drawing.Point(342, 100);
            this.phone_NOTextBox.Name = "phone_NOTextBox";
            this.phone_NOTextBox.Size = new System.Drawing.Size(173, 22);
            this.phone_NOTextBox.TabIndex = 6;
            // 
            // customerDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataGridView.Location = new System.Drawing.Point(407, 285);
            this.customerDataGridView.Name = "customerDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(551, 231);
            this.customerDataGridView.TabIndex = 7;
            this.customerDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 167;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 198;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone_NO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone_NO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 142;
            // 
            // btn_Cus_Ins
            // 
            this.btn_Cus_Ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cus_Ins.Location = new System.Drawing.Point(340, 165);
            this.btn_Cus_Ins.Name = "btn_Cus_Ins";
            this.btn_Cus_Ins.Size = new System.Drawing.Size(92, 40);
            this.btn_Cus_Ins.TabIndex = 8;
            this.btn_Cus_Ins.Text = "Insert";
            this.btn_Cus_Ins.UseVisualStyleBackColor = true;
            this.btn_Cus_Ins.Click += new System.EventHandler(this.btn_Cus_Ins_Click);
            // 
            // btn_Cus_Upd
            // 
            this.btn_Cus_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cus_Upd.Location = new System.Drawing.Point(438, 165);
            this.btn_Cus_Upd.Name = "btn_Cus_Upd";
            this.btn_Cus_Upd.Size = new System.Drawing.Size(92, 40);
            this.btn_Cus_Upd.TabIndex = 9;
            this.btn_Cus_Upd.Text = "Update";
            this.btn_Cus_Upd.UseVisualStyleBackColor = true;
            this.btn_Cus_Upd.Click += new System.EventHandler(this.btn_Cus_Upd_Click);
            // 
            // btn_Cus_Del
            // 
            this.btn_Cus_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cus_Del.Location = new System.Drawing.Point(536, 165);
            this.btn_Cus_Del.Name = "btn_Cus_Del";
            this.btn_Cus_Del.Size = new System.Drawing.Size(92, 40);
            this.btn_Cus_Del.TabIndex = 10;
            this.btn_Cus_Del.Text = "Delete";
            this.btn_Cus_Del.UseVisualStyleBackColor = true;
            this.btn_Cus_Del.Click += new System.EventHandler(this.btn_Cus_Del_Click);
            // 
            // btn_Customer_Reset
            // 
            this.btn_Customer_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Reset.Location = new System.Drawing.Point(634, 165);
            this.btn_Customer_Reset.Name = "btn_Customer_Reset";
            this.btn_Customer_Reset.Size = new System.Drawing.Size(92, 40);
            this.btn_Customer_Reset.TabIndex = 11;
            this.btn_Customer_Reset.Text = "Reset";
            this.btn_Customer_Reset.UseVisualStyleBackColor = true;
            this.btn_Customer_Reset.Click += new System.EventHandler(this.btn_Customer_Reset_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(935, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 27);
            this.btn_Close.TabIndex = 29;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Search_Textbox
            // 
            this.Search_Textbox.Location = new System.Drawing.Point(815, 239);
            this.Search_Textbox.Name = "Search_Textbox";
            this.Search_Textbox.Size = new System.Drawing.Size(143, 22);
            this.Search_Textbox.TabIndex = 30;
            this.Search_Textbox.TextChanged += new System.EventHandler(this.SearchTextbox_Textchanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Search:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Textbox);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Customer_Reset);
            this.Controls.Add(this.btn_Cus_Del);
            this.Controls.Add(this.btn_Cus_Upd);
            this.Controls.Add(this.btn_Cus_Ins);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(customer_IdLabel);
            this.Controls.Add(this.customer_IdTextBox);
            this.Controls.Add(customer_NameLabel);
            this.Controls.Add(this.customer_NameTextBox);
            this.Controls.Add(phone_NOLabel);
            this.Controls.Add(this.phone_NOTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Medical_Store_ManagementDataSet medical_Store_ManagementDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Medical_Store_ManagementDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customer_IdTextBox;
        private System.Windows.Forms.TextBox customer_NameTextBox;
        private System.Windows.Forms.TextBox phone_NOTextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button btn_Cus_Ins;
        private System.Windows.Forms.Button btn_Cus_Upd;
        private System.Windows.Forms.Button btn_Cus_Del;
        private System.Windows.Forms.Button btn_Customer_Reset;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox Search_Textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}