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
    public partial class EditCustomer : Form
    {
        private Opacity opacity;

        public EditCustomer(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            opacity.Close();
        }

        private void find_Click(object sender, EventArgs e)
        {
            int custId = int.Parse(find_custid.Text);

            string query = "SELECT Last_Name, First_Name, Middle_Initial, Email, Phone_Number, Customer_Address FROM Game_Customers WHERE Customer_ID = @CustomerId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", custId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lastedit.Text = reader["Last_Name"].ToString();
                    firstedit.Text = reader["First_Name"].ToString();
                    middleedit.Text = reader["Middle_initial"].ToString();
                    emailedit.Text = reader["Email"].ToString();
                    numberedit.Text = reader["Phone_Number"].ToString();
                    addressedit.Text = reader["Customer_Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer ID not found.");
                }

                reader.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            int custoId = int.Parse(find_custid.Text);
            string lastname = lastedit.Text;
            string firstname = firstedit.Text;
            string middlename = middleedit.Text;
            string email = emailedit.Text;
            string number = numberedit.Text;
            string address = addressedit.Text;

            string updateQuery = "UPDATE Game_Customers SET  Last_Name = @Lastname, First_Name = @Firstname, Middle_initial = @Middleinitial, Email = @Email, Phone_Number = @Number, Customer_Address = @Address WHERE Customer_ID = @CustId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@CustId", custoId);
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Middleinitial", middlename);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Number", number);
                cmd.Parameters.AddWithValue("@Address", address);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update Customer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            find_custid.Text = "";
            lastedit.Text = "";
            firstedit.Text = "";
            middleedit.Text = "";
            emailedit.Text = "";
            numberedit.Text = "";
            addressedit.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("delete Game_Customers where Customer_ID=" + Convert.ToInt32(delete_custid.Text), sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Delete Successful", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            delete_custid.Text = "";
        }



    }
}
