using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin.Controls;
using JMZHPos.Commodity;
using JMZHPos.BLL.JMZHPos;

namespace JMZHPos.Pages
{
    public partial class 供货商管理 : DSkinUserControl
    {
        #region ------初始化变量------
        private string strSql = "";                 //查询条件
        #endregion


        public 供货商管理()
        {
            InitializeComponent();
        }

        private void CommAddBtn_Click(object sender, EventArgs e)
        {
            SupplierAdd comadd = new SupplierAdd();
            comadd.ShowDialog();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            string id = dSkinGridList1.SelectedItem.Cells[0].Value.ToString();
            if (id != null)
            {
                SupplierEdit frmEdit = new SupplierEdit();
                //frmEdit.Owner = this;
                frmEdit.Tag = id.ToString();
                frmEdit.ShowDialog();

            }
        }

        private void dSkinButton3_Click(object sender, EventArgs e)
        {
            fillGVList("");
        }

        private void 供货商管理_Load(object sender, EventArgs e)
        {
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "编号", DataPropertyName = "SP_ID" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "供货商名称", DataPropertyName = "SP_Name" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "联系人", Width = 100, DataPropertyName = "SP_Prople", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "账户信息", Width = 100, DataPropertyName = "SP_Tele", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "电话", Width = 100, DataPropertyName = "SP_Tel", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "网站/邮箱", Width = 100, DataPropertyName = "SP_Email", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "地址", Width = 100, DataPropertyName = "SP_Adress", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "备注", Width = 100, DataPropertyName = "SP_Mark", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "操作", Width = 158, CellTemplate = typeof(OperationCellTemplate) });


            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            SupplierBLL bll = new SupplierBLL();
            DataSet ds = new DataSet();

            ds = bll.GetAllList();

            dSkinGridList1.DataSource = ds.Tables[0];
            fillGVList("");

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        #region ------填出datagridview------
        public void fillGVList(string key)
        {
            strSql = key;
            SupplierBLL bll = new SupplierBLL();
            DataSet ds = new DataSet();

            ds = bll.GetAllList();
            dSkinGridList1.DataSource = ds.Tables[0];
        }
        #endregion
    }
}
