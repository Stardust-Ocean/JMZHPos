using DSkin.Forms;
using JMZHPos.BLL.JMZHPos;
using JMZHPos.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JMZHPos.Commodity
{
    public partial class CommodityEdit : DSkin.Forms.DSkinForm
    {
        public CommodityEdit()
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

        private void SmallForm2_Load(object sender, EventArgs e)
        {
            CommodityBLL bll = new CommodityBLL();
            Model.Commodity com = new Model.Commodity();
            com = bll.GetModel(this.Tag.ToString());
            CoNumber.Text = com.Co_Number;
            CoName.Text = com.Co_Name;
            Co_creatDate.Text = com.Co_creatDate.ToString();


            CoPrice.Text = com.Co_Price.ToString();
            Co_Purchase.Text = com.Co_Purchase.ToString();
            Co_Instock.Text = com.Co_Instock.ToString();
            // com.Co_Purchase = 12;
            //com.Co_Instock = 23;
        }

        private void CommAddBtn_Click(object sender, EventArgs e)
        {
            Model.Commodity comEdit = new Model.Commodity();
            CommodityBLL cbll = new CommodityBLL();
            comEdit.Commo_Id = this.Tag.ToString();
            comEdit.Co_Number = CoNumber.Text;
            comEdit.Co_Name = CoName.Text;
            comEdit.Co_Id = Co_Id.Text;
            comEdit.Co_creatDate = DateTime.Parse(Co_creatDate.Text);
            comEdit.Co_Price = decimal.Parse(CoPrice.Text);
            comEdit.Co_Purchase = decimal.Parse(Co_Purchase.Text);
            comEdit.Co_Instock = decimal.Parse(Co_Instock.Text);
            if (cbll.Update(comEdit))
            {
                DSkinMessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //商品浏览 sp = new 商品浏览();
                //sp.fillGVList("");
                this.Close();
            }
            else
            {
                DSkinMessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
