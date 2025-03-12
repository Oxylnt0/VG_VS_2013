namespace VG_DB_2013
{
    partial class NewPlatform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.newplatformbox = new System.Windows.Forms.TextBox();
            this.addplatbox = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.backbtn2);
            this.panel1.Location = new System.Drawing.Point(-13, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 55);
            this.panel1.TabIndex = 49;
            // 
            // backbtn2
            // 
            this.backbtn2.BackColor = System.Drawing.Color.Gold;
            this.backbtn2.FlatAppearance.BorderSize = 0;
            this.backbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn2.ForeColor = System.Drawing.Color.Black;
            this.backbtn2.Location = new System.Drawing.Point(210, 14);
            this.backbtn2.Name = "backbtn2";
            this.backbtn2.Size = new System.Drawing.Size(76, 25);
            this.backbtn2.TabIndex = 54;
            this.backbtn2.Text = "Back";
            this.backbtn2.UseVisualStyleBackColor = false;
            this.backbtn2.Click += new System.EventHandler(this.backbtn2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(36, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 21);
            this.label11.TabIndex = 50;
            this.label11.Text = "New Platform:";
            // 
            // newplatformbox
            // 
            this.newplatformbox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newplatformbox.Location = new System.Drawing.Point(40, 96);
            this.newplatformbox.Name = "newplatformbox";
            this.newplatformbox.Size = new System.Drawing.Size(209, 25);
            this.newplatformbox.TabIndex = 51;
            // 
            // addplatbox
            // 
            this.addplatbox.BackColor = System.Drawing.Color.Gold;
            this.addplatbox.FlatAppearance.BorderSize = 0;
            this.addplatbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addplatbox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addplatbox.ForeColor = System.Drawing.Color.Black;
            this.addplatbox.Location = new System.Drawing.Point(40, 127);
            this.addplatbox.Name = "addplatbox";
            this.addplatbox.Size = new System.Drawing.Size(81, 37);
            this.addplatbox.TabIndex = 55;
            this.addplatbox.Text = "Add";
            this.addplatbox.UseVisualStyleBackColor = false;
            this.addplatbox.Click += new System.EventHandler(this.addplatbox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.addplatbox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.newplatformbox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 178);
            this.panel2.TabIndex = 56;
            // 
            // NewPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(313, 207);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPlatform";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newplatformbox;
        private System.Windows.Forms.Button addplatbox;
        private System.Windows.Forms.Panel panel2;
    }
}