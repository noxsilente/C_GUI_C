using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using C_GUI_C.Properties;

namespace C_GUI_C
{
    public partial class C_GUI : Form
    {

        //-------- Var declaration
        bool In, Mm;
        string ListSel,  toolmsg1, toolmsgimg;
        string[] par_val = new string[16];
        int[] par_val_t = new int[16];
        double inch, mm;
        //StringBuilder res = new StringBuilder();
        public static string lang;
        public static string mode;
        public static string img;
        public static string obj;
        public static string subject;
        public C_GUI()
        {
            mode = Settings.Default.Mode.ToString();
            lang = Settings.Default.Lang.ToString();
            InitializeComponent();
            if (mode == "dark") DarkModeEnable();
            if (mode == "light") LightModeEnable();
            switch (lang)
            {
                case "de_DE":
                    DEsel();
                    break;
                case "en_EN":
                    ENsel();
                    break;
                case "es_ES":
                    ESsel();
                    break;
                case "fr_FR":
                    FRsel();
                    break;
                case "it_IT":
                    ITsel();
                    break;
            }
            button5.Hide();
        }
        private void STD_SEL(object sender, EventArgs e)
        {
            Settings.Default.Mode = "light";
            LightModeEnable();
        }
        private void DARK_SEL(object sender, EventArgs e)
        {
            Settings.Default.Mode = "dark";
            DarkModeEnable();
        }
        private void DE_sel(object sender, EventArgs e)
        {
            Settings.Default.Lang = "de_DE";
            DEsel();
        }
        private void EN_sel(object sender, EventArgs e)
        {
            Settings.Default.Lang = "en_EN";
            ENsel();
        }
        private void ES_sel(object sender, EventArgs e)
        {
            Settings.Default.Lang = "es_ES";
            ESsel();
        }
        private void FR_sel(object sender, EventArgs e)
        {
            Settings.Default.Lang = "fr_FR";
            FRsel();
        }
        private void IT_sel(object sender, EventArgs e)
        {
            Settings.Default.Lang = "it_IT";
            ITsel();
        }
        private void SaveSetts(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
        private void PButtonClicked(object sender, EventArgs e)
        {
            if (In == true) ListSel = "PRS_I";
            if (Mm == true) ListSel = "PRS_M";
            List.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (XElement l1e in XElement.Load(@"RES/rif.xml").Elements(ListSel))
            {
                List.Items.Add(l1e.Attribute("obj").Value);
                listBox1.Items.Add(l1e.Attribute("ref").Value).ToString();
                listBox2.Items.Add(l1e.Attribute("ref2").Value).ToString();
                listBox3.Items.Add(l1e.Attribute("sh").Value).ToString();              

            }
        }
        private void RButtonClicked(object sender, EventArgs e)
        {
            if (In == true) ListSel = "CRS_I";
            if (Mm == true) ListSel = "CRS_M";
            List.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (XElement l1e in XElement.Load(@"RES/rif.xml").Elements(ListSel))
            {
                List.Items.Add(l1e.Attribute("obj").Value);
                listBox1.Items.Add(l1e.Attribute("ref").Value).ToString();
                listBox2.Items.Add(l1e.Attribute("ref2").Value).ToString();
                listBox3.Items.Add(l1e.Attribute("sh").Value).ToString();
            }
        }
        private void BCButtonClicked(object sender, EventArgs e)
        {
           if (PC.Checked == true) ListSel = "P";
           if (RC.Checked == true) ListSel = "R";
           if (SC.Checked == true) ListSel = "S";
           if (NEC.Checked == true) ListSel = "NE";
            List.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (XElement l1e in XElement.Load(@"RES/rif.xml").Elements(ListSel))
            {
                List.Items.Add(l1e.Attribute("obj").Value).ToString();
                listBox1.Items.Add(l1e.Attribute("ref").Value).ToString();
                listBox2.Items.Add(l1e.Attribute("ref2").Value).ToString();
                listBox3.Items.Add(l1e.Attribute("sh").Value).ToString();
            }
        }
        private void lstsel(object sender, EventArgs e)
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
            listBox1.SelectedIndex = List.SelectedIndex;
            listBox2.SelectedIndex = List.SelectedIndex;
            listBox3.SelectedIndex = List.SelectedIndex;
            XmlDocument xdc = new XmlDocument();
            xdc.Load(listBox1.SelectedItem.ToString());
            // get all numeric "id" values from xml selected file
            foreach (XElement l1e in XElement.Load(@listBox1.SelectedItem.ToString()).Elements("b"))
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
        private void inse_(object sender, EventArgs e)
        {
            if (INC.Checked == true)
            {
                In = true;
                Mm = false;
            }
            if (MMC.Checked == true)
            {
                In = false;
                Mm = true;
            }
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
            XmlDocument xdc2 = new XmlDocument();
            xdc2.Load(listBox2.SelectedItem.ToString());
            //Image img = Image.FromFile(listBox3.SelectedItem.ToString() + ".png");
            //Control for INFOBOX with languages.. if there is no info ("N/A" in xml file) it will use english info
            // if there is no images/3d objects the section "sh" of xml file, the value will be "0", so the app will not crash if 
            // the selected subject is without image/3d obj.  
            switch (lang)
            {
                case "it_IT":
                    foreach (XmlNode node in xdc2.DocumentElement)
                        if (node.Name == "IT") richTextBox1.Text = node.InnerText;
                    if (richTextBox1.Text == "N/A")
                        foreach (XmlNode node in xdc2.DocumentElement)
                            if (node.Name == "EN") richTextBox1.Text = node.InnerText;
                    break;
                case "es_ES":
                    foreach (XmlNode node in xdc2.DocumentElement)
                        if (node.Name == "ES") richTextBox1.Text = node.InnerText;
                    if (richTextBox1.Text == "N/A")
                        foreach (XmlNode node in xdc2.DocumentElement)
                            if (node.Name == "EN") richTextBox1.Text = node.InnerText;
                    break;

                case "en_EN":
                    foreach (XmlNode node in xdc2.DocumentElement)
                        if (node.Name == "EN") richTextBox1.Text = node.InnerText;
                    break;
            }
            if (listBox3.SelectedItem.ToString() != "0")
            {
                obj = (@listBox3.SelectedItem.ToString() + ".obj");
                String file = "temp";
                if (!File.Exists(file))
                {
                    using (StreamWriter sw = File.CreateText(file)) sw.WriteLine(obj);
                }
                else
                    using (StreamWriter sw = File.CreateText(file))
                    {
                        
                        sw.WriteLine(obj);
                    }
                img = (@listBox3.SelectedItem.ToString() + ".jpg");
                pictureBox1.Image = Image.FromFile(img);
                subject = (List.SelectedItem.ToString());
              //  button5.Visible = true;
            }
            else
            {
                MessageBox.Show("NO IMAGE!", "NO IMAGE!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                pictureBox1.Image = null;
                button5.Hide();
            }
        }
        private void chkif(object sender, EventArgs e)
        {
            if (In == false && Mm == false)
            {
                toolTip1.SetToolTip(PB, toolmsg1);
                toolTip1.SetToolTip(RB, toolmsg1);
            }
        }
        private void BalCalStart(object sender, EventArgs e)
        {
            mode = Settings.Default.Mode.ToString();
            lang = Settings.Default.Lang.ToString();
            BC form = new BC();
            form.Show();
        }
        private void cksel(object sender, EventArgs e)
        {
            mode = Settings.Default.Mode.ToString();
            lang = Settings.Default.Lang.ToString();
            CK form = new CK();
            form.Show();
        }
        private void BK(object sender, EventArgs e)
        {
            mode = Settings.Default.Mode.ToString();
            lang = Settings.Default.Lang.ToString();
            BK form = new BK();
            form.Show();
        }
        private void Tdw(object sender, EventArgs e)
        {
           /* TDW.MAIN form = new TDW.MAIN();
            form.Show();
            */
            
        }

        private void imgzoom(object sender, EventArgs e)
        {
            if (img != null)
            {
                mode = Settings.Default.Mode.ToString();
                IMGZ form = new IMGZ();
                form.Show();
            }
            else MessageBox.Show("NO IMAGES");
        }
        private void Infobox(object sender, EventArgs e)
        {
            mode = Settings.Default.Mode.ToString();
            lang = Settings.Default.Lang.ToString();
            INFO form = new INFO();
            form.Show();
        }

        private void ENsel()
        {
            Settings.Default.Lang = "en_EN";
            OpenMenuBar.Text = en_EN._1;
            BC_BAR.Text = en_EN._12;
            BK_BAR.Text = en_EN._13;
            CK_BAR.Text = en_EN._14;
            Conv.Text = en_EN.Conv;
            OptionMenuBar.Text = en_EN._2;
            Lang_bar.Text = en_EN._21;
            VM_BAR.Text = en_EN._22;
            label1.Text = en_EN.id1;
            label2.Text = en_EN.id2;
            label3.Text = en_EN.id3;
            label4.Text = en_EN.id4;
            label5.Text = en_EN.id5;
            label6.Text = en_EN.id6;
            label7.Text = en_EN.id7;
            label8.Text = en_EN.id8;
            label9.Text = en_EN.id9;
            PC.Text = en_EN.P;
            RC.Text = en_EN.R;
            SC.Text = en_EN.S;
            toolmsg1 = en_EN.in_mm;
            toolmsgimg = en_EN.timg;
        }
        private void DEsel()
        {
            OpenMenuBar.Text = de_DE._1;
            BC_BAR.Text = de_DE._12;
            BK_BAR.Text = de_DE._13;
            CK_BAR.Text = de_DE._14;
            Conv.Text = de_DE.Conv;
            OptionMenuBar.Text = de_DE._2;
            Lang_bar.Text = de_DE._21;
            VM_BAR.Text = de_DE._22;
            label1.Text = de_DE.id1;
            label2.Text = de_DE.id2;
            label3.Text = de_DE.id3;
            label4.Text = de_DE.id4;
            label5.Text = de_DE.id5;
            label6.Text = de_DE.id6;
            label7.Text = de_DE.id7;
            label8.Text = de_DE.id8;
            label9.Text = de_DE.id9;
            toolmsg1 = de_DE.in_mm;
            PC.Text = de_DE.P;
            RC.Text = de_DE.R;
            SC.Text = de_DE.S;
            toolmsgimg = de_DE.timg;
        }
        private void ESsel()
        {
            Settings.Default.Lang = "es_ES";
            OpenMenuBar.Text = es_ES._1;
            BC_BAR.Text = es_ES._12;
            BK_BAR.Text = es_ES._13;
            CK_BAR.Text = es_ES._14;
            Conv.Text = es_ES.Conv;
            OptionMenuBar.Text = es_ES._2;
            Lang_bar.Text = es_ES._21;
            VM_BAR.Text = es_ES._22;
            label1.Text = es_ES.id1;
            label2.Text = es_ES.id2;
            label3.Text = es_ES.id3;
            label4.Text = es_ES.id4;
            label5.Text = es_ES.id5;
            label6.Text = es_ES.id6;
            label7.Text = es_ES.id7;
            label8.Text = es_ES.id8;
            label9.Text = es_ES.id9;
            PC.Text = es_ES.P;
            RC.Text = es_ES.R;
            SC.Text = es_ES.S;
            toolmsg1 = es_ES.in_mm;
            toolmsgimg = es_ES.timg;
        }
        private void FRsel()
        {
            Settings.Default.Lang = "fr_FR";
            OpenMenuBar.Text = fr_FR._1;
            BC_BAR.Text = fr_FR._12;
            BK_BAR.Text = fr_FR._13;
            CK_BAR.Text = fr_FR._14;
            Conv.Text = fr_FR.Conv;
            OptionMenuBar.Text = fr_FR._2;
            Lang_bar.Text = fr_FR._21;
            VM_BAR.Text = fr_FR._22;
            label1.Text = fr_FR.id1;
            label2.Text = fr_FR.id2;
            label3.Text = fr_FR.id3;
            label4.Text = fr_FR.id4;
            label5.Text = fr_FR.id5;
            label6.Text = fr_FR.id6;
            label7.Text = fr_FR.id7;
            label8.Text = fr_FR.id8;
            label9.Text = fr_FR.id9;
            PC.Text = fr_FR.P;
            RC.Text = fr_FR.R;
            SC.Text = fr_FR.S;
            toolmsg1 = fr_FR.in_mm;
            toolmsgimg = fr_FR.timg;
        }
        private void ITsel()
        {
            Settings.Default.Lang = "it_IT";
            OpenMenuBar.Text = it_IT._1;
            BC_BAR.Text = it_IT._12;
            BK_BAR.Text = it_IT._13;
            CK_BAR.Text = it_IT._14;
            Conv.Text = it_IT.Conv;
            OptionMenuBar.Text = it_IT._2;
            Lang_bar.Text = it_IT._21;
            VM_BAR.Text = it_IT._22;
            label1.Text = it_IT.id1;
            label2.Text = it_IT.id2;
            label3.Text = it_IT.id3;
            label4.Text = it_IT.id4;
            label5.Text = it_IT.id5;
            label6.Text = it_IT.id6;
            label7.Text = it_IT.id7;
            label8.Text = it_IT.id8;
            label9.Text = it_IT.id9;
            PC.Text = it_IT.P;
            RC.Text = it_IT.R;
            SC.Text = it_IT.S;
            toolmsg1 = it_IT.in_mm;
            toolmsgimg = it_IT.timg;
        }
        private void Ins(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
            && (e.KeyChar != ',') && (e.KeyChar != '-')) e.Handled = true;
        }

        private void toolimg(object sender, EventArgs e)
        {
            if (img != null) toolTip2.SetToolTip(pictureBox1, toolmsgimg);
        }


        private void cl(object sender, MouseEventArgs e)
        {
            if (Tbin.Text == "") Tbmm.Text = "";
            else if (Tbmm.Text == "") Tbin.Text = "";
        }


        /*  private void Conv_in(object sender, EventArgs e)
          {
              if (Tbin.Text == ".") Tbin.Text = "";
              if ((Tbin.Text != "") && (Tbin.Text != "."))
              {
                  inch = double.Parse(Tbin.Text);
                  mm = inch * 25.4;
                  Tbmm.Text = mm.ToString("0.000");
              }
          }*/

        private void conv_click(object sender, EventArgs e)
        {
           
            if (Tbin.Text == "")
            {
                mm = double.Parse(Tbmm.Text);
                inch = mm / 25.4;
                Tbin.Text = inch.ToString("0.000");
            }
            else if (Tbmm.Text == "")
            {
                inch = double.Parse(Tbin.Text);
                mm = inch * 25.4;
                Tbmm.Text = mm.ToString("0.000");
            }
        }

        private void Enable_conv(object sender, EventArgs e)
        {
            if (Conv.Checked == true) groupBox1.Visible = true;
            if (Conv.Checked == false) groupBox1.Visible = false;
        }
       /* private void Conv_mm(object sender, EventArgs e)
        {
            if (Tbmm.Text == ".") Tbmm.Text = "";
            if ((Tbmm.Text != "") && (Tbmm.Text != "."))
            {
                mm = double.Parse(Tbmm.Text);
                inch = mm / 25.4;
                Tbin.Text = inch.ToString("0.000");
            }
        }*/
        private void DarkModeEnable()
        {
            BackColor = Color.FromArgb(30, 30, 30);
            MenuBar.BackColor = Color.FromArgb(10, 10, 10);
            OptionMenuBar.BackColor = Color.FromArgb(10, 10, 10);
            Lang_bar.BackColor = Color.FromArgb(10, 10, 10);
            DE_L.BackColor = Color.FromArgb(10, 10, 10);
            EN_L.BackColor = Color.FromArgb(10, 10, 10);
            ES_L.BackColor = Color.FromArgb(10, 10, 10);
            FR_L.BackColor = Color.FromArgb(10, 10, 10);
            IT_L.BackColor = Color.FromArgb(10, 10, 10);
            VM_BAR.BackColor = Color.FromArgb(10, 10, 10);
            STD_MODE.BackColor = Color.FromArgb(10, 10, 10);
            DARK_MODE.BackColor = Color.FromArgb(10, 10, 10);
            OpenMenuBar.BackColor = Color.FromArgb(10, 10, 10);
            BC_BAR.BackColor = Color.FromArgb(10, 10, 10);
            BK_BAR.BackColor = Color.FromArgb(10, 10, 10);
            CK_BAR.BackColor = Color.FromArgb(10, 10, 10);
            Conv.BackColor = Color.FromArgb(10, 10, 10);
            infobox.BackColor = Color.FromArgb(10, 10, 10);
            MenuBar.ForeColor = Color.DarkKhaki;
            OptionMenuBar.ForeColor = Color.DarkOliveGreen;
            Lang_bar.ForeColor = Color.DarkOliveGreen;
            DE_L.ForeColor = Color.DarkOliveGreen;
            EN_L.ForeColor = Color.DarkOliveGreen;
            ES_L.ForeColor = Color.DarkOliveGreen;
            FR_L.ForeColor = Color.DarkOliveGreen;
            IT_L.ForeColor = Color.DarkOliveGreen;
            VM_BAR.ForeColor = Color.DarkOliveGreen;
            STD_MODE.ForeColor = Color.DarkOliveGreen;
            DARK_MODE.ForeColor = Color.DarkOliveGreen;
            OpenMenuBar.ForeColor = Color.DarkKhaki;
            BC_BAR.ForeColor = Color.DarkKhaki;
            BK_BAR.ForeColor = Color.DarkKhaki;
            CK_BAR.ForeColor = Color.DarkKhaki;
            Conv.ForeColor = Color.DarkKhaki;
            infobox.ForeColor = Color.White;
            List.BackColor = Color.FromArgb(0, 0, 10);
            List.ForeColor = Color.Silver;
            PB.BackColor = Color.FromArgb(0, 0, 10);
            RB.BackColor = Color.FromArgb(0, 0, 10);
            BCB.BackColor = Color.FromArgb(0, 0, 10);
            button5.BackColor = Color.FromArgb(0, 0, 10);
            okb.BackColor = Color.FromArgb(0, 0, 10);
            okb.ForeColor = Color.White;
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.ForeColor = Color.White;
            pictureBox1.BackColor = Color.Gainsboro;
            Tbin.BackColor = Color.Gainsboro;
            Tbmm.BackColor = Color.Gainsboro;
            // button4.BackColor = Color.DarkCyan;
            INC.ForeColor = Color.DarkKhaki;
            MMC.ForeColor = Color.DarkKhaki;
            PC.ForeColor = Color.DarkKhaki;
            RC.ForeColor = Color.DarkKhaki;
            SC.ForeColor = Color.DarkKhaki;
            NEC.ForeColor = Color.DarkKhaki;
            label10.ForeColor = Color.DarkOliveGreen;
            label11.ForeColor = Color.DarkOliveGreen;
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

        }
        private void LightModeEnable()
        {
            BackColor = Color.White;
            MenuBar.BackColor = Color.White;
            OptionMenuBar.BackColor = Color.White;
            Lang_bar.BackColor = Color.White;
            DE_L.BackColor = Color.White;
            EN_L.BackColor = Color.White;
            ES_L.BackColor = Color.White;
            FR_L.BackColor = Color.White;
            IT_L.BackColor = Color.White;
            VM_BAR.BackColor = Color.White;
            STD_MODE.BackColor = Color.White;
            DARK_MODE.BackColor = Color.White;
            OpenMenuBar.BackColor = Color.White;
            BC_BAR.BackColor = Color.White;
            BK_BAR.BackColor = Color.White;
            CK_BAR.BackColor = Color.White;
            Conv.BackColor = Color.White;
            infobox.BackColor = Color.White;
            MenuBar.ForeColor = Color.Black;
            OptionMenuBar.ForeColor = Color.Black;
            Lang_bar.ForeColor = Color.Black;
            DE_L.ForeColor = Color.Black;
            EN_L.ForeColor = Color.Black;
            ES_L.ForeColor = Color.Black;
            FR_L.ForeColor = Color.Black;
            IT_L.ForeColor = Color.Black;
            VM_BAR.ForeColor = Color.Black;
            STD_MODE.ForeColor = Color.Black;
            DARK_MODE.ForeColor = Color.Black;
            OpenMenuBar.ForeColor = Color.Black;
            BC_BAR.ForeColor = Color.Black;
            BK_BAR.ForeColor = Color.Black;
            CK_BAR.ForeColor = Color.Black;
            Conv.ForeColor = Color.Black;
            infobox.ForeColor = Color.Black;
            List.BackColor = Color.White;
            List.ForeColor = Color.Black;
            PB.BackColor = Color.White;
            RB.BackColor = Color.White;
            BCB.BackColor = Color.White;
            button5.BackColor = Color.White;
            okb.BackColor = Color.White;
            okb.ForeColor = Color.Black;
            Tbin.BackColor = Color.White;
            Tbmm.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.White;
            // button4.BackColor = Color.White;
            INC.ForeColor = Color.Black;
            MMC.ForeColor = Color.Black;
            PC.ForeColor = Color.Black;
            RC.ForeColor = Color.Black;
            SC.ForeColor = Color.Black;
            NEC.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            _10.ForeColor = Color.Black;
            _8.ForeColor = Color.Black;
            _7.ForeColor = Color.Black;
            _6.ForeColor = Color.Black;
            _5.ForeColor = Color.Black;
            _4.ForeColor = Color.Black;
            _3.ForeColor = Color.Black;
            _2.ForeColor = Color.Black;
            _1.ForeColor = Color.Black;
            bullet.ForeColor = Color.Black;

        }
    }
}
