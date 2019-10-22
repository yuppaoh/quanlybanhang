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
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label employee_idLabel1;
            this.qLBHDataSet = new QLBH.QLBHDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.order_detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unit_priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.ordersTableAdapter = new QLBH.QLBHDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new QLBH.QLBHDataSetTableAdapters.TableAdapterManager();
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
            quantityLabel1 = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            employee_idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_priceNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(24, 56);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 3;
            customer_idLabel.Text = "customer id:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(30, 83);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(58, 13);
            order_dateLabel.TabIndex = 5;
            order_dateLabel.Text = "order date:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(17, 109);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(71, 13);
            shipped_dateLabel.TabIndex = 7;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(30, 134);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(58, 13);
            ship_nameLabel.TabIndex = 9;
            ship_nameLabel.Text = "ship name:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(13, 160);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(75, 13);
            ship_address1Label.TabIndex = 11;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(316, 29);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(75, 13);
            ship_address2Label.TabIndex = 13;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(343, 52);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(48, 13);
            ship_cityLabel.TabIndex = 15;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(336, 79);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(55, 13);
            ship_stateLabel.TabIndex = 17;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(304, 105);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(87, 13);
            ship_postal_codeLabel.TabIndex = 19;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(324, 130);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(67, 13);
            ship_countryLabel.TabIndex = 21;
            ship_countryLabel.Text = "ship country:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(318, 156);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel.TabIndex = 23;
            payment_typeLabel.Text = "payment type:";
            // 
            // payment_typeLabel1
            // 
            payment_typeLabel1.AutoSize = true;
            payment_typeLabel1.Location = new System.Drawing.Point(503, 29);
            payment_typeLabel1.Name = "payment_typeLabel1";
            payment_typeLabel1.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel1.TabIndex = 25;
            payment_typeLabel1.Text = "payment type:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(525, 56);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(54, 13);
            paid_dateLabel.TabIndex = 27;
            paid_dateLabel.Text = "paid date:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(514, 83);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(65, 13);
            order_statusLabel.TabIndex = 29;
            order_statusLabel.Text = "order status:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(16, 28);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(57, 13);
            product_idLabel.TabIndex = 31;
            product_idLabel.Text = "product id:";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Location = new System.Drawing.Point(174, 28);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(47, 13);
            quantityLabel1.TabIndex = 44;
            quantityLabel1.Text = "quantity:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(326, 28);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(53, 13);
            unit_priceLabel.TabIndex = 45;
            unit_priceLabel.Text = "unit price:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(502, 28);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(50, 13);
            discountLabel.TabIndex = 46;
            discountLabel.Text = "discount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 29;
            label1.Text = "From date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 31;
            label2.Text = "To date:";
            // 
            // employee_idLabel1
            // 
            employee_idLabel1.AutoSize = true;
            employee_idLabel1.Location = new System.Drawing.Point(22, 29);
            employee_idLabel1.Name = "employee_idLabel1";
            employee_idLabel1.Size = new System.Drawing.Size(66, 13);
            employee_idLabel1.TabIndex = 30;
            employee_idLabel1.Text = "employee id:";
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
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(94, 53);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_idTextBox.TabIndex = 4;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_date", true));
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(94, 79);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_dateDateTimePicker.TabIndex = 6;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipped_date", true));
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(94, 105);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipped_dateDateTimePicker.TabIndex = 8;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.ship_nameTextBox.Location = new System.Drawing.Point(94, 131);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_nameTextBox.TabIndex = 10;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address1", true));
            this.ship_address1TextBox.Location = new System.Drawing.Point(94, 157);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address1TextBox.TabIndex = 12;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address2", true));
            this.ship_address2TextBox.Location = new System.Drawing.Point(397, 26);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address2TextBox.TabIndex = 14;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.ship_cityTextBox.Location = new System.Drawing.Point(397, 53);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_cityTextBox.TabIndex = 16;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_state", true));
            this.ship_stateTextBox.Location = new System.Drawing.Point(397, 79);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_stateTextBox.TabIndex = 18;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postal_code", true));
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(397, 105);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_postal_codeTextBox.TabIndex = 20;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.ship_countryTextBox.Location = new System.Drawing.Point(397, 131);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_countryTextBox.TabIndex = 22;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox.Location = new System.Drawing.Point(397, 157);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.payment_typeTextBox.TabIndex = 24;
            // 
            // payment_typeTextBox1
            // 
            this.payment_typeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox1.Location = new System.Drawing.Point(581, 26);
            this.payment_typeTextBox1.Name = "payment_typeTextBox1";
            this.payment_typeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.payment_typeTextBox1.TabIndex = 26;
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(581, 53);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paid_dateDateTimePicker.TabIndex = 28;
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.order_statusTextBox.Location = new System.Drawing.Point(581, 79);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.order_statusTextBox.TabIndex = 30;
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.Location = new System.Drawing.Point(71, 25);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_idTextBox.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Thêm SP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // order_detailsDataGridView
            // 
            this.order_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_detailsDataGridView.Location = new System.Drawing.Point(33, 56);
            this.order_detailsDataGridView.Name = "order_detailsDataGridView";
            this.order_detailsDataGridView.Size = new System.Drawing.Size(765, 209);
            this.order_detailsDataGridView.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Thêm đơn hàng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Sửa đơn hàng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 538);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Xóa đơn hàng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(734, 538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(825, 538);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(employee_idLabel1);
            this.groupBox1.Controls.Add(this.cbbEmployee);
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
            this.groupBox1.Location = new System.Drawing.Point(287, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 197);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "employee_id", true));
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(94, 26);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbbEmployee.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(discountLabel);
            this.groupBox2.Controls.Add(this.discountNumericUpDown);
            this.groupBox2.Controls.Add(unit_priceLabel);
            this.groupBox2.Controls.Add(this.unit_priceNumericUpDown);
            this.groupBox2.Controls.Add(quantityLabel1);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.order_detailsDataGridView);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.product_idTextBox);
            this.groupBox2.Controls.Add(product_idLabel);
            this.groupBox2.Location = new System.Drawing.Point(287, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 273);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết đơn hàng";
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "discount", true));
            this.discountNumericUpDown.Location = new System.Drawing.Point(552, 26);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.discountNumericUpDown.TabIndex = 47;
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.qLBHDataSet;
            // 
            // unit_priceNumericUpDown
            // 
            this.unit_priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "unit_price", true));
            this.unit_priceNumericUpDown.Location = new System.Drawing.Point(378, 26);
            this.unit_priceNumericUpDown.Name = "unit_priceNumericUpDown";
            this.unit_priceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unit_priceNumericUpDown.TabIndex = 46;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(221, 25);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadOrder);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.dtp2);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.dtp1);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 493);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đơn hàng";
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Location = new System.Drawing.Point(9, 117);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(251, 23);
            this.btnLoadOrder.TabIndex = 34;
            this.btnLoadOrder.Text = "Lấy danh sách đơn hàng";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderdateDataGridViewTextBoxColumn,
            this.shippeddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(251, 332);
            this.dataGridView1.TabIndex = 33;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // shippeddateDataGridViewTextBoxColumn
            // 
            this.shippeddateDataGridViewTextBoxColumn.DataPropertyName = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.HeaderText = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.Name = "shippeddateDataGridViewTextBoxColumn";
            // 
            // dtp2
            // 
            this.dtp2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.dtp2.Location = new System.Drawing.Point(6, 72);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 32;
            // 
            // dtp1
            // 
            this.dtp1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.dtp1.Location = new System.Drawing.Point(6, 33);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 30;
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
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "FrmDatHang";
            this.Text = "FrmDatHang";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_priceNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
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
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView order_detailsDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown unit_priceNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbbEmployee;
        private QLBHDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private QLBHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}