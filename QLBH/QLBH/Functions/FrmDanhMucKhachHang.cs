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
    public partial class FrmDanhMucKhachHang : Form
    {
        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.qLBHDataSet.customers);
            // TODO: This line of code loads data into the 'qLBHDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.qLBHDataSet.customers);
            // TODO: This line of code loads data into the 'qLBHDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.qLBHDataSet.customers);

        }

        private void customersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBHDataSet);

        }
    }
}
