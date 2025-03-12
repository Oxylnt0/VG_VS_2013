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
    public partial class AdminForm : Form
    {

        private Opacity opacity;

        public AdminForm()
        {
            InitializeComponent();
        }

        private string query = "select Admin_ID, Username, Admin_Password, Last_Name, First_Name, Middle_Initial from Admins where 1=1";

        public void BindData()
        {

            string connectionstring = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";


           using (SqlConnection conn = new SqlConnection(connectionstring))
           {
               conn.Open();
               SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
               DataTable dt = new DataTable();
               adapter.Fill(dt);

               AdminGrid.DataSource = dt;

               AdminGrid.Columns.Clear();

               AdminGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Admin ID", DataPropertyName = "Admin_ID" });
               AdminGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Username", DataPropertyName = "Username" });
               AdminGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Password", DataPropertyName = "Admin_Password" });
               AdminGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "Last_Name" });
               AdminGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "First_Name" });
               AdminGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Middle Initial", DataPropertyName = "Middle_Initial" });

               AdminGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
               AdminGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           }

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            this.BindData();
            this.AdminGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.AdminGrid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            query = "select Admin_ID, Username, Admin_Password, Last_Name, First_Name, Middle_Initial from Admins where Username Like '%" + search.Text + "%';";
            this.BindData();
            AdminGrid.Update();
            AdminGrid.Refresh();
            query = "select Admin_ID, Username, Admin_Password, Last_Name, First_Name, Middle_Initial from Admins";
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
            AdminGrid.Update();
            AdminGrid.Refresh();

            query = "select Admin_ID, Username, Admin_Password, Last_Name, First_Name, Middle_Initial from Admins where 1=1";
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            this.BindData();
            AdminGrid.Update();
            AdminGrid.Refresh();
        }

        private void addadminbtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            AddAdmin add = new AddAdmin(opacity);
            add.Show();
            add.TopMost = true;
        }

        private void editadminbtn_Click(object sender, EventArgs e)
        {
            opacity = new Opacity();
            opacity.Show();
            opacity.Opacity = 0.6;

            EditAdmin edit = new EditAdmin(opacity);
            edit.Show();
            edit.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mainForm = Application.OpenForms["Menu"] as Menu;
            if (mainForm != null)
            {
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }



   }
}
