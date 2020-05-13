namespace SamCheng.PinyinHelper
{
    partial class frmMain
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
            this.btnZhuyin = new System.Windows.Forms.Button();
            this.webViewContent = new System.Windows.Forms.WebBrowser();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZhuyin
            // 
            this.btnZhuyin.Location = new System.Drawing.Point(188, 36);
            this.btnZhuyin.Name = "btnZhuyin";
            this.btnZhuyin.Size = new System.Drawing.Size(63, 152);
            this.btnZhuyin.TabIndex = 2;
            this.btnZhuyin.Text = "注入灵魂";
            this.btnZhuyin.UseVisualStyleBackColor = true;
            this.btnZhuyin.Click += new System.EventHandler(this.btnZhuyin_Click);
            // 
            // webViewContent
            // 
            this.webViewContent.Location = new System.Drawing.Point(257, 12);
            this.webViewContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webViewContent.Name = "webViewContent";
            this.webViewContent.Size = new System.Drawing.Size(314, 443);
            this.webViewContent.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(14, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(168, 21);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "竹枝词";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "标题：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(11, 65);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 12);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "作者：";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(12, 81);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(170, 21);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.Text = "唐 刘禹锡";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(11, 111);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(41, 12);
            this.lblContent.TabIndex = 10;
            this.lblContent.Text = "正文：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 127);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(170, 307);
            this.txtContent.TabIndex = 9;
            this.txtContent.Text = "千里莺啼绿映红，";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ver 2.0 2020/04/24";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.webViewContent);
            this.Controls.Add(this.btnZhuyin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pinyin Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZhuyin;
        private System.Windows.Forms.WebBrowser webViewContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
    }
}

