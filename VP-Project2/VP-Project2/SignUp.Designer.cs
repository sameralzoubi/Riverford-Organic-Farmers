
namespace VP_Project2
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaleG = new System.Windows.Forms.RadioButton();
            this.FemaleG = new System.Windows.Forms.RadioButton();
            this.DomainBox = new System.Windows.Forms.ComboBox();
            this.DOBL = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.CPasswordL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.EmailL = new System.Windows.Forms.Label();
            this.LNameL = new System.Windows.Forms.Label();
            this.FNameL = new System.Windows.Forms.Label();
            this.NextB = new System.Windows.Forms.Button();
            this.CPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MobilTextBox = new System.Windows.Forms.TextBox();
            this.ShowPassCheckBox1 = new System.Windows.Forms.CheckBox();
            this.ShowPassCheckBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MaleG);
            this.panel1.Controls.Add(this.FemaleG);
            this.panel1.Location = new System.Drawing.Point(120, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 25);
            this.panel1.TabIndex = 57;
            // 
            // MaleG
            // 
            this.MaleG.AutoSize = true;
            this.MaleG.Location = new System.Drawing.Point(3, 3);
            this.MaleG.Name = "MaleG";
            this.MaleG.Size = new System.Drawing.Size(48, 17);
            this.MaleG.TabIndex = 26;
            this.MaleG.TabStop = true;
            this.MaleG.Text = "Male";
            this.MaleG.UseVisualStyleBackColor = true;
            this.MaleG.CheckedChanged += new System.EventHandler(this.MaleG_CheckedChanged);
            // 
            // FemaleG
            // 
            this.FemaleG.AutoSize = true;
            this.FemaleG.Location = new System.Drawing.Point(49, 3);
            this.FemaleG.Name = "FemaleG";
            this.FemaleG.Size = new System.Drawing.Size(59, 17);
            this.FemaleG.TabIndex = 27;
            this.FemaleG.TabStop = true;
            this.FemaleG.Text = "Female";
            this.FemaleG.UseVisualStyleBackColor = true;
            // 
            // DomainBox
            // 
            this.DomainBox.FormattingEnabled = true;
            this.DomainBox.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@yahoo.com",
            "@outlook.com",
            "@icloud.com"});
            this.DomainBox.Location = new System.Drawing.Point(225, 92);
            this.DomainBox.Name = "DomainBox";
            this.DomainBox.Size = new System.Drawing.Size(115, 21);
            this.DomainBox.TabIndex = 56;
            // 
            // DOBL
            // 
            this.DOBL.AutoSize = true;
            this.DOBL.Location = new System.Drawing.Point(24, 217);
            this.DOBL.Name = "DOBL";
            this.DOBL.Size = new System.Drawing.Size(68, 13);
            this.DOBL.TabIndex = 55;
            this.DOBL.Text = "Date Of Birth";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(24, 186);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 54;
            this.Gender.Text = "Gender";
            // 
            // CPasswordL
            // 
            this.CPasswordL.AutoSize = true;
            this.CPasswordL.Location = new System.Drawing.Point(24, 155);
            this.CPasswordL.Name = "CPasswordL";
            this.CPasswordL.Size = new System.Drawing.Size(91, 13);
            this.CPasswordL.TabIndex = 53;
            this.CPasswordL.Text = "Confirm Password";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Location = new System.Drawing.Point(24, 124);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(53, 13);
            this.PasswordL.TabIndex = 52;
            this.PasswordL.Text = "Password";
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Location = new System.Drawing.Point(24, 93);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(35, 13);
            this.EmailL.TabIndex = 51;
            this.EmailL.Text = "Email ";
            // 
            // LNameL
            // 
            this.LNameL.AutoSize = true;
            this.LNameL.Location = new System.Drawing.Point(24, 62);
            this.LNameL.Name = "LNameL";
            this.LNameL.Size = new System.Drawing.Size(58, 13);
            this.LNameL.TabIndex = 50;
            this.LNameL.Text = "Last Name";
            // 
            // FNameL
            // 
            this.FNameL.AutoSize = true;
            this.FNameL.Location = new System.Drawing.Point(24, 31);
            this.FNameL.Name = "FNameL";
            this.FNameL.Size = new System.Drawing.Size(57, 13);
            this.FNameL.TabIndex = 49;
            this.FNameL.Text = "First Name";
            // 
            // NextB
            // 
            this.NextB.BackColor = System.Drawing.Color.SeaGreen;
            this.NextB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NextB.Location = new System.Drawing.Point(137, 289);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(83, 28);
            this.NextB.TabIndex = 48;
            this.NextB.Text = "Next";
            this.NextB.UseVisualStyleBackColor = false;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // CPasswordTextBox
            // 
            this.CPasswordTextBox.Location = new System.Drawing.Point(120, 152);
            this.CPasswordTextBox.Name = "CPasswordTextBox";
            this.CPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.CPasswordTextBox.TabIndex = 47;
            this.CPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(120, 122);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 46;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthBox.Location = new System.Drawing.Point(120, 217);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirthBox.TabIndex = 45;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(120, 92);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 44;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Location = new System.Drawing.Point(120, 62);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LNameTextBox.TabIndex = 43;
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(120, 32);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FNameTextBox.TabIndex = 42;
            this.FNameTextBox.TextChanged += new System.EventHandler(this.FNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mobile";
            // 
            // MobilTextBox
            // 
            this.MobilTextBox.Location = new System.Drawing.Point(120, 247);
            this.MobilTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MobilTextBox.Name = "MobilTextBox";
            this.MobilTextBox.Size = new System.Drawing.Size(100, 20);
            this.MobilTextBox.TabIndex = 60;
            // 
            // ShowPassCheckBox1
            // 
            this.ShowPassCheckBox1.AutoSize = true;
            this.ShowPassCheckBox1.Location = new System.Drawing.Point(225, 125);
            this.ShowPassCheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPassCheckBox1.Name = "ShowPassCheckBox1";
            this.ShowPassCheckBox1.Size = new System.Drawing.Size(53, 17);
            this.ShowPassCheckBox1.TabIndex = 61;
            this.ShowPassCheckBox1.Text = "Show";
            this.ShowPassCheckBox1.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox1.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox1_CheckedChanged);
            // 
            // ShowPassCheckBox2
            // 
            this.ShowPassCheckBox2.AutoSize = true;
            this.ShowPassCheckBox2.Location = new System.Drawing.Point(225, 148);
            this.ShowPassCheckBox2.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPassCheckBox2.Name = "ShowPassCheckBox2";
            this.ShowPassCheckBox2.Size = new System.Drawing.Size(53, 17);
            this.ShowPassCheckBox2.TabIndex = 62;
            this.ShowPassCheckBox2.Text = "Show";
            this.ShowPassCheckBox2.UseVisualStyleBackColor = true;
            this.ShowPassCheckBox2.CheckedChanged += new System.EventHandler(this.ShowPassCheckBox2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::VP_Project2.Properties.Resources.riverford_organic_farmers_office;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ShowPassCheckBox2);
            this.panel2.Controls.Add(this.ShowPassCheckBox1);
            this.panel2.Controls.Add(this.MobilTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.DomainBox);
            this.panel2.Controls.Add(this.DOBL);
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.CPasswordL);
            this.panel2.Controls.Add(this.PasswordL);
            this.panel2.Controls.Add(this.EmailL);
            this.panel2.Controls.Add(this.LNameL);
            this.panel2.Controls.Add(this.FNameL);
            this.panel2.Controls.Add(this.NextB);
            this.panel2.Controls.Add(this.CPasswordTextBox);
            this.panel2.Controls.Add(this.PasswordTextBox);
            this.panel2.Controls.Add(this.DateOfBirthBox);
            this.panel2.Controls.Add(this.EmailTextBox);
            this.panel2.Controls.Add(this.LNameTextBox);
            this.panel2.Controls.Add(this.FNameTextBox);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 331);
            this.panel2.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 45);
            this.label6.TabIndex = 65;
            this.label6.Text = "Get Started";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(396, 559);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton MaleG;
        private System.Windows.Forms.RadioButton FemaleG;
        private System.Windows.Forms.ComboBox DomainBox;
        private System.Windows.Forms.Label DOBL;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label CPasswordL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Label EmailL;
        private System.Windows.Forms.Label LNameL;
        private System.Windows.Forms.Label FNameL;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.TextBox CPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MobilTextBox;
        private System.Windows.Forms.CheckBox ShowPassCheckBox1;
        private System.Windows.Forms.CheckBox ShowPassCheckBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}