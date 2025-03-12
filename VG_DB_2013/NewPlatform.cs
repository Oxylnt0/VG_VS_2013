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
using System.IO;

namespace VG_DB_2013
{
    public partial class NewPlatform : Form
    {

        private AddPurchases form;

        public NewPlatform(AddPurchases load)
        {
            InitializeComponent();
            form = load;
        }

        private void backbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addplatbox_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string platformName = newplatformbox.Text.Trim();

            if (string.IsNullOrEmpty(platformName))
            {
                MessageBox.Show("Please enter a platform name.");
                return;
            }

            string query = "INSERT INTO Game_Platform (Platform_Name) VALUES (@PlatformName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlatformName", platformName);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Platform added successfully!");
                            newplatformbox.Clear();

                         
                            form.LoadPlatforms();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add platform.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
