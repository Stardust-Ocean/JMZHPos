﻿using DSkin.Forms;
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
    public partial class MemberAdd : DSkin.Forms.DSkinForm
    {
        public MemberAdd()
        {
            InitializeComponent();
            this.CaptionBackColors = new Color[] { MainForm.ChangeColor(MainForm.SkinColor, -20) };
            MainForm.SkinColorChanged += MainForm_SkinColorChanged;


            MemberLevelBLL bll = new MemberLevelBLL();
            Me_Item.DataSource = bll.GetAllList().Tables[0];
            Me_Item.DisplayMember = "MemberLivel";
            Me_Item.ValueMember = "LivelId";


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
            MemberBLL bll = new MemberBLL();
            Model.Member comdodel = new Model.Member();
            comdodel.Me_Number = Me_Number.Text;
            comdodel.Me_Password = Me_Password.Text;
            comdodel.Me_Item = Me_Item.Text;
            comdodel.Me_Name = Me_Name.Text; ;
            comdodel.Me_Tel = Me_Tel.Text;
            comdodel.Me_Birthday = DateTime.Parse(Me_Birthday.Text);
            comdodel.Me_adress = Me_adress.Text;
            comdodel.Me_NewDatetime = DateTime.Today;
            comdodel.Me_EffectiveTime = int.Parse(Me_EffectiveTime.Text);

            comdodel.Me_ExpirationTIme = System.DateTime.Today.AddDays(double.Parse(Me_EffectiveTime.Text));
            comdodel.Me_integral = decimal.Parse(Me_integral.Text);
            comdodel.Me_balance = decimal.Parse(Me_balance.Text);
            comdodel.Me_Remark = Me_Remark.Text;

            if (bll.Add(comdodel))
            {
                DSkinMessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }


        private void Me_integral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
                else if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                {
                    if (((TextBox)sender).Text.Trim().Substring(((TextBox)sender).Text.Trim().IndexOf('.') + 1).Length >= 4)
                        e.Handled = true;
                }
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void MemberAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
