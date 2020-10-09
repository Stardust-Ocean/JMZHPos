using DSkin.Forms;
using JMZHPos.BLL.JMZHPos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JMZHPos.Commodity
{
    public partial class CommodityAdd : DSkin.Forms.DSkinForm
    {
        public CommodityAdd()
        {
            InitializeComponent();
            this.CaptionBackColors = new Color[] { MainForm.ChangeColor(MainForm.SkinColor, -20) };
            MainForm.SkinColorChanged += MainForm_SkinColorChanged;

            SupplierBLL bll = new SupplierBLL();
            Co_Id.DataSource = bll.GetAllList().Tables[0];
            Co_Id.DisplayMember = "SP_Name";
            Co_Id.ValueMember = "SP_ID";

        }

        private void MainForm_SkinColorChanged()
        {
            this.CaptionBackColors = new Color[] { MainForm.ChangeColor(MainForm.SkinColor, -20) };
        }

        protected override void OnClosed(EventArgs e)
        {
            MainForm.SkinColorChanged -= MainForm_SkinColorChanged;
            base.OnClosed(e);
        }

        private void CommAddBtn_Click(object sender, EventArgs e)
        {
            CommodityBLL bll = new CommodityBLL();
            Model.Commodity comdodel = new Model.Commodity();
            comdodel.Commo_Id = "1";
            comdodel.Co_Number = CoNumber.Text;
            comdodel.Co_Name = CoName.Text;
            comdodel.Co_Id = Co_Id.Text;
            comdodel.Co_creatDate = DateTime.Parse(Co_creatDate.Text);
            comdodel.Co_Price = decimal.Parse(CoPrice.Text);
            comdodel.Co_Purchase = decimal.Parse(Co_Purchase.Text);
            comdodel.Co_Instock = decimal.Parse(Co_Instock.Text);
            if (bll.Add(comdodel))
            {
                DSkinMessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }




        #region  输入限制
        private void CoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
                else if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                {
                    if (((TextBox)sender).Text.Trim().Substring(((TextBox)sender).Text.Trim().IndexOf('.') + 1).Length >= 4)
                        e.Handled = true;
                }
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
