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
    public partial class Exam_pise_systems : Form
    {
        public Exam_pise_systems()
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

        private void total_amount_Click(object sender, EventArgs e)
        {
            double[] R = new double[10];
            R[0] = Convert.ToDouble(text_monthly_free.Text);
            R[1] = Convert.ToDouble(text_total_month.Text);
            R[2] = Convert.ToDouble(text_fine.Text);
            R[3] = Convert.ToDouble(text_addmission_free.Text);
            R[4] = Convert.ToDouble(text_current_payed.Text);
            //R[5] = Convert.ToDouble(diew_text.Text);

            R[6] = ((R[0] * R[1]) + R[2]);
            R[7] = (R[6] + R[3]);
            R[8] = (R[7] - R[4]);
          
            string total = Convert.ToString(R[6]);
            string totat_payed = Convert.ToString(R[7]);
            string current_pay=Convert.ToString(R[8]);



            text_total_month_free.Text = total;
            text_total_payed.Text = totat_payed;
            text_diew.Text=current_pay;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(text_admissions_no.Text,text_name.Text,text_fathers_name.Text,combo_sex_box.Text,text_roll_no.Text,
                text_monthly_free.Text,text_fine.Text,text_total_month_free.Text,text_payment_date.Text,text_class.Text,text_addmission_free.Text,
                text_total_month.Text,text_total_payed.Text,text_current_payed.Text,text_diew.Text);

        }

        private void delate_btn_Click(object sender, EventArgs e)
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

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            text_admissions_no.Text = Convert.ToString(rnd.Next(12022, 254984));

            rt_transcieft1.Clear();
            combo_sex_box.Items.Clear();

            text_name.Clear();






        }

        private void rt_tarnscieft_btn_Click(object sender, EventArgs e)
        {
            rt_transcieft1.Text = "\t Chand Kahli Islamiya Dakhil madrasha" + "\n\n\n";

            rt_transcieft1.AppendText("Addmission No: \t" + text_admissions_no.Text + "\n");
            rt_transcieft1.AppendText("Student Name: \t" + text_name.Text + "\n");
            rt_transcieft1.AppendText("Fathers Name: \t" + text_fathers_name.Text + "\n\n");

            rt_transcieft1.AppendText("Student Sex :\t" + combo_sex_box.Text + "\t\t") ;
            rt_transcieft1.AppendText("Stu:Roll No :\t" + text_roll_no.Text + "\n");

            rt_transcieft1.AppendText("Monthly Free:\t" + text_monthly_free.Text + "\t\t");
            rt_transcieft1.AppendText("Fine          :\t" + text_fine.Text + "\n");

            rt_transcieft1.AppendText("To Month Fre:\t" + text_total_month_free.Text + "\t\t");
            rt_transcieft1.AppendText("Payment Date:\t" + text_payment_date.Text + "\n");

            rt_transcieft1.AppendText("Class       :\t" + text_class.Text + "\t\t");
            rt_transcieft1.AppendText("Admissions Fre:\t" + text_addmission_free.Text + "\n");

            rt_transcieft1.AppendText("Total Month :\t" + text_total_month.Text + "\t\t");
            rt_transcieft1.AppendText("Total Payed:\t" + text_total_payed.Text + "\n");

            rt_transcieft1.AppendText("Current Payed :\t" + text_current_payed.Text + "\t\t");
            rt_transcieft1.AppendText("Diew          :\t" + text_diew.Text + "\n\n\n");

            rt_transcieft1.AppendText("N.B: Well_come to chandkhali islamiya Dakhil Madrasha. \n Hello Sir Education is the backbown of a netions, \n So if you nead to high lavel study so we are beside you \n \t\t\t Thanks");


        }

        private void Print_btn_Click(object sender, EventArgs e)
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
                System.Drawing.Font fntString = new System.Drawing.Font("Arial", 20, FontStyle.Regular);
                e.Graphics.DrawString(rt_transcieft1.Text, fntString, Brushes.Blue, 40, 120);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Menagement Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
