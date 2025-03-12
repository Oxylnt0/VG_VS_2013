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
    public partial class NewGenre : Form
    {
        private AddPurchases form;

        public NewGenre(AddPurchases load)
        {
            InitializeComponent();
            form = load;
        }

        private void backbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addgenbox_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True";
            string GenreName = newgenrebox.Text.Trim();

            if (string.IsNullOrEmpty(GenreName))
            {
                MessageBox.Show("Please enter a Genre name.");
                return;
            }

            string query = "INSERT INTO Genre (Genre_Name) VALUES (@GenreName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GenreName", GenreName);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Genre added successfully!");
                            newgenrebox.Clear();


                            form.LoadGenres();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Genre.");
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
