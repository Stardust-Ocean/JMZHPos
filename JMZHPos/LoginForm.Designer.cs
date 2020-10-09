namespace JMZHPos
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.background = new DSkin.Controls.DSkinPanel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinCheckBox2 = new DSkin.Controls.DSkinCheckBox();
            this.dSkinCheckBox1 = new DSkin.Controls.DSkinCheckBox();
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.dSkinIcon1 = new DSkin.Controls.DSkinIcon();
            this.dSkinPanel3 = new DSkin.Controls.DSkinPanel();
            this.dSkinUserPwd = new DSkin.Controls.DSkinTextBox();
            this.dSkinPictureBox3 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.dSkinUserName = new DSkin.Controls.DSkinTextBox();
            this.dSkinPictureBox2 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinPictureBox1 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinPanel2 = new DSkin.Controls.DSkinPanel();
            this.dSkinPictureBox4 = new DSkin.Controls.DSkinPictureBox();
            this.background.SuspendLayout();
            this.dSkinPanel3.SuspendLayout();
            this.dSkinPanel1.SuspendLayout();
            this.dSkinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BackgroundImage = global::JMZHPos.Properties.Resources.loginBackImage;
            this.background.Controls.Add(this.dSkinLabel1);
            this.background.Controls.Add(this.dSkinCheckBox2);
            this.background.Controls.Add(this.dSkinCheckBox1);
            this.background.Controls.Add(this.dSkinButton1);
            this.background.Controls.Add(this.dSkinIcon1);
            this.background.Controls.Add(this.dSkinPanel3);
            this.background.Controls.Add(this.dSkinPanel1);
            this.background.Location = new System.Drawing.Point(1, 140);
            this.background.Name = "background";
            this.background.RightBottom = ((System.Drawing.Image)(resources.GetObject("background.RightBottom")));
            this.background.Size = new System.Drawing.Size(454, 267);
            this.background.TabIndex = 0;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dSkinPanel1_MouseDown);
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.AutoSize = false;
            this.dSkinLabel1.BackgroundImage = global::JMZHPos.Properties.Resources.tip;
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinLabel1.Location = new System.Drawing.Point(122, -18);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(115, 58);
            this.dSkinLabel1.SudokuDrawBackImage = true;
            this.dSkinLabel1.SudokuPartitionWidth = new System.Windows.Forms.Padding(15, 15, 15, 25);
            this.dSkinLabel1.TabIndex = 7;
            this.dSkinLabel1.Text = "用户名不能为空";
            this.dSkinLabel1.TextInnerPadding = new System.Windows.Forms.Padding(12, 15, 12, 25);
            this.dSkinLabel1.Visible = false;
            // 
            // dSkinCheckBox2
            // 
            this.dSkinCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinCheckBox2.Checked = false;
            this.dSkinCheckBox2.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.dSkinCheckBox2.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBox2.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.dSkinCheckBox2.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.dSkinCheckBox2.CheckRectBackColorNormal = System.Drawing.Color.White;
            this.dSkinCheckBox2.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dSkinCheckBox2.CheckRectColor = System.Drawing.Color.Silver;
            this.dSkinCheckBox2.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBox2.CheckRectWidth = 14;
            this.dSkinCheckBox2.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.dSkinCheckBox2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinCheckBox2.ForeColor = System.Drawing.Color.DimGray;
            this.dSkinCheckBox2.InnerPaddingWidth = 2;
            this.dSkinCheckBox2.InnerRectInflate = 3;
            this.dSkinCheckBox2.Location = new System.Drawing.Point(295, 166);
            this.dSkinCheckBox2.Name = "dSkinCheckBox2";
            this.dSkinCheckBox2.Size = new System.Drawing.Size(79, 22);
            this.dSkinCheckBox2.SpaceBetweenCheckMarkAndText = 3;
            this.dSkinCheckBox2.TabIndex = 6;
            this.dSkinCheckBox2.Text = "记住密码";
            this.dSkinCheckBox2.TextColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dSkinCheckBox1
            // 
            this.dSkinCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dSkinCheckBox1.Checked = false;
            this.dSkinCheckBox1.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.dSkinCheckBox1.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBox1.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.dSkinCheckBox1.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.dSkinCheckBox1.CheckRectBackColorNormal = System.Drawing.Color.White;
            this.dSkinCheckBox1.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dSkinCheckBox1.CheckRectColor = System.Drawing.Color.Silver;
            this.dSkinCheckBox1.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBox1.CheckRectWidth = 14;
            this.dSkinCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.dSkinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinCheckBox1.ForeColor = System.Drawing.Color.DimGray;
            this.dSkinCheckBox1.InnerPaddingWidth = 2;
            this.dSkinCheckBox1.InnerRectInflate = 3;
            this.dSkinCheckBox1.Location = new System.Drawing.Point(81, 166);
            this.dSkinCheckBox1.Name = "dSkinCheckBox1";
            this.dSkinCheckBox1.Size = new System.Drawing.Size(79, 22);
            this.dSkinCheckBox1.SpaceBetweenCheckMarkAndText = 3;
            this.dSkinCheckBox1.TabIndex = 6;
            this.dSkinCheckBox1.Text = "自动登录";
            this.dSkinCheckBox1.TextColorDisabled = System.Drawing.Color.Gray;
            this.dSkinCheckBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.AdaptImage = true;
            this.dSkinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.dSkinButton1.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinButton1.ForeColor = System.Drawing.Color.White;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = null;
            this.dSkinButton1.Location = new System.Drawing.Point(81, 199);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = null;
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = null;
            this.dSkinButton1.Radius = 6;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(293, 40);
            this.dSkinButton1.TabIndex = 3;
            this.dSkinButton1.Text = "登录";
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            this.dSkinButton1.Click += new System.EventHandler(this.dSkinButton1_Click);
            // 
            // dSkinIcon1
            // 
            this.dSkinIcon1.AutoSize = false;
            this.dSkinIcon1.BackgroundImage = global::JMZHPos.Properties.Resources.closeBtn;
            this.dSkinIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dSkinIcon1.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;
            this.dSkinIcon1.Icon = DSkin.Common.FontAwesomeChars.icon_close;
            this.dSkinIcon1.IconSize = 23F;
            this.dSkinIcon1.Location = new System.Drawing.Point(414, -1);
            this.dSkinIcon1.Name = "dSkinIcon1";
            this.dSkinIcon1.Size = new System.Drawing.Size(38, 38);
            this.dSkinIcon1.TabIndex = 4;
            this.dSkinIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinIcon1.TextInnerPadding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.dSkinIcon1.Click += new System.EventHandler(this.dSkinIcon1_Click);
            this.dSkinIcon1.MouseEnter += new System.EventHandler(this.dSkinIcon1_MouseEnter);
            this.dSkinIcon1.MouseLeave += new System.EventHandler(this.dSkinIcon1_MouseLeave);
            // 
            // dSkinPanel3
            // 
            this.dSkinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel3.Controls.Add(this.dSkinUserPwd);
            this.dSkinPanel3.Controls.Add(this.dSkinPictureBox3);
            this.dSkinPanel3.DuiBackgroundRender.BorderColor = System.Drawing.Color.Silver;
            this.dSkinPanel3.DuiBackgroundRender.Radius = 6;
            this.dSkinPanel3.DuiBackgroundRender.RenderBorders = true;
            this.dSkinPanel3.Location = new System.Drawing.Point(81, 112);
            this.dSkinPanel3.Name = "dSkinPanel3";
            this.dSkinPanel3.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel3.RightBottom")));
            this.dSkinPanel3.Size = new System.Drawing.Size(294, 42);
            this.dSkinPanel3.TabIndex = 2;
            this.dSkinPanel3.Text = "dSkinPanel1";
            // 
            // dSkinUserPwd
            // 
            this.dSkinUserPwd.BitmapCache = false;
            this.dSkinUserPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dSkinUserPwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinUserPwd.Location = new System.Drawing.Point(54, 11);
            this.dSkinUserPwd.Name = "dSkinUserPwd";
            this.dSkinUserPwd.PasswordChar = '*';
            this.dSkinUserPwd.Size = new System.Drawing.Size(223, 20);
            this.dSkinUserPwd.TabIndex = 1;
            this.dSkinUserPwd.TransparencyKey = System.Drawing.Color.Empty;
            this.dSkinUserPwd.WaterFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinUserPwd.WaterText = "密码";
            this.dSkinUserPwd.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.dSkinUserPwd.TextChanged += new System.EventHandler(this.dSkinTextBox1_TextChanged);
            this.dSkinUserPwd.Enter += new System.EventHandler(this.dSkinTextBox1_Enter);
            this.dSkinUserPwd.Leave += new System.EventHandler(this.dSkinTextBox1_Leave);
            // 
            // dSkinPictureBox3
            // 
            this.dSkinPictureBox3.Image = global::JMZHPos.Properties.Resources.password;
            this.dSkinPictureBox3.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::JMZHPos.Properties.Resources.password))};
            this.dSkinPictureBox3.Location = new System.Drawing.Point(12, 8);
            this.dSkinPictureBox3.Name = "dSkinPictureBox3";
            this.dSkinPictureBox3.Size = new System.Drawing.Size(25, 25);
            this.dSkinPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dSkinPictureBox3.TabIndex = 0;
            this.dSkinPictureBox3.Text = "dSkinPictureBox2";
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Controls.Add(this.dSkinUserName);
            this.dSkinPanel1.Controls.Add(this.dSkinPictureBox2);
            this.dSkinPanel1.DuiBackgroundRender.BorderColor = System.Drawing.Color.Silver;
            this.dSkinPanel1.DuiBackgroundRender.Radius = 6;
            this.dSkinPanel1.DuiBackgroundRender.RenderBorders = true;
            this.dSkinPanel1.Location = new System.Drawing.Point(81, 58);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(294, 42);
            this.dSkinPanel1.TabIndex = 1;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // dSkinUserName
            // 
            this.dSkinUserName.BitmapCache = false;
            this.dSkinUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dSkinUserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinUserName.Location = new System.Drawing.Point(54, 11);
            this.dSkinUserName.Name = "dSkinUserName";
            this.dSkinUserName.Size = new System.Drawing.Size(223, 20);
            this.dSkinUserName.TabIndex = 1;
            this.dSkinUserName.TransparencyKey = System.Drawing.Color.Empty;
            this.dSkinUserName.WaterFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinUserName.WaterText = "用户名";
            this.dSkinUserName.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.dSkinUserName.TextChanged += new System.EventHandler(this.dSkinTextBox1_TextChanged);
            this.dSkinUserName.Enter += new System.EventHandler(this.dSkinTextBox1_Enter);
            this.dSkinUserName.Leave += new System.EventHandler(this.dSkinTextBox1_Leave);
            // 
            // dSkinPictureBox2
            // 
            this.dSkinPictureBox2.Image = global::JMZHPos.Properties.Resources.user;
            this.dSkinPictureBox2.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::JMZHPos.Properties.Resources.user))};
            this.dSkinPictureBox2.Location = new System.Drawing.Point(12, 8);
            this.dSkinPictureBox2.Name = "dSkinPictureBox2";
            this.dSkinPictureBox2.Size = new System.Drawing.Size(25, 25);
            this.dSkinPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dSkinPictureBox2.TabIndex = 0;
            this.dSkinPictureBox2.Text = "dSkinPictureBox2";
            // 
            // dSkinPictureBox1
            // 
            this.dSkinPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPictureBox1.DuiBackgroundRender.BorderColor = System.Drawing.Color.White;
            this.dSkinPictureBox1.DuiBackgroundRender.BorderWidth = 3;
            this.dSkinPictureBox1.DuiBackgroundRender.Radius = 86;
            this.dSkinPictureBox1.DuiBackgroundRender.RenderBorders = true;
            this.dSkinPictureBox1.Image = global::JMZHPos.Properties.Resources.用户;
            this.dSkinPictureBox1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::JMZHPos.Properties.Resources.用户))};
            this.dSkinPictureBox1.Location = new System.Drawing.Point(11, 11);
            this.dSkinPictureBox1.Name = "dSkinPictureBox1";
            this.dSkinPictureBox1.Size = new System.Drawing.Size(88, 88);
            this.dSkinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dSkinPictureBox1.TabIndex = 1;
            this.dSkinPictureBox1.Text = "dSkinPictureBox1";
            // 
            // dSkinPanel2
            // 
            this.dSkinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel2.BackgroundImage = global::JMZHPos.Properties.Resources.UserBackImage;
            this.dSkinPanel2.Controls.Add(this.dSkinPictureBox1);
            this.dSkinPanel2.Location = new System.Drawing.Point(175, 6);
            this.dSkinPanel2.Name = "dSkinPanel2";
            this.dSkinPanel2.Padding = new System.Windows.Forms.Padding(11);
            this.dSkinPanel2.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel2.RightBottom")));
            this.dSkinPanel2.Size = new System.Drawing.Size(110, 110);
            this.dSkinPanel2.TabIndex = 2;
            this.dSkinPanel2.Text = "dSkinPanel2";
            // 
            // dSkinPictureBox4
            // 
            this.dSkinPictureBox4.Image = global::JMZHPos.Properties.Resources.cao;
            this.dSkinPictureBox4.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::JMZHPos.Properties.Resources.cao))};
            this.dSkinPictureBox4.Location = new System.Drawing.Point(264, 1);
            this.dSkinPictureBox4.Name = "dSkinPictureBox4";
            this.dSkinPictureBox4.Size = new System.Drawing.Size(50, 39);
            this.dSkinPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dSkinPictureBox4.TabIndex = 3;
            this.dSkinPictureBox4.Text = "dSkinPictureBox4";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.dSkinButton1;
            this.AnimationType = DSkin.Forms.AnimationTypes.GradualCurtainEffect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.CanResize = false;
            this.CaptionShowMode = DSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(462, 489);
            this.Controls.Add(this.dSkinPictureBox4);
            this.Controls.Add(this.dSkinPanel2);
            this.Controls.Add(this.background);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.DrawIcon = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.ShowSystemButtons = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.dSkinPanel3.ResumeLayout(false);
            this.dSkinPanel3.PerformLayout();
            this.dSkinPanel1.ResumeLayout(false);
            this.dSkinPanel1.PerformLayout();
            this.dSkinPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinPanel background;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinPanel dSkinPanel2;
        private DSkin.Controls.DSkinIcon dSkinIcon1;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox2;
        private DSkin.Controls.DSkinTextBox dSkinUserName;
        private DSkin.Controls.DSkinPanel dSkinPanel3;
        private DSkin.Controls.DSkinTextBox dSkinUserPwd;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox3;
        private DSkin.Controls.DSkinButton dSkinButton1;
        private DSkin.Controls.DSkinCheckBox dSkinCheckBox1;
        private DSkin.Controls.DSkinCheckBox dSkinCheckBox2;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox4;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
    }
}

