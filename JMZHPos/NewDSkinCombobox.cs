using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace JMZHPos
{
    public class NewDSkinCombobox : DSkin.Controls.DSkinComboBox
    {
        private DSkin.Controls.ControlHost controlHost1;

        public NewDSkinCombobox()
        {
            AutoDrawSelecedItem = false;
            IsPureColor = true;
            ButtonBorderColor = Color.LightGray;
            InnerListBox.Borders.AllColor = Color.LightGray;
            Font = new Font("微软雅黑", 14, GraphicsUnit.Pixel);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            foreach (DSkin.DirectUI.DuiLabel item in Items)
            {
                item.Font = new Font("微软雅黑", 14, GraphicsUnit.Pixel);
                item.Height = 36;
                item.TextAlign = ContentAlignment.MiddleLeft;
                item.TextInnerPadding = new Padding(5, 0, 0, 0);
                item.Width = Width;
            }
            base.OnMouseDown(e);
        }

        private void InitializeComponent()
        {
            this.controlHost1 = new DSkin.Controls.ControlHost();
            ((System.ComponentModel.ISupportInitialize)(this.InnerListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controlHost1
            // 
            this.controlHost1.Location = new System.Drawing.Point(0, 0);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(0, 0);
            this.controlHost1.TabIndex = 0;
            this.controlHost1.Text = "controlHost1";
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // NewDSkinCombobox
            // 
            // 
            // 
            // 
            this.InnerListBox.BackColor = System.Drawing.Color.Transparent;
            this.InnerListBox.Borders.AllColor = System.Drawing.Color.Silver;
            this.InnerListBox.Borders.BottomColor = System.Drawing.Color.Silver;
            this.InnerListBox.Borders.LeftColor = System.Drawing.Color.Silver;
            this.InnerListBox.Borders.RightColor = System.Drawing.Color.Silver;
            this.InnerListBox.Borders.TopColor = System.Drawing.Color.Silver;
            this.InnerListBox.Location = new System.Drawing.Point(0, 0);
            this.InnerListBox.Name = "";
            this.InnerListBox.ScrollBarWidth = 12;
            this.InnerListBox.TabIndex = 0;
            this.InnerListBox.Value = 0D;
            // 
            // 
            // 
            this.ToolStripDropDown.BorderColor = System.Drawing.Color.DarkGray;
            this.ToolStripDropDown.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStripDropDown.MinimumSize = new System.Drawing.Size(18, 18);
            this.ToolStripDropDown.Name = "";
            this.ToolStripDropDown.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripDropDown.Resizable = false;
            this.ToolStripDropDown.ResizeGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.ToolStripDropDown.ResizeGridSize = new System.Drawing.Size(16, 16);
            this.ToolStripDropDown.Size = new System.Drawing.Size(18, 18);
            this.ToolStripDropDown.WhereIsResizeGrid = DSkin.ResizeGridLocation.BottomRight;
            ((System.ComponentModel.ISupportInitialize)(this.InnerListBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
