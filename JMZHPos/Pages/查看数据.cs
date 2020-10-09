using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSkin.Controls;
using JMZHPos.BLL.JMZHPos;

namespace JMZHPos.Pages
{
    public partial class 查看数据 : DSkinUserControl
    {
        public 查看数据()
        {
            InitializeComponent();
        }
        UserTableBLL bll = new UserTableBLL();
        private void 查看数据_Load(object sender, EventArgs e)
        {
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "列1", DataPropertyName = "UserName" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "列2", DataPropertyName = "UserPwd" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "列3", Width = 100, DataPropertyName = "l3", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "操作", Width = 158, CellTemplate = typeof(OperationCellTemplate) });
            

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();



            DataSet ds = new DataSet();
            
            ds = bll.GetAllList();
            dSkinGridList1.DataSource = ds.Tables[0];

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
