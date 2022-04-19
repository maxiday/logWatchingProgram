namespace logWatchingProgram
{
    partial class 로그모니터링메인뷰
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(로그모니터링메인뷰));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnHighlighting = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전부지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about로모ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.강조ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.콘텐츠뷰어 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.콘텐츠뷰어.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.지우기ToolStripMenuItem,
            this.전부지우기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.불러오기ToolStripMenuItem,
            this.저장하기ToolStripMenuItem,
            this.강조ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about로모ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnHighlighting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1272, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 36);
            this.btnOpen.Text = "열기";
            // 
            // btnHighlighting
            // 
            this.btnHighlighting.Image = ((System.Drawing.Image)(resources.GetObject("btnHighlighting.Image")));
            this.btnHighlighting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHighlighting.Name = "btnHighlighting";
            this.btnHighlighting.Size = new System.Drawing.Size(98, 36);
            this.btnHighlighting.Text = "강조";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(436, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(836, 35);
            this.textBox1.TabIndex = 2;
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // 지우기ToolStripMenuItem
            // 
            this.지우기ToolStripMenuItem.Name = "지우기ToolStripMenuItem";
            this.지우기ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.지우기ToolStripMenuItem.Text = "지우기";
            // 
            // 전부지우기ToolStripMenuItem
            // 
            this.전부지우기ToolStripMenuItem.Name = "전부지우기ToolStripMenuItem";
            this.전부지우기ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.전부지우기ToolStripMenuItem.Text = "전부 지우기";
            // 
            // about로모ToolStripMenuItem
            // 
            this.about로모ToolStripMenuItem.Name = "about로모ToolStripMenuItem";
            this.about로모ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.about로모ToolStripMenuItem.Text = "About 로모";
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            // 
            // 강조ToolStripMenuItem
            // 
            this.강조ToolStripMenuItem.Name = "강조ToolStripMenuItem";
            this.강조ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.강조ToolStripMenuItem.Text = "강조";
            // 
            // 콘텐츠뷰어
            // 
            this.콘텐츠뷰어.Controls.Add(this.tabPageHome);
            this.콘텐츠뷰어.Dock = System.Windows.Forms.DockStyle.Fill;
            this.콘텐츠뷰어.Location = new System.Drawing.Point(0, 82);
            this.콘텐츠뷰어.Name = "콘텐츠뷰어";
            this.콘텐츠뷰어.SelectedIndex = 0;
            this.콘텐츠뷰어.Size = new System.Drawing.Size(1272, 753);
            this.콘텐츠뷰어.TabIndex = 3;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Location = new System.Drawing.Point(8, 39);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1256, 706);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "홈화면";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // 로그모니터링메인뷰
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 835);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.콘텐츠뷰어);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "로그모니터링메인뷰";
            this.Text = "로모-로그모니터링프로그램";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.콘텐츠뷰어.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnHighlighting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전부지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 강조ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about로모ToolStripMenuItem;
        private System.Windows.Forms.TabControl 콘텐츠뷰어;
        private System.Windows.Forms.TabPage tabPageHome;
    }
}

