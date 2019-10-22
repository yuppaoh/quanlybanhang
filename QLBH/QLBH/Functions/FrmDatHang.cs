using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDatHang : Form
    {
        string connectionString = QLBH.Properties.Settings.Default.QLBHConnectionString;
        SortedDictionary<int, string> listEmployees = new SortedDictionary<int, string>();
        public FrmDatHang()
        {
            InitializeComponent();
        }


        public void Load_order()
        {
            string fromDate = dtp1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string toDate = dtp2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            // Tạo câu lệnh để thực thi đến database
            string queryStringOrder = string.Format("SELECT order_date, shipped_date FROM orders where order_date BETWEEN '{0}' and '{1}'", fromDate, toDate);

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryStringOrder, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(qLBHDataSet.orders);

                        // Hiển thị dữ liệu
                        //configsBindingSource.DataSource = null;
                        ordersBindingSource.DataSource = qLBHDataSet.orders;
                        

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }

                }
            }


        }

        public void Load_order_details()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM order_details";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(qLBHDataSet.customers);

                        // Hiển thị dữ liệu
                        //configsBindingSource.DataSource = null;
                        order_detailsBindingSource.DataSource = qLBHDataSet.order_details;
                        order_detailsDataGridView.DataSource = order_detailsBindingSource;
                        order_detailsDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        public void LoadDanhSachNhanVien()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM employees");

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(qLBHDataSet.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in qLBHDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployees.Add(key, value);
                        }
                        cbbEmployee.DataSource = new BindingSource(listEmployees, null);
                        cbbEmployee.DisplayMember = "Value";
                        cbbEmployee.ValueMember = "Key";

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.customers' table. You can move, or remove it, as needed.
            Load_order_details();
            LoadDanhSachNhanVien();


        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employee_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            Load_order();
            
        }
    }
}
