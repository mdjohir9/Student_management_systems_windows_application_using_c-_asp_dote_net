using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Student_m_enagement_systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Student_addmissions_form());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Teachears_Addmissions_systems());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Student_result_systems());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Exam_pise_systems());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Teachers_payment_systems());
        }
    }
}
