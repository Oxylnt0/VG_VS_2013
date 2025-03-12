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
    public partial class ChangePassword : Form
    {
        private Opacity opacity;

        public ChangePassword(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            opacity.Close();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            string oldPassword = currentpass.Text;
            string newPassword = newpass.Text;
            string confirmPassword = confirmpass.Text;
            string adminUsername = username.Text;

            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE Username = @username AND Admin_Password = @oldPassword";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", adminUsername);
                        cmd.Parameters.AddWithValue("@oldPassword", oldPassword);

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            string updateQuery = "UPDATE Admins SET ADMIN_Password = @newPassword WHERE Username = @username";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@username", adminUsername);
                                updateCmd.Parameters.AddWithValue("@newPassword", newPassword);

                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    currentpass.Clear();
                                    newpass.Clear();
                                    confirmpass.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Password change failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
