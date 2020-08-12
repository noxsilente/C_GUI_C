using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace C_GUI_C
{

    public partial class BK : Form
    {
        string lang, mode, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, name;
        int ximg = 0;
        private void cng_pic_2(object sender, EventArgs e)
        {
            if (ximg == 0) pictureBox10.BackgroundImage = Image.FromFile(@"RES/imgs/slugs.PNG");
            if (ximg == 1) pictureBox10.BackgroundImage = Image.FromFile(@"RES/imgs/vld.PNG");
            if (ximg == 2) pictureBox10.BackgroundImage = Image.FromFile(@"RES/imgs/HS.PNG");
            if (ximg == 3)
            {
                pictureBox10.BackgroundImage = Image.FromFile(@"RES/imgs/sabot.PNG");
                ximg = 0;
            }
            ximg++;
        }
        private void cng_pic(object sender, EventArgs e)
        {
            if (ximg == 0)pictureBox1.BackgroundImage = Image.FromFile(@"RES/imgs/b2.png");
            if (ximg == 1) pictureBox1.BackgroundImage = Image.FromFile(@"RES/imgs/b3.png");
            if (ximg == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"RES/imgs/b1.png");
                ximg = 0;
            }
            ximg++;
        }

        public BK()
        {
            InitializeComponent();
            XmlDocument xdc = new XmlDocument();
            xdc.Load("BK.xml");
            lang = C_GUI.lang;
            mode = C_GUI.mode;
            if (mode == "dark")
            {
                tabPage1.BackColor = Color.FromArgb(30, 30, 30);
                tabPage2.BackColor = Color.FromArgb(30, 30, 30);
                tabPage3.BackColor = Color.FromArgb(30, 30, 30);
                tabPage4.BackColor = Color.FromArgb(30, 30, 30);
                tabPage5.BackColor = Color.FromArgb(30, 30, 30);
                tabPage6.BackColor = Color.FromArgb(30, 30, 30);
                tabPage7.BackColor = Color.FromArgb(30, 30, 30);
                tabPage8.BackColor = Color.FromArgb(30, 30, 30);
                tabPage9.BackColor = Color.FromArgb(30, 30, 30);
                tabPage10.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox2.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox3.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox4.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox5.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox6.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox7.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox8.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox9.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox10.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox1.ForeColor = Color.White;
                richTextBox2.ForeColor = Color.White;
                richTextBox3.ForeColor = Color.White;
                richTextBox4.ForeColor = Color.White;
                richTextBox5.ForeColor = Color.White;
                richTextBox6.ForeColor = Color.White;
                richTextBox7.ForeColor = Color.White;
                richTextBox8.ForeColor = Color.White;
                richTextBox9.ForeColor = Color.White;
                richTextBox10.ForeColor = Color.White;
            }
            switch (lang)
            {
                case "de_DE":
                    name = "DE";
                    T1 = de_DE.form;
                    T2 = de_DE.abb;
                    T3 = de_DE.ap;
                    T4 = de_DE.In;
                    T5 = de_DE.Ex;
                    T6 = de_DE.Jacketed;
                    T7 = de_DE.Fra;
                    T8 = de_DE.Tra;
                    T9 = de_DE.HP;
                    T10 = de_DE.oth;
                    break;
                case "en_EN":
                    name = "EN";
                    T1 = en_EN.form;
                    T2 = en_EN.abb;
                    T3 = en_EN.ap;
                    T4 = en_EN.In;
                    T5 = en_EN.Ex;
                    T6 = en_EN.Jacketed;
                    T7 = en_EN.Fra;
                    T8 = en_EN.Tra;
                    T9 = en_EN.HP;
                    T10 = en_EN.oth;
                    break;
                case "es_ES":
                    name = "ES";
                    T1 = es_ES.form;
                    T2 = es_ES.abb;
                    T3 = es_ES.ap;
                    T4 = es_ES.In;
                    T5 = es_ES.Ex;
                    T6 = es_ES.Jacketed;
                    T7 = es_ES.Fra;
                    T8 = es_ES.Tra;
                    T9 = es_ES.HP;
                    T10 = es_ES.oth;
                    break;
                case "fr_FR":
                    name = "FR";
                    T1 = fr_FR.form;
                    T2 = fr_FR.abb;
                    T3 = fr_FR.ap;
                    T4 = fr_FR.In;
                    T5 = fr_FR.Ex;
                    T6 = fr_FR.Jacketed;
                    T7 = fr_FR.Fra;
                    T8 = fr_FR.Tra;
                    T9 = fr_FR.HP;
                    T10 = fr_FR.oth;
                    break;
                case "it_IT":
                    name = "IT";
                    T1 = it_IT.form;
                    T2 = it_IT.abb;
                    T3 = it_IT.ap;
                    T4 = it_IT.In;
                    T5 = it_IT.Ex;
                    T6 = it_IT.Jacketed;
                    T7 = it_IT.Fra;
                    T8 = it_IT.Tra;
                    T9 = it_IT.HP;
                    T10 = it_IT.oth;
                    break;
            }
            tabPage1.Text = T1;
            tabPage2.Text = T2;
            tabPage3.Text = T3;
            tabPage4.Text = T4;
            tabPage5.Text = T5;
            tabPage6.Text = T6;
            tabPage7.Text = T7;
            tabPage8.Text = T8;
            tabPage9.Text = T9;
            tabPage10.Text = T10;
            //pictureBox1.Image = Image.FromFile(@"RES/b1.png");
            foreach (XmlNode x in xdc.DocumentElement)
                if (x.Name == name)
                {
                    foreach (XmlNode c in x.ChildNodes)
                        if (c.Name == "t1") richTextBox1.Text = c.InnerText;
                        else
                        if (c.Name == "t2") richTextBox2.Text = c.InnerText;
                        else
                        if (c.Name == "t3") richTextBox3.Text = c.InnerText;
                        else
                        if (c.Name == "t4") richTextBox4.Text = c.InnerText;
                        else
                        if (c.Name == "t5") richTextBox5.Text = c.InnerText;
                        else
                        if (c.Name == "t6") richTextBox6.Text = c.InnerText;
                        else
                        if (c.Name == "t7") richTextBox7.Text = c.InnerText;
                        else
                        if (c.Name == "t8") richTextBox8.Text = c.InnerText;
                        else
                        if (c.Name == "t9") richTextBox9.Text = c.InnerText;
                        else
                        if (c.Name == "t10") richTextBox10.Text = c.InnerText;
                }
        }
    }
}
