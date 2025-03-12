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
    public partial class EditAdmin : Form
    {

        private Opacity opacity;

        public EditAdmin(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void editmode_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("delete Admins where Admin_ID=" + Convert.ToInt32(admin_id.Text), sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Delete Successful", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            admin_id.Text = "";
        }

        private void find_Click(object sender, EventArgs e)
        {
            int adminId = int.Parse(find_admin_id.Text);

            string query = "SELECT Username, Last_Name, First_Name, Middle_Initial FROM admins WHERE Admin_ID = @AdminId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminId", adminId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    useredit.Text = reader["Username"].ToString();
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
            int adminId = int.Parse(find_admin_id.Text);
            string username = useredit.Text;
            string lastname = lastedit.Text;
            string firstname = firstedit.Text;
            string middlename = middleedit.Text;

            string updateQuery = "UPDATE admins SET Username = @Username, Last_Name = @Lastname, First_Name = @Firstname, Middle_initial = @Middleinitial WHERE Admin_ID = @AdminId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@AdminId", adminId);
                cmd.Parameters.AddWithValue("@Username", username);
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            opacity.Close();
        }



  
    }
}
