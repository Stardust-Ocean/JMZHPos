using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JMZHPos.Commodity;
using DSkin.Controls;
using JMZHPos.BLL.JMZHPos;
using JMZHPos.Commodity.会员管理;

namespace JMZHPos.Pages
{
    public partial class 会员浏览 : DSkin.Controls.DSkinUserControl
    {


        #region ------初始化变量------
        private string strSql = "";                 //查询条件
        #endregion
        public 会员浏览()
        {
            InitializeComponent();
        }

        private void 会员浏览_Load(object sender, EventArgs e)
        {
            #region 表格字段加载

            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "编号", Width = 130, DataPropertyName = "Me_Id" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员卡号", Width = 160, DataPropertyName = "Me_Number" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员分类", Width = 160, DataPropertyName = "Me_Item", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员姓名", Width = 130, DataPropertyName = "Me_Name" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员电话", Width = 130, DataPropertyName = "Me_Tel" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员生日", Width = 130, DataPropertyName = "Me_Birthday", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "联系地址", DataPropertyName = "Me_adress" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "开卡时间", Width = 130, DataPropertyName = "Me_NewDatetime" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "有效时间", Width = 130, DataPropertyName = "Me_EffectiveTime", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "过期时间", Width = 130, DataPropertyName = "Me_ExpirationTIme" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "初始积分", Width = 130, DataPropertyName = "Me_integral" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "初始余额", Width = 130, DataPropertyName = "Me_balance", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "备注", Width = 130, DataPropertyName = "Me_Remark" });
          
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "操作", Width = 158, CellTemplate = typeof(OperationCellTemplate) });
            #endregion
            MemberBLL bll = new MemberBLL();
            DataSet ds = new DataSet();

            ds = bll.GetAllList();

            dSkinGridList1.DataSource = ds.Tables[0];
            fillGVList("");
        }

        private void CommAddBtn_Click(object sender, EventArgs e)
        {
            MemberAdd ma = new MemberAdd();
            ma.Show();
        }

        #region ------填出datagridview------
        public void fillGVList(string key)
        {
            strSql = key;
            MemberBLL bll = new MemberBLL();
            DataSet ds = new DataSet();

            ds = bll.GetAllList();
            dSkinGridList1.DataSource = ds.Tables[0];
        }
        #endregion

        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            string id = dSkinGridList1.SelectedItem.Cells[0].Value.ToString();
            if (id != null)
            {
                MemberEdit frmEdit = new MemberEdit();
                //frmEdit.Owner = this;
                frmEdit.Tag = id.ToString();
                frmEdit.ShowDialog();

            }
        }

        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            MemberLevelList asd = new MemberLevelList();
            asd.ShowDialog();
        }
    }
}
