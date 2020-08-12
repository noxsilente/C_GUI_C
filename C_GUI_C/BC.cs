using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI_C
{
    public partial class BC : Form
    {

        string lang, mode, msgbox1, msgbox2, toolmsg1;
        public BC()
        {
            InitializeComponent();
            lang = C_GUI.lang;
            mode = C_GUI.mode;
            switch (lang)
            {
                case "de_DE":
                    CoeffBall.Text = de_DE.bc1;
                    i.Text = de_DE.bc3;
                    Delta.Text = de_DE.cdf1;
                    button1.Text = de_DE.button;
                    button3.Text = de_DE.button;
                    button4.Text = de_DE.button;
                    button5.Text = de_DE.button;
                    msgbox1 = de_DE.camp0;
                    msgbox2 = de_DE.fill;
                    toolmsg1 = de_DE.tool1;
                    label2.Text = de_DE.bc2;
                    label3.Text = de_DE.cdf2;
                    label12.Text = de_DE.bc4;
                    label13.Text = de_DE.bcval;
                    label16.Text = de_DE.cdf1;
                    label17.Text = de_DE.cdf2;
                    label21.Text = de_DE.faval;
                    label23.Text = de_DE.bc_corr;
                    toolTip1.SetToolTip(gr_check, de_DE.tool1);
                    toolTip1.SetToolTip(g_check, de_DE.tool1);
                    break;
                case "en_EN":
                    CoeffBall.Text = en_EN.bc1;
                    button1.Text = en_EN.button;
                    button3.Text = en_EN.button;
                    button4.Text = en_EN.button;
                    button5.Text = en_EN.button;
                    i.Text = en_EN.bc3;
                    Delta.Text = en_EN.cdf1;
                    msgbox1 = en_EN.camp0;
                    msgbox2 = en_EN.fill;
                    toolmsg1 = en_EN.tool1;
                    label2.Text = en_EN.bc2;
                    label3.Text = en_EN.cdf2;
                    label12.Text = en_EN.bc4;
                    label13.Text = en_EN.bcval;
                    label14.Text = en_EN.N;
                    label16.Text = en_EN.L;
                    label17.Text = en_EN.cdf2;
                    label21.Text = en_EN.faval;
                    label23.Text = en_EN.bc_corr;
                    toolTip1.SetToolTip(gr_check, en_EN.tool1);
                    toolTip1.SetToolTip(g_check, en_EN.tool1);
                    break;
                case "es_ES":
                    CoeffBall.Text = es_ES.bc1;
                    i.Text = es_ES.bc3;
                    Delta.Text = es_ES.cdf1;
                    button1.Text = es_ES.button;
                    button3.Text = es_ES.button;
                    button4.Text = es_ES.button;
                    button5.Text = es_ES.button;
                    msgbox1 = es_ES.camp0;
                    msgbox2 = es_ES.fill;
                    toolmsg1 = es_ES.tool1;
                    label2.Text = es_ES.bc2;
                    label3.Text = es_ES.cdf2;
                    label12.Text = es_ES.bc4;
                    label13.Text = es_ES.bcval;
                    label16.Text = es_ES.cdf1;
                    label17.Text = es_ES.cdf2;
                    label21.Text = es_ES.faval;
                    label23.Text = es_ES.bc_corr;
                    toolTip1.SetToolTip(gr_check, es_ES.tool1);
                    toolTip1.SetToolTip(g_check, es_ES.tool1);
                    break;
                case "fr_FR":
                    CoeffBall.Text = fr_FR.bc1;
                    i.Text = fr_FR.bc3;
                    Delta.Text = fr_FR.cdf1;
                    button1.Text = fr_FR.button;
                    button3.Text = fr_FR.button;
                    button4.Text = fr_FR.button;
                    button5.Text = fr_FR.button;
                    msgbox1 = fr_FR.camp0;
                    msgbox2 = fr_FR.fill;
                    toolmsg1 = fr_FR.tool1;
                    label2.Text = fr_FR.bc2;
                    label3.Text = fr_FR.cdf2;
                    label12.Text = fr_FR.bc4;
                    label13.Text = fr_FR.bcval;
                    label16.Text = fr_FR.cdf1;
                    label17.Text = fr_FR.cdf2;
                    label21.Text = fr_FR.faval;
                    label23.Text = fr_FR.bc_corr;
                    toolTip1.SetToolTip(gr_check, fr_FR.tool1);
                    toolTip1.SetToolTip(g_check, fr_FR.tool1);
                    break;
                case "it_IT":
                    CoeffBall.Text = it_IT.bc1;
                    i.Text = it_IT.bc3;
                    Delta.Text = it_IT.cdf1;
                    button1.Text = it_IT.button;
                    button3.Text = it_IT.button;
                    button4.Text = it_IT.button;
                    button5.Text = it_IT.button;
                    msgbox1 = it_IT.camp0;
                    msgbox2 = it_IT.fill;
                    toolmsg1 = it_IT.tool1;
                    label2.Text = it_IT.bc2;
                    label3.Text = it_IT.cdf2;
                    label12.Text = it_IT.bc4;
                    label13.Text = it_IT.bcval;
                    label16.Text = it_IT.cdf1;
                    label17.Text = it_IT.cdf2;
                    label21.Text = it_IT.faval;
                    label23.Text = it_IT.bc_corr;
                    toolTip1.SetToolTip(gr_check, it_IT.tool1);
                    toolTip1.SetToolTip(g_check, it_IT.tool1);
                    break;
            }
            if (mode == "dark")
            {
                BackColor = Color.FromArgb(30, 30, 30);
                //textbox colouring
                textBox1.BackColor = Color.Black;
                textBox2.BackColor = Color.Black;
                textBox3.BackColor = Color.Black;
                textBox10.BackColor = Color.Black;
                textBox12.BackColor = Color.Black;
                textBox13.BackColor = Color.Black;
                textBox14.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
                textBox3.ForeColor = Color.White;
                textBox10.ForeColor = Color.White;
                textBox12.ForeColor = Color.White;
                textBox13.ForeColor = Color.White;
                textBox14.ForeColor = Color.White;
                //label colouring
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                label18.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label20.ForeColor = Color.White;
                label21.ForeColor = Color.White;
                label22.ForeColor = Color.White;
                label23.ForeColor = Color.White;
                label24.ForeColor = Color.White;
                //buttons and boxes colouring
                CoeffBall.ForeColor = Color.DarkKhaki;
                i.ForeColor = Color.DarkOrange;
                Delta.ForeColor = Color.DarkCyan;
                button1.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
            }
            textBox12.Enabled = false;
        }
        double G, D, FC, S1, FA, H, T, Cal, L;
        double v = 331.6;


        private void chk(object sender, EventArgs e)
        {
            if (g_check.Checked == true) gr_check.Checked = false;
            if (gr_check.Checked == true) g_check.Checked = false;
        }

        //ball.coeff.
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (G == 0 || FC == 0 || D == 0) MessageBox.Show(msgbox1);
                else
                {
                    if (g_check.Checked == true) S1 = (G / (FC * (D * D))) * 1.442;
                    if (gr_check.Checked == true) S1 = G / (FC * (D * D));
                    label1.Text = S1.ToString("0.000");
                }
            }
            else MessageBox.Show(msgbox2);
        }
        //shape coeff. 
        private void cdf_calc(object sender, EventArgs e)
        {

            if (textBox10.Text != "")
            {
                //Cal = double.Parse(textBox12.Text);
                L = double.Parse(textBox10.Text);
                if (L == 0) MessageBox.Show(msgbox1);
                else
                {
                    double N;
                    //Siacci(v);
                    //FC = ((Cx * (v * v) * FA)) / (2 * fv);
                    N = (4*L+1) / 4;
                    FC = (2 / N) * (Math.Sqrt((4 * N - 1)*N));
                    label18.Text = FC.ToString("0.000");
                    textBox2.Text = FC.ToString("0.000");
                }
            }
            else MessageBox.Show(msgbox2);
        }
        //Env. fact.
        private void EF_calc(object sender, EventArgs e)
        {
            if (textBox14.Text != "" && textBox13.Text != "")
            {
                if (H == 0 || T == 0) MessageBox.Show(msgbox1);
                else
                {
                    FA = (347 - (0.033 * H)) / (273 + T);
                    label22.Text = FA.ToString("0.000");
                    textBox10.Text = label22.Text;
                }
            }
            else MessageBox.Show(msgbox2);
        }
        //Correction Env. Fact
        private void FA_corr(object sender, EventArgs e)
        {
            if (FA != 0)
            {
                FA = FA / 1.225;
                label24.Text = FA.ToString("0.000");
                textBox10.Text = label24.Text;
            }
        }
        //---------------------------------------------------------------------------------
        private void H_change(object sender, EventArgs e) //humidity
        {
            if (textBox14.Text != "") H = double.Parse(textBox14.Text);
        }
        private void T_change(object sender, EventArgs e) // temperature.. it should get negative values too
        {
            if (textBox13.Text != "")
            {
                T = double.Parse(textBox13.Text);
                v = 331.6 + (0.6 * T);
            }
        }
        private void insert_T(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar!='-')) e.Handled = true;
        }
        private void insert(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }

        //------------------------------------------------------------------------------------
        private void gpress(object sender, EventArgs e)//weight cb
        {
            if (textBox1.Text != "") G = double.Parse(textBox1.Text);
        }
        private void fcpress(object sender, EventArgs e) //cx imput value
        {
            if (textBox2.Text != "") FC = double.Parse(textBox2.Text);
        }
        private void dpress(object sender, EventArgs e) // diameter cb
        {
            if (textBox3.Text != "") D = double.Parse(textBox3.Text);
        }
   /*     private double Siacci(double v)
        {
            if (T != 0) v = 331.6 + (0.6 * T);
            double temp_v1 = 0.2002 * v;
            double temp_v2 = (0.1648 * v) - 47.95;
            double temp_v3 = 0.0442 * v;
            fv = (temp_v1 - 48.05) + (Math.Sqrt((temp_v2 * temp_v2) + 9.6)) + ((temp_v3 * (v - 300))) / (371 + Math.Pow((v / 200), 10));
            return (fv);
        }*/
    }
}
