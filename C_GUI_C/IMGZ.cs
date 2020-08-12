using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI_C
{
    public partial class IMGZ : Form
    {
        string img;
        public IMGZ()
        {
            InitializeComponent();
            if (C_GUI.subject != null && C_GUI.img != null)
            {
                Text = C_GUI.subject;
                img = C_GUI.img;
                pictureBox1.Image = Image.FromFile(img);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}

