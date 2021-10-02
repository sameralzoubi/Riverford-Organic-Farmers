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
    public partial class Start : Form
    {
        SQLiteConnection DBProject;
        public Start()
        {
            InitializeComponent();     
            DBProject = new SQLiteConnection("Data Source=DB-Project.db;Version=3;");
            DBProject.Open();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text=="" || PasswordTextBox.Text=="")
            { MessageBox.Show("Required field missing"); }
            
            else
            {
                try
                {
                    if (UsernameTextBox.Text.Contains("@"))
                    {
                        // Check of Users
                        string sql2;
                        sql2 = "SELECT Password FROM Users WHERE Email = '" + UsernameTextBox.Text + "'; ";
                        SQLiteCommand command2 = new SQLiteCommand(sql2, DBProject);
                        SQLiteDataReader reder2 = command2.ExecuteReader();
                        string pass2 = "";
                        reder2.Read();
                        pass2 += reder2[0];
                        if (PasswordTextBox.Text == pass2)
                        {
                            string sqlID = "";
                            sqlID += "INSERT INTO orders (CustomerID) VALUES ('" + UsernameTextBox.Text + "')";
                            SQLiteCommand command3 = new SQLiteCommand(sqlID, DBProject);
                            command3.ExecuteNonQuery();
                            Order s2 = new Order();
                            this.Hide();
                            s2.Show();
                            MessageBox.Show("Welcome to My Store :)");
                        }
                        else
                            MessageBox.Show("Invalid Username or Password :( ");
                        
                    }
                    else
                    {
                        // Check of Admins
                        string sql;
                        sql = "SELECT Password FROM Admins WHERE Username = '" + UsernameTextBox.Text + "'; ";
                        SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                        SQLiteDataReader reder = command.ExecuteReader();
                        string pass = "";
                        reder.Read();
                        pass += reder[0];


                        if (PasswordTextBox.Text == pass)
                        {
                            Admin s2 = new Admin();
                            this.Hide();
                            s2.Show();
                            
                        }
                        else
                            MessageBox.Show("Invalid Username or Password :( ");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Username or Password :(");
                }
            
            }         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            SignUp si = new SignUp();
            si.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
                PasswordTextBox.UseSystemPasswordChar = false;
            else
                PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
