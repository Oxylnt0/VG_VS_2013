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

        private void add_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into Admins values (@Username, @Admin_Password, @Last_Name, @First_Name, @Middle_Initial)", sqlcon);
            cmd.Parameters.AddWithValue("@Username", (usernamebox.Text));
            cmd.Parameters.AddWithValue("@Admin_Password", (passwordbox.Text));
            cmd.Parameters.AddWithValue("@Last_Name", (lastbox.Text));
            cmd.Parameters.AddWithValue("@First_Name", (firstbox.Text));
            cmd.Parameters.AddWithValue("@Middle_Initial", (middlebox.Text));
            cmd.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Admin Added", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            this.BindData();
            AdminGrid.Update();
            AdminGrid.Refresh();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            usernamebox.Text = "";
            passwordbox.Text = "";
            lastbox.Text = "";
            firstbox.Text = "";
            middlebox.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("delete Admins where Admin_ID=" + Convert.ToInt32(admin_id.Text), sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Delete Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin_id.Text = "";

        }

        private void find_Click(object sender, EventArgs e)
        {
            int adminId = int.Parse(find_supplier_id.Text);

            string query = "SELECT Username, Admin_password, Last_Name, First_Name, Middle_Initial FROM admins WHERE Admin_ID = @AdminId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminId", adminId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    useredit.Text = reader["Username"].ToString();
                    passedit.Text = reader["Admin_Password"].ToString();
                    lastedit.Text = reader["Last_Name"].ToString();
                    firstedit.Text = reader["First_Name"].ToString();
                    middleedit.Text = reader["Middle_initial"].ToString();
                }
                else
                {
                    MessageBox.Show("Admin ID not found.");
                }

                reader.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int adminId = int.Parse(find_supplier_id.Text);
            string username = useredit.Text;
            string password = passedit.Text;
            string lastname = lastedit.Text;
            string firstname = firstedit.Text;
            string middlename = middleedit.Text;

            string updateQuery = "UPDATE admins SET Username = @Username, Admin_Password = @Password, Last_Name = @Lastname, First_Name = @Firstname, Middle_initial = @Middleinitial WHERE Admin_ID = @AdminId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@AdminId", adminId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Middleinitial", middlename);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update Admin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            find_supplier_id.Text = "";
            useredit.Text = "";
            passedit.Text = "";
            lastedit.Text = "";
            firstedit.Text = "";
            middleedit.Text = "";
        }

   }
}
