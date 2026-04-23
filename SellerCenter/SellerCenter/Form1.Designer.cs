namespace SellerCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuOrder = new ToolStripMenuItem();
            subMenuRecordHistory = new ToolStripMenuItem();
            subMenuNewRecording = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuOrder });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // menuOrder
            // 
            menuOrder.DropDownItems.AddRange(new ToolStripItem[] { subMenuRecordHistory, subMenuNewRecording });
            menuOrder.Name = "menuOrder";
            menuOrder.Size = new Size(71, 20);
            menuOrder.Text = "Đơn hàng";
            // 
            // subMenuRecordHistory
            // 
            subMenuRecordHistory.Name = "subMenuRecordHistory";
            subMenuRecordHistory.Size = new Size(180, 22);
            subMenuRecordHistory.Text = "Lịch sử video";
            subMenuRecordHistory.Click += subMenuRecordHistory_Click;
            // 
            // subMenuNewRecording
            // 
            subMenuNewRecording.Name = "subMenuNewRecording";
            subMenuNewRecording.Size = new Size(180, 22);
            subMenuNewRecording.Text = "Quay video";
            subMenuNewRecording.Click += subMenuNewRecording_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Form1";
            Text = "Seller Center";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menuOrder;
        private ToolStripMenuItem subMenuRecordHistory;
        private ToolStripMenuItem subMenuNewRecording;
    }
}
