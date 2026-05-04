namespace SellerCenter.Forms
{
    partial class frmRolePermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRolePermission));
            tableLayoutPanel1 = new TableLayoutPanel();
            cbbRole = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            checkedListBoxPermission = new CheckedListBox();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.57202959F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.42797F));
            tableLayoutPanel1.Controls.Add(cbbRole, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(checkedListBoxPermission, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 2);
            tableLayoutPanel1.Location = new Point(31, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.86240768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.13759F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 475F));
            tableLayoutPanel1.Size = new Size(1773, 883);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(119, 3);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(273, 23);
            cbbRole.TabIndex = 1;
            cbbRole.TextChanged += cbbRole_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Chức vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Quyền truy cập";
            // 
            // checkedListBoxPermission
            // 
            checkedListBoxPermission.CheckOnClick = true;
            checkedListBoxPermission.Dock = DockStyle.Fill;
            checkedListBoxPermission.FormattingEnabled = true;
            checkedListBoxPermission.Location = new Point(119, 35);
            checkedListBoxPermission.Name = "checkedListBoxPermission";
            checkedListBoxPermission.Size = new Size(1651, 369);
            checkedListBoxPermission.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmRolePermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmRolePermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRolePermission";
            Load += frmRolePermission_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbbRole;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBoxPermission;
        private Button btnSave;
    }
}