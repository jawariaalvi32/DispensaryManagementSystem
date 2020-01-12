namespace dbms
{
    partial class Bill
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
            System.Windows.Forms.Label med_IDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label total_AmountLabel;
            System.Windows.Forms.Label paid_amountLabel;
            System.Windows.Forms.Label return_AmountLabel;
            System.Windows.Forms.Label cus_IDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.med_IDTextBox = new System.Windows.Forms.TextBox();
            this.customer_BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_Store_ManagementDataSet = new dbms.Medical_Store_ManagementDataSet();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.total_AmountTextBox = new System.Windows.Forms.TextBox();
            this.paid_amountTextBox = new System.Windows.Forms.TextBox();
            this.return_AmountTextBox = new System.Windows.Forms.TextBox();
            this.btn_Bil_Ins = new System.Windows.Forms.Button();
            this.btn_bil_Upd = new System.Windows.Forms.Button();
            this.Btn_bil_Del = new System.Windows.Forms.Button();
            this.textBox_Grand_Tot = new System.Windows.Forms.TextBox();
            this.btn_Grand_Total = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.cus_IDTextBox = new System.Windows.Forms.TextBox();
            this.btn_Bill_Reset = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.customer_BillTableAdapter = new dbms.Medical_Store_ManagementDataSetTableAdapters.Customer_BillTableAdapter();
            this.tableAdapterManager = new dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new dbms.Medical_Store_ManagementDataSetTableAdapters.CustomerTableAdapter();
            this.medical_Store_ManagementDataSet1 = new dbms.Medical_Store_ManagementDataSet1();
            this.customer_BillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customer_BillTableAdapter1 = new dbms.Medical_Store_ManagementDataSet1TableAdapters.Customer_BillTableAdapter();
            this.tableAdapterManager1 = new dbms.Medical_Store_ManagementDataSet1TableAdapters.TableAdapterManager();
            this.customer_BillDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RET_AMOUNT = new System.Windows.Forms.Button();
            med_IDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            total_AmountLabel = new System.Windows.Forms.Label();
            paid_amountLabel = new System.Windows.Forms.Label();
            return_AmountLabel = new System.Windows.Forms.Label();
            cus_IDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customer_BillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_BillBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_BillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // med_IDLabel
            // 
            med_IDLabel.AutoSize = true;
            med_IDLabel.BackColor = System.Drawing.Color.Transparent;
            med_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            med_IDLabel.Location = new System.Drawing.Point(42, 77);
            med_IDLabel.Name = "med_IDLabel";
            med_IDLabel.Size = new System.Drawing.Size(88, 25);
            med_IDLabel.TabIndex = 3;
            med_IDLabel.Text = "Med ID:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = System.Drawing.Color.Transparent;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(42, 105);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(100, 25);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Quantity:";
            // 
            // total_AmountLabel
            // 
            total_AmountLabel.AutoSize = true;
            total_AmountLabel.BackColor = System.Drawing.Color.Transparent;
            total_AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_AmountLabel.Location = new System.Drawing.Point(42, 133);
            total_AmountLabel.Name = "total_AmountLabel";
            total_AmountLabel.Size = new System.Drawing.Size(148, 25);
            total_AmountLabel.TabIndex = 7;
            total_AmountLabel.Text = "Total Amount:";
            // 
            // paid_amountLabel
            // 
            paid_amountLabel.AutoSize = true;
            paid_amountLabel.BackColor = System.Drawing.Color.Transparent;
            paid_amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paid_amountLabel.Location = new System.Drawing.Point(425, 477);
            paid_amountLabel.Name = "paid_amountLabel";
            paid_amountLabel.Size = new System.Drawing.Size(139, 25);
            paid_amountLabel.TabIndex = 9;
            paid_amountLabel.Text = "Paid amount:";
            // 
            // return_AmountLabel
            // 
            return_AmountLabel.AutoSize = true;
            return_AmountLabel.BackColor = System.Drawing.Color.Transparent;
            return_AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            return_AmountLabel.Location = new System.Drawing.Point(402, 511);
            return_AmountLabel.Name = "return_AmountLabel";
            return_AmountLabel.Size = new System.Drawing.Size(162, 25);
            return_AmountLabel.TabIndex = 11;
            return_AmountLabel.Text = "Return Amount:";
            // 
            // cus_IDLabel1
            // 
            cus_IDLabel1.AutoSize = true;
            cus_IDLabel1.BackColor = System.Drawing.Color.Transparent;
            cus_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cus_IDLabel1.Location = new System.Drawing.Point(45, 52);
            cus_IDLabel1.Name = "cus_IDLabel1";
            cus_IDLabel1.Size = new System.Drawing.Size(85, 25);
            cus_IDLabel1.TabIndex = 20;
            cus_IDLabel1.Text = "Cus ID:";
            // 
            // med_IDTextBox
            // 
            this.med_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_BillBindingSource, "Med_ID", true));
            this.med_IDTextBox.Location = new System.Drawing.Point(213, 80);
            this.med_IDTextBox.Name = "med_IDTextBox";
            this.med_IDTextBox.Size = new System.Drawing.Size(151, 22);
            this.med_IDTextBox.TabIndex = 4;
            // 
            // customer_BillBindingSource
            // 
            this.customer_BillBindingSource.DataMember = "Customer_Bill";
            this.customer_BillBindingSource.DataSource = this.medical_Store_ManagementDataSet;
            // 
            // medical_Store_ManagementDataSet
            // 
            this.medical_Store_ManagementDataSet.DataSetName = "Medical_Store_ManagementDataSet";
            this.medical_Store_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_BillBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(213, 108);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(151, 22);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // total_AmountTextBox
            // 
            this.total_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_BillBindingSource, "Total_Amount", true));
            this.total_AmountTextBox.Location = new System.Drawing.Point(213, 136);
            this.total_AmountTextBox.Name = "total_AmountTextBox";
            this.total_AmountTextBox.Size = new System.Drawing.Size(151, 22);
            this.total_AmountTextBox.TabIndex = 8;
            // 
            // paid_amountTextBox
            // 
            this.paid_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_BillBindingSource, "Paid_amount", true));
            this.paid_amountTextBox.Location = new System.Drawing.Point(596, 483);
            this.paid_amountTextBox.Name = "paid_amountTextBox";
            this.paid_amountTextBox.Size = new System.Drawing.Size(125, 22);
            this.paid_amountTextBox.TabIndex = 10;
            // 
            // return_AmountTextBox
            // 
            this.return_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_BillBindingSource, "Return_Amount", true));
            this.return_AmountTextBox.Location = new System.Drawing.Point(596, 511);
            this.return_AmountTextBox.Name = "return_AmountTextBox";
            this.return_AmountTextBox.Size = new System.Drawing.Size(125, 22);
            this.return_AmountTextBox.TabIndex = 12;
            // 
            // btn_Bil_Ins
            // 
            this.btn_Bil_Ins.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Bil_Ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bil_Ins.Location = new System.Drawing.Point(510, 22);
            this.btn_Bil_Ins.Name = "btn_Bil_Ins";
            this.btn_Bil_Ins.Size = new System.Drawing.Size(114, 34);
            this.btn_Bil_Ins.TabIndex = 14;
            this.btn_Bil_Ins.Text = "Insert";
            this.btn_Bil_Ins.UseVisualStyleBackColor = false;
            this.btn_Bil_Ins.Click += new System.EventHandler(this.btn_Bil_Ins_Click);
            // 
            // btn_bil_Upd
            // 
            this.btn_bil_Upd.BackColor = System.Drawing.SystemColors.Control;
            this.btn_bil_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bil_Upd.Location = new System.Drawing.Point(510, 62);
            this.btn_bil_Upd.Name = "btn_bil_Upd";
            this.btn_bil_Upd.Size = new System.Drawing.Size(114, 34);
            this.btn_bil_Upd.TabIndex = 15;
            this.btn_bil_Upd.Text = "Update";
            this.btn_bil_Upd.UseVisualStyleBackColor = false;
            this.btn_bil_Upd.Click += new System.EventHandler(this.btn_bil_Upd_Click);
            // 
            // Btn_bil_Del
            // 
            this.Btn_bil_Del.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_bil_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_bil_Del.Location = new System.Drawing.Point(510, 105);
            this.Btn_bil_Del.Name = "Btn_bil_Del";
            this.Btn_bil_Del.Size = new System.Drawing.Size(114, 34);
            this.Btn_bil_Del.TabIndex = 16;
            this.Btn_bil_Del.Text = "Delete";
            this.Btn_bil_Del.UseVisualStyleBackColor = false;
            this.Btn_bil_Del.Click += new System.EventHandler(this.Btn_bil_Del_Click);
            // 
            // textBox_Grand_Tot
            // 
            this.textBox_Grand_Tot.Location = new System.Drawing.Point(85, 507);
            this.textBox_Grand_Tot.Name = "textBox_Grand_Tot";
            this.textBox_Grand_Tot.Size = new System.Drawing.Size(151, 22);
            this.textBox_Grand_Tot.TabIndex = 17;
            // 
            // btn_Grand_Total
            // 
            this.btn_Grand_Total.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Grand_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grand_Total.Location = new System.Drawing.Point(245, 483);
            this.btn_Grand_Total.Name = "btn_Grand_Total";
            this.btn_Grand_Total.Size = new System.Drawing.Size(117, 65);
            this.btn_Grand_Total.TabIndex = 18;
            this.btn_Grand_Total.Text = "Grand Total";
            this.btn_Grand_Total.UseVisualStyleBackColor = false;
            this.btn_Grand_Total.Click += new System.EventHandler(this.btn_Grand_Total_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(779, 481);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(136, 76);
            this.btn_Report.TabIndex = 20;
            this.btn_Report.Text = "Generate Bill";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // cus_IDTextBox
            // 
            this.cus_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_BillBindingSource, "Cus_ID", true));
            this.cus_IDTextBox.Location = new System.Drawing.Point(213, 52);
            this.cus_IDTextBox.Name = "cus_IDTextBox";
            this.cus_IDTextBox.Size = new System.Drawing.Size(151, 22);
            this.cus_IDTextBox.TabIndex = 21;
            // 
            // btn_Bill_Reset
            // 
            this.btn_Bill_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Bill_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill_Reset.Location = new System.Drawing.Point(510, 145);
            this.btn_Bill_Reset.Name = "btn_Bill_Reset";
            this.btn_Bill_Reset.Size = new System.Drawing.Size(114, 34);
            this.btn_Bill_Reset.TabIndex = 22;
            this.btn_Bill_Reset.Text = "Reset";
            this.btn_Bill_Reset.UseVisualStyleBackColor = false;
            this.btn_Bill_Reset.Click += new System.EventHandler(this.btn_Bill_Reset_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(930, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 27);
            this.btn_Close.TabIndex = 29;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // customer_BillTableAdapter
            // 
            this.customer_BillTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_BillTableAdapter = this.customer_BillTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Store_StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // medical_Store_ManagementDataSet1
            // 
            this.medical_Store_ManagementDataSet1.DataSetName = "Medical_Store_ManagementDataSet1";
            this.medical_Store_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_BillBindingSource1
            // 
            this.customer_BillBindingSource1.DataMember = "Customer_Bill";
            this.customer_BillBindingSource1.DataSource = this.medical_Store_ManagementDataSet1;
            // 
            // customer_BillTableAdapter1
            // 
            this.customer_BillTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Customer_BillTableAdapter = this.customer_BillTableAdapter1;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.Store_StockTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = dbms.Medical_Store_ManagementDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customer_BillDataGridView
            // 
            this.customer_BillDataGridView.AutoGenerateColumns = false;
            this.customer_BillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_BillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Quantity,
            this.dataGridViewTextBoxColumn4});
            this.customer_BillDataGridView.DataSource = this.customer_BillBindingSource1;
            this.customer_BillDataGridView.Location = new System.Drawing.Point(331, 212);
            this.customer_BillDataGridView.Name = "customer_BillDataGridView";
            this.customer_BillDataGridView.RowTemplate.Height = 24;
            this.customer_BillDataGridView.Size = new System.Drawing.Size(450, 220);
            this.customer_BillDataGridView.TabIndex = 29;
            this.customer_BillDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customer_BillDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cus_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cus_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Med_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Med_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total_Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total_Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // RET_AMOUNT
            // 
            this.RET_AMOUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RET_AMOUNT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RET_AMOUNT.Location = new System.Drawing.Point(515, 542);
            this.RET_AMOUNT.Name = "RET_AMOUNT";
            this.RET_AMOUNT.Size = new System.Drawing.Size(206, 33);
            this.RET_AMOUNT.TabIndex = 30;
            this.RET_AMOUNT.Text = "Return Amount";
            this.RET_AMOUNT.UseVisualStyleBackColor = true;
            this.RET_AMOUNT.Click += new System.EventHandler(this.RET_AMOUNT_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 587);
            this.Controls.Add(this.RET_AMOUNT);
            this.Controls.Add(this.customer_BillDataGridView);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Bill_Reset);
            this.Controls.Add(cus_IDLabel1);
            this.Controls.Add(this.cus_IDTextBox);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Grand_Total);
            this.Controls.Add(this.textBox_Grand_Tot);
            this.Controls.Add(this.Btn_bil_Del);
            this.Controls.Add(this.btn_bil_Upd);
            this.Controls.Add(this.btn_Bil_Ins);
            this.Controls.Add(med_IDLabel);
            this.Controls.Add(this.med_IDTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(total_AmountLabel);
            this.Controls.Add(this.total_AmountTextBox);
            this.Controls.Add(paid_amountLabel);
            this.Controls.Add(this.paid_amountTextBox);
            this.Controls.Add(return_AmountLabel);
            this.Controls.Add(this.return_AmountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_BillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_BillBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_BillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Medical_Store_ManagementDataSet medical_Store_ManagementDataSet;
        private System.Windows.Forms.BindingSource customer_BillBindingSource;
        private Medical_Store_ManagementDataSetTableAdapters.Customer_BillTableAdapter customer_BillTableAdapter;
        private Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox med_IDTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox total_AmountTextBox;
        private System.Windows.Forms.TextBox paid_amountTextBox;
        private System.Windows.Forms.TextBox return_AmountTextBox;
        private System.Windows.Forms.Button btn_Bil_Ins;
        private System.Windows.Forms.Button btn_bil_Upd;
        private System.Windows.Forms.Button Btn_bil_Del;
        private System.Windows.Forms.TextBox textBox_Grand_Tot;
        private System.Windows.Forms.Button btn_Grand_Total;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Medical_Store_ManagementDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox cus_IDTextBox;
        private System.Windows.Forms.Button btn_Bill_Reset;
        private System.Windows.Forms.Button btn_Close;
        private Medical_Store_ManagementDataSet1 medical_Store_ManagementDataSet1;
        private System.Windows.Forms.BindingSource customer_BillBindingSource1;
        private Medical_Store_ManagementDataSet1TableAdapters.Customer_BillTableAdapter customer_BillTableAdapter1;
        private Medical_Store_ManagementDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView customer_BillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button RET_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}