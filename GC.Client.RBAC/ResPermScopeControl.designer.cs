namespace GC.Client.RBAC
{
    partial class ResPermScopeControl
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditResname = new DevExpress.XtraEditors.TextEdit();
            this.textEditResdesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonRespermscopeDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditRestype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControlResPermScope = new DevExpress.XtraGrid.GridControl();
            this.gridViewResPermScope = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnRestype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RestypeItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumnResname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnResdesc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResdesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditRestype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResPermScope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResPermScope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestypeItemComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.CausesValidation = false;
            this.labelControl3.Location = new System.Drawing.Point(528, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "资源描述:";
            // 
            // textEditResname
            // 
            this.textEditResname.CausesValidation = false;
            this.textEditResname.EnterMoveNextControl = true;
            this.textEditResname.Location = new System.Drawing.Point(322, 3);
            this.textEditResname.Name = "textEditResname";
            this.textEditResname.Properties.ValidateOnEnterKey = true;
            this.textEditResname.Size = new System.Drawing.Size(200, 20);
            this.textEditResname.TabIndex = 1;
            this.textEditResname.Validating += new System.ComponentModel.CancelEventHandler(this.Edit_Validating);
            // 
            // textEditResdesc
            // 
            this.textEditResdesc.CausesValidation = false;
            this.textEditResdesc.EnterMoveNextControl = true;
            this.textEditResdesc.Location = new System.Drawing.Point(584, 3);
            this.textEditResdesc.Name = "textEditResdesc";
            this.textEditResdesc.Properties.ValidateOnEnterKey = true;
            this.textEditResdesc.Size = new System.Drawing.Size(200, 20);
            this.textEditResdesc.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.CausesValidation = false;
            this.labelControl2.Location = new System.Drawing.Point(268, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "资源名称:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "资源类型:";
            // 
            // simpleButtonRespermscopeDelete
            // 
            this.simpleButtonRespermscopeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRespermscopeDelete.CausesValidation = false;
            this.simpleButtonRespermscopeDelete.Location = new System.Drawing.Point(966, 34);
            this.simpleButtonRespermscopeDelete.Name = "simpleButtonRespermscopeDelete";
            this.simpleButtonRespermscopeDelete.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonRespermscopeDelete.TabIndex = 4;
            this.simpleButtonRespermscopeDelete.Text = "删除";
            this.simpleButtonRespermscopeDelete.Click += new System.EventHandler(this.simpleButtonRespermscopeDelete_Click);
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSave.Location = new System.Drawing.Point(885, 34);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSave.TabIndex = 5;
            this.simpleButtonSave.Text = "添加";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // comboBoxEditRestype
            // 
            this.comboBoxEditRestype.CausesValidation = false;
            this.comboBoxEditRestype.EnterMoveNextControl = true;
            this.comboBoxEditRestype.Location = new System.Drawing.Point(62, 3);
            this.comboBoxEditRestype.Name = "comboBoxEditRestype";
            this.comboBoxEditRestype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditRestype.Properties.Items.AddRange(new object[] {
            "厂区",
            "类型"});
            this.comboBoxEditRestype.Properties.ValidateOnEnterKey = true;
            this.comboBoxEditRestype.Size = new System.Drawing.Size(200, 20);
            this.comboBoxEditRestype.TabIndex = 0;
            this.comboBoxEditRestype.Validating += new System.ComponentModel.CancelEventHandler(this.Edit_Validating);
            // 
            // gridControlResPermScope
            // 
            this.gridControlResPermScope.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlResPermScope.Location = new System.Drawing.Point(0, 63);
            this.gridControlResPermScope.MainView = this.gridViewResPermScope;
            this.gridControlResPermScope.Name = "gridControlResPermScope";
            this.gridControlResPermScope.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RestypeItemComboBox});
            this.gridControlResPermScope.Size = new System.Drawing.Size(1050, 287);
            this.gridControlResPermScope.TabIndex = 6;
            this.gridControlResPermScope.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResPermScope});
            // 
            // gridViewResPermScope
            // 
            this.gridViewResPermScope.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnRestype,
            this.gridColumnResname,
            this.gridColumnResdesc});
            this.gridViewResPermScope.GridControl = this.gridControlResPermScope;
            this.gridViewResPermScope.Name = "gridViewResPermScope";
            this.gridViewResPermScope.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewResPermScope.OptionsView.ShowGroupPanel = false;
            this.gridViewResPermScope.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewResPermScope_CellValueChanged);
            this.gridViewResPermScope.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewResPermScope_ValidatingEditor);
            // 
            // gridColumnRestype
            // 
            this.gridColumnRestype.Caption = "资源类型";
            this.gridColumnRestype.ColumnEdit = this.RestypeItemComboBox;
            this.gridColumnRestype.FieldName = "Restype";
            this.gridColumnRestype.Name = "gridColumnRestype";
            this.gridColumnRestype.Visible = true;
            this.gridColumnRestype.VisibleIndex = 0;
            // 
            // RestypeItemComboBox
            // 
            this.RestypeItemComboBox.AutoHeight = false;
            this.RestypeItemComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RestypeItemComboBox.Items.AddRange(new object[] {
            "厂区",
            "类型"});
            this.RestypeItemComboBox.Name = "RestypeItemComboBox";
            // 
            // gridColumnResname
            // 
            this.gridColumnResname.Caption = "资源名称";
            this.gridColumnResname.FieldName = "Resname";
            this.gridColumnResname.Name = "gridColumnResname";
            this.gridColumnResname.Visible = true;
            this.gridColumnResname.VisibleIndex = 1;
            // 
            // gridColumnResdesc
            // 
            this.gridColumnResdesc.Caption = "资源描述";
            this.gridColumnResdesc.FieldName = "Resdesc";
            this.gridColumnResdesc.Name = "gridColumnResdesc";
            this.gridColumnResdesc.Visible = true;
            this.gridColumnResdesc.VisibleIndex = 2;
            // 
            // ResPermScopeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlResPermScope);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.simpleButtonRespermscopeDelete);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditResname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditResdesc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboBoxEditRestype);
            this.Name = "ResPermScopeControl";
            this.Size = new System.Drawing.Size(1050, 350);
            this.Load += new System.EventHandler(this.ResPermScopeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditResname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResdesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditRestype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResPermScope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResPermScope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestypeItemComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditResname;
        private DevExpress.XtraEditors.TextEdit textEditResdesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRespermscopeDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditRestype;
        private DevExpress.XtraGrid.GridControl gridControlResPermScope;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResPermScope;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRestype;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnResname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnResdesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox RestypeItemComboBox;
    }
}
