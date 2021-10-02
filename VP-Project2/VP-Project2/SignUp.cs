using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace VP_Project2
{
    
    public partial class SignUp : Form
    {
        SQLiteConnection DBProject;
        
        private void SignUp_Load(object sender, EventArgs e)
        {        
            DBProject = new SQLiteConnection("Data Source=DB-Project.db;Version=3;");
            DBProject.Open();
            
        }

        public SignUp()
        {
            InitializeComponent();
           
        }

        private void FNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextB_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (MaleG.Checked == true)
                Gender = "M";
            else Gender = "F";
            if (String.IsNullOrEmpty(FNameTextBox.Text)|| String.IsNullOrEmpty(LNameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) ||
                String.IsNullOrEmpty(DomainBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text) || String.IsNullOrEmpty(CPasswordTextBox.Text) ||
                String.IsNullOrEmpty(Gender)||String.IsNullOrEmpty(MobilTextBox.Text))
            {
                MessageBox.Show("Required field missing ");
            }
            else
            {
                if (FNameTextBox.Text.Contains('0') || FNameTextBox.Text.Contains('1') || FNameTextBox.Text.Contains('2') || FNameTextBox.Text.Contains('3') ||
                 FNameTextBox.Text.Contains('4') || FNameTextBox.Text.Contains('5') || FNameTextBox.Text.Contains('6') || FNameTextBox.Text.Contains('7') ||
                 FNameTextBox.Text.Contains('8') || FNameTextBox.Text.Contains('9') || LNameTextBox.Text.Contains('0') || LNameTextBox.Text.Contains('1') || LNameTextBox.Text.Contains('2') ||
                 LNameTextBox.Text.Contains('3') || LNameTextBox.Text.Contains('4') || LNameTextBox.Text.Contains('5') || LNameTextBox.Text.Contains('6') || LNameTextBox.Text.Contains('7') ||
                 LNameTextBox.Text.Contains('8') || LNameTextBox.Text.Contains('9'))
                {
                    MessageBox.Show("Name fields cannot contain numbers ");
                }
                else
                {
                    if (EmailTextBox.Text[0] >= '0' && EmailTextBox.Text[0] <= '9')
                        MessageBox.Show("Email address cannot start with a number");
                    else
                    {
                        if (PasswordTextBox.Text == CPasswordTextBox.Text)
                        {
                            String s = MobilTextBox.Text;
                            int i;
                            for (i = 0; i < s.Length; i++)
                            {
                                if (s[i] > '9')
                                    break;
                            }
                            if (i == s.Length)
                            {
                                try
                                {
                                    string sql;
                                    string EmailFull = EmailTextBox.Text + DomainBox.Text;
                                    string DOB = DateOfBirthBox.Value.ToString();
                                    sql = "INSERT INTO Users (FName, LName, Email, Password, Gender, DOB, Mobile) VALUES ('" + FNameTextBox.Text + "', '" + LNameTextBox.Text + "', '" + EmailFull + "', '" + PasswordTextBox.Text + "', '" + Gender + "', '" + DOB + "', " + int.Parse(MobilTextBox.Text) + ")";
                                    SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Registration Successful");
                                    this.Close();
                                    Order o = new Order();
                                    o.Show();
                                }
                                catch
                                {
                                    MessageBox.Show("This email address is already being used, login instead?");
                                }
                            }
                            else
                                MessageBox.Show("Invalid Mobile Number");

                        }
                        else
                            MessageBox.Show("Passwords do not match");
                    }

                }
            }
            
                
        }

        private void MaleG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowPassCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox1.Checked)
                PasswordTextBox.UseSystemPasswordChar = false;
            else
                PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ShowPassCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox2.Checked)
                CPasswordTextBox.UseSystemPasswordChar = false;
            else
                CPasswordTextBox.UseSystemPasswordChar = true;
        }

    }
}
