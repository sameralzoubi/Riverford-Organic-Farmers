
namespace VP_Project2
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ColumnUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GenderEmailButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddOrdersButtons = new System.Windows.Forms.Button();
            this.GetEmailButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.ProductTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.OrdersTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Orders.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProductTab);
            this.tabControl1.Controls.Add(this.OrdersTab);
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.panel1);
            this.ProductTab.Location = new System.Drawing.Point(4, 22);
            this.ProductTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Size = new System.Drawing.Size(664, 524);
            this.ProductTab.TabIndex = 3;
            this.ProductTab.Text = "Prodact";
            this.ProductTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 558);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.ColumnUpDown);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(275, 249);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 265);
            this.panel6.TabIndex = 7;
            // 
            // ColumnUpDown
            // 
            this.ColumnUpDown.Location = new System.Drawing.Point(123, 88);
            this.ColumnUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ColumnUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ColumnUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColumnUpDown.Name = "ColumnUpDown";
            this.ColumnUpDown.Size = new System.Drawing.Size(93, 20);
            this.ColumnUpDown.TabIndex = 7;
            this.ColumnUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(23, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "DELETE ROW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Update to";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 131);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(23, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "UPDATE ROW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Column Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.PriceTextBox);
            this.panel2.Controls.Add(this.PriceLabel);
            this.panel2.Controls.Add(this.CostTextBox);
            this.panel2.Controls.Add(this.CostLabel);
            this.panel2.Controls.Add(this.QuantityTextBox);
            this.panel2.Controls.Add(this.QuantityLabel);
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.ProductIDTextBox);
            this.panel2.Controls.Add(this.ProductIDLabel);
            this.panel2.Location = new System.Drawing.Point(22, 249);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 265);
            this.panel2.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(12, 218);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 24);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(82, 166);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(130, 20);
            this.PriceTextBox.TabIndex = 9;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(9, 169);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(82, 129);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(130, 20);
            this.CostTextBox.TabIndex = 7;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(9, 132);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(82, 93);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(130, 20);
            this.QuantityTextBox.TabIndex = 5;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(9, 98);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(82, 57);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(130, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 62);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(82, 19);
            this.ProductIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(130, 20);
            this.ProductIDTextBox.TabIndex = 1;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(9, 22);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(55, 13);
            this.ProductIDLabel.TabIndex = 0;
            this.ProductIDLabel.Text = "ProductID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.panel5);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(664, 524);
            this.OrdersTab.TabIndex = 2;
            this.OrdersTab.Text = "Users";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.GenderEmailButton);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(764, 558);
            this.panel5.TabIndex = 0;
            // 
            // GenderEmailButton
            // 
            this.GenderEmailButton.BackColor = System.Drawing.Color.SeaGreen;
            this.GenderEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderEmailButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenderEmailButton.Location = new System.Drawing.Point(26, 469);
            this.GenderEmailButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenderEmailButton.Name = "GenderEmailButton";
            this.GenderEmailButton.Size = new System.Drawing.Size(171, 30);
            this.GenderEmailButton.TabIndex = 3;
            this.GenderEmailButton.Text = "GET EMAIL ADRESSES";
            this.GenderEmailButton.UseVisualStyleBackColor = false;
            this.GenderEmailButton.Click += new System.EventHandler(this.GenderEmailButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(89, 433);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-3, -3);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(664, 384);
            this.dataGridView3.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.panel3);
            this.Orders.Location = new System.Drawing.Point(4, 22);
            this.Orders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(664, 524);
            this.Orders.TabIndex = 4;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.AddOrdersButtons);
            this.panel3.Controls.Add(this.GetEmailButton);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 520);
            this.panel3.TabIndex = 0;
            // 
            // AddOrdersButtons
            // 
            this.AddOrdersButtons.BackColor = System.Drawing.Color.SeaGreen;
            this.AddOrdersButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrdersButtons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddOrdersButtons.Location = new System.Drawing.Point(282, 467);
            this.AddOrdersButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOrdersButtons.Name = "AddOrdersButtons";
            this.AddOrdersButtons.Size = new System.Drawing.Size(116, 27);
            this.AddOrdersButtons.TabIndex = 2;
            this.AddOrdersButtons.Text = "ADD ORDERS";
            this.AddOrdersButtons.UseVisualStyleBackColor = false;
            this.AddOrdersButtons.Click += new System.EventHandler(this.AddOrdersButtons_Click);
            // 
            // GetEmailButton
            // 
            this.GetEmailButton.BackColor = System.Drawing.Color.SeaGreen;
            this.GetEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetEmailButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetEmailButton.Location = new System.Drawing.Point(282, 425);
            this.GetEmailButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetEmailButton.Name = "GetEmailButton";
            this.GetEmailButton.Size = new System.Drawing.Size(116, 27);
            this.GetEmailButton.TabIndex = 1;
            this.GetEmailButton.Text = "GET EMAIL";
            this.GetEmailButton.UseVisualStyleBackColor = false;
            this.GetEmailButton.Click += new System.EventHandler(this.GetEmailButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(99, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(483, 394);
            this.dataGridView2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Column Numberyou would like to update or delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select the gender of users you would like to retrive their email addresses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Project2.Properties.Resources.background_food_fruits_vegetables_collection_fruit_vegetable_portrait_format_healthy_eating_diet_apples_oranges_tomatoes_190446153;
            this.pictureBox1.Location = new System.Drawing.Point(698, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 610);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(838, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.ProductTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.OrdersTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Orders.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown ColumnUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddOrdersButtons;
        private System.Windows.Forms.Button GetEmailButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GenderEmailButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}