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
        private OleDbConnection con;
        private String cmd;
        private OleDbDataAdapter da,da1;
        private DataTable dt,dt1;
        
        
 


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
            
             con = new OleDbConnection (@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Stratos\Documents\GitHub\RestManag\RestManag\CorrectDatabase.accdb");
             cmd = ("Select Count(*) FROM Users where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'" + " and Category=1");
             da1 = new OleDbDataAdapter(cmd, con);
             dt1 = new DataTable();
             da1.Fill(dt1);
            

            da = new OleDbDataAdapter("Select Count(*) FROM Users where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'" + " and Category=0", con);
            dt = new DataTable();
            da.Fill(dt);
           
            if (dt.Rows[0][0].ToString() == "1")
            { 
                Waiter w = new Waiter(); // This is bad
                w.Show();
                
            }
            else if(dt1.Rows[0][0].ToString()== "1"){
                this.Hide();
                Admin a = new Admin();
                a.Show();
            }else
            {
                MessageBox.Show("please check you username and password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
