namespace SellerCenter.Forms
{
    partial class frmTemplatePrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplatePrompt));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            socialMediaPlatformControl1 = new SellerCenter.UserControls.SocialMediaPlatformControl();
            label1 = new Label();
            label2 = new Label();
            articleTypeControl1 = new SellerCenter.UserControls.ArticleTypeControl();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 177);
            richTextBox1.MaximumSize = new Size(1920, 600);
            richTextBox1.MinimumSize = new Size(1920, 600);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1920, 600);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 135);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 1;
            button1.Text = "Lưu template";
            button1.UseVisualStyleBackColor = true;
            // 
            // socialMediaPlatformControl1
            // 
            socialMediaPlatformControl1.AutoScroll = true;
            socialMediaPlatformControl1.Location = new Point(12, 27);
            socialMediaPlatformControl1.Name = "socialMediaPlatformControl1";
            socialMediaPlatformControl1.Size = new Size(121, 102);
            socialMediaPlatformControl1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 3;
            label1.Text = "Nền tảng mạng xã hội";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 9);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Loại bài viết";
            // 
            // articleTypeControl1
            // 
            articleTypeControl1.AutoScroll = true;
            articleTypeControl1.Location = new Point(168, 27);
            articleTypeControl1.Name = "articleTypeControl1";
            articleTypeControl1.Size = new Size(82, 102);
            articleTypeControl1.TabIndex = 5;
            // 
            // frmTemplatePrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(articleTypeControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(socialMediaPlatformControl1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmTemplatePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template prompt AI";
            Load += frmTemplatePrompt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl1;
        private Label label1;
        private Label label2;
        private UserControls.ArticleTypeControl articleTypeControl1;
    }
}