using DSkin.Controls;
using DSkin.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace 打印
{
    public partial class Form1 : DSkinForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CommAddBtn_Click(object sender, EventArgs e)
        {
            导入excel_Click();
        }
        /// <summary>
        /// 读取excel
        /// </summary>
        private void 导入excel_Click()
        {
            string path = "";


            System.Windows.Forms.OpenFileDialog fd = new System.Windows.Forms.OpenFileDialog();
            fd.Title = "选择文件";//选择框名称
            fd.Filter = "xls files (*.xls)|*.xls";//选择文件的类型为Xls表格
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)//当点击确定
            {
                path = fd.FileName.Trim();//文件路径
                path = path.Replace("\\", "/");
            }

            string mystring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='";
            mystring += path.ToString();
            mystring += "';User ID=admin;Password=;Extended properties='Excel 8.0;IMEX=1;HDR=NO;'";
            OleDbConnection cnnxls = new OleDbConnection(mystring);
            OleDbDataAdapter myDa = new OleDbDataAdapter("Select * from [Sheet1$]", cnnxls);
            DataSet myDs = new DataSet();
            myDa.Fill(myDs);//数据存放在myDs中了
                            //dataGridView1.DataSource = myDs.Tables[0];


            DataTable dataTable = myDs.Tables[0];


            for (int i = 10; i < dataTable.Columns.Count; i++)
            {
                DSkinGridListColumn dSkinGridListColumn = new DSkinGridListColumn();
                //  dSkinGridListColumn.Name = dataTable.Columns[i].ColumnName;
                dSkinGridListColumn.Width = 100;
                dSkinGridListColumn.DataPropertyName = dataTable.Columns[i].ColumnName;
                dSkinGridList1.Columns.Add(dSkinGridListColumn);
            }
            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                if (dataTable.Rows[j].ItemArray[3].ToString() != "")
                {
                    dSkinGridList1.Rows.AddRow(dataTable.Rows[j].ItemArray);
                }
            }
            // string id = dSkinGridList1.SelectedItem.Cells[2].Value.ToString();
            // string filePath= dSkinGridList1.DataMember.d

            Director(@"D:\打印\合格证");

           

            //PrintDocument print = new PrintDocument();
            //string sDefault = print.PrinterSettings.PrinterName;//默认打印机名
            //foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            //{
            //    comboBox1.Items.Add(sPrint);
            //    if (sPrint == sDefault)
            //        comboBox1.SelectedIndex = comboBox1.Items.IndexOf(sPrint);
            //}
            //#region
            //string path = @"D:\12.prn";//文件路径

            //System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            //string text;
            //using (System.IO.StreamReader sr = new System.IO.StreamReader(path, encoding))
            //{
            //    text = sr.ReadToEnd();
            //    MessageBox.Show(text);
            //}
        }
        static void Director(string dir)
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            FileSystemInfo[] fsinfos = d.GetFileSystemInfos();
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                if (fsinfo is DirectoryInfo)     //判断是否为文件夹
                {
                    Director(fsinfo.FullName);//递归调用
                }
                else
                {
                   // DSkinMessageBox.Show(fsinfo.FullName);//输出文件的全部路径
                }
            }
        }
    }
}
