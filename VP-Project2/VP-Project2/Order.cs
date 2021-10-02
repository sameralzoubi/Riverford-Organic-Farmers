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
    
    public partial class Order : Form
    {
        SQLiteConnection DBProject;
        double sum = 0;

        public Order()
        {
            InitializeComponent();
            DBProject = new SQLiteConnection("Data Source=DB-Project.db;Version=3;");
            DBProject.Open();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            UserClass user = new UserClass();
            string sqlOID = "SELECT max(orderID) FROM orders;";
            SQLiteCommand c = new SQLiteCommand(sqlOID, DBProject);
            SQLiteDataReader reder = c.ExecuteReader();
            reder.Read();
            string sql2;
            sql2 = "Select CustomerID FROM Orders WHERE orderID=" + reder[0] + ";";
            SQLiteCommand c2 = new SQLiteCommand(sql2, DBProject);
            SQLiteDataReader reder2 = c2.ExecuteReader();
            reder2.Read();

            string sql3;
            sql3 = "Select FName FROM Users WHERE Email='" + reder2[0] + "';";
            SQLiteCommand c3 = new SQLiteCommand(sql3, DBProject);
            SQLiteDataReader reder3 = c3.ExecuteReader();
            reder3.Read();
            // MessageBox.Show(reder3[0].ToString());
            user.Name = reder3[0].ToString();
            NameOfUserLabel.Text = user.Name;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int index = BillListBox.SelectedIndex;
                int quy = int.Parse(QuantityListBox.Items[index].ToString());
                quy++;
                QuantityListBox.Items.RemoveAt(index);
                QuantityListBox.Items.Insert(index, quy);
                sum += double.Parse(PriceListBox.Items[index].ToString());
                SumLabel.Text = sum.ToString();
                TotalLabel.Text = (sum + (sum * 0.16)).ToString();
                TotalListBox.Items.RemoveAt(index);
                TotalListBox.Items.Insert(index, quy * double.Parse(PriceListBox.Items[index].ToString()));

                QLabel.Text = quy.ToString();
            }
            catch
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BillListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = BillListBox.SelectedIndex;
                int quy = int.Parse(QuantityListBox.Items[index].ToString());
                QLabel.Text = quy.ToString();
            }
            catch
            {

            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int index = BillListBox.SelectedIndex;
                int quy = int.Parse(QuantityListBox.Items[index].ToString());
                quy--;
                sum -= double.Parse(PriceListBox.Items[index].ToString());
                SumLabel.Text = sum.ToString();
                TotalLabel.Text = (sum - (sum * 0.16)).ToString();
                TotalListBox.Items.RemoveAt(index);
                TotalListBox.Items.Insert(index, quy * double.Parse(PriceListBox.Items[index].ToString()));
                if (quy == 0)
                {
                    BillListBox.Items.RemoveAt(index);
                    PriceListBox.Items.RemoveAt(index);
                    QuantityListBox.Items.RemoveAt(index);
                    TotalListBox.Items.RemoveAt(index);
                    QLabel.Text = "";
                }
                else
                {
                    QuantityListBox.Items.RemoveAt(index);
                    QuantityListBox.Items.Insert(index, quy);
                    QLabel.Text = quy.ToString();
                }
            }
            catch
            {

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //checkout Button
            try
            {
                DateTime now = DateTime.Now;
                string sql;
                string sqlOID = "SELECT max(orderID) FROM orders;";
                SQLiteCommand c = new SQLiteCommand(sqlOID, DBProject);
                SQLiteDataReader reder = c.ExecuteReader();
                reder.Read();
                //MessageBox.Show(reder[0].ToString());
                //string sqlCID = "SELECT customerID FROM orders where orderID='" + sqlOID + "';";
                sql = "UPDATE orders SET orderDate = '" + now.ToString() + "', orderTotal =" + double.Parse(TotalLabel.Text) + " WHERE orderID =" + reder[0] + ";";
                SQLiteCommand command = new SQLiteCommand(sql, DBProject);
                command.ExecuteNonQuery();
                MessageBox.Show("Your order has been processed sucessfully!");
                Application.Exit();
            }
            catch
            {

            }
        }

        //items buttons
        private void TomatoButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Tomato'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Tomato"))
            {
                int i = BillListBox.Items.IndexOf("Tomato");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Tomato");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {

                BillListBox.Items.Add("Tomato");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Tomato"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();

        }
        private void PotatoButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Potato'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Potato"))
            {
                int i = BillListBox.Items.IndexOf("Potato");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Potato");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Potato");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Potato"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void CucumberButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Cucumber'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Cucumber"))
            {
                int i = BillListBox.Items.IndexOf("Cucumber");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Cucumber");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Cucumber");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Cucumber"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void OnionsButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Onion'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Onion"))
            {
                int i = BillListBox.Items.IndexOf("Onion");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Onion");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Onion");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Onion"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void GarlicButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Garlic'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Garlic"))
            {
                int i = BillListBox.Items.IndexOf("Garlic");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Garlic");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {

                BillListBox.Items.Add("Garlic");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Garlic"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void PepperButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Pepper'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Pepper"))
            {
                int i = BillListBox.Items.IndexOf("Pepper");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Pepper");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Pepper");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Pepper"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void BroccoliButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Brocoli'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Brocoli"))
            {
                int i = BillListBox.Items.IndexOf("Brocoli");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Brocoli");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Brocoli");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Brocoli"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void MushroomButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Mushroom'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Mushroom"))
            {
                int i = BillListBox.Items.IndexOf("Mushroom");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Mushroom");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Mushroom");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Mushroom"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void CarrotButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Carrot'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Carrot"))
            {
                int i = BillListBox.Items.IndexOf("Carrot");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Carrot");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Carrot");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Carrot"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }
        //*************************************************************************************
        private void AppleButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Apple'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Apple"))
            {
                int i = BillListBox.Items.IndexOf("Apple");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Apple");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Apple");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Apple"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void CherryButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Cherry'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Cherry"))
            {
                int i = BillListBox.Items.IndexOf("Cherry");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Cherry");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Cherry");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Cherry"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void ApricotButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Apricot'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Apricot"))
            {
                int i = BillListBox.Items.IndexOf("Apricot");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Apricot");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {

                BillListBox.Items.Add("Apricot");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Apricot"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void GrapefruitButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Grapefruit'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Grapefruit"))
            {
                int i = BillListBox.Items.IndexOf("Grapefruit");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Grapefruit");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Grapefruit");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Grapefruit"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void BerryButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Blueberry'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Blueberry"))
            {
                int i = BillListBox.Items.IndexOf("Blueberry");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Blueberry");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }

            else
            {
                BillListBox.Items.Add("Blueberry");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Blueberry"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void KiwiButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Kiwi'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Kiwi"))
            {
                int i = BillListBox.Items.IndexOf("Kiwi");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Kiwi");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {
                BillListBox.Items.Add("Kiwi");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Kiwi"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void WatermelonButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Watermelon'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Watermelon"))
            {
                int i = BillListBox.Items.IndexOf("Watermelon");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Watermelon");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {
                BillListBox.Items.Add("Watermelon");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Watermelon"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void BananaButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Banana'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Banana"))
            {
                int i = BillListBox.Items.IndexOf("Banana");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Banana");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {

                BillListBox.Items.Add("Banana");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Banana"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            double price = 0;
            string sql;
            sql = "SELECT Price FROM Product where Name='Orange'";
            SQLiteCommand command = new SQLiteCommand(sql, DBProject);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            string p = "";
            p += reader[0];
            price = double.Parse(p);
            if (BillListBox.Items.Contains("Orange"))
            {
                int i = BillListBox.Items.IndexOf("Orange");
                int qty = int.Parse(QuantityListBox.Items[i].ToString()) + 1;
                QuantityListBox.Items.RemoveAt(i);
                QuantityListBox.Items.Insert(i, qty);
                int idx = BillListBox.Items.IndexOf("Orange");
                double tot = double.Parse(QuantityListBox.Items[idx].ToString()) * double.Parse(PriceListBox.Items[idx].ToString());
                TotalListBox.Items.RemoveAt(idx);
                TotalListBox.Items.Insert(idx, tot);
            }


            else
            {

                BillListBox.Items.Add("Orange");
                PriceListBox.Items.Add(price);
                QuantityListBox.Items.Add(1);
                TotalListBox.Items.Insert(BillListBox.Items.IndexOf("Orange"), price);

            }
            sum += price;
            SumLabel.Text = sum.ToString();
            TotalLabel.Text = (sum + (sum * 0.16)).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
