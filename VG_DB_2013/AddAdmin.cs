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
    public partial class AddAdmin : Form
    {

        private Opacity opacity;

        public AddAdmin(Opacity opacity)
        {
            InitializeComponent();
            this.opacity = opacity;
        }

        private void add_Click(object sender, EventArgs e)
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

        private void clear_Click(object sender, EventArgs e)
        {
            usernamebox.Text = "";
            passwordbox.Text = "";
            lastbox.Text = "";
            firstbox.Text = "";
            middlebox.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            opacity.Close();
        }

    }
}
