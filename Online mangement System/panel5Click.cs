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
    public partial class panel5Click : Form
    {
        public panel5Click()
        {
            InitializeComponent();
        }

        private void panel5Click_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EV555OQ\SQLEXPRESS;Initial Catalog=Projectdb;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("SELECT \r\n    crtab.*, \r\n    Studentab.StudentName, \r\n    Coursetab.CourseName\r\nFROM \r\n    crtab\r\nJOIN \r\n    Studentab ON crtab.StudentId = Studentab.StudentId\r\nJOIN \r\n    Coursetab ON crtab.CourseId = Coursetab.CourseId;\r\n", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
