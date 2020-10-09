namespace JMZHPos.Pages
{
    partial class 图片列表
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dSkinListBox1 = new DSkin.Controls.DSkinListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSkinListBox1
            // 
            this.dSkinListBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinListBox1.EnabledFloat = true;
            this.dSkinListBox1.Location = new System.Drawing.Point(0, 0);
            this.dSkinListBox1.Name = "dSkinListBox1";
            this.dSkinListBox1.ScrollBarWidth = 12;
            this.dSkinListBox1.Size = new System.Drawing.Size(655, 539);
            this.dSkinListBox1.TabIndex = 0;
            this.dSkinListBox1.Text = "dSkinListBox1";
            this.dSkinListBox1.Ulmul = true;
            this.dSkinListBox1.Value = 0D;
            this.dSkinListBox1.ItemClick += new System.EventHandler<DSkin.Controls.ItemClickEventArgs>(this.dSkinListBox1_ItemClick);
            // 
            // 图片列表
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dSkinListBox1);
            this.Name = "图片列表";
            this.Size = new System.Drawing.Size(655, 539);
            this.Load += new System.EventHandler(this.图片列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinListBox dSkinListBox1;
    }
}
