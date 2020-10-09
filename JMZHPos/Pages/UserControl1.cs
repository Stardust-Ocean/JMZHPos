using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin.Controls;

namespace JMZHPos.Pages
{
    public partial class UserControl1 : DSkin.Controls.DSkinUserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "编号", DataPropertyName = "UserName" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "数量", DataPropertyName = "UserPwd" });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "已打印数量", Width = 100, DataPropertyName = "l3", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "已打印数量", Width = 100, DataPropertyName = "l3", });
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "标签文件", Width = 100, DataPropertyName = "l3", });
            
            dSkinGridList1.Columns.Add(new DSkinGridListColumn { Name = "操作", Width = 158, CellTemplate = typeof(OperationCellTemplate) });
        }
    }
}
