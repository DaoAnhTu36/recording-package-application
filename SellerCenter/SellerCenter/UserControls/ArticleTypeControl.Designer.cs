namespace SellerCenter.UserControls
{
    partial class ArticleTypeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowArticleTypePanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowArticleTypePanel
            // 
            flowArticleTypePanel.Dock = DockStyle.Fill;
            flowArticleTypePanel.Location = new Point(0, 0);
            flowArticleTypePanel.Name = "flowArticleTypePanel";
            flowArticleTypePanel.Size = new Size(150, 150);
            flowArticleTypePanel.TabIndex = 0;
            // 
            // ArticleTypeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowArticleTypePanel);
            Name = "ArticleTypeControl";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowArticleTypePanel;
    }
}
