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
    public partial class NewDev : Form
    {
        public NewDev()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adddevbox_Click(object sender, EventArgs e)
        {
            string newDeveloper = newdevbox.Text.Trim(); 

            if (!string.IsNullOrEmpty(newDeveloper))
            {
                Inventory inventory = new Inventory();
                if (inventory != null)
                {
                    inventory.AddDeveloper(newDeveloper); 
                    newdevbox.Clear(); 
                    MessageBox.Show("Developer added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Developer name.");
            }
        }



    }
}
