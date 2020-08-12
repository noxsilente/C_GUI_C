namespace C_GUI_C
{
    partial class INFO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INFO));
            this.logobox = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HTU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pdf1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf1)).BeginInit();
            this.SuspendLayout();
            // 
            // logobox
            // 
            this.logobox.BackColor = System.Drawing.Color.Transparent;
            this.logobox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logobox.BackgroundImage")));
            this.logobox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logobox.Location = new System.Drawing.Point(10, 10);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(100, 100);
            this.logobox.TabIndex = 0;
            this.logobox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(117, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(671, 342);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // HTU
            // 
            this.HTU.AutoSize = true;
            this.HTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTU.Location = new System.Drawing.Point(13, 128);
            this.HTU.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.HTU.Name = "HTU";
            this.HTU.Size = new System.Drawing.Size(97, 25);
            this.HTU.TabIndex = 2;
            this.HTU.Text = "H.T.U";
            this.HTU.UseVisualStyleBackColor = true;
            this.HTU.Click += new System.EventHandler(this.GP_Visible);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pdf1);
            this.groupBox1.Location = new System.Drawing.Point(117, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // pdf1
            // 
            this.pdf1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf1.Enabled = true;
            this.pdf1.Location = new System.Drawing.Point(0, 3);
            this.pdf1.Name = "pdf1";
            this.pdf1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf1.OcxState")));
            this.pdf1.Size = new System.Drawing.Size(671, 342);
            this.pdf1.TabIndex = 4;
            this.pdf1.Visible = false;
            // 
            // INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HTU);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.logobox);
            this.Name = "INFO";
            this.ShowIcon = false;
            this.Text = "INFO";
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdf1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button HTU;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxAcroPDFLib.AxAcroPDF pdf1;
    }
}