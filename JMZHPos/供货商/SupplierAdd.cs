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
    public partial class SupplierAdd : DSkin.Forms.DSkinForm
    {
        public SupplierAdd()
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
            comdodel.SP_Name = SP_Name.Text;
            comdodel.SP_Prople = SP_Prople.Text;
            comdodel.SP_Tele = SP_Tele.Text;
            comdodel.SP_Tel = SP_Tel.Text; ;
            comdodel.SP_Email = SP_Email.Text;
            comdodel.SP_Adress = SP_Adress.Text;
            comdodel.SP_Mark = SP_Mark.Text;
            if (bll.Add(comdodel))
            {
                DSkinMessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        
    }
}
