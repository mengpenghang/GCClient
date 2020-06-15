namespace GC.Client.RBAC
{
    partial class ResButtonControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。

        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditFormname = new DevExpress.XtraEditors.TextEdit();
            this.textEditButtonname = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonResButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlResButton = new DevExpress.XtraGrid.GridControl();
            this.gridViewResButton = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnFormname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnButtonname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonResButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFormname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditButtonname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "界面名称:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(326, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "界面按钮名称:";
            // 
            // textEditFormname
            // 
            this.textEditFormname.CausesValidation = false;
            this.textEditFormname.EnterMoveNextControl = true;
            this.textEditFormname.Location = new System.Drawing.Point(71, 5);
            this.textEditFormname.Name = "textEditFormname";
            this.textEditFormname.Properties.ValidateOnEnterKey = true;
            this.textEditFormname.Size = new System.Drawing.Size(249, 20);
            this.textEditFormname.TabIndex = 0;
            this.textEditFormname.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // textEditButtonname
            // 
            this.textEditButtonname.CausesValidation = false;
            this.textEditButtonname.EnterMoveNextControl = true;
            this.textEditButtonname.Location = new System.Drawing.Point(416, 5);
            this.textEditButtonname.Name = "textEditButtonname";
            this.textEditButtonname.Properties.ValidateOnEnterKey = true;
            this.textEditButtonname.Size = new System.Drawing.Size(240, 20);
            this.textEditButtonname.TabIndex = 1;
            this.textEditButtonname.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // simpleButtonResButtonSave
            // 
            this.simpleButtonResButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonResButtonSave.Location = new System.Drawing.Point(858, 32);
            this.simpleButtonResButtonSave.Name = "simpleButtonResButtonSave";
            this.simpleButtonResButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonResButtonSave.TabIndex = 4;
            this.simpleButtonResButtonSave.Text = "添加";
            this.simpleButtonResButtonSave.Click += new System.EventHandler(this.simpleButtonResButtonSave_Click);
            // 
            // gridControlResButton
            // 
            this.gridControlResButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlResButton.Location = new System.Drawing.Point(0, 61);
            this.gridControlResButton.MainView = this.gridViewResButton;
            this.gridControlResButton.Name = "gridControlResButton";
            this.gridControlResButton.Size = new System.Drawing.Size(1031, 286);
            this.gridControlResButton.TabIndex = 5;
            this.gridControlResButton.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResButton,
            this.gridView2});
            // 
            // gridViewResButton
            // 
            this.gridViewResButton.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnFormname,
            this.gridColumnButtonname});
            this.gridViewResButton.GridControl = this.gridControlResButton;
            this.gridViewResButton.Name = "gridViewResButton";
            this.gridViewResButton.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewResButton.OptionsView.ShowGroupPanel = false;
            this.gridViewResButton.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewResButton_CellValueChanged);
            this.gridViewResButton.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewResButton_ValidatingEditor);
            // 
            // gridColumnFormname
            // 
            this.gridColumnFormname.Caption = "界面名称";
            this.gridColumnFormname.FieldName = "Formname";
            this.gridColumnFormname.Name = "gridColumnFormname";
            this.gridColumnFormname.Visible = true;
            this.gridColumnFormname.VisibleIndex = 0;
            // 
            // gridColumnButtonname
            // 
            this.gridColumnButtonname.Caption = "界面按钮名称";
            this.gridColumnButtonname.FieldName = "Buttonname";
            this.gridColumnButtonname.Name = "gridColumnButtonname";
            this.gridColumnButtonname.Visible = true;
            this.gridColumnButtonname.VisibleIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlResButton;
            this.gridView2.Name = "gridView2";
            // 
            // simpleButtonResButtonDelete
            // 
            this.simpleButtonResButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonResButtonDelete.CausesValidation = false;
            this.simpleButtonResButtonDelete.Location = new System.Drawing.Point(939, 32);
            this.simpleButtonResButtonDelete.Name = "simpleButtonResButtonDelete";
            this.simpleButtonResButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonResButtonDelete.TabIndex = 3;
            this.simpleButtonResButtonDelete.Text = "删除";
            this.simpleButtonResButtonDelete.Click += new System.EventHandler(this.simpleButtonResButtonDelete_Click);
            // 
            // ResButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlResButton);
            this.Controls.Add(this.simpleButtonResButtonSave);
            this.Controls.Add(this.simpleButtonResButtonDelete);
            this.Controls.Add(this.textEditButtonname);
            this.Controls.Add(this.textEditFormname);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ResButtonControl";
            this.Size = new System.Drawing.Size(1031, 350);
            this.Load += new System.EventHandler(this.ResButtonControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditFormname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditButtonname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditFormname;
        private DevExpress.XtraEditors.TextEdit textEditButtonname;
        private DevExpress.XtraEditors.SimpleButton simpleButtonResButtonSave;
        private DevExpress.XtraGrid.GridControl gridControlResButton;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnButtonname;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonResButtonDelete;
    }
}
