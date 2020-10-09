using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace JMZHPos
{
    public class ImageTemplate:DSkin.Controls.DSkinListItemTemplate
    {
        private DSkin.DirectUI.DuiLabel duiLabel1;
        private DSkin.DirectUI.DuiPictureBox duiPictureBox1;

        public ImageTemplate()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.duiPictureBox1 = new DSkin.DirectUI.DuiPictureBox();
            this.duiLabel1 = new DSkin.DirectUI.DuiLabel();
            this.SuspendLayout();
            // 
            // duiPictureBox1
            // 
            this.duiPictureBox1.AutoSize = false;
            this.duiPictureBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiPictureBox1.Images = new System.Drawing.Image[] {
        null};
            this.duiPictureBox1.Location = new System.Drawing.Point(20, 7);
            this.duiPictureBox1.Name = "duiPictureBox1";
            this.duiPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.duiPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // duiLabel1
            // 
            this.duiLabel1.AutoEllipsis = true;
            this.duiLabel1.DesignModeCanMove = false;
            this.duiLabel1.DesignModeCanResize = false;
            this.duiLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.duiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duiLabel1.Location = new System.Drawing.Point(0, 111);
            this.duiLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.duiLabel1.Name = "duiLabel1";
            this.duiLabel1.Size = new System.Drawing.Size(136, 19);
            this.duiLabel1.Text = "Dui设计模式";
            this.duiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageTemplate
            // 
            this.Borders.AllColor = System.Drawing.Color.Gainsboro;
            this.Borders.BottomColor = System.Drawing.Color.Gainsboro;
            this.Borders.LeftColor = System.Drawing.Color.Gainsboro;
            this.Borders.RightColor = System.Drawing.Color.Gainsboro;
            this.Borders.TopColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.duiPictureBox1);
            this.Controls.Add(this.duiLabel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(136, 135);
            this.ResumeLayout();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //duiPictureBox1.Image = (Image)Eval("Image");
            //duiLabel1.Text = Eval("text").ToString();
        }

        public Image Image
        {
            get { return duiPictureBox1.Image; }
            set { duiPictureBox1.Image = value; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            duiLabel1.Text = Text;
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            this.Borders.AllColor = Color.Gray;
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Borders.AllColor = Color.Gainsboro;
        }
    }
}
