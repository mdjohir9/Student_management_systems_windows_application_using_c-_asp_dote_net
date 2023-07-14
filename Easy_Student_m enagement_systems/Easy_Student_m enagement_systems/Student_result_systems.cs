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
    public partial class Student_result_systems : Form
    {
        public Student_result_systems()
        {
            InitializeComponent();
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iQuilt;
                iQuilt = MessageBox.Show("Confirm if you want to Exit", "c# Dialoge Systems", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iQuilt == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void reset_btn_Click(object sender, EventArgs e)
        {
            rt_transcieft.Clear();
            Combo_course_code.Items.Clear();

            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);

            };
            func(Controls);
        }
        private void Ranking_btn_Click(object sender, EventArgs e)
        {
            double[] R = new double[14];
            R[0] = Convert.ToDouble(text_methmetics.Text);
            R[1] = Convert.ToDouble(text_Business_sts.Text);
            R[2] = Convert.ToDouble(text_english.Text);
            R[3] = Convert.ToDouble(Text_Economics.Text);
            R[4] = Convert.ToDouble(text_physics.Text);
            R[5] = Convert.ToDouble(text_chemistry.Text);
            R[6] = Convert.ToDouble(text_biology.Text);
            R[7] = Convert.ToDouble(text_Accounting.Text);

            R[8] = (R[0] + R[1] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7]) / 8;
            R[9] = (R[0] + R[1] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7]);

            string average = Convert.ToString(R[8]);
            string total = Convert.ToString(R[9]);

            text_Avarege.Text = average;
            text_total_score.Text = total;
            if (R[9] > 700)
            {
                text_ranking.Text = "1st";
                progressions_text_box.Text = "Course complite";
            }
            else if (R[9] > 600)
            {
                text_ranking.Text = "2nd";
                progressions_text_box.Text = "Course complite";

            }
            else if (R[9] > 500)
            {
                text_ranking.Text = "3rd";
                progressions_text_box.Text = "Course complite";

            }
            else if (R[9] > 400)
            {
                text_ranking.Text = "4th";

                progressions_text_box.Text = "Course complite";
            }

            else if (R[9] > 300)
            {
                text_ranking.Text = "5th";
                progressions_text_box.Text = "Course complite";
            }
            else if (R[9] > 200)
            {
                text_ranking.Text = "fiel";
                progressions_text_box.Text = "Course not Complite" + "you are fiel";

            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(text_student_id.Text, text_first_name.Text, text_Sure_name.Text, Combo_course_code.Text, text_total_score.Text, text_Avarege.Text, text_ranking.Text,
             text_methmetics.Text, text_Business_sts.Text, text_english.Text, Text_Economics.Text, text_physics.Text, text_chemistry.Text, text_biology.Text, text_Accounting.Text , progressions_text_box.Text);

        }

        private void Transcieft_btn_Click(object sender, EventArgs e)
        {
            rt_transcieft.Text = "Chand Kahli Islamiya Dakhil madrasha" + "\n";
            rt_transcieft.AppendText(text_first_name.Text +  " Result Shite" +"\n");
            rt_transcieft.AppendText("Student_ID: \t\t\t" + text_student_id.Text + "\n");
            rt_transcieft.AppendText("First_Name: \t\t\t" + text_first_name.Text + "\n");
            rt_transcieft.AppendText("Sure_Name: \t\t\t" + text_Sure_name.Text + "\n");
            rt_transcieft.AppendText("Course_Code :\t\t\t" + Combo_course_code.Text + "\n");
            rt_transcieft.AppendText("Total score :\t\t\t" + text_total_score.Text + "\n");
            rt_transcieft.AppendText("Avareg Number :\t\t\t" + text_Avarege.Text + "\n");
            rt_transcieft.AppendText("Ranking No :\t\t\t" + text_ranking.Text + "\n");
            rt_transcieft.AppendText("Methmetis :\t\t\t" + text_methmetics.Text + "\n");
            rt_transcieft.AppendText("Biology No :\t\t\t" + text_Business_sts.Text + "\n");
            rt_transcieft.AppendText("Business STS :\t\t\t" + text_english.Text + "\n");
            rt_transcieft.AppendText("Computing :\t\t\t" + Text_Economics.Text + "\n");
            rt_transcieft.AppendText("Economics :\t\t\t" + text_physics.Text + "\n");
            rt_transcieft.AppendText("Accounting :\t\t\t" + text_chemistry.Text + "\n");
            rt_transcieft.AppendText("English No :\t\t\t" + text_biology.Text + "\n");
            rt_transcieft.AppendText("Business :\t\t\t" + text_Accounting.Text + "\n");
            
            rt_transcieft.AppendText("Progress and Desissons :\t\t" + progressions_text_box.Text + "\n");


        }

        private void Delate_BTN_Click(object sender, EventArgs e)
        {
                int q;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                }
                else
                {
                    MessageBox.Show("Select a row to be deleted", "Stedent result ranking");
                }
            
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Menagement Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font fntString = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                e.Graphics.DrawString(rt_transcieft.Text, fntString, Brushes.Black, 120, 120);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Menagement Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
