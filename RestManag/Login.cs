using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace RestManag
{
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usersTableAdapter1.checkLogin(textBox1.Text, textBox2.Text, 1).Value==1)
            {
                this.Hide();
                Admin a = new Admin();
                a.Show();
            }

            else if (usersTableAdapter1.checkLogin(textBox1.Text, textBox2.Text, 0).Value == 1)
            {
                this.Hide();
                Waiter w = new Waiter(); // This is bad
                w.Show();

            }
            else
            {
                MessageBox.Show("please check you username and password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
