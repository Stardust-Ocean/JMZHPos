using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSkin.DirectUI;

namespace JMZHPos
{
    public partial class MessageBoxForm : DSkin.Forms.DSkinForm
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Opacity = 0;
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            int top = (rect.Height - Height) / 2;
            Left = (rect.Width - Width) / 2;
            this.DoEffect(() =>
            {
                if (Top < top - 4)
                {
                    Opacity = 1 - 1.0 * (top - Top) / (top);
                    Top += ((top - Top) / 5);
                    return true;
                }
                Top = top;
                return false;
            });
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.C)
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(Text + "\r\n" + dSkinLabel1.Text);
                }
                catch (Exception E)
                {
                    Console.WriteLine(E.Message);
                }
            }
        }

        /// <summary>
        /// 显示弹窗
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="content"></param>
        /// <param name="messageBoxType"></param>
        /// <returns></returns>
        public static DialogResult Show(string caption, string content, MessageBoxTypes messageBoxType)
        {
            using (MessageBoxForm ms = new MessageBoxForm())
            {
                ms.Text = caption;
                ms.dSkinLabel1.Text = content;
                switch (messageBoxType)
                {
                    case MessageBoxTypes.YesNo:
                        ms.dSkinButton1.Text = "是";
                        ms.dSkinButton1.DialogResult = DialogResult.Yes;
                        ms.dSkinButton4.Text = "否";
                        ms.dSkinButton4.DialogResult = DialogResult.No;
                        ms.dSkinButton2.Visible = false;
                        break;
                    case MessageBoxTypes.OkCancel:
                        ms.dSkinButton2.Visible = false;
                        break;
                    default:
                        ms.dSkinButton1.Visible = false;
                        ms.dSkinButton4.Visible = false;
                        break;
                }
                return ms.ShowDialog();
            }
        }
    }

    public enum MessageBoxTypes
    {
        Ok,
        YesNo,
        OkCancel
    }
}
