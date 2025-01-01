using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Online_mangement_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           // Click panel3.Click += Panel3_Click;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display1();
            display2();
            display3();
            display4();
            display5();
        }

        private void display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM studentab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0) 
            {
                label4.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label4.Text = "0";
            }

            con.Close();
        }

        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM coursetab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label5.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label5.Text = "0";
            }

            con.Close();
        }

        private void display3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM teachertab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label6.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label6.Text = "0";
            }

            con.Close();
        }

        private void display4()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM entab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label8.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label8.Text = "0";
            }

            con.Close();
        }

        private void display5()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(RegistrationID) FROM crtab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label10.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label10.Text = "0";
            }

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel3click panel3Click = new panel3click();
            panel3Click.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4Click panel4Click = new panel4Click();
            panel4Click.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel15Click panel15Click = new Panel15Click(); 
                    panel15Click.Show();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel16Click panel16Click = new panel16Click(); 
                                panel16Click.Show();        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5Click panel5Click = new panel5Click();
            panel5Click.Show();
        }

       
    }
}
