namespace QLBH.Functions
{
    partial class FrmDatHang
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
            System.Windows.Forms.Label employee_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatHang));
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label payment_typeLabel1;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label order_detail_statusLabel;
            System.Windows.Forms.Label date_allocatedLabel;
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new QLBH.QLBHDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employee_idTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.payment_typeTextBox1 = new System.Windows.Forms.TextBox();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_detailsTableAdapter = new QLBH.QLBHDataSetTableAdapters.order_detailsTableAdapter();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unit_priceTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.order_detail_statusTextBox = new System.Windows.Forms.TextBox();
            this.date_allocatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.order_detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            payment_typeLabel1 = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            order_detail_statusLabel = new System.Windows.Forms.Label();
            date_allocatedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.qLBHDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = this.order_detailsTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(930, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(13, 30);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(66, 13);
            employee_idLabel.TabIndex = 1;
            employee_idLabel.Text = "employee id:";
            // 
            // employee_idTextBox
            // 
            this.employee_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "employee_id", true));
            this.employee_idTextBox.Location = new System.Drawing.Point(85, 27);
            this.employee_idTextBox.Name = "employee_idTextBox";
            this.employee_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.employee_idTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(15, 56);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 3;
            customer_idLabel.Text = "customer id:";
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(85, 53);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_idTextBox.TabIndex = 4;
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(21, 83);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(58, 13);
            order_dateLabel.TabIndex = 5;
            order_dateLabel.Text = "order date:";
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_date", true));
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(85, 79);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_dateDateTimePicker.TabIndex = 6;
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(8, 109);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(71, 13);
            shipped_dateLabel.TabIndex = 7;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipped_date", true));
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(85, 105);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipped_dateDateTimePicker.TabIndex = 8;
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(21, 134);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(58, 13);
            ship_nameLabel.TabIndex = 9;
            ship_nameLabel.Text = "ship name:";
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.ship_nameTextBox.Location = new System.Drawing.Point(85, 131);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_nameTextBox.TabIndex = 10;
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(4, 160);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(75, 13);
            ship_address1Label.TabIndex = 11;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address1", true));
            this.ship_address1TextBox.Location = new System.Drawing.Point(85, 157);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address1TextBox.TabIndex = 12;
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(331, 26);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(75, 13);
            ship_address2Label.TabIndex = 13;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address2", true));
            this.ship_address2TextBox.Location = new System.Drawing.Point(412, 23);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address2TextBox.TabIndex = 14;
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(358, 52);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(48, 13);
            ship_cityLabel.TabIndex = 15;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.ship_cityTextBox.Location = new System.Drawing.Point(412, 49);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_cityTextBox.TabIndex = 16;
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(351, 79);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(55, 13);
            ship_stateLabel.TabIndex = 17;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_state", true));
            this.ship_stateTextBox.Location = new System.Drawing.Point(412, 76);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_stateTextBox.TabIndex = 18;
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(319, 105);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(87, 13);
            ship_postal_codeLabel.TabIndex = 19;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postal_code", true));
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(412, 102);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_postal_codeTextBox.TabIndex = 20;
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(339, 130);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(67, 13);
            ship_countryLabel.TabIndex = 21;
            ship_countryLabel.Text = "ship country:";
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.ship_countryTextBox.Location = new System.Drawing.Point(412, 127);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_countryTextBox.TabIndex = 22;
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(333, 156);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel.TabIndex = 23;
            payment_typeLabel.Text = "payment type:";
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox.Location = new System.Drawing.Point(412, 153);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.payment_typeTextBox.TabIndex = 24;
            // 
            // payment_typeLabel1
            // 
            payment_typeLabel1.AutoSize = true;
            payment_typeLabel1.Location = new System.Drawing.Point(577, 22);
            payment_typeLabel1.Name = "payment_typeLabel1";
            payment_typeLabel1.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel1.TabIndex = 25;
            payment_typeLabel1.Text = "payment type:";
            // 
            // payment_typeTextBox1
            // 
            this.payment_typeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox1.Location = new System.Drawing.Point(656, 17);
            this.payment_typeTextBox1.Name = "payment_typeTextBox1";
            this.payment_typeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.payment_typeTextBox1.TabIndex = 26;
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(596, 49);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(54, 13);
            paid_dateLabel.TabIndex = 27;
            paid_dateLabel.Text = "paid date:";
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(656, 43);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paid_dateDateTimePicker.TabIndex = 28;
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(585, 75);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(65, 13);
            order_statusLabel.TabIndex = 29;
            order_statusLabel.Text = "order status:";
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.order_statusTextBox.Location = new System.Drawing.Point(656, 72);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.order_statusTextBox.TabIndex = 30;
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.qLBHDataSet;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(15, 16);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(57, 13);
            product_idLabel.TabIndex = 31;
            product_idLabel.Text = "product id:";
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(18, 31);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_idTextBox.TabIndex = 32;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(138, 15);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(47, 13);
            quantityLabel.TabIndex = 33;
            quantityLabel.Text = "quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(141, 31);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 34;
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(262, 16);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(53, 13);
            unit_priceLabel.TabIndex = 35;
            unit_priceLabel.Text = "unit price:";
            // 
            // unit_priceTextBox
            // 
            this.unit_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "unit_price", true));
            this.unit_priceTextBox.Location = new System.Drawing.Point(265, 31);
            this.unit_priceTextBox.Name = "unit_priceTextBox";
            this.unit_priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unit_priceTextBox.TabIndex = 36;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(387, 15);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(50, 13);
            discountLabel.TabIndex = 37;
            discountLabel.Text = "discount:";
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(390, 31);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 38;
            // 
            // order_detail_statusLabel
            // 
            order_detail_statusLabel.AutoSize = true;
            order_detail_statusLabel.Location = new System.Drawing.Point(508, 15);
            order_detail_statusLabel.Name = "order_detail_statusLabel";
            order_detail_statusLabel.Size = new System.Drawing.Size(93, 13);
            order_detail_statusLabel.TabIndex = 39;
            order_detail_statusLabel.Text = "order detail status:";
            // 
            // order_detail_statusTextBox
            // 
            this.order_detail_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "order_detail_status", true));
            this.order_detail_statusTextBox.Location = new System.Drawing.Point(511, 31);
            this.order_detail_statusTextBox.Name = "order_detail_statusTextBox";
            this.order_detail_statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_detail_statusTextBox.TabIndex = 40;
            // 
            // date_allocatedLabel
            // 
            date_allocatedLabel.AutoSize = true;
            date_allocatedLabel.Location = new System.Drawing.Point(633, 15);
            date_allocatedLabel.Name = "date_allocatedLabel";
            date_allocatedLabel.Size = new System.Drawing.Size(77, 13);
            date_allocatedLabel.TabIndex = 41;
            date_allocatedLabel.Text = "date allocated:";
            // 
            // date_allocatedDateTimePicker
            // 
            this.date_allocatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "date_allocated", true));
            this.date_allocatedDateTimePicker.Location = new System.Drawing.Point(636, 31);
            this.date_allocatedDateTimePicker.Name = "date_allocatedDateTimePicker";
            this.date_allocatedDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.date_allocatedDateTimePicker.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Thêm SP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // order_detailsDataGridView
            // 
            this.order_detailsDataGridView.AutoGenerateColumns = false;
            this.order_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_detailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.order_detailsDataGridView.DataSource = this.order_detailsBindingSource;
            this.order_detailsDataGridView.Location = new System.Drawing.Point(18, 57);
            this.order_detailsDataGridView.Name = "order_detailsDataGridView";
            this.order_detailsDataGridView.Size = new System.Drawing.Size(866, 220);
            this.order_detailsDataGridView.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unit_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "unit_price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_detail_status";
            this.dataGridViewTextBoxColumn6.HeaderText = "order_detail_status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_allocated";
            this.dataGridViewTextBoxColumn7.HeaderText = "date_allocated";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Thêm đơn hàng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Sửa đơn hàng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Xóa đơn hàng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(734, 519);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(825, 519);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 45;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payment_typeTextBox1);
            this.groupBox1.Controls.Add(this.paid_dateDateTimePicker);
            this.groupBox1.Controls.Add(this.order_statusTextBox);
            this.groupBox1.Controls.Add(order_statusLabel);
            this.groupBox1.Controls.Add(paid_dateLabel);
            this.groupBox1.Controls.Add(payment_typeLabel1);
            this.groupBox1.Controls.Add(payment_typeLabel);
            this.groupBox1.Controls.Add(this.payment_typeTextBox);
            this.groupBox1.Controls.Add(ship_countryLabel);
            this.groupBox1.Controls.Add(this.ship_countryTextBox);
            this.groupBox1.Controls.Add(ship_postal_codeLabel);
            this.groupBox1.Controls.Add(this.ship_postal_codeTextBox);
            this.groupBox1.Controls.Add(ship_stateLabel);
            this.groupBox1.Controls.Add(this.ship_stateTextBox);
            this.groupBox1.Controls.Add(ship_cityLabel);
            this.groupBox1.Controls.Add(this.ship_cityTextBox);
            this.groupBox1.Controls.Add(ship_address2Label);
            this.groupBox1.Controls.Add(this.ship_address2TextBox);
            this.groupBox1.Controls.Add(ship_address1Label);
            this.groupBox1.Controls.Add(this.ship_address1TextBox);
            this.groupBox1.Controls.Add(ship_nameLabel);
            this.groupBox1.Controls.Add(this.ship_nameTextBox);
            this.groupBox1.Controls.Add(shipped_dateLabel);
            this.groupBox1.Controls.Add(this.shipped_dateDateTimePicker);
            this.groupBox1.Controls.Add(order_dateLabel);
            this.groupBox1.Controls.Add(this.order_dateDateTimePicker);
            this.groupBox1.Controls.Add(customer_idLabel);
            this.groupBox1.Controls.Add(this.customer_idTextBox);
            this.groupBox1.Controls.Add(employee_idLabel);
            this.groupBox1.Controls.Add(this.employee_idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 196);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.order_detailsDataGridView);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.date_allocatedDateTimePicker);
            this.groupBox2.Controls.Add(this.order_detail_statusTextBox);
            this.groupBox2.Controls.Add(this.discountTextBox);
            this.groupBox2.Controls.Add(this.unit_priceTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.product_idTextBox);
            this.groupBox2.Controls.Add(product_idLabel);
            this.groupBox2.Controls.Add(order_detail_statusLabel);
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(unit_priceLabel);
            this.groupBox2.Controls.Add(discountLabel);
            this.groupBox2.Controls.Add(date_allocatedLabel);
            this.groupBox2.Location = new System.Drawing.Point(18, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 283);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết đơn hàng";
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Name = "FrmDatHang";
            this.Text = "FrmDatHang";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private QLBHDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox employee_idTextBox;
        private QLBHDataSetTableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.TextBox payment_typeTextBox1;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unit_priceTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox order_detail_statusTextBox;
        private System.Windows.Forms.DateTimePicker date_allocatedDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView order_detailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}