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
              //  button.Image = Image.FromFile(@"^B30A33B3F310F5203A93CD135AC3732367BC7355D0F90C89B8^pimgpsh_fullsize_distr.png");

                

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
    }
}
