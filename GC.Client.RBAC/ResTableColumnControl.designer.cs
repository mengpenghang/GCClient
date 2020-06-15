namespace GC.Client.RBAC
{
    partial class ResTableColumnControl
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
            this.simpleButtonRestablecolumnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRestablecolumnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTablename = new DevExpress.XtraEditors.TextEdit();
            this.textEditObjectname = new DevExpress.XtraEditors.TextEdit();
            this.textEditObjectcolumn = new DevExpress.XtraEditors.TextEdit();
            this.textEditTablecolumn = new DevExpress.XtraEditors.TextEdit();
            this.gridControlResTableColumn = new DevExpress.XtraGrid.GridControl();
            this.gridViewResTableColumn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTablename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTablecolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectcolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTablename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObjectname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObjectcolumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTablecolumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResTableColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResTableColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonRestablecolumnDelete
            // 
            this.simpleButtonRestablecolumnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRestablecolumnDelete.CausesValidation = false;
            this.simpleButtonRestablecolumnDelete.Location = new System.Drawing.Point(971, 31);
            this.simpleButtonRestablecolumnDelete.Name = "simpleButtonRestablecolumnDelete";
            this.simpleButtonRestablecolumnDelete.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonRestablecolumnDelete.TabIndex = 5;
            this.simpleButtonRestablecolumnDelete.Text = "删除";
            this.simpleButtonRestablecolumnDelete.Click += new System.EventHandler(this.simpleButtonRestablecolumnDelete_Click);
            // 
            // simpleButtonRestablecolumnSave
            // 
            this.simpleButtonRestablecolumnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRestablecolumnSave.Location = new System.Drawing.Point(890, 31);
            this.simpleButtonRestablecolumnSave.Name = "simpleButtonRestablecolumnSave";
            this.simpleButtonRestablecolumnSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonRestablecolumnSave.TabIndex = 6;
            this.simpleButtonRestablecolumnSave.Text = "添加";
            this.simpleButtonRestablecolumnSave.Click += new System.EventHandler(this.simpleButtonRestablecolumnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(2, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "表名称:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(459, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "对象名称:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(700, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "对象字段:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(231, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "表字段:";
            // 
            // textEditTablename
            // 
            this.textEditTablename.CausesValidation = false;
            this.textEditTablename.EnterMoveNextControl = true;
            this.textEditTablename.Location = new System.Drawing.Point(46, 3);
            this.textEditTablename.Name = "textEditTablename";
            this.textEditTablename.Properties.ValidateOnEnterKey = true;
            this.textEditTablename.Size = new System.Drawing.Size(180, 20);
            this.textEditTablename.TabIndex = 0;
            this.textEditTablename.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // textEditObjectname
            // 
            this.textEditObjectname.CausesValidation = false;
            this.textEditObjectname.EnterMoveNextControl = true;
            this.textEditObjectname.Location = new System.Drawing.Point(517, 3);
            this.textEditObjectname.Name = "textEditObjectname";
            this.textEditObjectname.Properties.ValidateOnEnterKey = true;
            this.textEditObjectname.Size = new System.Drawing.Size(180, 20);
            this.textEditObjectname.TabIndex = 2;
            this.textEditObjectname.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // textEditObjectcolumn
            // 
            this.textEditObjectcolumn.CausesValidation = false;
            this.textEditObjectcolumn.EnterMoveNextControl = true;
            this.textEditObjectcolumn.Location = new System.Drawing.Point(758, 3);
            this.textEditObjectcolumn.Name = "textEditObjectcolumn";
            this.textEditObjectcolumn.Properties.ValidateOnEnterKey = true;
            this.textEditObjectcolumn.Size = new System.Drawing.Size(180, 20);
            this.textEditObjectcolumn.TabIndex = 3;
            this.textEditObjectcolumn.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // textEditTablecolumn
            // 
            this.textEditTablecolumn.CausesValidation = false;
            this.textEditTablecolumn.EnterMoveNextControl = true;
            this.textEditTablecolumn.Location = new System.Drawing.Point(274, 3);
            this.textEditTablecolumn.Name = "textEditTablecolumn";
            this.textEditTablecolumn.Properties.ValidateOnEnterKey = true;
            this.textEditTablecolumn.Size = new System.Drawing.Size(180, 20);
            this.textEditTablecolumn.TabIndex = 1;
            this.textEditTablecolumn.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // gridControlResTableColumn
            // 
            this.gridControlResTableColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlResTableColumn.Location = new System.Drawing.Point(0, 59);
            this.gridControlResTableColumn.MainView = this.gridViewResTableColumn;
            this.gridControlResTableColumn.Name = "gridControlResTableColumn";
            this.gridControlResTableColumn.Size = new System.Drawing.Size(1054, 291);
            this.gridControlResTableColumn.TabIndex = 7;
            this.gridControlResTableColumn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResTableColumn});
            // 
            // gridViewResTableColumn
            // 
            this.gridViewResTableColumn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTablename,
            this.gridColumnTablecolumn,
            this.gridColumnObjectname,
            this.gridColumnObjectcolumn});
            this.gridViewResTableColumn.GridControl = this.gridControlResTableColumn;
            this.gridViewResTableColumn.Name = "gridViewResTableColumn";
            this.gridViewResTableColumn.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewResTableColumn.OptionsView.ShowGroupPanel = false;
            this.gridViewResTableColumn.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewResTableColumn_CellValueChanged);
            this.gridViewResTableColumn.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewResTableColumn_ValidatingEditor);
            // 
            // gridColumnTablename
            // 
            this.gridColumnTablename.Caption = "表名称";
            this.gridColumnTablename.FieldName = "Tablename";
            this.gridColumnTablename.Name = "gridColumnTablename";
            this.gridColumnTablename.Visible = true;
            this.gridColumnTablename.VisibleIndex = 0;
            // 
            // gridColumnTablecolumn
            // 
            this.gridColumnTablecolumn.Caption = "表字段";
            this.gridColumnTablecolumn.FieldName = "Tablecolumn";
            this.gridColumnTablecolumn.Name = "gridColumnTablecolumn";
            this.gridColumnTablecolumn.Visible = true;
            this.gridColumnTablecolumn.VisibleIndex = 1;
            // 
            // gridColumnObjectname
            // 
            this.gridColumnObjectname.Caption = "对象名称";
            this.gridColumnObjectname.FieldName = "Objectname";
            this.gridColumnObjectname.Name = "gridColumnObjectname";
            this.gridColumnObjectname.Visible = true;
            this.gridColumnObjectname.VisibleIndex = 2;
            // 
            // gridColumnObjectcolumn
            // 
            this.gridColumnObjectcolumn.Caption = "对象字段";
            this.gridColumnObjectcolumn.FieldName = "Objectcolumn";
            this.gridColumnObjectcolumn.Name = "gridColumnObjectcolumn";
            this.gridColumnObjectcolumn.Visible = true;
            this.gridColumnObjectcolumn.VisibleIndex = 3;
            // 
            // ResTableColumnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.gridControlResTableColumn);
            this.Controls.Add(this.textEditTablecolumn);
            this.Controls.Add(this.textEditObjectcolumn);
            this.Controls.Add(this.textEditObjectname);
            this.Controls.Add(this.textEditTablename);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButtonRestablecolumnSave);
            this.Controls.Add(this.simpleButtonRestablecolumnDelete);
            this.Name = "ResTableColumnControl";
            this.Size = new System.Drawing.Size(1054, 350);
            this.Load += new System.EventHandler(this.ResTableColumnControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTablename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObjectname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObjectcolumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTablecolumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResTableColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResTableColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonRestablecolumnDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRestablecolumnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditTablename;
        private DevExpress.XtraEditors.TextEdit textEditObjectname;
        private DevExpress.XtraEditors.TextEdit textEditObjectcolumn;
        private DevExpress.XtraEditors.TextEdit textEditTablecolumn;
        private DevExpress.XtraGrid.GridControl gridControlResTableColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResTableColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTablename;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTablecolumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectcolumn;

    }
}
