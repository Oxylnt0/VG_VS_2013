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
    public partial class Login_Form : Form
    {

        Database database_object = new Database();
        SqlConnection connection = new SqlConnection("Data Source=SIMOUNANDRE\\SQLEXPRESS;Initial Catalog=VG_Inventory_Management;Integrated Security=True");
        SqlDataReader db_reader;

        public Login_Form()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        private void logibtn_Click(object sender, EventArgs e)
        {
            String Username = usernamebox.Text;
            String Password = passwordbox.Text;

            SqlCommand newcommand;

            if (Username.Equals("") || Password.Equals(""))
            {

                MessageBox.Show("All Fields Required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                newcommand = new SqlCommand("select * from Admins where Username=@Username and Admin_Password=@password", connection);
                newcommand.Parameters.AddWithValue("@Username", Username);
                newcommand.Parameters.AddWithValue("@Password", Password);

                connection.Open();

                db_reader = newcommand.ExecuteReader();

                if (db_reader.HasRows)
                {

                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();

                }

                else
                {

                    MessageBox.Show("Login Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernamebox.Clear();
                    passwordbox.Clear();

                }

                connection.Close();

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usernamebox.Text = "";
            passwordbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            passwordbox.PasswordChar = '*';
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            passwordbox.PasswordChar = '\0';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

  
 



    }
}
