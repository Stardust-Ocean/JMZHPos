using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DSkin.DirectUI;
using DSkin.Controls;

namespace JMZHPos
{
    /// <summary>
    /// 左边菜单模板
    /// </summary>
    public class MenuTemplate : DSkinTreeViewNodeTemplate
    {
        public MenuTemplate()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Node.CanSelect = false;
            duiLabel1.Text = Node.Text;
            duiIcon1.Icon = (DSkin.Common.FontAwesomeChars)Node.Tag;
            duiIcon2.Visible = Node.Nodes.Count > 0;
        }
        protected override void Dispose(bool disposing)
        {
            Node.Nodes.ItemAdded -= Nodes_ItemAdded;
            Node.Nodes.ItemRemoved -= Nodes_ItemRemoved;
            base.Dispose(disposing);
        }

        private void Nodes_ItemRemoved(object sender, DSkin.Common.CollectionEventArgs<DSkin.Controls.DSkinTreeViewNode> e)
        {
            duiIcon2.Visible = Node.Nodes.Count > 0;
        }

        private void Nodes_ItemAdded(object sender, DSkin.Common.CollectionEventArgs<DSkin.Controls.DSkinTreeViewNode> e)
        {
            duiIcon2.Visible = Node.Nodes.Count > 0;
        }

        private DSkin.DirectUI.DuiIcon duiIcon1;
        private DSkin.DirectUI.DuiIcon duiIcon2;
        private DSkin.DirectUI.DuiLabel duiLabel1;

        private void InitializeComponent()
        {
            this.duiLabel1 = new DSkin.DirectUI.DuiLabel();
            this.duiIcon1 = new DSkin.DirectUI.DuiIcon();
            this.duiIcon2 = new DSkin.DirectUI.DuiIcon();
            // 
            // duiLabel1
            // 
            this.duiLabel1.AutoSize = true;
            this.duiLabel1.DesignModeCanResize = false;
            this.duiLabel1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.duiLabel1.Location = new System.Drawing.Point(56, 13);
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
            this.duiIcon1.Location = new System.Drawing.Point(25, 14);
            this.duiIcon1.Name = "duiIcon1";
            this.duiIcon1.Size = new System.Drawing.Size(24, 21);
            // 
            // duiIcon2
            // 
            this.duiIcon2.DesignModeCanResize = false;
            this.duiIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.duiIcon2.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.duiIcon2.Icon = DSkin.Common.FontAwesomeChars.icon_angle_down;
            this.duiIcon2.IconSize = 18F;
            this.duiIcon2.Location = new System.Drawing.Point(173, 12);
            this.duiIcon2.Name = "duiIcon2";
            this.duiIcon2.Size = new System.Drawing.Size(18, 21);
            // 
            // MenuTemplate
            // 
            this.Controls.Add(this.duiLabel1);
            this.Controls.Add(this.duiIcon1);
            this.Controls.Add(this.duiIcon2);
            this.Size = new System.Drawing.Size(200, 45);
            this.MouseEnter += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.MenuTemplate_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MenuTemplate_MouseLeave);

        }

        private void MenuTemplate_MouseEnter(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void MenuTemplate_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseDown(DuiMouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (Node.Nodes.Count > 0)
            {
                Node.NodesOpened = !Node.NodesOpened;
                duiIcon2.Icon = Node.NodesOpened ? DSkin.Common.FontAwesomeChars.icon_angle_up : DSkin.Common.FontAwesomeChars.icon_angle_down;
            }
        }
    }
}
