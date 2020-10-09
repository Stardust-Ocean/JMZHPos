using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JMZHPos.Pages
{
    public partial class 图片列表 : DSkin.Controls.DSkinUserControl
    {
        public 图片列表()
        {
            InitializeComponent();
        }

        private void 图片列表_Load(object sender, EventArgs e)
        {
            Image image = Properties.Resources.user;
            for (int i = 0; i < 100; i++)
            {
                dSkinListBox1.Items.Add(new ImageTemplate { Text = "test测试", Image = image });
            }
        }

        private void dSkinListBox1_ItemClick(object sender, DSkin.Controls.ItemClickEventArgs e)
        {
            DSkin.Controls.PictureBrowseForm pictureBrowseForm = new DSkin.Controls.PictureBrowseForm();
            pictureBrowseForm.Image = (e.Control as ImageTemplate).Image;
            pictureBrowseForm.Show();
        }
    }
}
