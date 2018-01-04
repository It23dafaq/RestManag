using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace RestManag
{
    public partial class Waiter : Form
    {
        public Waiter()
        {    
           
            InitializeComponent();

            //pictureBox5.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/order2.png");
            this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;

            string SQL6 = "SELECT Pname,Price FROM Product";
            string SQL2 = "SELECT Pname FROM Product WHERE Category ='Drinks'";
            string SQL3 = "SELECT Pname FROM Product WHERE Category ='Appetizer'";
            string SQL4 = "SELECT Pname FROM Product WHERE Category ='Main Dish'";
            string SQL5 = "SELECT Pname FROM Product WHERE Category = 'Sweet'";

            

           

            using (OleDbDataAdapter sda = new OleDbDataAdapter(SQL2, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda.Fill(dat);
                listBox1.DataSource = dat;
                listBox1.DisplayMember = "Pname";
                listBox1.Click += click_do;
            }
            using (OleDbDataAdapter sda1 = new OleDbDataAdapter(SQL3, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda1.Fill(dat);
                listBox2.DataSource = dat;
                listBox2.DisplayMember = "Pname";
                listBox2.Click += click_do;
            }
            using (OleDbDataAdapter sda2 = new OleDbDataAdapter(SQL4, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda2.Fill(dat);
                listBox3.DataSource = dat;
                listBox3.DisplayMember = "Pname";
                listBox3.Click += click_do;
            }
            using (OleDbDataAdapter sda3 = new OleDbDataAdapter(SQL5, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda3.Fill(dat);
                listBox4.DataSource = dat;
                listBox4.DisplayMember = "Pname";
                listBox4.Click += click_do;
            }
        }

        private void click_do(object sender, EventArgs e)
        {
            //drinks
            if (listBox1.Text.Equals("Water"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/water1.jpg");
                
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else if (listBox1.Text.Equals("Coke"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/coce.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                
            }
            else if (listBox1.Text.Equals("Sprite"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/sprite.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("Red Wine"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/rwhine.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("White Wine"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/wwhine.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("Vodka"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/belfe.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else if (listBox1.Text.Equals("Whiskey"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/jonnie.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("Gin"))

            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/jin1.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("Rum"))
            {   //rum
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/diplomatias.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }


            //apertizers
            if (listBox2.Text.Equals("Fried Potatoes"))

            {
                pictureBox2.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/patates.jpg");
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox2.Text.Equals("Grilled Potatoes"))

            {
                pictureBox2.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/patates1.jpg");
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox2.Text.Equals("Greek Cheese"))

            {
                pictureBox2.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/tiraki.jpg");
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox2.Text.Equals("Yeast Rolls"))

            {
                pictureBox2.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/mana.jpg");
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            //Main dish
            if (listBox3.Text.Equals("Chicken Wings"))
            {
                pictureBox3.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/kotopoulo.jpeg");
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox3.Text.Equals("Deluxe Burger"))
            {
                pictureBox3.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/burger.png");
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox3.Text.Equals("Seafood Pasta"))
            {
                pictureBox3.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/seafood1.jpg");
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox3.Text.Equals("Roasted Rack of Lamp"))
            {
                pictureBox3.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/lamp.jpg");
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            //desert
            if (listBox4.Text.Equals("Chocolate Ball"))
            {
                pictureBox4.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/chocoball1.jpg");
                this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox4.Text.Equals("Cheese Cake"))
            {
                pictureBox4.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/cheesecake.jpg");
                this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox4.Text.Equals("Mille Feuille"))
            {
                pictureBox4.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/milfake.jpeg");
                this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
            

            
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Drinks_Click(object sender, EventArgs e)
        {

        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'correctDatabaseDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.correctDatabaseDataSet.Payment);
            // TODO: This line of code loads data into the 'correctDatabaseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.correctDatabaseDataSet.Order);
            // TODO: This line of code loads data into the 'correctDatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.correctDatabaseDataSet.Product);

        }

        private void Logoutw_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //listbox must to be group 
            if (tabControl1.SelectedIndex == 1)
            {
                DataTable t = productTableAdapter.GetDataBy(listBox1.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(),t.Rows[0]["Price"].ToString());

               
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                DataTable t = productTableAdapter.GetDataBy(listBox2.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                DataTable t = productTableAdapter.GetDataBy(listBox3.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                DataTable t = productTableAdapter.GetDataBy(listBox4.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());


            }
           
           
        }


    }
    }
        
    
