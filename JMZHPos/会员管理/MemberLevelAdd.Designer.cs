namespace JMZHPos.Commodity.会员管理
{
    partial class MemberLevelAdd
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
            DSkin.Controls.BlendColor blendColor2 = new DSkin.Controls.BlendColor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLevelAdd));
            this.dSkinLinearGradientBrush1 = new DSkin.Controls.DSkinLinearGradientBrush();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.deleteBtn = new DSkin.Controls.DSkinButton();
            this.dSkinGroupBox1 = new DSkin.Controls.DSkinGroupBox();
            this.Me_Part = new DSkin.Controls.DSkinCheckBox();
            this.Me_Num = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.Me_Discount = new DSkin.Controls.DSkinTextBox();
            this.MemberLivel = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinPanel1.SuspendLayout();
            this.dSkinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSkinLinearGradientBrush1
            // 
            blendColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            blendColor2.Position = 1F;
            this.dSkinLinearGradientBrush1.Colors.AddRange(new DSkin.Controls.BlendColor[] {
            blendColor2});
            this.dSkinLinearGradientBrush1.GammaCorrection = false;
            this.dSkinLinearGradientBrush1.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Controls.Add(this.deleteBtn);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dSkinPanel1.Location = new System.Drawing.Point(4, 267);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(452, 69);
            this.dSkinPanel1.TabIndex = 5;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.AdaptImage = true;
            this.deleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.deleteBtn.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.deleteBtn.ButtonBorderWidth = 1;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverColor = System.Drawing.Color.Empty;
            this.deleteBtn.HoverImage = null;
            this.deleteBtn.Location = new System.Drawing.Point(160, 17);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NormalImage = null;
            this.deleteBtn.PressColor = System.Drawing.Color.Empty;
            this.deleteBtn.PressedImage = null;
            this.deleteBtn.Radius = 5;
            this.deleteBtn.ShowButtonBorder = true;
            this.deleteBtn.Size = new System.Drawing.Size(108, 32);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.TextPadding = 0;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dSkinGroupBox1
            // 
            this.dSkinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinGroupBox1.Controls.Add(this.Me_Part);
            this.dSkinGroupBox1.Controls.Add(this.Me_Num);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel5);
            this.dSkinGroupBox1.Controls.Add(this.Me_Discount);
            this.dSkinGroupBox1.Controls.Add(this.MemberLivel);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel4);
            this.dSkinGroupBox1.Controls.Add(this.dSkinLabel1);
            this.dSkinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dSkinGroupBox1.Location = new System.Drawing.Point(4, 44);
            this.dSkinGroupBox1.Name = "dSkinGroupBox1";
            this.dSkinGroupBox1.Radius = 20;
            this.dSkinGroupBox1.RightBottom = null;
            this.dSkinGroupBox1.Size = new System.Drawing.Size(452, 222);
            this.dSkinGroupBox1.TabIndex = 6;
            this.dSkinGroupBox1.Text = "基本信息";
            // 
            // Me_Part
            // 
            this.Me_Part.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Me_Part.Checked = false;
            this.Me_Part.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.Me_Part.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.Me_Part.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.Me_Part.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.Me_Part.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.Me_Part.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.Me_Part.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.Me_Part.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.Me_Part.CheckRectWidth = 14;
            this.Me_Part.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.Me_Part.Font = new System.Drawing.Font("宋体", 15F);
            this.Me_Part.InnerPaddingWidth = 2;
            this.Me_Part.InnerRectInflate = 3;
            this.Me_Part.Location = new System.Drawing.Point(151, 188);
            this.Me_Part.Name = "Me_Part";
            this.Me_Part.Size = new System.Drawing.Size(152, 29);
            this.Me_Part.SpaceBetweenCheckMarkAndText = 3;
            this.Me_Part.TabIndex = 11;
            this.Me_Part.Text = "是否参与积分";
            this.Me_Part.TextColorDisabled = System.Drawing.Color.Gray;
            this.Me_Part.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Me_Num
            // 
            this.Me_Num.BitmapCache = false;
            this.Me_Num.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Me_Num.Location = new System.Drawing.Point(151, 141);
            this.Me_Num.Name = "Me_Num";
            this.Me_Num.PasswordChar = '*';
            this.Me_Num.Size = new System.Drawing.Size(240, 30);
            this.Me_Num.TabIndex = 10;
            this.Me_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Me_Num.TransparencyKey = System.Drawing.Color.Empty;
            this.Me_Num.WaterFont = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Me_Num.WaterText = "为0则不参与积分";
            this.Me_Num.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.Me_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // dSkinLabel5
            // 
            this.dSkinLabel5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel5.Location = new System.Drawing.Point(36, 144);
            this.dSkinLabel5.Name = "dSkinLabel5";
            this.dSkinLabel5.Size = new System.Drawing.Size(94, 27);
            this.dSkinLabel5.TabIndex = 9;
            this.dSkinLabel5.Text = "升级积分";
            // 
            // Me_Discount
            // 
            this.Me_Discount.BitmapCache = false;
            this.Me_Discount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Me_Discount.Location = new System.Drawing.Point(151, 91);
            this.Me_Discount.Name = "Me_Discount";
            this.Me_Discount.PasswordChar = '*';
            this.Me_Discount.Size = new System.Drawing.Size(240, 30);
            this.Me_Discount.TabIndex = 6;
            this.Me_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Me_Discount.TransparencyKey = System.Drawing.Color.Empty;
            this.Me_Discount.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Me_Discount.WaterText = "";
            this.Me_Discount.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.Me_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // MemberLivel
            // 
            this.MemberLivel.BitmapCache = false;
            this.MemberLivel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MemberLivel.Location = new System.Drawing.Point(151, 40);
            this.MemberLivel.Name = "MemberLivel";
            this.MemberLivel.Size = new System.Drawing.Size(240, 30);
            this.MemberLivel.TabIndex = 4;
            this.MemberLivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MemberLivel.TransparencyKey = System.Drawing.Color.Empty;
            this.MemberLivel.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MemberLivel.WaterText = "";
            this.MemberLivel.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel4.Location = new System.Drawing.Point(36, 94);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(51, 27);
            this.dSkinLabel4.TabIndex = 3;
            this.dSkinLabel4.Text = "折扣";
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.Location = new System.Drawing.Point(36, 43);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(94, 27);
            this.dSkinLabel1.TabIndex = 0;
            this.dSkinLabel1.Text = "会员等级";
            // 
            // MemberLevelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))))};
            this.CaptionCenter = true;
            this.CaptionColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CaptionHeight = 40;
            this.CaptionOffset = new System.Drawing.Point(10, 3);
            this.CaptionShowMode = DSkin.TextShowModes.Ordinary;
            this.ClientSize = new System.Drawing.Size(460, 340);
            this.CloseBox.NormalColor = System.Drawing.Color.White;
            this.Controls.Add(this.dSkinGroupBox1);
            this.Controls.Add(this.dSkinPanel1);
            this.DragChangeBackImage = false;
            this.DrawIcon = false;
            this.EnableAnimation = false;
            this.IconRectangle = new System.Drawing.Rectangle(8, 10, 18, 18);
            this.MaxBox.NormalColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinBox.NormalColor = System.Drawing.Color.White;
            this.MinimizeBox = false;
            this.Name = "MemberLevelAdd";
            this.NormalBox.NormalColor = System.Drawing.Color.White;
            this.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.ShowIcon = false;
            this.ShowShadow = true;
            this.SystemButtonsOffset = new System.Drawing.Point(3, 3);
            this.Text = "新增会员等级";
            this.dSkinPanel1.ResumeLayout(false);
            this.dSkinGroupBox1.ResumeLayout(false);
            this.dSkinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DSkin.Controls.DSkinLinearGradientBrush dSkinLinearGradientBrush1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinButton deleteBtn;
        private DSkin.Controls.DSkinGroupBox dSkinGroupBox1;
        private DSkin.Controls.DSkinCheckBox Me_Part;
        private DSkin.Controls.DSkinTextBox Me_Num;
        private DSkin.Controls.DSkinLabel dSkinLabel5;
        private DSkin.Controls.DSkinTextBox Me_Discount;
        private DSkin.Controls.DSkinTextBox MemberLivel;
        private DSkin.Controls.DSkinLabel dSkinLabel4;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
    }
}