using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DSkin.Controls;
using JMZHPos.Commodity;
using JMZHPos.BLL.JMZHPos;
using DSkin.Forms;

namespace JMZHPos.Pages
{
    public partial class 商品浏览 : DSkin.Controls.DSkinUserControl
    {
        #region ------初始化变量------
        private string strSql = "";                 //查询条件
        #endregion



        #region ------窗体实例化------
        public 商品浏览()
        {
            InitializeComponent();
        }
        #endregion



        #region ------窗体加载------
        private void 表格_Load(object sender, EventArgs e)
        {
            #region  测试实例

            //System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            //stopwatch.Start();
            ////for (int i = 0; i < 200; i++)
            ////{
            ////    dataTable.Rows.Add("数据" + i, "12232sdagafa", "fgsddf");
            ////}
            ////dSkinGridList1.DataSource = dataTable;
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            #endregion


            #region 表格字段加载

            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "商品编号", Width = 130, DataPropertyName = "Commo_Id" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "商品条码", Width = 160, DataPropertyName = "Co_Number" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "商品名称", Width = 160, DataPropertyName = "Co_Name", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "零售价", Width = 130, DataPropertyName = "Co_Price" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "进货价", Width = 130, DataPropertyName = "Co_Purchase" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "会员价", Width = 130, DataPropertyName = "Co_Member", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "库存", DataPropertyName = "Co_Instock" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "库存价值", Width = 130, DataPropertyName = "Co_InstockPre" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "总销量", Width = 130, DataPropertyName = "Co_Sales", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "单价", Width = 130, DataPropertyName = "Co_UnitPre" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "规格", Width = 130, DataPropertyName = "Co_Specification" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "商品货号", Width = 130, DataPropertyName = "Co_Item", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "商品分类", Width = 130, DataPropertyName = "Co_Categories" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "供货商", Width = 130, DataPropertyName = "Co_Id" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "生产日期", Width = 160, DataPropertyName = "Co_creatDate", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "保质期", Width = 130, DataPropertyName = "Co_Shelf" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "是否打折", Width = 130, DataPropertyName = "Co_ShelfLife" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "是否积分", Width = 130, DataPropertyName = "Co_b_Nunber", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "积分", Width = 130, DataPropertyName = "Co_JIfen" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "备注", Width = 130, DataPropertyName = "Co_Remark" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "操作", Width = 158, CellTemplate = typeof(OperationCellTemplate) });
            #endregion
            CommodityBLL bll = new CommodityBLL();
            DataSet ds = new DataSet();

            ds = bll.GetAllList();

            dSkinGridList1.DataSource = ds.Tables[0];
            fillGVList("");

        }
        #endregion



        #region ------弹出添加窗孔------


        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            CommodityAdd comadd = new CommodityAdd();
            comadd.ShowDialog();
        }
        #endregion

        #region ------搜索------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbKey.Text.Trim() != "")
            {
                string key = tbKey.Text;
                strSql = "  Co_Name like '%" + key + "%'";
                fillGVList(strSql);

            }
        }
        #endregion

        #region ------共用刷新方法------
        public void refreshData()
        {
            fillGVList(strSql);
        }
        #endregion

        #region ------填出datagridview------
        public void fillGVList(string key)
        {
            strSql = key;
            CommodityBLL bll = new CommodityBLL();
            DataSet ds = new DataSet();

            //ds = bll.GetAllList();
            ds = bll.GetList(key);
            dSkinGridList1.DataSource = ds.Tables[0];
        }
        #endregion



        #region ------单条删除记录------
        private void btnDel_Click(object sender, EventArgs e)
        {
            ////删除会员

        }
        #endregion


        #region ------双击行弹出编辑界面------

        #endregion


        private void dSkinGridList1_AcceptTask(object sender, DSkin.DirectUI.AcceptTaskEventArgs e)
        {
            if (e.TaskName == "修改")
            {
                // dataTable.Rows.Remove(((DataRowView)e.Data).Row);
                //dSkinGridList1.DataBind();
                //  string id = dSkinGridList1.Rows[0].Cells[0].Value.ToString();

            }

        }
        #region ------修改记录------
        private void dSkinButton2_Click(object sender, EventArgs e)
        {
            //try
            //{
                string id = dSkinGridList1.SelectedItem.Cells[0].Value.ToString();
                if (id != null)
                {
                    CommodityEdit frmEdit = new CommodityEdit();
                    //frmEdit.Owner = this;
                    frmEdit.Tag = id.ToString();
                    frmEdit.ShowDialog();

                }
            //}
            //catch
            //{
            //    DSkinMessageBox.Show("请选择要修改的行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        #endregion

        #region ------显示所有数据------

        private void dSkinButton3_Click(object sender, EventArgs e)
        {
            fillGVList("");
        }
        #endregion
    }


}
