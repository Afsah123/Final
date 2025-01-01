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
    public partial class Course_registration : Form
    {
        public Course_registration()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/mm/yyyy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into crtab values(@RegistrationId,@StudentId,@CourseId,@EnrollDate)", con);
            cnn.Parameters.AddWithValue("@RegistrationId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentId", textBox2.Text);

            cnn.Parameters.AddWithValue("@CourseId", textBox3.Text);
            cnn.Parameters.AddWithValue("@EnrollDate", dateTimePicker2.Value);
            
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from crtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("update crtab set StudentId=@StudentId,CourseId=@CourseId,EnrollDate=@EnrollDate where RegistrationId=@RegistrationId", con);
            cnn.Parameters.AddWithValue("@RegistrationId", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@StudentId", textBox2.Text);

            cnn.Parameters.AddWithValue("@CourseId", textBox3.Text);
            cnn.Parameters.AddWithValue("@EnrollDate", dateTimePicker2.Value);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete crtab where RegistrationId=@RegistrationId", con);
            cnn.Parameters.AddWithValue("@EId", textBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from crtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Course_registration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("SELECT \r\n    crtab.*, \r\n    Studentab.StudentName, \r\n    Coursetab.CourseName\r\nFROM \r\n    crtab\r\nJOIN \r\n    Studentab ON crtab.StudentId = Studentab.StudentId\r\nJOIN \r\n    Coursetab ON crtab.CourseId = Coursetab.CourseId;\r\n", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
