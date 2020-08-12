using System;
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
    public partial class CK : Form
    {
        string lang, mode, T1, T2, T3, T4, T5, T6,T7, T8, name;
        public CK()
        {       
            InitializeComponent();
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
                richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox2.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox3.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox4.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox5.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox6.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox7.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox8.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox1.ForeColor = Color.White;
                richTextBox2.ForeColor = Color.White;
                richTextBox3.ForeColor = Color.White;
                richTextBox4.ForeColor = Color.White;
                richTextBox5.ForeColor = Color.White;
                richTextBox6.ForeColor = Color.White;
                richTextBox7.ForeColor = Color.White;
                richTextBox8.ForeColor = Color.White;
            }
            switch (lang)
            {
                case "de_DE":
                    name = "DE";
                    T1 = de_DE._14;
                    T2 = de_DE.rimmed;
                    T3 = de_DE.semir;
                    T4 = de_DE.rimless;
                    T5 = de_DE.rebrim;
                    T6 = de_DE.belted;
                    T7 = de_DE.centf;
                    T8 = de_DE.id_13;
                    break;
                case "en_EN":
                    name = "EN";
                    T1 = en_EN._14;
                    T2 = en_EN.rimmed;
                    T3 = en_EN.semir;
                    T4 = en_EN.rimless;
                    T5 = en_EN.rebrim;
                    T6 = en_EN.belted;
                    T7 = en_EN.centf;
                    T8 = en_EN.id_13;
                    break;
                case "es_ES":
                    name = "ES";
                    T1 = es_ES._14;
                    T2 = es_ES.rimmed;
                    T3 = es_ES.semir;
                    T4 = es_ES.rimless;
                    T5 = es_ES.rebrim;
                    T6 = es_ES.belted;
                    T7 = es_ES.centf;
                    T8 = es_ES.id_13;
                    break;
                case "fr_FR":
                    name = "FR";
                    T1 = fr_FR._14;
                    T2 = fr_FR.rimmed;
                    T3 = fr_FR.semir;
                    T4 = fr_FR.rimless;
                    T5 = fr_FR.rebrim;
                    T6 = fr_FR.belted;
                    T7 = fr_FR.centf;
                    T8 = fr_FR.id_13;
                    break;
                case "it_IT":
                    name = "IT";
                    T1 = it_IT._14;
                    T2 = it_IT.rimmed;
                    T3 = it_IT.semir;
                    T4 = it_IT.rimless;
                    T5 = it_IT.rebrim;
                    T6 = it_IT.belted;
                    T7 = it_IT.centf;
                    T8 = it_IT.id_13;
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
            XmlDocument xdc = new XmlDocument();
            xdc.Load("CK.xml");
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
                }
        }
    }
}
