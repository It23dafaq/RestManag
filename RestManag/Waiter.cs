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

            using (OleDbDataAdapter sda = new OleDbDataAdapter(SQL2, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda.Fill(dat);
                listBox1.DataSource = dat;
                listBox1.DisplayMember = "Pname";
                listBox1.Click += click_do;
            }
        }

        private void click_do(object sender, EventArgs e)
        {
           
            if (listBox1.Text.Equals("Water"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/water.jpg");
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
            }else if (listBox1.Text.Equals("Red Wine"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/rwhine.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (listBox1.Text.Equals("White Wine"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/wwhine.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (listBox1.Text.Equals("Vodka")) {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/belfe.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }else if (listBox1.Text.Equals("Whiskey"))
            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/jonnie.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (listBox1.Text.Equals("Gin"))

            {
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/jin.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if(listBox1.Text.Equals("Rum"))
            {   //rum
                pictureBox1.Image = Image.FromFile("C:/Users/dafou/Documents/GitHub/RestManag-master/RestManag/Resources/diplomatias.jpg");
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
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

            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = listBox1.SelectedItems[0].ToString();
        }
    }
}
