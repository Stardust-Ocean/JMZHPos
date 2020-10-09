using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace JMZHPos
{
    public class ChildMenuTemplate : DSkin.Controls.DSkinTreeViewNodeTemplate
    {
        private DSkin.DirectUI.DuiLabel duiLabel1;
        private DSkin.DirectUI.DuiIcon duiIcon1;

        public ChildMenuTemplate()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            duiLabel1.Text = Node.Text;
            duiIcon1.Icon = (DSkin.Common.FontAwesomeChars)Node.Tag;
            Node.SelectedChanged += Node_SelectedChanged;
            //Parent.InnerDuiControl.Margin = new Padding();
        }

        protected override void Dispose(bool disposing)
        {
            Node.SelectedChanged -= Node_SelectedChanged;
            base.Dispose(disposing);
        }

        private void Node_SelectedChanged(object sender, EventArgs e)
        {
            if (Node.Selected)
            {
                BackColor = Color.FromArgb(35, 159, 253);
            }
            else
            {
                BackColor = Color.FromArgb(80, 0, 0, 0);
            }
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            duiIcon1.ForeColor = duiLabel1.ForeColor = Color.White;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            duiIcon1.ForeColor = duiLabel1.ForeColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void InitializeComponent()
        {
            this.duiLabel1 = new DSkin.DirectUI.DuiLabel();
            this.duiIcon1 = new DSkin.DirectUI.DuiIcon();
            // 
            // duiLabel1
            // 
            this.duiLabel1.AutoSize = true;
            this.duiLabel1.DesignModeCanResize = false;
            this.duiLabel1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.duiLabel1.Location = new System.Drawing.Point(68, 13);
            this.duiLabel1.Name = "duiLabel1";
            this.duiLabel1.Size = new System.Drawing.Size(87, 21);
            this.duiLabel1.Text = "Dui设计模式";
            // 
            // duiIcon1
            // 
            this.duiIcon1.DesignModeCanResize = false;
            this.duiIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.duiIcon1.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.duiIcon1.Icon = DSkin.Common.FontAwesomeChars.icon_star;
            this.duiIcon1.IconSize = 18F;
            this.duiIcon1.Location = new System.Drawing.Point(37, 14);
            this.duiIcon1.Name = "duiIcon1";
            this.duiIcon1.Size = new System.Drawing.Size(24, 21);
            // 
            // ChildMenuTemplate
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.duiIcon1);
            this.Controls.Add(this.duiLabel1);
            this.Size = new System.Drawing.Size(200, 45);

        }
    }
}
