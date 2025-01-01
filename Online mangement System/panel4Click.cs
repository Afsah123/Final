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

namespace Online_mangement_System
{
    public partial class panel4Click : Form
    {
        public panel4Click()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* string connectionString = (@"Data Source=DESKTOP-EV555OQ\\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
             string query = "SELECT * FROM coursetab";

             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 try
                 {
                     connection.Open();

                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         SqlDataReader reader = command.ExecuteReader();
                         if (reader.Read())
                         {
                             string data = reader["ColumnName"].ToString();
                             MessageBox.Show($"Data: {data}", "Database Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {
                             MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from coursetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;*/
        }

        private void panel4Click_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from coursetab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
        }
    }
}
