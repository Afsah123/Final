using Online_mangement_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course course = new Course();   
            course.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();        
            teacher.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Section section = new Section();    
            section.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
                enrollment.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
                attendence.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  
                dashboard.Show();
        }
    }
}
