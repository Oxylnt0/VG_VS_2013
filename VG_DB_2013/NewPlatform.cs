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
    public partial class NewPlatform : Form
    {

        public NewPlatform()
        {
            InitializeComponent();
        }

        private void backbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addplatbox_Click(object sender, EventArgs e)
        {
            string newPlatform = newplatformbox.Text.Trim(); // txtPlatformName is your TextBox

            if (!string.IsNullOrEmpty(newPlatform))
            {
                // Check if the MainForm instance is available
                Inventory inventory = new Inventory();
                if (inventory != null)
                {
                    inventory.AddPlatform(newPlatform);  // Call AddPlatform method in MainForm
                    newplatformbox.Clear();  // Optionally clear the TextBox after adding
                    MessageBox.Show("Platform added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid platform name.");
            }
        }
    }
}
