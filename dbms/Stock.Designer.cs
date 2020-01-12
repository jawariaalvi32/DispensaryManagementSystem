namespace dbms
{
    partial class Stock
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
            System.Windows.Forms.Label medicine_idLabel;
            System.Windows.Forms.Label medicine_NameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label pack_sizeLabel;
            System.Windows.Forms.Label mgLabel;
            System.Windows.Forms.Label purposeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label expiry_DateLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.medical_Store_ManagementDataSet = new dbms.Medical_Store_ManagementDataSet();
            this.store_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.store_StockTableAdapter = new dbms.Medical_Store_ManagementDataSetTableAdapters.Store_StockTableAdapter();
            this.tableAdapterManager = new dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager();
            this.medicine_idTextBox = new System.Windows.Forms.TextBox();
            this.medicine_NameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.pack_sizeTextBox = new System.Windows.Forms.TextBox();
            this.mgTextBox = new System.Windows.Forms.TextBox();
            this.purposeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.expiry_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.company_NameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.store_StockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.btn_INS = new System.Windows.Forms.Button();
            this.btn_Upd = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Stock_Reset = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            medicine_idLabel = new System.Windows.Forms.Label();
            medicine_NameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            pack_sizeLabel = new System.Windows.Forms.Label();
            mgLabel = new System.Windows.Forms.Label();
            purposeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            expiry_DateLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_StockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_StockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicine_idLabel
            // 
            medicine_idLabel.AutoSize = true;
            medicine_idLabel.BackColor = System.Drawing.Color.Transparent;
            medicine_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medicine_idLabel.Location = new System.Drawing.Point(94, 48);
            medicine_idLabel.Name = "medicine_idLabel";
            medicine_idLabel.Size = new System.Drawing.Size(129, 25);
            medicine_idLabel.TabIndex = 1;
            medicine_idLabel.Text = "Medicine id:";
            // 
            // medicine_NameLabel
            // 
            medicine_NameLabel.AutoSize = true;
            medicine_NameLabel.BackColor = System.Drawing.Color.Transparent;
            medicine_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medicine_NameLabel.Location = new System.Drawing.Point(95, 84);
            medicine_NameLabel.Name = "medicine_NameLabel";
            medicine_NameLabel.Size = new System.Drawing.Size(168, 25);
            medicine_NameLabel.TabIndex = 3;
            medicine_NameLabel.Text = "Medicine Name:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = System.Drawing.Color.Transparent;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(94, 122);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(100, 25);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Quantity:";
            // 
            // pack_sizeLabel
            // 
            pack_sizeLabel.AutoSize = true;
            pack_sizeLabel.BackColor = System.Drawing.Color.Transparent;
            pack_sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pack_sizeLabel.Location = new System.Drawing.Point(94, 156);
            pack_sizeLabel.Name = "pack_sizeLabel";
            pack_sizeLabel.Size = new System.Drawing.Size(112, 25);
            pack_sizeLabel.TabIndex = 7;
            pack_sizeLabel.Text = "Pack size:";
            // 
            // mgLabel
            // 
            mgLabel.AutoSize = true;
            mgLabel.BackColor = System.Drawing.Color.Transparent;
            mgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mgLabel.Location = new System.Drawing.Point(94, 196);
            mgLabel.Name = "mgLabel";
            mgLabel.Size = new System.Drawing.Size(48, 25);
            mgLabel.TabIndex = 9;
            mgLabel.Text = "mg:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.BackColor = System.Drawing.Color.Transparent;
            purposeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purposeLabel.Location = new System.Drawing.Point(553, 47);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new System.Drawing.Size(99, 25);
            purposeLabel.TabIndex = 11;
            purposeLabel.Text = "Purpose:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(553, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 25);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            // 
            // expiry_DateLabel
            // 
            expiry_DateLabel.AutoSize = true;
            expiry_DateLabel.BackColor = System.Drawing.Color.Transparent;
            expiry_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expiry_DateLabel.Location = new System.Drawing.Point(553, 114);
            expiry_DateLabel.Name = "expiry_DateLabel";
            expiry_DateLabel.Size = new System.Drawing.Size(130, 25);
            expiry_DateLabel.TabIndex = 15;
            expiry_DateLabel.Text = "Expiry Date:";
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.BackColor = System.Drawing.Color.Transparent;
            company_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            company_NameLabel.Location = new System.Drawing.Point(553, 151);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(173, 25);
            company_NameLabel.TabIndex = 17;
            company_NameLabel.Text = "Company Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = System.Drawing.Color.Transparent;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(553, 184);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(107, 25);
            categoryLabel.TabIndex = 19;
            categoryLabel.Text = "Category:";
            // 
            // medical_Store_ManagementDataSet
            // 
            this.medical_Store_ManagementDataSet.DataSetName = "Medical_Store_ManagementDataSet";
            this.medical_Store_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // store_StockBindingSource
            // 
            this.store_StockBindingSource.DataMember = "Store_Stock";
            this.store_StockBindingSource.DataSource = this.medical_Store_ManagementDataSet;
            // 
            // store_StockTableAdapter
            // 
            this.store_StockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_BillTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Store_StockTableAdapter = this.store_StockTableAdapter;
            this.tableAdapterManager.UpdateOrder = dbms.Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicine_idTextBox
            // 
            this.medicine_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Medicine_id", true));
            this.medicine_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_idTextBox.Location = new System.Drawing.Point(273, 40);
            this.medicine_idTextBox.Name = "medicine_idTextBox";
            this.medicine_idTextBox.Size = new System.Drawing.Size(241, 27);
            this.medicine_idTextBox.TabIndex = 2;
            // 
            // medicine_NameTextBox
            // 
            this.medicine_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Medicine_Name", true));
            this.medicine_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_NameTextBox.Location = new System.Drawing.Point(273, 78);
            this.medicine_NameTextBox.Name = "medicine_NameTextBox";
            this.medicine_NameTextBox.Size = new System.Drawing.Size(241, 27);
            this.medicine_NameTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Quantity", true));
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(273, 115);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(241, 27);
            this.quantityTextBox.TabIndex = 6;
            // 
            // pack_sizeTextBox
            // 
            this.pack_sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Pack_size", true));
            this.pack_sizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pack_sizeTextBox.Location = new System.Drawing.Point(273, 155);
            this.pack_sizeTextBox.Name = "pack_sizeTextBox";
            this.pack_sizeTextBox.Size = new System.Drawing.Size(241, 27);
            this.pack_sizeTextBox.TabIndex = 8;
            // 
            // mgTextBox
            // 
            this.mgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "mg", true));
            this.mgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgTextBox.Location = new System.Drawing.Point(273, 195);
            this.mgTextBox.Name = "mgTextBox";
            this.mgTextBox.Size = new System.Drawing.Size(241, 27);
            this.mgTextBox.TabIndex = 10;
            // 
            // purposeTextBox
            // 
            this.purposeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Purpose", true));
            this.purposeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purposeTextBox.Location = new System.Drawing.Point(752, 44);
            this.purposeTextBox.Name = "purposeTextBox";
            this.purposeTextBox.Size = new System.Drawing.Size(247, 27);
            this.purposeTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(752, 78);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(247, 27);
            this.priceTextBox.TabIndex = 14;
            // 
            // expiry_DateDateTimePicker
            // 
            this.expiry_DateDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.expiry_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.store_StockBindingSource, "Expiry_Date", true));
            this.expiry_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiry_DateDateTimePicker.Location = new System.Drawing.Point(752, 114);
            this.expiry_DateDateTimePicker.Name = "expiry_DateDateTimePicker";
            this.expiry_DateDateTimePicker.Size = new System.Drawing.Size(247, 27);
            this.expiry_DateDateTimePicker.TabIndex = 16;
            // 
            // company_NameTextBox
            // 
            this.company_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "Company_Name", true));
            this.company_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_NameTextBox.Location = new System.Drawing.Point(752, 150);
            this.company_NameTextBox.Name = "company_NameTextBox";
            this.company_NameTextBox.Size = new System.Drawing.Size(247, 27);
            this.company_NameTextBox.TabIndex = 18;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_StockBindingSource, "category", true));
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(752, 185);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(247, 27);
            this.categoryTextBox.TabIndex = 20;
            // 
            // store_StockDataGridView
            // 
            this.store_StockDataGridView.AutoGenerateColumns = false;
            this.store_StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.store_StockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.store_StockDataGridView.DataSource = this.store_StockBindingSource;
            this.store_StockDataGridView.Location = new System.Drawing.Point(51, 383);
            this.store_StockDataGridView.Name = "store_StockDataGridView";
            this.store_StockDataGridView.RowTemplate.Height = 24;
            this.store_StockDataGridView.Size = new System.Drawing.Size(1053, 232);
            this.store_StockDataGridView.TabIndex = 21;
            this.store_StockDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.store_StockDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Medicine_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Medicine_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Medicine_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Medicine_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pack_size";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pack_size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mg";
            this.dataGridViewTextBoxColumn5.HeaderText = "mg";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Purpose";
            this.dataGridViewTextBoxColumn6.HeaderText = "Purpose";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Expiry_Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Expiry_Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Company_Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Company_Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn10.HeaderText = "category";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.Location = new System.Drawing.Point(914, 341);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(157, 27);
            this.SearchTextbox.TabIndex = 26;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.Searchtextbox_Textchange);
            // 
            // btn_INS
            // 
            this.btn_INS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INS.Location = new System.Drawing.Point(523, 252);
            this.btn_INS.Name = "btn_INS";
            this.btn_INS.Size = new System.Drawing.Size(114, 39);
            this.btn_INS.TabIndex = 22;
            this.btn_INS.Text = "Insert";
            this.btn_INS.UseVisualStyleBackColor = true;
            this.btn_INS.Click += new System.EventHandler(this.btn_INS_Click);
            // 
            // btn_Upd
            // 
            this.btn_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upd.Location = new System.Drawing.Point(662, 252);
            this.btn_Upd.Name = "btn_Upd";
            this.btn_Upd.Size = new System.Drawing.Size(114, 39);
            this.btn_Upd.TabIndex = 23;
            this.btn_Upd.Text = "Update";
            this.btn_Upd.UseVisualStyleBackColor = true;
            this.btn_Upd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(799, 252);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(114, 39);
            this.btn_Del.TabIndex = 24;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Stock_Reset
            // 
            this.btn_Stock_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock_Reset.Location = new System.Drawing.Point(926, 252);
            this.btn_Stock_Reset.Name = "btn_Stock_Reset";
            this.btn_Stock_Reset.Size = new System.Drawing.Size(114, 39);
            this.btn_Stock_Reset.TabIndex = 25;
            this.btn_Stock_Reset.Text = "Reset";
            this.btn_Stock_Reset.UseVisualStyleBackColor = true;
            this.btn_Stock_Reset.Click += new System.EventHandler(this.btn_Stock_Reset_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(1064, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 27);
            this.btn_Close.TabIndex = 28;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(794, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search:";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.btn_Stock_Reset);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Upd);
            this.Controls.Add(this.btn_INS);
            this.Controls.Add(this.store_StockDataGridView);
            this.Controls.Add(medicine_idLabel);
            this.Controls.Add(this.medicine_idTextBox);
            this.Controls.Add(medicine_NameLabel);
            this.Controls.Add(this.medicine_NameTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(pack_sizeLabel);
            this.Controls.Add(this.pack_sizeTextBox);
            this.Controls.Add(mgLabel);
            this.Controls.Add(this.mgTextBox);
            this.Controls.Add(purposeLabel);
            this.Controls.Add(this.purposeTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(expiry_DateLabel);
            this.Controls.Add(this.expiry_DateDateTimePicker);
            this.Controls.Add(company_NameLabel);
            this.Controls.Add(this.company_NameTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medical_Store_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_StockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_StockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Medical_Store_ManagementDataSet medical_Store_ManagementDataSet;
        private System.Windows.Forms.BindingSource store_StockBindingSource;
        private Medical_Store_ManagementDataSetTableAdapters.Store_StockTableAdapter store_StockTableAdapter;
        private Medical_Store_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox medicine_idTextBox;
        private System.Windows.Forms.TextBox medicine_NameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox pack_sizeTextBox;
        private System.Windows.Forms.TextBox mgTextBox;
        private System.Windows.Forms.TextBox purposeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker expiry_DateDateTimePicker;
        private System.Windows.Forms.TextBox company_NameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DataGridView store_StockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button btn_INS;
        private System.Windows.Forms.Button btn_Upd;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Stock_Reset;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
    }
}