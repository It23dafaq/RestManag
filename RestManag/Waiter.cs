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
            string SQL6 = "SELECT Pname FROM Product WHERE Category='Salad'";

            Addbutton.Visible = false;
            Removebutton.Visible = false;
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
            using (OleDbDataAdapter sda4 = new OleDbDataAdapter(SQL6, Properties.Settings.Default.CorrectDatabaseConnectionString))
            {
                DataTable dat = new DataTable();
                sda4.Fill(dat);
                listBox1.DataSource = dat;
                listBox1.DisplayMember = "Pname";
                listBox1.Click += click_do;
            }
           

        }
        private Double sum1 = 0.0;
        private void click_do(object sender, EventArgs e)
        {
           
            if (drinksListBox.Text.Equals("Water"))
            {
                pictureBox1.Image = RestManag.Properties.Resources.water;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                
            }
            else if (drinksListBox.Text.Equals("Coke"))
            {
                pictureBox1.Image = RestManag.Properties.Resources.coce;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (drinksListBox.Text.Equals("Sprite"))
            {
                pictureBox1.Image = RestManag.Properties.Resources.sprite;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("Red Wine"))
            {
                pictureBox1.Image = RestManag.Properties.Resources.rwhine;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("White Wine"))
            {
                pictureBox1.Image = RestManag.Properties.Resources.wwhine;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("Vodka")) {
                pictureBox1.Image = RestManag.Properties.Resources.belfe;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }else if (drinksListBox.Text.Equals("Whiskey"))
            {
                pictureBox1.Image = RestManag.Properties.Resources.jonnie;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }else if (drinksListBox.Text.Equals("Gin"))

            {
                pictureBox1.Image = RestManag.Properties.Resources.jin;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if(drinksListBox.Text.Equals("Rum"))
            {   //rum
                pictureBox1.Image = RestManag.Properties.Resources.diplomatias;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if (appetizzerListBox.Text.Equals("Fried Potatoes")) {
                pictureBox2.Image = RestManag.Properties.Resources.patates;
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (appetizzerListBox.Text.Equals("Grilled Potatoes")){ 
            pictureBox2.Image = RestManag.Properties.Resources.patates1;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (appetizzerListBox.Text.Equals("Greek Cheese")){
                pictureBox2.Image = RestManag.Properties.Resources.tiraki;
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (appetizzerListBox.Text.Equals("Yeast Rolls"))
            {
                pictureBox2.Image = RestManag.Properties.Resources.mana;
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox2.Image = RestManag.Properties.Resources.party_poppers;
                this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if (mainDishListBox.Text.Equals("Chicken Wings"))
            {
                pictureBox3.Image = RestManag.Properties.Resources.kotopoulo;
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (mainDishListBox.Text.Equals("Deluxe Burger"))
            {
                pictureBox3.Image = RestManag.Properties.Resources.burger;
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (mainDishListBox.Text.Equals("Seafood Pasta"))
            {
                pictureBox3.Image = RestManag.Properties.Resources.seafood1;
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox3.Image = RestManag.Properties.Resources.lamp;
                this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            if (listBox1.Text.Equals("Green Salad"))
            {
                pictureBox5.Image = RestManag.Properties.Resources.greensalad;
                this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("Curry Salad"))
            {
                pictureBox5.Image = RestManag.Properties.Resources.currysalad;
                this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (listBox1.Text.Equals("Coleslaw"))
            {
                pictureBox5.Image = RestManag.Properties.Resources.coleslawsalad;
                this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox5.Image = RestManag.Properties.Resources.chefsalad;
                this.pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if (dessertListBox.Text.Equals("Chocolate Ball"))
            {
                pictureBox4.Image = RestManag.Properties.Resources.chocoball1;
                this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (dessertListBox.Text.Equals("Cheese Cake"))
            {
                pictureBox4.Image = RestManag.Properties.Resources.cheesecake;
                this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox4.Image = RestManag.Properties.Resources.milfake;
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
                DataTable t = productTableAdapter.GetDataBy(listBox1.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                DataTable t = productTableAdapter.GetDataBy(mainDishListBox.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                DataTable t = productTableAdapter.GetDataBy(dessertListBox.Text);
                dataGridView1.Rows.Add(t.Rows[0]["Pname"].ToString(), t.Rows[0]["Price"].ToString());


            }

            this.addCost();
        }

        private void plox(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tableLabel.Text = b.Text;
            if (b.Tag == "green")
            {
                b.Image = RestManag.Properties.Resources.images2;

                b.Tag = "red";
            }
            else
            {
                b.Image = RestManag.Properties.Resources.images;
                b.Tag = "green";
            }
        }
        private void trapezia(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int tcode = Int32.Parse(b.Text);
            DataTable dt = tableTableAdapter1.GetSeats2(tcode);
            String s = dt.Rows[0]["Seats"].ToString();
            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(b, "seats: " + s);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Addbutton.Visible = false;
                Removebutton.Visible = false;
            }
            else
            {

                Addbutton.Visible = true;
                Removebutton.Visible = true;
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                this.addCost();
            }
        }

        private void addCost()
        {
            sum1 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells["Price"].Value);
            }
            totalSum.Text = sum1.ToString() + " €";
            costLabel.Text = sum1.ToString() + " €";
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            String table = tableLabel.Text;
            String user = Login.username;
            String comments = richTextBox1.Text;
            String pname;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                pname = dataGridView1.Rows[i].Cells["Pname"].Value.ToString();
                DataTable dt=productTableAdapter.GetCode(pname);
                int pcode = Int32.Parse(dt.Rows[0]["Code"].ToString());
                orderTableAdapter.InsertOrder(i, pcode, Convert.ToInt32(table), user, DateTime.Now, Convert.ToDecimal(sum1), comments);
            }
        }
    }
}

