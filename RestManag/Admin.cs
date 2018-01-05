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
            // TODO: This line of code loads data into the 'correctDatabaseDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.correctDatabaseDataSet.Payment);
            // TODO: This line of code loads data into the 'correctDatabaseDataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.correctDatabaseDataSet1.Order);
            // TODO: This line of code loads data into the 'correctDatabaseDataSet.Payroll' table. You can move, or remove it, as needed.
            this.payrollTableAdapter.Fill(this.correctDatabaseDataSet.Payroll);
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
                button.Image = RestManag.Properties.Resources.images;
                button.Tag = "green";
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.MouseHover += this.showSeats;
                button.Click += this.plox; 
                if (y==5) {
                    //tableLayoutPanel1.Controls.Add(button,y,x);
                    x++;
                    y = 1;
                }
                else {

                    //tableLayoutPanel1.Controls.Add(button,y,x);
                    y = y + 2;
                }
            }
        }

        public void plox(object sender, EventArgs e)
        {
            Button b = (Button)sender;
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
        
        private void showSeats(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int tcode = Int32.Parse(b.Text);
            int s=Int32.Parse(tableTableAdapter1.GetSeats2(tcode).Rows[0][0].ToString());
            b.Text = s.ToString();
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

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            String username=textBox2.Text;
            double salary = Double.Parse(textBox3.Text);
            double bonus = Double.Parse(textBox4.Text);
            if (usersTableAdapter1.checkUser(username) == 1) {
                payrollTableAdapter.UpdatePayroll(username, Convert.ToDecimal(salary), Convert.ToDecimal(bonus), username);
            }
            payrollTableAdapter.Fill(correctDatabaseDataSet.Payroll);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text,
                hour = hourSpin.Value.ToString(),
                minute = minuteSpin.Value.ToString();

            String time = hour + ":" + minute;
            String date = dateTimePicker.Value.ToShortDateString();
            DateTime dt2 = Convert.ToDateTime(time + " " + date);
            hoursTableAdapter.DeleteQuery(username, dt2);
            hoursTableAdapter.Fill(correctDatabaseDataSet.Hours);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            orderTableAdapter.Fill(correctDatabaseDataSet.Order);
        }

        private void refreshButtonPay_Click(object sender, EventArgs e)
        {
            paymentTableAdapter.Fill(correctDatabaseDataSet.Payment);
        }
        
        private void trapezia(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int tcode = Int32.Parse(b.Text);
            DataTable dt= tableTableAdapter1.GetSeats2(tcode);
            String s= dt.Rows[0]["Seats"].ToString();
            ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(b, "seats: "+s);


        }
    }
}
