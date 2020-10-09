using System;
using System.Collections.Generic;
using System.Text;
using DSkin.Controls;

namespace JMZHPos
{
    public class OperationCellTemplate : DSkinGridListCellTemplate
    {
        private DSkin.DirectUI.DuiButton duiButton2;
        private DSkin.DirectUI.DuiButton duiButton1;
        public OperationCellTemplate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.duiButton1 = new DSkin.DirectUI.DuiButton();
            this.duiButton2 = new DSkin.DirectUI.DuiButton();
            // 
            // duiButton1
            // 
            this.duiButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.duiButton1.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.duiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duiButton1.ForeColor = System.Drawing.Color.White;
            this.duiButton1.HoverColor = System.Drawing.Color.Empty;
            this.duiButton1.Location = new System.Drawing.Point(12, 9);
            this.duiButton1.Name = "duiButton1";
            this.duiButton1.PressColor = System.Drawing.Color.Empty;
            this.duiButton1.Radius = 5;
            this.duiButton1.Size = new System.Drawing.Size(64, 22);
            this.duiButton1.Text = "修改";
            this.duiButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.duiButton1.MouseClick += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.duiButton1_MouseClick);
            // 
            // duiButton2
            // 
            this.duiButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(86)))), ((int)(((byte)(35)))));
            this.duiButton2.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(86)))), ((int)(((byte)(35)))));
            this.duiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duiButton2.ForeColor = System.Drawing.Color.White;
            this.duiButton2.HoverColor = System.Drawing.Color.Empty;
            this.duiButton2.Location = new System.Drawing.Point(83, 7);
            this.duiButton2.Name = "duiButton2";
            this.duiButton2.PressColor = System.Drawing.Color.Empty;
            this.duiButton2.Radius = 5;
            this.duiButton2.Size = new System.Drawing.Size(64, 22);
            this.duiButton2.Text = "删除";
            this.duiButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.duiButton2.MouseClick += new System.EventHandler<DSkin.DirectUI.DuiMouseEventArgs>(this.duiButton2_MouseClick);
            // 
            // OperationCellTemplate
            // 
            this.Controls.Add(this.duiButton1);
            this.Controls.Add(this.duiButton2);
            this.Size = new System.Drawing.Size(157, 37);

        }

        private void duiButton2_MouseClick(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            this.SendTask("删除", this.Cell.DSkinGridListRow.RowData);
        }

        private void duiButton1_MouseClick(object sender, DSkin.DirectUI.DuiMouseEventArgs e)
        {
            this.SendTask("修改", this.Cell.DSkinGridListRow.RowData);
            MessageBoxForm.Show("标题", "测试内容", MessageBoxTypes.Ok);
            SmallForm sa = new SmallForm();
            sa.ShowDialog();
        }
    }
}
