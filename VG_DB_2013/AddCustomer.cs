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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addcustbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last.Text) ||
              string.IsNullOrWhiteSpace(first.Text) ||
              string.IsNullOrWhiteSpace(middle.Text) ||
              string.IsNullOrWhiteSpace(email.Text) ||
              string.IsNullOrWhiteSpace(num.Text) ||
              string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("All Fields Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into Game_Customers values (@Last, @First, @Middle, @Email, @Phone, @Address)", sqlcon);
            cmd.Parameters.AddWithValue("@Last", (last.Text));
            cmd.Parameters.AddWithValue("@First", (first.Text));
            cmd.Parameters.AddWithValue("@Middle", (middle.Text));
            cmd.Parameters.AddWithValue("@Email", (email.Text));
            cmd.Parameters.AddWithValue("@Phone", (num.Text));
            cmd.Parameters.AddWithValue("@Address", (address.Text));
            cmd.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Customer Added", "Game Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
