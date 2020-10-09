using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace JMZHPos
{
    public class TabItemTemplate : DSkin.Controls.DSkinTabItem
    {
        private DSkin.DirectUI.DuiIcon duiIcon1;
        private DSkin.DirectUI.DuiIcon duiIcon2;

        public TabItemTemplate()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.duiIcon1 = new DSkin.DirectUI.DuiIcon();
            this.duiIcon2 = new DSkin.DirectUI.DuiIcon();
            this.SuspendLayout();
            // 
            // duiIcon1
            // 
            this.duiIcon1.DesignModeCanResize = false;
            this.duiIcon1.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.duiIcon1.Icon = DSkin.Common.FontAwesomeChars.icon_align_justify;
            this.duiIcon1.IconSize = 18F;
            this.duiIcon1.Location = new System.Drawing.Point(12, 12);
            this.duiIcon1.Name = "duiIcon1";
            this.duiIcon1.Size = new System.Drawing.Size(25, 21);
            // 
            // duiIcon2
            // 
            this.duiIcon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.duiIcon2.DesignModeCanResize = false;
            this.duiIcon2.ForeColor = System.Drawing.Color.Gray;
            this.duiIcon2.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.duiIcon2.Icon = DSkin.Common.FontAwesomeChars.icon_close;
            this.duiIcon2.Location = new System.Drawing.Point(180, 14);
            this.duiIcon2.Name = "duiIcon2";
            this.duiIcon2.Size = new System.Drawing.Size(14, 14);
            this.duiIcon2.MouseEnter += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.duiIcon2_MouseEnter);
            this.duiIcon2.MouseLeave += new System.EventHandler(this.duiIcon2_MouseLeave);
            this.duiIcon2.MouseClick += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.duiIcon2_MouseClick);
            // 
            // TabItemTemplate
            // 
            this.AutoEllipsis = true;
            this.Controls.Add(this.duiIcon1);
            this.Controls.Add(this.duiIcon2);
            this.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IsPureColor = true;
            this.PressColor = System.Drawing.Color.White;
            this.RoundStyle = DSkin.Common.RoundStyle.None;
            this.Size = new System.Drawing.Size(200, 40);
            this.Text = "123十大个阿萨德安抚多个萨达阿达";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextInnerPadding = new System.Windows.Forms.Padding(38, 10, 15, 10);
            this.ResumeLayout();

        }

        private void duiIcon2_MouseEnter(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            duiIcon2.BackColor = System.Drawing.Color.FromArgb(254, 86, 39);
            duiIcon2.ForeColor = Color.White;
        }

        private void duiIcon2_MouseLeave(object sender, EventArgs e)
        {
            duiIcon2.BackColor = System.Drawing.Color.Transparent;
            duiIcon2.ForeColor = Color.Gray;
        }

        protected override void OnControlStateChanged(EventArgs e)
        {
            base.OnControlStateChanged(e);
            if (ControlState == DSkin.DirectUI.ControlStates.Pressed)
            {
                Borders.RightColor = Borders.LeftColor = System.Drawing.Color.FromArgb(225, 225, 225);
            }
            else
            {
                Borders.RightColor = Borders.LeftColor = System.Drawing.Color.Transparent;
            }
        }

        public DSkin.Common.FontAwesomeChars Icon
        {
            get { return duiIcon1.Icon; }
            set { duiIcon1.Icon = value; }
        }

        private void duiIcon2_MouseClick(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            this.SendTask("移除选项卡");
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                Width = (int)g.MeasureString(Text, Font).Width + 60;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (Loaded)
            {
                using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
                {
                    Width = (int)g.MeasureString(Text, Font).Width + 60;
                }
            }
        }
    }
}
