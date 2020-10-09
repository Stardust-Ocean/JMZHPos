using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSkin.Controls;
using DSkin.Common;
using System.Linq;

namespace JMZHPos
{
    public partial class MainForm : DSkin.Forms.DSkinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dSkinTreeView1.HorizontalScrollBar.Height = 0;
            dSkinTreeView1.HorizontalScrollBar.BackColor = dSkinTreeView1.HorizontalScrollBar.ScrollBarNormalColor = dSkinTreeView1.HorizontalScrollBar.ArrowNormalColor = Color.Transparent;
            dSkinTreeView1.InnerScrollBar.BackColor = Color.Transparent;
            dSkinTreeView1.InnerScrollBar.Width = 5;
            dSkinTabControl1.ItemSize = new Size(1, 1);

            #region 换肤颜色
            var colors = new Color[] {
                Color.FromArgb(56, 60, 72),
                Color.FromArgb(0, 190, 172),
                Color.FromArgb(76, 93, 111),
                Color.FromArgb(140, 100, 80),
                Color.FromArgb(172, 146, 232),
                Color.FromArgb(93, 156, 234),
                Color.FromArgb(103, 58, 183),
                Color.FromArgb(0, 188, 212),
                Color.FromArgb(80, 126, 164),
                Color.FromArgb(79, 192, 232),
                Color.FromArgb(0, 149, 135),
                Color.FromArgb(44, 90, 188)
            };
            foreach (var item in colors)
            {
                dSkinListBox1.Items.Add(new DSkin.DirectUI.DuiBaseControl { Width = 33, Height = 31, BackColor = item, Margin = new Padding(2) });
            }
            #endregion
            #region  商品管理
            var node1 = AddMenu(FontAwesomeChars.icon_arrow_circle_up, "商品管理");
            AddChildMenu(node1, FontAwesomeChars.icon_bookmark_o, "查看数据");
            AddChildMenu(node1, FontAwesomeChars.icon_bookmark_o, "UserControl1");

            AddChildMenu(node1, FontAwesomeChars.icon_bookmark_o, "供货商管理");
            AddChildMenu(node1, FontAwesomeChars.icon_bookmark_o, "会员浏览");
            
            AddChildMenu(node1, FontAwesomeChars.icon_bookmark_o, "商品浏览");
            AddChildMenu(node1, FontAwesomeChars.icon_bookmark_o, "会员等级");
            #endregion
            //for (int i = 0; i < 10; i++)
            //{
            //    var node = AddMenu(FontAwesomeChars.icon_arrow_circle_up, "菜单" + i);
            //    for (int j = 0; j < 10; j++)
            //    {
            //        AddChildMenu(node, FontAwesomeChars.icon_bookmark_o, "子菜单" + j);
            //    }
            //}
        }
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="icon"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        DSkinTreeViewNode AddMenu(FontAwesomeChars icon, string text)
        {
            var node = new DSkinTreeViewNode { Template = typeof(MenuTemplate), Text = text, Tag = icon };
            dSkinTreeView1.Nodes.Add(node);
            return node;
        }
        /// <summary>
        /// 添加子菜单，名称和页面类名一样
        /// </summary>
        /// <param name="node"></param>
        /// <param name="icon"></param>
        /// <param name="text"></param>
        void AddChildMenu(DSkinTreeViewNode node, FontAwesomeChars icon, string text)
        {
            node.Nodes.Add(new DSkinTreeViewNode { Template = typeof(ChildMenuTemplate), Text = text, Tag = icon });
        }

        private void dSkinTreeView1_NodeClick(object sender, DSkinTreeViewNodeClickEventArgs e)
        {
            if (e.Item.Template == typeof(ChildMenuTemplate))
            {
                if (dSkinTabBar1.Items.Any(a => a.Text == e.Item.Text))
                {
                    dSkinTabControl1.SelectedIndex = dSkinTabBar1.Items.FindIndex(a => a.Text == e.Item.Text);
                }
                else
                {
                    dSkinTabBar1.Items.Add(new TabItemTemplate { Icon = (FontAwesomeChars)e.Item.Tag, Text = e.Item.Text });
                    var page = new DSkinTabPage { BackColor = Color.White, Text = e.Item.Text };
                    var type = Type.GetType("JMZHPos.Pages." + e.Item.Text);
                    if (type != null)//通过页面名字找到页面类型，实例化添加到选项卡里
                    {
                        var control = (Control)Activator.CreateInstance(type);
                        control.Dock = DockStyle.Fill;
                        page.Controls.Add(control);
                    }
                    dSkinTabControl1.TabPages.Add(page);
                    dSkinTabControl1.SelectedTab = page;
                }

                e.Item.Item.Controls[0].IsSelected = true;
            }
        }

        private void dSkinIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            dSkinTabBar1.Value -= 0.15;
        }

        private void dSkinIcon2_MouseDown(object sender, MouseEventArgs e)
        {
            dSkinTabBar1.Value += 0.15;
        }

        private void dSkinTabBar1_AcceptTask(object sender, DSkin.DirectUI.AcceptTaskEventArgs e)
        {
            if (e.TaskName == "移除选项卡")
            {
                var index = dSkinTabBar1.Items.IndexOf(e.Source);
                dSkinTabBar1.Items.Remove(e.Source);
                dSkinTabControl1.TabPages.RemoveAt(index);
            }
        }

        private void dSkinTreeView1_ItemCreated(object sender, DSkinTreeViewEventArgs e)
        {
            e.Item.Item.Margin = new Padding();
        }

        private void dSkinTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in dSkinTreeView1.AllNodes.Where(a => a.Template == typeof(ChildMenuTemplate)))
            {
                if (dSkinTabControl1.SelectedTab != null && dSkinTabControl1.SelectedTab.Text == item.Text)
                {
                    item.Selected = true;
                }
                else
                {
                    item.Selected = false;
                }
            }
        }
        /// <summary>
        /// 皮肤颜色改变事件
        /// </summary>
        public static event Action SkinColorChanged;
        static Color skinColor = Color.FromArgb(93, 156, 234);
        /// <summary>
        /// 当前皮肤颜色
        /// </summary>
        public static Color SkinColor
        {
            get { return skinColor; }
        }

        private void dSkinListBox1_ItemClick(object sender, ItemClickEventArgs e)
        {
            skinColor = e.Control.BackColor;
            if (SkinColorChanged != null)
            {
                SkinColorChanged();
            }
            dSkinTreeView1.BackColor = e.Control.BackColor;
            this.CaptionBackColors = new Color[] { ChangeColor(e.Control.BackColor, -20) };
        }

        public static Color ChangeColor(Color color, int change)
        {
            var r = color.R + change > 255 ? 255 : color.R + change;
            var g = color.G + change > 255 ? 255 : color.G + change;
            var b = color.B + change > 255 ? 255 : color.B + change;
            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;
            return Color.FromArgb(color.A, r, g, b);
        }

        private void MainForm_SystemButtonMouseClick(object sender, DSkin.Forms.SystemButtonMouseClickEventArgs e)
        {
            dSkinPanel2.Visible = !dSkinPanel2.Visible;
        }
    }
}
