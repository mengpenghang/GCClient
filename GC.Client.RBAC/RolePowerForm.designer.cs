namespace GC.Client.RBAC
{
    partial class RolePowerForm
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
            this.xtraTabControlPower = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageMenuinfo = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageResButton = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageResPermScope = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageResTableColumn = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPower)).BeginInit();
            this.xtraTabControlPower.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControlPower
            // 
            this.xtraTabControlPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlPower.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlPower.Name = "xtraTabControlPower";
            this.xtraTabControlPower.SelectedTabPage = this.xtraTabPageMenuinfo;
            this.xtraTabControlPower.Size = new System.Drawing.Size(1009, 515);
            this.xtraTabControlPower.TabIndex = 2;
            this.xtraTabControlPower.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageMenuinfo,
            this.xtraTabPageResButton,
            this.xtraTabPageResPermScope,
            this.xtraTabPageResTableColumn});
            // 
            // xtraTabPageMenuinfo
            // 
            this.xtraTabPageMenuinfo.Name = "xtraTabPageMenuinfo";
            this.xtraTabPageMenuinfo.Size = new System.Drawing.Size(1003, 488);
            this.xtraTabPageMenuinfo.Text = "模块(菜单)表";
            // 
            // xtraTabPageResButton
            // 
            this.xtraTabPageResButton.Name = "xtraTabPageResButton";
            this.xtraTabPageResButton.Size = new System.Drawing.Size(683, 386);
            this.xtraTabPageResButton.Text = "界面按键控制";
            // 
            // xtraTabPageResPermScope
            // 
            this.xtraTabPageResPermScope.Name = "xtraTabPageResPermScope";
            this.xtraTabPageResPermScope.Size = new System.Drawing.Size(683, 386);
            this.xtraTabPageResPermScope.Text = "资源表";
            // 
            // xtraTabPageResTableColumn
            // 
            this.xtraTabPageResTableColumn.Name = "xtraTabPageResTableColumn";
            this.xtraTabPageResTableColumn.Size = new System.Drawing.Size(683, 386);
            this.xtraTabPageResTableColumn.Text = "表字段";
            // 
            // RolePowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 515);
            this.Controls.Add(this.xtraTabControlPower);
            this.Name = "RolePowerForm";
            this.Text = "权限设置";
            this.Load += new System.EventHandler(this.RolePowerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPower)).EndInit();
            this.xtraTabControlPower.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlPower;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMenuinfo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageResButton;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageResPermScope;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageResTableColumn;
    }
}