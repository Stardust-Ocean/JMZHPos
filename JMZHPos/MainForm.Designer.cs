namespace JMZHPos
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DSkin.Forms.SystemButton systemButton1 = new DSkin.Forms.SystemButton();
            this.dSkinTreeView1 = new DSkin.Controls.DSkinTreeView();
            this.dSkinTabControl1 = new DSkin.Controls.DSkinTabControl();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.dSkinTabBar1 = new DSkin.Controls.DSkinTabBar();
            this.dSkinIcon2 = new DSkin.Controls.DSkinIcon();
            this.dSkinIcon1 = new DSkin.Controls.DSkinIcon();
            this.dSkinPanel2 = new DSkin.Controls.DSkinPanel();
            this.dSkinListBox1 = new DSkin.Controls.DSkinListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinTreeView1)).BeginInit();
            this.dSkinPanel1.SuspendLayout();
            this.dSkinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSkinTreeView1
            // 
            this.dSkinTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            resources.ApplyResources(this.dSkinTreeView1, "dSkinTreeView1");
            this.dSkinTreeView1.ItemBackColorHover = System.Drawing.Color.Transparent;
            this.dSkinTreeView1.ItemBorderColorHover = System.Drawing.Color.Transparent;
            this.dSkinTreeView1.ItemSelectedBackColor = System.Drawing.Color.Transparent;
            this.dSkinTreeView1.ItemSelectedBorderColor = System.Drawing.Color.Transparent;
            this.dSkinTreeView1.Name = "dSkinTreeView1";
            this.dSkinTreeView1.NodeOffset = 0;
            this.dSkinTreeView1.ItemCreated += new System.EventHandler<DSkin.Controls.DSkinTreeViewEventArgs>(this.dSkinTreeView1_ItemCreated);
            this.dSkinTreeView1.NodeClick += new System.EventHandler<DSkin.Controls.DSkinTreeViewNodeClickEventArgs>(this.dSkinTreeView1_NodeClick);
            // 
            // dSkinTabControl1
            // 
            resources.ApplyResources(this.dSkinTabControl1, "dSkinTabControl1");
            this.dSkinTabControl1.BitmapCache = false;
            this.dSkinTabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.ItemBackgroundImage = null;
            this.dSkinTabControl1.ItemBackgroundImageHover = null;
            this.dSkinTabControl1.ItemBackgroundImageSelected = null;
            this.dSkinTabControl1.Multiline = true;
            this.dSkinTabControl1.Name = "dSkinTabControl1";
            this.dSkinTabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.dSkinTabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.SelectedBottomLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dSkinTabControl1.SelectedBottomLineHeight = ((uint)(2u));
            this.dSkinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dSkinTabControl1.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.dSkinTabControl1.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.dSkinTabControl1.UpdownBtnBackColor = System.Drawing.Color.White;
            this.dSkinTabControl1.UpdownBtnBorderColor = System.Drawing.Color.Black;
            this.dSkinTabControl1.SelectedIndexChanged += new System.EventHandler(this.dSkinTabControl1_SelectedIndexChanged);
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dSkinPanel1.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dSkinPanel1.Controls.Add(this.dSkinTabBar1);
            this.dSkinPanel1.Controls.Add(this.dSkinIcon2);
            this.dSkinPanel1.Controls.Add(this.dSkinIcon1);
            resources.ApplyResources(this.dSkinPanel1, "dSkinPanel1");
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            // 
            // dSkinTabBar1
            // 
            resources.ApplyResources(this.dSkinTabBar1, "dSkinTabBar1");
            this.dSkinTabBar1.EnabledLayoutContent = true;
            this.dSkinTabBar1.Name = "dSkinTabBar1";
            this.dSkinTabBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.dSkinTabBar1.TabControl = this.dSkinTabControl1;
            this.dSkinTabBar1.AcceptTask += new System.EventHandler<DSkin.DirectUI.AcceptTaskEventArgs>(this.dSkinTabBar1_AcceptTask);
            // 
            // dSkinIcon2
            // 
            resources.ApplyResources(this.dSkinIcon2, "dSkinIcon2");
            this.dSkinIcon2.ForeColor = System.Drawing.Color.Gray;
            this.dSkinIcon2.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.dSkinIcon2.Icon = DSkin.Common.FontAwesomeChars.icon_angle_double_right;
            this.dSkinIcon2.IconSize = 25F;
            this.dSkinIcon2.Name = "dSkinIcon2";
            this.dSkinIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinIcon2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinIcon2_MouseDown);
            // 
            // dSkinIcon1
            // 
            resources.ApplyResources(this.dSkinIcon1, "dSkinIcon1");
            this.dSkinIcon1.ForeColor = System.Drawing.Color.Gray;
            this.dSkinIcon1.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.dSkinIcon1.Icon = DSkin.Common.FontAwesomeChars.icon_angle_double_left;
            this.dSkinIcon1.IconSize = 25F;
            this.dSkinIcon1.Name = "dSkinIcon1";
            this.dSkinIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinIcon1_MouseDown);
            // 
            // dSkinPanel2
            // 
            resources.ApplyResources(this.dSkinPanel2, "dSkinPanel2");
            this.dSkinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel2.BackgroundImage = global::JMZHPos.Properties.Resources.colorPanel;
            this.dSkinPanel2.Controls.Add(this.dSkinListBox1);
            this.dSkinPanel2.Name = "dSkinPanel2";
            this.dSkinPanel2.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel2.RightBottom")));
            // 
            // dSkinListBox1
            // 
            this.dSkinListBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinListBox1.EnabledFloat = true;
            resources.ApplyResources(this.dSkinListBox1, "dSkinListBox1");
            this.dSkinListBox1.Name = "dSkinListBox1";
            this.dSkinListBox1.ScrollBarWidth = 12;
            this.dSkinListBox1.Ulmul = true;
            this.dSkinListBox1.Value = 0D;
            this.dSkinListBox1.ItemClick += new System.EventHandler<DSkin.Controls.ItemClickEventArgs>(this.dSkinListBox1_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.CaptionBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))))};
            this.CaptionColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CaptionHeight = 60;
            this.CaptionOffset = new System.Drawing.Point(40, 10);
            this.CaptionShowMode = DSkin.TextShowModes.Ordinary;
            resources.ApplyResources(this, "$this");
            this.CloseBox.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dSkinPanel2);
            this.Controls.Add(this.dSkinTabControl1);
            this.Controls.Add(this.dSkinPanel1);
            this.Controls.Add(this.dSkinTreeView1);
            this.DragChangeBackImage = false;
            this.EnableAnimation = false;
            this.IconRectangle = new System.Drawing.Rectangle(15, 10, 36, 36);
            this.MaxBox.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinBox.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "MainForm";
            this.NormalBox.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.ShowShadow = true;
            systemButton1.Image = global::JMZHPos.Properties.Resources.skin;
            this.SystemButtons.Add(systemButton1);
            this.SystemButtonsOffset = new System.Drawing.Point(10, 10);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SystemButtonMouseClick += new System.EventHandler<DSkin.Forms.SystemButtonMouseClickEventArgs>(this.MainForm_SystemButtonMouseClick);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSkinTreeView1)).EndInit();
            this.dSkinPanel1.ResumeLayout(false);
            this.dSkinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinTreeView dSkinTreeView1;
        private DSkin.Controls.DSkinTabControl dSkinTabControl1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinTabBar dSkinTabBar1;
        private DSkin.Controls.DSkinIcon dSkinIcon2;
        private DSkin.Controls.DSkinIcon dSkinIcon1;
        private DSkin.Controls.DSkinPanel dSkinPanel2;
        private DSkin.Controls.DSkinListBox dSkinListBox1;
    }
}