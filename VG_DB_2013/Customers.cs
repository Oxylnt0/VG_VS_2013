using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VG_DB_2013
{
    public partial class Customers : Form
    {
        private Opacity opacity;

        public Customers()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string query = "select Customer_ID, Last_Name, First_Name, Middle_Initial, Email, Phone_Number, Customer_Address from Game_Customers where 1=1";

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                customergrid.DataSource = dt;

                customergrid.Columns.Clear();

                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Customer ID", DataPropertyName = "Customer_ID" });
                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "Last_Name" });
                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "First_Name" });
                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Middle Initial", DataPropertyName = "Middle_Initial" });
                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone Number", DataPropertyName = "Phone_Number" });
                customergrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Customer_Address" });

                customergrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                customergrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            this.BindData();
            this.customergrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.customergrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.customergrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.customergrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.customergrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.customergrid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.customergrid.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void editcustbtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            EditCustomer custform = new EditCustomer(opacity);
            custform.Show();
            custform.TopMost = true;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.BindData();
            customergrid.Update();
            customergrid.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mainForm = Application.OpenForms["Menu"] as Menu;
            if (mainForm != null)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (sortby.SelectedItem.ToString() == "Last Name - Ascending")
            {
                query += " order by Last_Name asc";
            }

            else if (sortby.SelectedItem.ToString() == "Last Name - Descending")
            {
                query += " order by Last_Name desc";

            }

            this.BindData();
            customergrid.Update();
            customergrid.Refresh();

            query = "select Customer_ID, Last_Name, First_Name, Middle_Initial, Email, Phone_Number, Customer_Address from Game_Customers where 1=1";
        }

   

    }
}
