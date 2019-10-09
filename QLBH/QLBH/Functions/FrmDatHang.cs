using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDatHang : Form
    {
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.qLBHDataSet.order_details);
            // TODO: This line of code loads data into the 'qLBHDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.qLBHDataSet.orders);

        }
    }
}
