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
    public partial class Teachers_payment_systems : Form
    {
        public Teachers_payment_systems()
        {
            InitializeComponent();
        }


        private void exit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iQuilt;
                iQuilt = MessageBox.Show("Confirm if you want to Exit", "c# Dialoge Systems",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_btn_Click(sender, e);
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            try
            {


                combo_gender.SelectedIndex = 0;
                pay_ref_combobox.SelectedIndex = 0;

                address_textbox.Clear();
                Empolyer_text.Clear();
                full_name_text.Clear();
                post_code_textbox.Text = "";
                text_city_weigh.Clear();
                txt_basic_selary.Clear();
                txt_over_time.Text = "";
                txt_ranking.Clear();




                lbl_deducations.Text = "";
                lbl_gross_pay.Text = "";
                lbl_net_pay.Text = "";
                lbl_ni_code.Text = "";
                lbl_ni_number.Text = "";
                lbl_ni_payment.Text = "";
                lbl_pension.Text = "";
                lbl_pensional.Text = "";
                lbl_state_lone.Text = "";
                lbl_tax.Text = "";
                lbl_texable_pay.Text = "";
                lbl_tax_code.Text = "";
                lbl_tax_period.Text = "";

                lbl_weigh_rf.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Pay_ref_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbl_weigh_rf.Text=Convert.ToString(rnd.Next(12022,254984));
        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            Pay_ref_btn_Click(sender, e);
        }

        private void lbl_weigh_rf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
