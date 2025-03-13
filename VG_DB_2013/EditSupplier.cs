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
    public partial class EditSupplier : Form
    {

        private Opacity opacity;

        public EditSupplier(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(find_supplier_id.Text))
            {
                MessageBox.Show("Enter Supplier ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierid = int.Parse(find_supplier_id.Text);

            string query = "SELECT Supplier_Name, Supplier_Email, Supplier_Phone_Number, Supplier_Address FROM Game_Suppliers WHERE Supplier_ID = @SupplierID";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierid);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nameedit.Text = reader["Supplier_Name"].ToString();
                    emailedit.Text = reader["Supplier_Email"].ToString();
                    numberedit.Text = reader["Supplier_Phone_Number"].ToString();
                    addressedit.Text = reader["Supplier_Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Supplier ID not found.");
                }

                reader.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameedit.Text) ||
                string.IsNullOrWhiteSpace(emailedit.Text) ||
                string.IsNullOrWhiteSpace(numberedit.Text) ||
                string.IsNullOrWhiteSpace(addressedit.Text))
            {
                MessageBox.Show("All Fields Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierId = int.Parse(find_supplier_id.Text);
            string suppliername = nameedit.Text;
            string supplieremail = emailedit.Text;
            string suppliernumber = numberedit.Text;
            string supplieraddress = addressedit.Text;

            string updateQuery = "UPDATE Game_Suppliers SET Supplier_Name = @SupplierName, Supplier_Email = @SupplierEmail, Supplier_Phone_Number = @PhoneNumber, Supplier_Address = @ADDRESS WHERE Supplier_ID = @SupplierID";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                cmd.Parameters.AddWithValue("@SupplierName", suppliername);
                cmd.Parameters.AddWithValue("@SupplierEmail", supplieremail);
                cmd.Parameters.AddWithValue("@PhoneNumber", suppliernumber);
                cmd.Parameters.AddWithValue("@ADDRESS", supplieraddress);

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
