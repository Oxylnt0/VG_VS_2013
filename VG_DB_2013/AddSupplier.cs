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
    public partial class AddSupplier : Form
    {

        private Opacity opacity;

        public AddSupplier(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SIMOUNANDRE\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into Game_Suppliers values (@Supplier_Name, @Supplier_Email, @Supplier_Phone_Number, @Supplier_Address)", sqlcon);
            cmd.Parameters.AddWithValue("@Supplier_Name", (suppliernamebox.Text));
            cmd.Parameters.AddWithValue("@Supplier_Email", (emailbox.Text));
            cmd.Parameters.AddWithValue("@Supplier_Phone_Number", (numberbox.Text));
            cmd.Parameters.AddWithValue("@Supplier_Address", (addressbox.Text));
            cmd.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Supplier Added", "Game Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            suppliernamebox.Text = "";
            emailbox.Text = "";
            numberbox.Text = "";
            addressbox.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            opacity.Close();
        }
    }
}
