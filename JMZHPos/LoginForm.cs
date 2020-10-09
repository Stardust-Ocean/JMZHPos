using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace JMZHPos
{
    public partial class LoginForm : DSkin.Forms.DSkinForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void dSkinPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.MoveForm();
        }

        private void dSkinIcon1_MouseEnter(object sender, EventArgs e)
        {
            dSkinIcon1.ForeColor = Color.FromArgb(100, 150, 252);
        }

        private void dSkinIcon1_MouseLeave(object sender, EventArgs e)
        {
            dSkinIcon1.ForeColor = Color.Black;
        }

        private void dSkinIcon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dSkinTextBox1_Enter(object sender, EventArgs e)
        {
            dSkinLabel1.Visible = false;
            var p = (sender as TextBox).Parent as DSkin.Controls.DSkinPanel;
            p.DuiBackgroundRender.BorderColor = Color.FromArgb(90, 170, 252);
        }

        private void dSkinTextBox1_Leave(object sender, EventArgs e)
        {
            var p = (sender as TextBox).Parent as DSkin.Controls.DSkinPanel;
            p.DuiBackgroundRender.BorderColor = Color.Silver;
        }
        #region 登录
        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dSkinUserName.Text))
            {
                dSkinLabel1.Top = 38;
                dSkinLabel1.AutoSize = true;
                dSkinLabel1.Text = "用户名不能为空！";
                dSkinLabel1.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(dSkinUserPwd.Text))
            {
                dSkinLabel1.Top = 88;
                dSkinLabel1.AutoSize = true;
                dSkinLabel1.Text = "密码不能为空！";
                dSkinLabel1.Visible = true;
                return;
            }
          

            //Model.UserTable mi = new Model.UserTable()
            //{
            //    UserName = dSkinUserName.Text,
            //    UserPwd = dSkinUserPwd.Text,
            //    Pow_PowerID = 1
            //}; user.Add(mi);

            Model.UserTable mi = new Model.UserTable();
            mi.UserName = dSkinUserName.Text;
            mi.UserPwd = dSkinUserPwd.Text;
            //if (user.LoginUser(mi))
            //{
            //    //登录成功，打开主窗体
            //    //MainForm mainForm = new MainForm();
            //    //mainForm.Tag = mi.Pow_PowerID;
            //    //mainForm.Show();
            //    //this.Visible = false;

            //    dSkinButton1.Enabled = dSkinPanel1.Enabled = dSkinPanel3.Enabled = false;
            //    dSkinButton1.Text = "登录中...";

            //    new Thread(() =>
            //    {
            //        Thread.Sleep(2000);
            //        this.SafeInvoke(() =>
            //        {
            //            this.DialogResult = DialogResult.OK;
            //        });
            //    })
            //    { IsBackground = true, Name = "登录" }.Start();
            //}
            //else
            //{
            //    dSkinLabel1.Top = 18;
            //    dSkinLabel1.AutoSize = true;
            //    dSkinLabel1.Text = "用户名或密码错误！";
            //    dSkinLabel1.Visible = true;
            //    return;
            //}

        }

        #endregion
        /// <summary>
        /// 委托到主线程操作
        /// </summary>
        /// <param name="action"></param>
        public void SafeInvoke(Action action)
        {
            if (!this.IsDisposed && this.Created)
            {
                this.Invoke(action);
            }
        }

        private void dSkinTextBox1_TextChanged(object sender, EventArgs e)
        {
            dSkinLabel1.Visible = false;
        }
    }
}
