using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.IO;

namespace C_GUI_C
{
    public partial class INFO : Form
    {
        string lang, mode, txt, pdf;

        private void GP_Visible(object sender, EventArgs e)
        {
            if(groupBox1.Visible==true) {
                        groupBox1.Visible = false;
                pdf1.Visible = false;
                        HTU.Text = txt;
            }
            else 
                {
                groupBox1.Visible = true;
                pdf1.Visible = true;
                pdf1.LoadFile(pdf);
                HTU.Text = "README";
                
            }
        }

        public INFO()
        {
            pdf = @"RES\Docs\c_gui-manual.pdf";
            InitializeComponent();
            lang = C_GUI.lang;
            mode = C_GUI.mode;
            if (mode == "dark")
            {
                BackColor = Color.FromArgb(30, 30, 30);
                richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
                HTU.BackColor = Color.FromArgb(30, 30, 30);
                richTextBox1.ForeColor = Color.White;
                HTU.ForeColor = Color.White;
            }
            switch (lang)
            {
                case "de_DE":
                    txt = de_DE.htu;
                    break;
                case "en_EN":
                    txt = en_EN.htu;
                    break;
                case "es_ES":
                    txt = es_ES.htu;
                    break;
                case "fr_FR":
                    txt = fr_FR.htu;
                    break;
                case "it_IT":
                    txt = it_IT.htu;
                    pdf = @"RES\Docs\c_gui-manual_IT.pdf";
                    break;
            }
                    HTU.Text = txt;
            richTextBox1.Text = System.IO.File.ReadAllText(@"RES/Readme.txt");
        }
    }
}
