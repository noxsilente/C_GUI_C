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
using System.Xml.Linq;

namespace C_GUI_C
{
    public partial class Comp : Form
    {
        string lang, mode, tmp1, tmp2, tmp;
        bool temp_ = false;
        string[] par_val = new string[16];
        int[] par_val_t = new int[16];

        public Comp()
        {
            InitializeComponent();
            lang = C_GUI.lang;
            mode = C_GUI.mode;
            tmp1 = C_GUI.temp_1;
            tmp2 = C_GUI.temp_2;

            if (mode == "dark")
            {
                BackColor = Color.FromArgb(30, 30, 30);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                _10.ForeColor = Color.DarkOrange;
                _8.ForeColor = Color.Gainsboro;
                _7.ForeColor = Color.Gainsboro;
                _6.ForeColor = Color.Gainsboro;
                _5.ForeColor = Color.Gainsboro;
                _4.ForeColor = Color.Gainsboro;
                _3.ForeColor = Color.Gainsboro;
                _2.ForeColor = Color.Gainsboro;
                _1.ForeColor = Color.Gainsboro;
                bullet.ForeColor = Color.Gainsboro;
                label21.ForeColor = Color.White;
                label22.ForeColor = Color.White;
                label23.ForeColor = Color.White;
                label24.ForeColor = Color.White;
                label25.ForeColor = Color.White;
                label26.ForeColor = Color.White;
                label27.ForeColor = Color.White;
                label28.ForeColor = Color.White;
                label29.ForeColor = Color.White;
                _10_1.ForeColor = Color.DarkOrange;
                _8_1.ForeColor = Color.Gainsboro;
                _7_1.ForeColor = Color.Gainsboro;
                _6_1.ForeColor = Color.Gainsboro;
                _5_1.ForeColor = Color.Gainsboro;
                _4_1.ForeColor = Color.Gainsboro;
                _3_1.ForeColor = Color.Gainsboro;
                _2_1.ForeColor = Color.Gainsboro;
                _1_1.ForeColor = Color.Gainsboro;
                bullet1.ForeColor = Color.Gainsboro;
            }
            switch (lang)
            {
                case "de_DE":
                    label1.Text = de_DE.id1;
                    label2.Text = de_DE.id2;
                    label3.Text = de_DE.id3;
                    label4.Text = de_DE.id4;
                    label5.Text = de_DE.id5;
                    label6.Text = de_DE.id6;
                    label7.Text = de_DE.id7;
                    label8.Text = de_DE.id8;
                    label9.Text = de_DE.id9;
                    label21.Text = de_DE.id9;
                    label22.Text = de_DE.id8;
                    label23.Text = de_DE.id7;
                    label24.Text = de_DE.id6;
                    label25.Text = de_DE.id5;
                    label26.Text = de_DE.id4;
                    label27.Text = de_DE.id3;
                    label28.Text = de_DE.id2;
                    label29.Text = de_DE.id1;
                    break;
                case "en_EN":
                    label1.Text = en_EN.id1;
                    label2.Text = en_EN.id2;
                    label3.Text = en_EN.id3;
                    label4.Text = en_EN.id4;
                    label5.Text = en_EN.id5;
                    label6.Text = en_EN.id6;
                    label7.Text = en_EN.id7;
                    label8.Text = en_EN.id8;
                    label9.Text = en_EN.id9;
                    label21.Text = en_EN.id9;
                    label22.Text = en_EN.id8;
                    label23.Text = en_EN.id7;
                    label24.Text = en_EN.id6;
                    label25.Text = en_EN.id5;
                    label26.Text = en_EN.id4;
                    label27.Text = en_EN.id3;
                    label28.Text = en_EN.id2;
                    label29.Text = en_EN.id1;
                    break;
                case "es_ES":
                    label1.Text = es_ES.id1;
                    label2.Text = es_ES.id2;
                    label3.Text = es_ES.id3;
                    label4.Text = es_ES.id4;
                    label5.Text = es_ES.id5;
                    label6.Text = es_ES.id6;
                    label7.Text = es_ES.id7;
                    label8.Text = es_ES.id8;
                    label9.Text = es_ES.id9;
                    label21.Text = es_ES.id9;
                    label22.Text = es_ES.id8;
                    label23.Text = es_ES.id7;
                    label24.Text = es_ES.id6;
                    label25.Text = es_ES.id5;
                    label26.Text = es_ES.id4;
                    label27.Text = es_ES.id3;
                    label28.Text = es_ES.id2;
                    label29.Text = es_ES.id1;
                    break;
                case "fr_FR":
                    label1.Text = fr_FR.id1;
                    label2.Text = fr_FR.id2;
                    label3.Text = fr_FR.id3;
                    label4.Text = fr_FR.id4;
                    label5.Text = fr_FR.id5;
                    label6.Text = fr_FR.id6;
                    label7.Text = fr_FR.id7;
                    label8.Text = fr_FR.id8;
                    label9.Text = fr_FR.id9;
                    label21.Text = fr_FR.id9;
                    label22.Text = fr_FR.id8;
                    label23.Text = fr_FR.id7;
                    label24.Text = fr_FR.id6;
                    label25.Text = fr_FR.id5;
                    label26.Text = fr_FR.id4;
                    label27.Text = fr_FR.id3;
                    label28.Text = fr_FR.id2;
                    label29.Text = fr_FR.id1;
                    break;
                case "it_IT":
                    label1.Text = it_IT.id1;
                    label2.Text = it_IT.id2;
                    label3.Text = it_IT.id3;
                    label4.Text = it_IT.id4;
                    label5.Text = it_IT.id5;
                    label6.Text = it_IT.id6;
                    label7.Text = it_IT.id7;
                    label8.Text = it_IT.id8;
                    label9.Text = it_IT.id9;
                    label21.Text = it_IT.id9;
                    label22.Text = it_IT.id8;
                    label23.Text = it_IT.id7;
                    label24.Text = it_IT.id6;
                    label25.Text = it_IT.id5;
                    label26.Text = it_IT.id4;
                    label27.Text = it_IT.id3;
                    label28.Text = it_IT.id2;
                    label29.Text = it_IT.id1;
                    break;
            }
            preset();
        }
        private void preset()
        {
            if (tmp1 != "")
            {
                temp_ = true;
                tmp = tmp1;
                lstsel();

            }
            if (tmp2 != "" && temp_==true)
            {
                temp_ = false;
                tmp = tmp2;
                lstsel2();
            }
             //else if (tmp2 == "")  MessageBox.Show("1/2");
        }
        private void lstsel()
        {
            // reset all texts
                bullet.Text = "-";
                _1.Text = "-";
                _2.Text = "-";
                _3.Text = "-";
                _4.Text = "-";
                _5.Text = "-";
                _6.Text = "-";
                _7.Text = "-";
                _8.Text = "-";
                _10.Text = "-";
            // reset variables
            for (int k = 0; k < 16; k++) par_val[k] = "-";
            for (int k = 0; k < 16; k++) par_val_t[k] = 0;
            //creating new container variables
            int j = 0;
            string s;
            XmlDocument xdc = new XmlDocument();
            xdc.Load(tmp);


            // get all numeric "id" values from xml selected file
            foreach (XElement l1e in XElement.Load(@tmp).Elements("b"))
            {
                j = int.Parse(l1e.Attribute("id").Value);
                par_val_t[j] = j;
            }
            // others temporary variables
            int x = 0;
            string[] s_t = new string[16];
            /*
             * Here we have 3 different arrays:
             * In the first array we put all text between the "<b 1d> </b>"
             * and all values enter in sequential stack of "s_t" (so in order.. 1,2,3 and so on)
             * In the for cycle the "s_t" value enters in the "par_val" array only when
             * x is equal to "par_val_t" of x and x_ is needed to get the next value of "s_t"
             * (so if x is equal to the id, par_val get the right string)
             * I made this for reduce the errors in the value positions
             */
            foreach (XmlNode node in xdc.DocumentElement)
                foreach (XmlNode child in node.ChildNodes)
                {
                    s_t[x] = child.OuterXml;
                    x++;
                }
            int xt = 0;
            int x_ = 0;
            for (x = 0; x < 15; x++)
            {
                if (x == par_val_t[x])
                {
                    xt = par_val_t[x];
                    s = s_t[x_];
                    par_val[xt] = s;
                    x_++;
                }
            }
            InsertParam(par_val_t, par_val);
        } 
        private void lstsel2()
        {
            // reset all texts
                bullet1.Text = "-";
                _1_1.Text = "-";
                _2_1.Text = "-";
                _3_1.Text = "-";
                _4_1.Text = "-";
                _5_1.Text = "-";
                _6_1.Text = "-";
                _7_1.Text = "-";
                _8_1.Text = "-";
                _10_1.Text = "-";
            // reset variables
            for (int k = 0; k < 16; k++) par_val[k] = "-";
            for (int k = 0; k < 16; k++) par_val_t[k] = 0;
            //creating new container variables
            int j = 0;
            string s;
            XmlDocument xdc = new XmlDocument();
            xdc.Load(tmp);


            // get all numeric "id" values from xml selected file
            foreach (XElement l1e in XElement.Load(@tmp).Elements("b"))
            {
                j = int.Parse(l1e.Attribute("id").Value);
                par_val_t[j] = j;
            }
            // others temporary variables
            int x = 0;
            string[] s_t = new string[16];
            /*
             * Here we have 3 different arrays:
             * In the first array we put all text between the "<b 1d> </b>"
             * and all values enter in sequential stack of "s_t" (so in order.. 1,2,3 and so on)
             * In the for cycle the "s_t" value enters in the "par_val" array only when
             * x is equal to "par_val_t" of x and x_ is needed to get the next value of "s_t"
             * (so if x is equal to the id, par_val get the right string)
             * I made this for reduce the errors in the value positions
             */
            foreach (XmlNode node in xdc.DocumentElement)
                foreach (XmlNode child in node.ChildNodes)
                {
                    s_t[x] = child.OuterXml;
                    x++;
                }
            int xt = 0;
            int x_ = 0;
            for (x = 0; x < 15; x++)
            {
                if (x == par_val_t[x])
                {
                    xt = par_val_t[x];
                    s = s_t[x_];
                    par_val[xt] = s;
                    x_++;
                }
            }
            InsertParam2(par_val_t, par_val);
        }
        private void InsertParam(int[] i, string[] s)
        {
            bullet.Text = s[0];
            if (i[1] == 1) _1.Text = _1.Text = s[1];
            else _1.Text = "-";
            if (i[2] == 2) _2.Text = s[2];
            else _2.Text = "-";
            if (i[3] == 3) _3.Text = s[3];
            else _3.Text = "-";
            if (i[4] == 4) _4.Text = s[4];
            else _4.Text = "-";
            if (i[5] == 5) _5.Text = s[5];
            else _5.Text = "-";
            if (i[6] == 6) _6.Text = s[6];
            else _6.Text = "-";
            if (i[7] == 7) _7.Text = s[7];
            else _7.Text = "-";
            if (i[8] == 8) _8.Text = s[8];
            else _8.Text = "-";
            //**************************************************//
            ////Control for primers in different languages
            switch (lang)
            {
                case "de_DE":
                    if (i[9] == 9 && _10.Text != null) _10.Text = de_DE.id_9;
                    if (i[10] == 10 && _10.Text != null) _10.Text = de_DE.id_10;
                    if (i[11] == 11 && _10.Text != null) _10.Text = de_DE.id_11;
                    if (i[12] == 12 && _10.Text != null) _10.Text = de_DE.id_12;
                    if (i[13] == 13 && _10.Text != null) _10.Text = de_DE.id_13;
                    if (i[14] == 14 && _10.Text != null) _10.Text = de_DE.id_14;
                    if (i[15] == 15 && _10.Text != null) _10.Text = de_DE.id_15;
                    break;
                case "en_EN":
                    if (i[9] == 9 && _10.Text != null) _10.Text = en_EN.id_9;
                    if (i[10] == 10 && _10.Text != null) _10.Text = en_EN.id_10;
                    if (i[11] == 11 && _10.Text != null) _10.Text = en_EN.id_11;
                    if (i[12] == 12 && _10.Text != null) _10.Text = en_EN.id_12;
                    if (i[13] == 13 && _10.Text != null) _10.Text = en_EN.id_13;
                    if (i[14] == 14 && _10.Text != null) _10.Text = en_EN.id_14;
                    if (i[15] == 15 && _10.Text != null) _10.Text = en_EN.id_15;
                    break;
                case "es_ES":
                    if (i[9] == 9 && _10.Text != null) _10.Text = es_ES.id_9;
                    if (i[10] == 10 && _10.Text != null) _10.Text = es_ES.id_10;
                    if (i[11] == 11 && _10.Text != null) _10.Text = es_ES.id_11;
                    if (i[12] == 12 && _10.Text != null) _10.Text = es_ES.id_12;
                    if (i[13] == 13 && _10.Text != null) _10.Text = es_ES.id_13;
                    if (i[14] == 14 && _10.Text != null) _10.Text = es_ES.id_14;
                    if (i[15] == 15 && _10.Text != null) _10.Text = es_ES.id_15;
                    break;
                case "fr_FR":
                    if (i[9] == 9 && _10.Text != null) _10.Text = fr_FR.id_9;
                    if (i[10] == 10 && _10.Text != null) _10.Text = fr_FR.id_10;
                    if (i[11] == 11 && _10.Text != null) _10.Text = fr_FR.id_11;
                    if (i[12] == 12 && _10.Text != null) _10.Text = fr_FR.id_12;
                    if (i[13] == 13 && _10.Text != null) _10.Text = fr_FR.id_13;
                    if (i[14] == 14 && _10.Text != null) _10.Text = fr_FR.id_14;
                    if (i[15] == 15 && _10.Text != null) _10.Text = fr_FR.id_15;
                    break;
                case "it_IT":
                    if (i[9] == 9 && _10.Text != null) _10.Text = it_IT.id_9;
                    if (i[10] == 10 && _10.Text != null) _10.Text = it_IT.id_10;
                    if (i[11] == 11 && _10.Text != null) _10.Text = it_IT.id_11;
                    if (i[12] == 12 && _10.Text != null) _10.Text = it_IT.id_12;
                    if (i[13] == 13 && _10.Text != null) _10.Text = it_IT.id_13;
                    if (i[14] == 14 && _10.Text != null) _10.Text = it_IT.id_14;
                    if (i[15] == 15 && _10.Text != null) _10.Text = it_IT.id_15;
                    break;
            }
            for (int y = 9; y < 16; y++)
            {
                if (i[y] == y && _10.Text != null) _11.Text = s[y];
                else _11.Text = "-";
            }
            //***********************************************// 
            /*
             * In this code we get from list selected element, the xml file position
             * then, with a specific language, we get the text from a language marked node
             * IT for Italian
             * EN for English
             * DE for German
             * ES for Spanish
             * FR for French
             * ..... and others 
             */
        }
        private void InsertParam2(int[] i, string[] s)
        {
            bullet1.Text = s[0];
            if (i[1] == 1) _1_1.Text = _1_1.Text = s[1];
            else _1_1.Text = "-";
            if (i[2] == 2) _2_1.Text = s[2];
            else _2_1.Text = "-";
            if (i[3] == 3) _3_1.Text = s[3];
            else _3_1.Text = "-";
            if (i[4] == 4) _4_1.Text = s[4];
            else _4_1.Text = "-";
            if (i[5] == 5) _5_1.Text = s[5];
            else _5_1.Text = "-";
            if (i[6] == 6) _6_1.Text = s[6];
            else _6_1.Text = "-";
            if (i[7] == 7) _7_1.Text = s[7];
            else _7_1.Text = "-";
            if (i[8] == 8) _8_1.Text = s[8];
            else _8_1.Text = "-";
            //**************************************************//
            ////Control for primers in different languages
            switch (lang)
            {
                case "de_DE":
                    if (i[9] == 9 && _10_1.Text != null) _10_1.Text = de_DE.id_9;
                    if (i[10] == 10 && _10_1.Text != null) _10_1.Text = de_DE.id_10;
                    if (i[11] == 11 && _10_1.Text != null) _10_1.Text = de_DE.id_11;
                    if (i[12] == 12 && _10_1.Text != null) _10_1.Text = de_DE.id_12;
                    if (i[13] == 13 && _10_1.Text != null) _10_1.Text = de_DE.id_13;
                    if (i[14] == 14 && _10_1.Text != null) _10_1.Text = de_DE.id_14;
                    if (i[15] == 15 && _10_1.Text != null) _10_1.Text = de_DE.id_15;
                    break;
                case "en_EN":
                    if (i[9] == 9 && _10_1.Text != null) _10_1.Text = en_EN.id_9;
                    if (i[10] == 10 && _10_1.Text != null) _10_1.Text = en_EN.id_10;
                    if (i[11] == 11 && _10_1.Text != null) _10_1.Text = en_EN.id_11;
                    if (i[12] == 12 && _10_1.Text != null) _10_1.Text = en_EN.id_12;
                    if (i[13] == 13 && _10_1.Text != null) _10_1.Text = en_EN.id_13;
                    if (i[14] == 14 && _10_1.Text != null) _10_1.Text = en_EN.id_14;
                    if (i[15] == 15 && _10_1.Text != null) _10_1.Text = en_EN.id_15;
                    break;
                case "es_ES":
                    if (i[9] == 9 && _10_1.Text != null) _10_1.Text = es_ES.id_9;
                    if (i[10] == 10 && _10_1.Text != null) _10_1.Text = es_ES.id_10;
                    if (i[11] == 11 && _10_1.Text != null) _10_1.Text = es_ES.id_11;
                    if (i[12] == 12 && _10_1.Text != null) _10_1.Text = es_ES.id_12;
                    if (i[13] == 13 && _10_1.Text != null) _10_1.Text = es_ES.id_13;
                    if (i[14] == 14 && _10_1.Text != null) _10_1.Text = es_ES.id_14;
                    if (i[15] == 15 && _10_1.Text != null) _10_1.Text = es_ES.id_15;
                    break;
                case "fr_FR":
                    if (i[9] == 9 && _10_1.Text != null) _10_1.Text = fr_FR.id_9;
                    if (i[10] == 10 && _10_1.Text != null) _10_1.Text = fr_FR.id_10;
                    if (i[11] == 11 && _10_1.Text != null) _10_1.Text = fr_FR.id_11;
                    if (i[12] == 12 && _10_1.Text != null) _10_1.Text = fr_FR.id_12;
                    if (i[13] == 13 && _10_1.Text != null) _10_1.Text = fr_FR.id_13;
                    if (i[14] == 14 && _10_1.Text != null) _10_1.Text = fr_FR.id_14;
                    if (i[15] == 15 && _10_1.Text != null) _10_1.Text = fr_FR.id_15;
                    break;
                case "it_IT":
                    if (i[9] == 9 && _10_1.Text != null) _10_1.Text = it_IT.id_9;
                    if (i[10] == 10 && _10_1.Text != null) _10_1.Text = it_IT.id_10;
                    if (i[11] == 11 && _10_1.Text != null) _10_1.Text = it_IT.id_11;
                    if (i[12] == 12 && _10_1.Text != null) _10_1.Text = it_IT.id_12;
                    if (i[13] == 13 && _10_1.Text != null) _10_1.Text = it_IT.id_13;
                    if (i[14] == 14 && _10_1.Text != null) _10_1.Text = it_IT.id_14;
                    if (i[15] == 15 && _10_1.Text != null) _10_1.Text = it_IT.id_15;
                    break;
            }
            for (int y = 9; y < 16; y++)
            {
                if (i[y] == y && _10_1.Text != null) _11_1.Text = s[y];
                else _11_1.Text = "-";
            }
            //***********************************************// 
            /*
             * In this code we get from list selected element, the xml file position
             * then, with a specific language, we get the text from a language marked node
             * IT for Italian
             * EN for English
             * DE for German
             * ES for Spanish
             * FR for French
             * ..... and others 
             */
        }
    }
}
