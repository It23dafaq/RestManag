using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestManag
{
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();

            string SQL2 = "SELECT Pname FROM Product WHERE Category ='Drinks'";
            string SQL3 = "SELECT Pname FROM Product WHERE Category ='Appetizer'";
            string SQL4 = "SELECT Pname FROM Product WHERE Category ='Main Dish'";
            string SQL5 = "SELECT Pname FROM Product WHERE Category = 'Sweet'";


            using (OleDbDataAdapter sda = new OleDbDataAdapter(SQL2, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda.Fill(dat);
                drinksListBox.DataSource = dat;
                drinksListBox.DisplayMember = "Pname";
                drinksListBox.Click += click_do;
            }
            using (OleDbDataAdapter sda1 = new OleDbDataAdapter(SQL3, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda1.Fill(dat);
                appetizzerListBox.DataSource = dat;
                appetizzerListBox.DisplayMember = "Pname";
                appetizzerListBox.Click += click_do;
            }
            using (OleDbDataAdapter sda2 = new OleDbDataAdapter(SQL4, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda2.Fill(dat);
                mainDishListBox.DataSource = dat;
                mainDishListBox.DisplayMember = "Pname";
                mainDishListBox.Click += click_do;
            }
            using (OleDbDataAdapter sda3 = new OleDbDataAdapter(SQL5, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda3.Fill(dat);
                dessertListBox.DataSource = dat;
                dessertListBox.DisplayMember = "Pname";
                dessertListBox.Click += click_do;
            }
        }

        private void click_do(object sender, EventArgs e)
        {
           /*
            if (drinksListBox.Text.Equals("Water"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/water.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else if (drinksListBox.Text.Equals("Coke"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/coce.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (drinksListBox.Text.Equals("Sprite"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/sprite.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("Red Wine"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/rwhine.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("White Wine"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/wwhine.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("Vodka")) {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/belfe.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }else if (drinksListBox.Text.Equals("Whiskey"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/jonnie.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("Gin"))

            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/jin.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if(drinksListBox.Text.Equals("Rum"))
            {   //rum
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/diplomatias.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            */
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
                DataTable t = productTableAdapter.GetDataBy(drinksListBox.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());


            }
            else if (tabControl1.SelectedIndex == 2)
            {
                DataTable t = productTableAdapter.GetDataBy(appetizzerListBox.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                DataTable t = productTableAdapter.GetDataBy(mainDishListBox.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                DataTable t = productTableAdapter.GetDataBy(dessertListBox.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());


            }
            Double sum1 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            totalSum.Text = sum1.ToString();
            costLabel.Text = sum1.ToString();
            

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
    //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = listBox1.SelectedItems[0].ToString();
}
