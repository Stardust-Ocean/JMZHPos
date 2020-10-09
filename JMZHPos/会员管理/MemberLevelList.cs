using DSkin.Controls;
using DSkin.Forms;
using JMZHPos.BLL.JMZHPos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JMZHPos.Commodity.会员管理
{
    public partial class MemberLevelList : DSkin.Forms.DSkinForm
    {
        public MemberLevelList()
        {
            InitializeComponent();
            this.CaptionBackColors = new Color[] { MainForm.ChangeColor(MainForm.SkinColor, -20) };
            MainForm.SkinColorChanged += MainForm_SkinColorChanged;

            MemberLevelBLL bll = new MemberLevelBLL();
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员等级", Width = 200, DataPropertyName = "MemberLivel" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "折扣", Width = 150, DataPropertyName = "Me_Discount" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "升级积分", Width = 100, DataPropertyName = "Me_Num", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "参与积分", Width = 100, DataPropertyName = "Me_Part", });


            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();



            DataSet ds = new DataSet();

            ds = bll.GetAllList();
            dSkinGridList1.DataSource = ds.Tables[0];

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


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




        private void MemberAdd_Load(object sender, EventArgs e)
        {

        }

        private void CommAddBtn_Click_1(object sender, EventArgs e)
        {
            MemberLevelAdd melvAdd = new MemberLevelAdd();
            melvAdd.Owner = this;
            melvAdd.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
