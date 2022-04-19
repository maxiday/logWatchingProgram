namespace logWatchingProgram
{
    partial class 모니터링화면
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
            this.모니터링파일 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.모니터링파일)).BeginInit();
            this.SuspendLayout();
            // 
            // 모니터링파일
            // 
            this.모니터링파일.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.모니터링파일.Dock = System.Windows.Forms.DockStyle.Fill;
            this.모니터링파일.Location = new System.Drawing.Point(0, 0);
            this.모니터링파일.Name = "모니터링파일";
            this.모니터링파일.RowHeadersWidth = 82;
            this.모니터링파일.RowTemplate.Height = 37;
            this.모니터링파일.Size = new System.Drawing.Size(835, 474);
            this.모니터링파일.TabIndex = 0;
            // 
            // 모니터링화면
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 474);
            this.Controls.Add(this.모니터링파일);
            this.Name = "모니터링화면";
            this.Text = "모니터링화면";
            ((System.ComponentModel.ISupportInitialize)(this.모니터링파일)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView 모니터링파일;
    }
}