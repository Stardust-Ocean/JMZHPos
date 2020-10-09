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
    public partial class SupplierEdit : DSkin.Forms.DSkinForm
    {
        public SupplierEdit()
        {
            InitializeComponent();
            this.CaptionBackColors = new Color[] { MainForm.ChangeColor(MainForm.SkinColor, -20) };
            MainForm.SkinColorChanged += MainForm_SkinColorChanged;
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
            SupplierBLL bll = new SupplierBLL();
            Model.Supplier comdodel = new Model.Supplier();
            //comdodel.Commo_Id = "1";
            comdodel.SP_ID = Convert.ToInt32(this.Tag.ToString()); 
            comdodel.SP_Name = SP_Name.Text;
            comdodel.SP_Prople = SP_Prople.Text;
            comdodel.SP_Tele = SP_Tele.Text;
            comdodel.SP_Tel = SP_Tel.Text; ;
            comdodel.SP_Email = SP_Email.Text;
            comdodel.SP_Adress = SP_Adress.Text;
            comdodel.SP_Mark = SP_Mark.Text;
            if (bll.Update(comdodel))
            {
                DSkinMessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void SupplierEdit_Load(object sender, EventArgs e)
        {
            SupplierBLL bll = new SupplierBLL();
            Model.Supplier com = new Model.Supplier();
            com = bll.GetModel(this.Tag.ToString());


            SP_Name.Text = com.SP_Name;
            SP_Prople.Text = com.SP_Prople;
            SP_Tele.Text = com.SP_Tele;
            SP_Tel.Text = com.SP_Tel; ;
            SP_Email.Text = com.SP_Email;
            SP_Adress.Text = com.SP_Adress;
            SP_Mark.Text = com.SP_Mark;

        }
    }
}
