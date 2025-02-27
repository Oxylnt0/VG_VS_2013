namespace VG_DB_2013
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.applybtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sortby = new System.Windows.Forms.ComboBox();
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.falcom = new System.Windows.Forms.CheckBox();
            this.sony = new System.Windows.Forms.CheckBox();
            this.nintendo = new System.Windows.Forms.CheckBox();
            this.fromsoft = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.atlus = new System.Windows.Forms.CheckBox();
            this.xboxone = new System.Windows.Forms.CheckBox();
            this.nswitch = new System.Windows.Forms.CheckBox();
            this.ps5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ps4 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 93);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::VG_DB_2013.Properties.Resources.icons8_close_301;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1451, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Inventory";
            // 
            // applybtn
            // 
            this.applybtn.BackColor = System.Drawing.Color.Orange;
            this.applybtn.FlatAppearance.BorderSize = 0;
            this.applybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applybtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applybtn.Location = new System.Drawing.Point(12, 441);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(105, 35);
            this.applybtn.TabIndex = 10;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = false;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort:";
            // 
            // sortby
            // 
            this.sortby.BackColor = System.Drawing.Color.White;
            this.sortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortby.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortby.FormattingEnabled = true;
            this.sortby.Items.AddRange(new object[] {
            "Name - Ascending",
            "Name - Descending",
            "Price - Ascending",
            "Price - Descending",
            "Game ID - Ascending",
            "Game ID - Descending"});
            this.sortby.Location = new System.Drawing.Point(64, 10);
            this.sortby.Name = "sortby";
            this.sortby.Size = new System.Drawing.Size(133, 21);
            this.sortby.TabIndex = 2;
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AllowUserToAddRows = false;
            this.InventoryGrid.AllowUserToDeleteRows = false;
            this.InventoryGrid.AllowUserToResizeColumns = false;
            this.InventoryGrid.AllowUserToResizeRows = false;
            this.InventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InventoryGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.InventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryGrid.EnableHeadersVisualStyles = false;
            this.InventoryGrid.GridColor = System.Drawing.Color.White;
            this.InventoryGrid.Location = new System.Drawing.Point(220, 99);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.InventoryGrid.RowHeadersVisible = false;
            this.InventoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.InventoryGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.InventoryGrid.Size = new System.Drawing.Size(1256, 667);
            this.InventoryGrid.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.falcom);
            this.panel3.Controls.Add(this.sony);
            this.panel3.Controls.Add(this.nintendo);
            this.panel3.Controls.Add(this.fromsoft);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.atlus);
            this.panel3.Controls.Add(this.xboxone);
            this.panel3.Controls.Add(this.nswitch);
            this.panel3.Controls.Add(this.ps5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ps4);
            this.panel3.Controls.Add(this.applybtn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.sortby);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 685);
            this.panel3.TabIndex = 5;
            // 
            // falcom
            // 
            this.falcom.AutoSize = true;
            this.falcom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falcom.ForeColor = System.Drawing.Color.White;
            this.falcom.Location = new System.Drawing.Point(12, 410);
            this.falcom.Name = "falcom";
            this.falcom.Size = new System.Drawing.Size(78, 25);
            this.falcom.TabIndex = 22;
            this.falcom.Text = "Falcom";
            this.falcom.UseVisualStyleBackColor = true;
            // 
            // sony
            // 
            this.sony.AutoSize = true;
            this.sony.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sony.ForeColor = System.Drawing.Color.White;
            this.sony.Location = new System.Drawing.Point(12, 379);
            this.sony.Name = "sony";
            this.sony.Size = new System.Drawing.Size(140, 25);
            this.sony.TabIndex = 21;
            this.sony.Text = "Sony Interactive";
            this.sony.UseVisualStyleBackColor = true;
            // 
            // nintendo
            // 
            this.nintendo.AutoSize = true;
            this.nintendo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nintendo.ForeColor = System.Drawing.Color.White;
            this.nintendo.Location = new System.Drawing.Point(12, 348);
            this.nintendo.Name = "nintendo";
            this.nintendo.Size = new System.Drawing.Size(94, 25);
            this.nintendo.TabIndex = 20;
            this.nintendo.Text = "Nintendo";
            this.nintendo.UseVisualStyleBackColor = true;
            // 
            // fromsoft
            // 
            this.fromsoft.AutoSize = true;
            this.fromsoft.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromsoft.ForeColor = System.Drawing.Color.White;
            this.fromsoft.Location = new System.Drawing.Point(12, 317);
            this.fromsoft.Name = "fromsoft";
            this.fromsoft.Size = new System.Drawing.Size(128, 25);
            this.fromsoft.TabIndex = 19;
            this.fromsoft.Text = "FromSoftware";
            this.fromsoft.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(8, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Developer:";
            // 
            // atlus
            // 
            this.atlus.AutoSize = true;
            this.atlus.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atlus.ForeColor = System.Drawing.Color.White;
            this.atlus.Location = new System.Drawing.Point(12, 286);
            this.atlus.Name = "atlus";
            this.atlus.Size = new System.Drawing.Size(64, 25);
            this.atlus.TabIndex = 17;
            this.atlus.Text = "Atlus";
            this.atlus.UseVisualStyleBackColor = true;
            // 
            // xboxone
            // 
            this.xboxone.AutoSize = true;
            this.xboxone.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxone.ForeColor = System.Drawing.Color.White;
            this.xboxone.Location = new System.Drawing.Point(12, 217);
            this.xboxone.Name = "xboxone";
            this.xboxone.Size = new System.Drawing.Size(96, 25);
            this.xboxone.TabIndex = 16;
            this.xboxone.Text = "Xbox One";
            this.xboxone.UseVisualStyleBackColor = true;
            // 
            // nswitch
            // 
            this.nswitch.AutoSize = true;
            this.nswitch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nswitch.ForeColor = System.Drawing.Color.White;
            this.nswitch.Location = new System.Drawing.Point(12, 186);
            this.nswitch.Name = "nswitch";
            this.nswitch.Size = new System.Drawing.Size(144, 25);
            this.nswitch.TabIndex = 15;
            this.nswitch.Text = "Nintendo Switch";
            this.nswitch.UseVisualStyleBackColor = true;
            // 
            // ps5
            // 
            this.ps5.AutoSize = true;
            this.ps5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ps5.ForeColor = System.Drawing.Color.White;
            this.ps5.Location = new System.Drawing.Point(12, 155);
            this.ps5.Name = "ps5";
            this.ps5.Size = new System.Drawing.Size(56, 25);
            this.ps5.TabIndex = 14;
            this.ps5.Text = "PS5";
            this.ps5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Platforms:";
            // 
            // ps4
            // 
            this.ps4.AutoSize = true;
            this.ps4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ps4.ForeColor = System.Drawing.Color.White;
            this.ps4.Location = new System.Drawing.Point(12, 124);
            this.ps4.Name = "ps4";
            this.ps4.Size = new System.Drawing.Size(56, 25);
            this.ps4.TabIndex = 12;
            this.ps4.Text = "PS4";
            this.ps4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 1);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filters:";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1488, 778);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.InventoryGrid);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InventoryGrid;
        private System.Windows.Forms.ComboBox sortby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sony;
        private System.Windows.Forms.CheckBox nintendo;
        private System.Windows.Forms.CheckBox fromsoft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox atlus;
        private System.Windows.Forms.CheckBox xboxone;
        private System.Windows.Forms.CheckBox nswitch;
        private System.Windows.Forms.CheckBox ps5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ps4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox falcom;
    }
}