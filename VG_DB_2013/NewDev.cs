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
    public partial class NewDev : Form
    {
        private AddPurchases form;

        public NewDev(AddPurchases load)
        {
            InitializeComponent();
            form = load;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adddevbox_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string DevName = newdevbox.Text.Trim();

            if (string.IsNullOrEmpty(DevName))
            {
                MessageBox.Show("Please enter a Developer name.");
                return;
            }

            string query = "INSERT INTO Developer (Developer_Name) VALUES (@DevName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DevName", DevName);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Developer added successfully!");
                            newdevbox.Clear();


                            form.LoadDevelopers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Developer.");
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
