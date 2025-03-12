namespace VG_DB_2013
{
    partial class AddSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.game_id_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.game_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.total_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.game_id = new System.Windows.Forms.TextBox();
            this.game_qty = new System.Windows.Forms.NumericUpDown();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gamegrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.add_cust_btn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.custgrid = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.payment_method = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamegrid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custgrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 55);
            this.panel1.TabIndex = 49;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Gold;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.Black;
            this.backbtn.Location = new System.Drawing.Point(847, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(76, 25);
            this.backbtn.TabIndex = 54;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Sales";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.payment_method);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.price);
            this.panel6.Controls.Add(this.game_id_search);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.cust_id);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.game_name);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.total_amount);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.date);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.game_id);
            this.panel6.Controls.Add(this.game_qty);
            this.panel6.Controls.Add(this.clear);
            this.panel6.Controls.Add(this.add);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(482, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(441, 479);
            this.panel6.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(58, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 21);
            this.label19.TabIndex = 62;
            this.label19.Text = "Game Price:";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(164, 100);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(201, 25);
            this.price.TabIndex = 61;
            this.price.Text = "0";
            // 
            // game_id_search
            // 
            this.game_id_search.BackColor = System.Drawing.Color.Gold;
            this.game_id_search.FlatAppearance.BorderSize = 0;
            this.game_id_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_id_search.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_id_search.ForeColor = System.Drawing.Color.Black;
            this.game_id_search.Location = new System.Drawing.Point(261, 12);
            this.game_id_search.Name = "game_id_search";
            this.game_id_search.Size = new System.Drawing.Size(76, 25);
            this.game_id_search.TabIndex = 55;
            this.game_id_search.Text = "Search";
            this.game_id_search.UseVisualStyleBackColor = false;
            this.game_id_search.Click += new System.EventHandler(this.game_id_search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Type Customer ID:";
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_id.Location = new System.Drawing.Point(164, 249);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(90, 25);
            this.cust_id.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Game Name:";
            // 
            // game_name
            // 
            this.game_name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_name.Location = new System.Drawing.Point(165, 53);
            this.game_name.Name = "game_name";
            this.game_name.ReadOnly = true;
            this.game_name.Size = new System.Drawing.Size(201, 25);
            this.game_name.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Total Amount:";
            // 
            // total_amount
            // 
            this.total_amount.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount.Location = new System.Drawing.Point(165, 196);
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            this.total_amount.Size = new System.Drawing.Size(209, 25);
            this.total_amount.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Payment Method:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(113, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Date:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(164, 329);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(50, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 42;
            this.label12.Text = "Type Game ID:";
            // 
            // game_id
            // 
            this.game_id.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_id.Location = new System.Drawing.Point(165, 12);
            this.game_id.Name = "game_id";
            this.game_id.Size = new System.Drawing.Size(90, 25);
            this.game_id.TabIndex = 43;
            // 
            // game_qty
            // 
            this.game_qty.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_qty.Location = new System.Drawing.Point(164, 150);
            this.game_qty.Name = "game_qty";
            this.game_qty.Size = new System.Drawing.Size(40, 25);
            this.game_qty.TabIndex = 41;
            this.game_qty.ValueChanged += new System.EventHandler(this.game_qty_ValueChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Gold;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(237, 619);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(76, 25);
            this.clear.TabIndex = 39;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gold;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(113, 619);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(76, 25);
            this.add.TabIndex = 38;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(86, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Quantity:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(163, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 55;
            this.button1.Text = "Add Sales";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.gamegrid);
            this.panel3.Location = new System.Drawing.Point(8, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 192);
            this.panel3.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Games";
            // 
            // gamegrid
            // 
            this.gamegrid.AllowUserToAddRows = false;
            this.gamegrid.AllowUserToDeleteRows = false;
            this.gamegrid.AllowUserToResizeColumns = false;
            this.gamegrid.AllowUserToResizeRows = false;
            this.gamegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gamegrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gamegrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gamegrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamegrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gamegrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gamegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gamegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gamegrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.gamegrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gamegrid.EnableHeadersVisualStyles = false;
            this.gamegrid.GridColor = System.Drawing.Color.White;
            this.gamegrid.Location = new System.Drawing.Point(3, 40);
            this.gamegrid.Name = "gamegrid";
            this.gamegrid.ReadOnly = true;
            this.gamegrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gamegrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gamegrid.RowHeadersVisible = false;
            this.gamegrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            this.gamegrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.gamegrid.Size = new System.Drawing.Size(436, 147);
            this.gamegrid.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.add_cust_btn);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.custgrid);
            this.panel4.Location = new System.Drawing.Point(8, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 192);
            this.panel4.TabIndex = 59;
            // 
            // add_cust_btn
            // 
            this.add_cust_btn.BackColor = System.Drawing.Color.Gold;
            this.add_cust_btn.FlatAppearance.BorderSize = 0;
            this.add_cust_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_cust_btn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cust_btn.ForeColor = System.Drawing.Color.Black;
            this.add_cust_btn.Location = new System.Drawing.Point(322, 3);
            this.add_cust_btn.Name = "add_cust_btn";
            this.add_cust_btn.Size = new System.Drawing.Size(117, 25);
            this.add_cust_btn.TabIndex = 62;
            this.add_cust_btn.Text = "Add Customer";
            this.add_cust_btn.UseVisualStyleBackColor = false;
            this.add_cust_btn.Click += new System.EventHandler(this.add_cust_btn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Azure;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 37);
            this.label18.TabIndex = 14;
            this.label18.Text = "Customers";
            // 
            // custgrid
            // 
            this.custgrid.AllowUserToAddRows = false;
            this.custgrid.AllowUserToDeleteRows = false;
            this.custgrid.AllowUserToResizeColumns = false;
            this.custgrid.AllowUserToResizeRows = false;
            this.custgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.custgrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.custgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.custgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.custgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.custgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custgrid.DefaultCellStyle = dataGridViewCellStyle22;
            this.custgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.custgrid.EnableHeadersVisualStyles = false;
            this.custgrid.GridColor = System.Drawing.Color.White;
            this.custgrid.Location = new System.Drawing.Point(3, 40);
            this.custgrid.Name = "custgrid";
            this.custgrid.ReadOnly = true;
            this.custgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.custgrid.RowHeadersVisible = false;
            this.custgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(5);
            this.custgrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.custgrid.Size = new System.Drawing.Size(436, 147);
            this.custgrid.TabIndex = 5;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Gold;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Black;
            this.refresh.Location = new System.Drawing.Point(147, 428);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(151, 25);
            this.refresh.TabIndex = 61;
            this.refresh.Text = "Refresh Tables";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // payment_method
            // 
            this.payment_method.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_method.FormattingEnabled = true;
            this.payment_method.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Gcash"});
            this.payment_method.Location = new System.Drawing.Point(163, 291);
            this.payment_method.Name = "payment_method";
            this.payment_method.Size = new System.Drawing.Size(201, 25);
            this.payment_method.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 479);
            this.panel2.TabIndex = 62;
            // 
            // AddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 561);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSales";
            this.Load += new System.EventHandler(this.AddSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamegrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custgrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox game_id;
        private System.Windows.Forms.NumericUpDown game_qty;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox game_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gamegrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView custgrid;
        private System.Windows.Forms.Button game_id_search;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button add_cust_btn;
        private System.Windows.Forms.ComboBox payment_method;
        private System.Windows.Forms.Panel panel2;
    }
}