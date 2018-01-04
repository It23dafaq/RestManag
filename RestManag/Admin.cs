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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            showTables();
            
           
            

        }




        public void setDays()
        {
            //TODO
        }



       

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'correctDatabaseDataSet.Hours' table. You can move, or remove it, as needed.
            this.hoursTableAdapter.Fill(this.correctDatabaseDataSet.Hours);
            // TODO: This line of code loads data into the 'restDatabaseDataSet1.Table' table. You can move, or remove it, as needed.




        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }


       

        private void showTables() {
            

            int cmdi = (int)tableTableAdapter1.countables();
            

            int x = 0;
            int y = 1;


            for (int i = 0; i < cmdi; i++)
            {
                 Button button = new Button();

                button.Text = tableTableAdapter1.GetTableCode().Rows[i][0].ToString();
                button.AutoSize = true;
                button.BackColor = Color.Green;
                button.Click += this.pacman; 
                
                  
                

                

                if (y==5) {
                    tableLayoutPanel1.Controls.Add(button,y,x);
                    x++;
                    y = 1;
                }
                else {

                    tableLayoutPanel1.Controls.Add(button,y,x);
                    y = y + 2;
                }

                
               
              
             
                

               

                
               
                

            }



        }

        public void pacman(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            b.BackColor = Color.Red;

            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text,
                hour = hourSpin.Value.ToString(),
                minute = minuteSpin.Value.ToString();
            
            String time = hour  +":"+ minute;
            int duration = (int)(durationSpin.Value);
            String date = dateTimePicker.Value.ToShortDateString();
            DateTime dt2 =  Convert.ToDateTime(time + " "+ date );
            if (usersTableAdapter1.checkUser(username) == 1)
            {
                hoursTableAdapter.InsertHours(username, dt2, DateTime.Now, duration);
                hoursTableAdapter.Fill(correctDatabaseDataSet.Hours);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text,
                hour = hourSpin.Value.ToString(),
                minute = minuteSpin.Value.ToString();

            String time = hour + ":" + minute;
            String date = dateTimePicker.Value.ToShortDateString();
            DateTime dt2 = Convert.ToDateTime(time + " " + date);
            hoursTableAdapter.DeleteQuery(username, dt2);
            //hoursBindingSource.RemoveAt(opws);
            hoursTableAdapter.Fill(correctDatabaseDataSet.Hours);
        }
    }
}
