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
using System.IO;

namespace VP_Project2
{
    public partial class Admin : Form
    {
        SQLiteConnection DBProject;
        public Admin()
        {
            InitializeComponent();
            DBProject = new SQLiteConnection("Data Source=DB-Project.db;Version=3;");
            DBProject.Open();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string SQLTableProduct = "SELECT * FROM Product;";
            SQLiteCommand command = new SQLiteCommand(SQLTableProduct, DBProject);
            SQLiteDataAdapter sd = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            string SQLTableUsers = "SELECT * FROM Users;";
            SQLiteCommand command3 = new SQLiteCommand(SQLTableUsers, DBProject);
            SQLiteDataAdapter sd3 = new SQLiteDataAdapter(command3);
            DataTable dt3 = new DataTable();
            sd3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            string SQLTableOrders = "SELECT * FROM Orders;";
            SQLiteCommand command4 = new SQLiteCommand(SQLTableOrders, DBProject);
            SQLiteDataAdapter sd4 = new SQLiteDataAdapter(command4);
            DataTable dt4 = new DataTable();
            sd4.Fill(dt4);
            dataGridView2.DataSource = dt4;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //try
           // {
                string sqlOID = "SELECT max(ProductID) FROM Product;";
                SQLiteCommand c = new SQLiteCommand(sqlOID, DBProject);
                SQLiteDataReader reder = c.ExecuteReader();
                reder.Read();
                string sql = "";
                sql += "UPDATE Product SET Name = '" + NameTextBox.Text + "', Quantity =" + int.Parse(QuantityTextBox.Text) + ",Cost=" + float.Parse(CostTextBox.Text) + ",Price=" + float.Parse(PriceTextBox.Text) + " WHERE ProductID =" + reder[0] + ";";
                //sql = "INSERT INTO Product (ProductID, Name, Quantity, Cost, Price) VALUES (" + int.Parse(ProductIDTextBox.Text) + ", '" + NameTextBox.Text + "', " + int.Parse(QuantityTextBox.Text) + ", " + float.Parse(CostTextBox.Text) + ", " + float.Parse(PriceTextBox.Text) + ")";
                //sql += "INSERT INTO Product (Name, Quantity, Cost, Price) VALUES ('" + NameTextBox.Text + "', " + int.Parse(QuantityTextBox.Text) + ", " + float.Parse(CostTextBox.Text) + ", " + float.Parse(PriceTextBox.Text) + ");";
                SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                command.ExecuteNonQuery();
                string SQLTableProduct = "SELECT * FROM Product;";
                SQLiteCommand commandSelect = new SQLiteCommand(SQLTableProduct, DBProject);
                SQLiteDataAdapter sd = new SQLiteDataAdapter(commandSelect);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
           // }
           // catch
           // {
           //     MessageBox.Show("Duplicate entry for same Product ID,Try a different product ID.");
           // }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = (int)ColumnUpDown.Value;
                string nameofcolumn = "";
                string value = "";
                if (x == 1)
                {
                    dataGridView1.SelectedRows[0].Cells[x].Value = textBox1.Text;
                    nameofcolumn += "Name";
                    value += "'" + textBox1.Text + "'";
                }
                else if (x == 2)
                {
                    dataGridView1.SelectedRows[0].Cells[x].Value = int.Parse(textBox1.Text);
                    nameofcolumn += "Quantity";
                    value += textBox1.Text;
                }
                else if (x == 3 || x == 4)
                {
                    dataGridView1.SelectedRows[0].Cells[x].Value = float.Parse(textBox1.Text);
                    if (x == 3)
                        nameofcolumn += "Cost";
                    else
                        nameofcolumn += "Price";
                    value += textBox1.Text;
                }
                string sql;
                sql = "UPDATE Product SET " + nameofcolumn + " = " + value + " WHERE ProductID = " + dataGridView1.SelectedRows[0].Cells[0].Value + ";";
                SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Type Mismatch");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "DELETE FROM Product WHERE ProductID = " + dataGridView1.SelectedRows[0].Cells[0].Value + ";";
                SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                command.ExecuteNonQuery();
                string SQLTableProduct = "SELECT * FROM Product;";
                SQLiteCommand command2 = new SQLiteCommand(SQLTableProduct, DBProject);
                SQLiteDataAdapter sd2 = new SQLiteDataAdapter(command2);
                DataTable dt2 = new DataTable();
                sd2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            catch
            {

            }
        }

        private void GetEmailButton_Click(object sender, EventArgs e)
        {
            string sql;
            var writer = new StreamWriter("test.txt");
            sql = "SELECT DISTINCT CustomerID FROM Orders;";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reder = command.ExecuteReader();
            string line = "";
            while (reder.Read())
            {
                line += reder[0].ToString() + "\n";
            }
            writer.WriteLine(line);
            writer.Close();       
        }

        private void AddOrdersButtons_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("or.txt");
            while(!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(' ');
                string sql = "";
                sql = "INSERT INTO Orders (CustomerID ,orderDate ,orderTotal) VALUES ('" + line[0] + "','" + line[1] + "'," + line[2] + ");";
                SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                command.ExecuteNonQuery();
            }
            reader.Close();
            string SQLTableOrders = "SELECT * FROM Orders;";
            SQLiteCommand command4 = new SQLiteCommand(SQLTableOrders, DBProject);
            SQLiteDataAdapter sd4 = new SQLiteDataAdapter(command4);
            DataTable dt4 = new DataTable();
            sd4.Fill(dt4);
            dataGridView2.DataSource = dt4;
        }

        private void GenderEmailButton_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (comboBox1.Text == "")
            { MessageBox.Show("No Gender selected");
                return;
            }
            else if (comboBox1.Text == "Male")
                Gender += "M";
            else //(comboBox1.Text == "Female")
                Gender += "F";
            string sql = "";
            sql = "SELECT Email FROM Users WHERE Gender = '" + Gender + "';";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reder = command.ExecuteReader();
            string output = "";
            while (reder.Read())
            {
                output += reder[0] + "\n";
            }
            MessageBox.Show(output);
        }
    }
}
