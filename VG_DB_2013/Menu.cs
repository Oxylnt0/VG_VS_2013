using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VG_DB_2013
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {

            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Result == DialogResult.Yes)
            {

                this.Hide();
                Login_Form newlogin = new Login_Form();
                newlogin.Show();

            }

        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            loadform(new AdminForm());
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            loadform(new Inventory());
        }
    }
}
