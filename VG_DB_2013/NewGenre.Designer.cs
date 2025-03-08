namespace VG_DB_2013
{
    partial class NewGenre
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
            this.addgenbox = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.newgenrebox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addgenbox
            // 
            this.addgenbox.BackColor = System.Drawing.Color.Gold;
            this.addgenbox.FlatAppearance.BorderSize = 0;
            this.addgenbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addgenbox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addgenbox.ForeColor = System.Drawing.Color.Black;
            this.addgenbox.Location = new System.Drawing.Point(45, 127);
            this.addgenbox.Name = "addgenbox";
            this.addgenbox.Size = new System.Drawing.Size(76, 25);
            this.addgenbox.TabIndex = 59;
            this.addgenbox.Text = "Add";
            this.addgenbox.UseVisualStyleBackColor = false;
            this.addgenbox.Click += new System.EventHandler(this.addgenbox_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(41, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 57;
            this.label11.Text = "New Genre:";
            // 
            // newgenrebox
            // 
            this.newgenrebox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgenrebox.Location = new System.Drawing.Point(45, 96);
            this.newgenrebox.Name = "newgenrebox";
            this.newgenrebox.Size = new System.Drawing.Size(209, 25);
            this.newgenrebox.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.backbtn1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 55);
            this.panel1.TabIndex = 56;
            // 
            // backbtn1
            // 
            this.backbtn1.BackColor = System.Drawing.Color.Gold;
            this.backbtn1.FlatAppearance.BorderSize = 0;
            this.backbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn1.ForeColor = System.Drawing.Color.Black;
            this.backbtn1.Location = new System.Drawing.Point(197, 12);
            this.backbtn1.Name = "backbtn1";
            this.backbtn1.Size = new System.Drawing.Size(76, 25);
            this.backbtn1.TabIndex = 54;
            this.backbtn1.Text = "Back";
            this.backbtn1.UseVisualStyleBackColor = false;
            this.backbtn1.Click += new System.EventHandler(this.backbtn1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.addgenbox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.newgenrebox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 178);
            this.panel2.TabIndex = 60;
            // 
            // NewGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(313, 207);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGenre";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addgenbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newgenrebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn1;
        private System.Windows.Forms.Panel panel2;
    }
}