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
        private PictureBox pictureBox1;
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

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IMGZ
            // 
            this.ClientSize = new System.Drawing.Size(579, 254);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IMGZ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

