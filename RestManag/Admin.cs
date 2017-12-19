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

namespace RestManag
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            String month = dateTimePicker1.Value.ToString("MMMM");
            String year = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
            Monthla.Text = month.ToString()+" "+year.ToString();
            

        }




        public void setDays()
        {
            //TODO
            int day = dateTimePicker1.Value.Day;
            int nextday = day + 1;
            SavvatoLabel.Text = day.ToString();
            Kiriakilebel.Text = nextday.ToString();
           

        
        }

        private void Addstaff_Click(object sender, EventArgs e)
        {
           
            String sql = "Select * from Rest where ISAdmin=0" ;
            DataTable results = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Rest;Integrated Security=True;Pooling=False"))
            using (SqlCommand command = new SqlCommand(sql, conn))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                dataAdapter.Fill(results);
            
            
        }




    }
}
