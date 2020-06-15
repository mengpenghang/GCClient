namespace GC.Client.RBAC
{
    partial class MenuInfoControl
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
            this.treeListMenuInfo = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnMenuname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnMenudesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnMenuimage = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnMenuindex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MenuindexItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.treeListColumnMenurule = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MenuruleItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.treeListColumnFormdialog = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnChildform = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnMenumark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.menumarkItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.treeListColumnTransparams = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TransparamsItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumnRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButtonMenuinfoDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMenuinfoInsert = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMenuinfoAdd = new DevExpress.XtraEditors.SimpleButton();
            this.textEditChildform = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMenuimage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMenudesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMenuname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMenumark = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditFormdialog = new DevExpress.XtraEditors.TextEdit();
            this.lookupEditMenurule = new DevExpress.XtraEditors.LookUpEdit();
            this.menuinfoLookupEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.CheckEditTransparams = new DevExpress.XtraEditors.CheckEdit();
            this.textEditMenuindex = new DevExpress.XtraEditors.SpinEdit();
            this.Excel导出 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenuInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuindexItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuruleItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menumarkItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransparamsItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChildform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuimage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenudesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenumark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFormdialog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditMenurule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuinfoLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditTransparams.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuindex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListMenuInfo
            // 
            this.treeListMenuInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListMenuInfo.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnMenuname,
            this.treeListColumnMenudesc,
            this.treeListColumnMenuimage,
            this.treeListColumnMenuindex,
            this.treeListColumnMenurule,
            this.treeListColumnFormdialog,
            this.treeListColumnChildform,
            this.treeListColumnMenumark,
            this.treeListColumnTransparams,
            this.treeListColumnRemark});
            this.treeListMenuInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListMenuInfo.KeyFieldName = "Sysid";
            this.treeListMenuInfo.Location = new System.Drawing.Point(0, 107);
            this.treeListMenuInfo.Name = "treeListMenuInfo";
            this.treeListMenuInfo.OptionsLayout.AddNewColumns = false;
            this.treeListMenuInfo.OptionsNavigation.AutoFocusNewNode = true;
            this.treeListMenuInfo.OptionsNavigation.AutoMoveRowFocus = true;
            this.treeListMenuInfo.OptionsNavigation.EnterMovesNextColumn = true;
            this.treeListMenuInfo.OptionsView.AutoWidth = false;
            this.treeListMenuInfo.OptionsView.BestFitNodes = DevExpress.XtraTreeList.TreeListBestFitNodes.Visible;
            this.treeListMenuInfo.ParentFieldName = "Parentid";
            this.treeListMenuInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.menumarkItemComboBox,
            this.TransparamsItemCheckEdit,
            this.MenuindexItemSpinEdit,
            this.MenuruleItemLookUpEdit});
            this.treeListMenuInfo.Size = new System.Drawing.Size(1009, 240);
            this.treeListMenuInfo.TabIndex = 15;
            this.treeListMenuInfo.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.treeListMenuInfo_ValidatingEditor);
            this.treeListMenuInfo.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeListMenuInfo_CellValueChanged);
            // 
            // treeListColumnMenuname
            // 
            this.treeListColumnMenuname.Caption = "模块名";
            this.treeListColumnMenuname.FieldName = "Menuname";
            this.treeListColumnMenuname.Name = "treeListColumnMenuname";
            this.treeListColumnMenuname.Visible = true;
            this.treeListColumnMenuname.VisibleIndex = 0;
            this.treeListColumnMenuname.Width = 126;
            // 
            // treeListColumnMenudesc
            // 
            this.treeListColumnMenudesc.Caption = "描述";
            this.treeListColumnMenudesc.FieldName = "Menudesc";
            this.treeListColumnMenudesc.Name = "treeListColumnMenudesc";
            this.treeListColumnMenudesc.Visible = true;
            this.treeListColumnMenudesc.VisibleIndex = 1;
            this.treeListColumnMenudesc.Width = 134;
            // 
            // treeListColumnMenuimage
            // 
            this.treeListColumnMenuimage.Caption = "图标";
            this.treeListColumnMenuimage.FieldName = "Menuimage";
            this.treeListColumnMenuimage.Name = "treeListColumnMenuimage";
            this.treeListColumnMenuimage.Visible = true;
            this.treeListColumnMenuimage.VisibleIndex = 2;
            // 
            // treeListColumnMenuindex
            // 
            this.treeListColumnMenuindex.Caption = "排序";
            this.treeListColumnMenuindex.ColumnEdit = this.MenuindexItemSpinEdit;
            this.treeListColumnMenuindex.FieldName = "Menuindex";
            this.treeListColumnMenuindex.Name = "treeListColumnMenuindex";
            this.treeListColumnMenuindex.Visible = true;
            this.treeListColumnMenuindex.VisibleIndex = 3;
            this.treeListColumnMenuindex.Width = 83;
            // 
            // MenuindexItemSpinEdit
            // 
            this.MenuindexItemSpinEdit.AutoHeight = false;
            this.MenuindexItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.MenuindexItemSpinEdit.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.MenuindexItemSpinEdit.Name = "MenuindexItemSpinEdit";
            // 
            // treeListColumnMenurule
            // 
            this.treeListColumnMenurule.Caption = "规则名";
            this.treeListColumnMenurule.ColumnEdit = this.MenuruleItemLookUpEdit;
            this.treeListColumnMenurule.FieldName = "Menurule";
            this.treeListColumnMenurule.Name = "treeListColumnMenurule";
            this.treeListColumnMenurule.Visible = true;
            this.treeListColumnMenurule.VisibleIndex = 4;
            this.treeListColumnMenurule.Width = 199;
            // 
            // MenuruleItemLookUpEdit
            // 
            this.MenuruleItemLookUpEdit.AutoHeight = false;
            this.MenuruleItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MenuruleItemLookUpEdit.DisplayMember = "Column";
            this.MenuruleItemLookUpEdit.Name = "MenuruleItemLookUpEdit";
            this.MenuruleItemLookUpEdit.NullText = "";
            this.MenuruleItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.MenuruleItemLookUpEdit.ValueMember = "Column";
            // 
            // treeListColumnFormdialog
            // 
            this.treeListColumnFormdialog.Caption = "界面弹出";
            this.treeListColumnFormdialog.FieldName = "Formdialog";
            this.treeListColumnFormdialog.Name = "treeListColumnFormdialog";
            this.treeListColumnFormdialog.Visible = true;
            this.treeListColumnFormdialog.VisibleIndex = 5;
            // 
            // treeListColumnChildform
            // 
            this.treeListColumnChildform.Caption = "子界面";
            this.treeListColumnChildform.FieldName = "Childform";
            this.treeListColumnChildform.Name = "treeListColumnChildform";
            this.treeListColumnChildform.Visible = true;
            this.treeListColumnChildform.VisibleIndex = 6;
            // 
            // treeListColumnMenumark
            // 
            this.treeListColumnMenumark.Caption = "菜单标识";
            this.treeListColumnMenumark.ColumnEdit = this.menumarkItemComboBox;
            this.treeListColumnMenumark.FieldName = "Menumark";
            this.treeListColumnMenumark.Name = "treeListColumnMenumark";
            this.treeListColumnMenumark.Visible = true;
            this.treeListColumnMenumark.VisibleIndex = 7;
            // 
            // menumarkItemComboBox
            // 
            this.menumarkItemComboBox.AutoHeight = false;
            this.menumarkItemComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.menumarkItemComboBox.Items.AddRange(new object[] {
            "",
            "Page",
            "Group",
            "LargeButton",
            "SmallButton"});
            this.menumarkItemComboBox.Name = "menumarkItemComboBox";
            // 
            // treeListColumnTransparams
            // 
            this.treeListColumnTransparams.Caption = "参数传递";
            this.treeListColumnTransparams.ColumnEdit = this.TransparamsItemCheckEdit;
            this.treeListColumnTransparams.FieldName = "Transparams";
            this.treeListColumnTransparams.Name = "treeListColumnTransparams";
            this.treeListColumnTransparams.Visible = true;
            this.treeListColumnTransparams.VisibleIndex = 8;
            // 
            // TransparamsItemCheckEdit
            // 
            this.TransparamsItemCheckEdit.AutoHeight = false;
            this.TransparamsItemCheckEdit.Name = "TransparamsItemCheckEdit";
            this.TransparamsItemCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.TransparamsItemCheckEdit.ValueChecked = "True";
            this.TransparamsItemCheckEdit.ValueUnchecked = null;
            // 
            // treeListColumnRemark
            // 
            this.treeListColumnRemark.Caption = "备注";
            this.treeListColumnRemark.FieldName = "Remark";
            this.treeListColumnRemark.Name = "treeListColumnRemark";
            this.treeListColumnRemark.Visible = true;
            this.treeListColumnRemark.VisibleIndex = 9;
            // 
            // simpleButtonMenuinfoDelete
            // 
            this.simpleButtonMenuinfoDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonMenuinfoDelete.CausesValidation = false;
            this.simpleButtonMenuinfoDelete.Location = new System.Drawing.Point(892, 80);
            this.simpleButtonMenuinfoDelete.Name = "simpleButtonMenuinfoDelete";
            this.simpleButtonMenuinfoDelete.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonMenuinfoDelete.TabIndex = 13;
            this.simpleButtonMenuinfoDelete.Text = "删除";
            this.simpleButtonMenuinfoDelete.Click += new System.EventHandler(this.simpleButtonMenuinfoDelete_Click);
            // 
            // simpleButtonMenuinfoInsert
            // 
            this.simpleButtonMenuinfoInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonMenuinfoInsert.Location = new System.Drawing.Point(801, 80);
            this.simpleButtonMenuinfoInsert.Name = "simpleButtonMenuinfoInsert";
            this.simpleButtonMenuinfoInsert.Size = new System.Drawing.Size(85, 23);
            this.simpleButtonMenuinfoInsert.TabIndex = 12;
            this.simpleButtonMenuinfoInsert.Text = "插入子菜单";
            this.simpleButtonMenuinfoInsert.Click += new System.EventHandler(this.simpleButtonMenuinfoInsert_Click);
            // 
            // simpleButtonMenuinfoAdd
            // 
            this.simpleButtonMenuinfoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonMenuinfoAdd.Location = new System.Drawing.Point(706, 80);
            this.simpleButtonMenuinfoAdd.Name = "simpleButtonMenuinfoAdd";
            this.simpleButtonMenuinfoAdd.Size = new System.Drawing.Size(89, 23);
            this.simpleButtonMenuinfoAdd.TabIndex = 11;
            this.simpleButtonMenuinfoAdd.Text = "添加同级菜单";
            this.simpleButtonMenuinfoAdd.Click += new System.EventHandler(this.simpleButtonMenuinfoAdd_Click);
            // 
            // textEditChildform
            // 
            this.textEditChildform.EnterMoveNextControl = true;
            this.textEditChildform.Location = new System.Drawing.Point(304, 30);
            this.textEditChildform.Name = "textEditChildform";
            this.textEditChildform.Properties.ValidateOnEnterKey = true;
            this.textEditChildform.Size = new System.Drawing.Size(167, 20);
            this.textEditChildform.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(473, 33);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 14);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "菜单标志:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(260, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 14);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "子界面:";
            // 
            // textEditRemark
            // 
            this.textEditRemark.EnterMoveNextControl = true;
            this.textEditRemark.Location = new System.Drawing.Point(305, 54);
            this.textEditRemark.Name = "textEditRemark";
            this.textEditRemark.Properties.ValidateOnEnterKey = true;
            this.textEditRemark.Size = new System.Drawing.Size(662, 20);
            this.textEditRemark.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(273, 57);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 14);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "备注:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(2, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 14);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "界面弹出:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(3, 56);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 14);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "同级顺序:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(683, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 14);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "规则名:";
            // 
            // textEditMenuimage
            // 
            this.textEditMenuimage.EnterMoveNextControl = true;
            this.textEditMenuimage.Location = new System.Drawing.Point(531, 6);
            this.textEditMenuimage.Name = "textEditMenuimage";
            this.textEditMenuimage.Properties.ValidateOnEnterKey = true;
            this.textEditMenuimage.Size = new System.Drawing.Size(146, 20);
            this.textEditMenuimage.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(497, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 14);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "图标:";
            // 
            // textEditMenudesc
            // 
            this.textEditMenudesc.CausesValidation = false;
            this.textEditMenudesc.EnterMoveNextControl = true;
            this.textEditMenudesc.Location = new System.Drawing.Point(304, 6);
            this.textEditMenudesc.Name = "textEditMenudesc";
            this.textEditMenudesc.Properties.ValidateOnEnterKey = true;
            this.textEditMenudesc.Size = new System.Drawing.Size(167, 20);
            this.textEditMenudesc.TabIndex = 1;
            this.textEditMenudesc.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit_Validating);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(270, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "描述:";
            // 
            // textEditMenuname
            // 
            this.textEditMenuname.CausesValidation = false;
            this.textEditMenuname.EnterMoveNextControl = true;
            this.textEditMenuname.Location = new System.Drawing.Point(57, 6);
            this.textEditMenuname.Name = "textEditMenuname";
            this.textEditMenuname.Properties.ValidateOnEnterKey = true;
            this.textEditMenuname.Size = new System.Drawing.Size(195, 20);
            this.textEditMenuname.TabIndex = 0;
            this.textEditMenuname.Validating += new System.ComponentModel.CancelEventHandler(this.textEditMenuname_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "模块名:";
            // 
            // textEditMenumark
            // 
            this.textEditMenumark.Location = new System.Drawing.Point(531, 30);
            this.textEditMenumark.Name = "textEditMenumark";
            this.textEditMenumark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditMenumark.Properties.Items.AddRange(new object[] {
            "",
            "Page",
            "Group",
            "LargeButton",
            "SmallButton"});
            this.textEditMenumark.Properties.ValidateOnEnterKey = true;
            this.textEditMenumark.Size = new System.Drawing.Size(146, 20);
            this.textEditMenumark.TabIndex = 6;
            // 
            // textEditFormdialog
            // 
            this.textEditFormdialog.EditValue = "";
            this.textEditFormdialog.EnterMoveNextControl = true;
            this.textEditFormdialog.Location = new System.Drawing.Point(57, 30);
            this.textEditFormdialog.Name = "textEditFormdialog";
            this.textEditFormdialog.Properties.NullText = "[EditValue is null]";
            this.textEditFormdialog.Properties.ValidateOnEnterKey = true;
            this.textEditFormdialog.Size = new System.Drawing.Size(195, 20);
            this.textEditFormdialog.TabIndex = 4;
            // 
            // lookupEditMenurule
            // 
            this.lookupEditMenurule.EnterMoveNextControl = true;
            this.lookupEditMenurule.Location = new System.Drawing.Point(729, 6);
            this.lookupEditMenurule.Name = "lookupEditMenurule";
            this.lookupEditMenurule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEditMenurule.Properties.NullText = "";
            this.lookupEditMenurule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupEditMenurule.Properties.ValidateOnEnterKey = true;
            this.lookupEditMenurule.Size = new System.Drawing.Size(238, 20);
            this.lookupEditMenurule.TabIndex = 3;
            // 
            // menuinfoLookupEdit
            // 
            this.menuinfoLookupEdit.EnterMoveNextControl = true;
            this.menuinfoLookupEdit.Location = new System.Drawing.Point(57, 77);
            this.menuinfoLookupEdit.Name = "menuinfoLookupEdit";
            this.menuinfoLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.menuinfoLookupEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Menudesc", "描述")});
            this.menuinfoLookupEdit.Properties.DisplayMember = "Menudesc";
            this.menuinfoLookupEdit.Properties.NullText = "";
            this.menuinfoLookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.menuinfoLookupEdit.Properties.ValidateOnEnterKey = true;
            this.menuinfoLookupEdit.Properties.ValueMember = "Sysid";
            this.menuinfoLookupEdit.Size = new System.Drawing.Size(195, 20);
            this.menuinfoLookupEdit.TabIndex = 9;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 80);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 14);
            this.labelControl11.TabIndex = 18;
            this.labelControl11.Text = "父菜单:";
            // 
            // CheckEditTransparams
            // 
            this.CheckEditTransparams.EditValue = null;
            this.CheckEditTransparams.Location = new System.Drawing.Point(729, 30);
            this.CheckEditTransparams.Name = "CheckEditTransparams";
            this.CheckEditTransparams.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.CheckEditTransparams.Properties.Caption = "是否有参数";
            this.CheckEditTransparams.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.CheckEditTransparams.Properties.ValueChecked = "True";
            this.CheckEditTransparams.Properties.ValueUnchecked = null;
            this.CheckEditTransparams.Size = new System.Drawing.Size(238, 19);
            this.CheckEditTransparams.TabIndex = 7;
            // 
            // textEditMenuindex
            // 
            this.textEditMenuindex.CausesValidation = false;
            this.textEditMenuindex.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEditMenuindex.Location = new System.Drawing.Point(57, 53);
            this.textEditMenuindex.Name = "textEditMenuindex";
            this.textEditMenuindex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.textEditMenuindex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEditMenuindex.Properties.Mask.BeepOnError = true;
            this.textEditMenuindex.Properties.Mask.EditMask = "d";
            this.textEditMenuindex.Properties.Mask.ShowPlaceHolders = false;
            this.textEditMenuindex.Properties.MaxValue = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.textEditMenuindex.Size = new System.Drawing.Size(195, 20);
            this.textEditMenuindex.TabIndex = 8;
            // 
            // Excel导出
            // 
            this.Excel导出.Location = new System.Drawing.Point(612, 80);
            this.Excel导出.Name = "Excel导出";
            this.Excel导出.Size = new System.Drawing.Size(75, 23);
            this.Excel导出.TabIndex = 24;
            this.Excel导出.Text = "Excel导出";
         //   this.Excel导出.Click += new System.EventHandler(this.Excel导出_Click);
            // 
            // MenuInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.Excel导出);
            this.Controls.Add(this.treeListMenuInfo);
            this.Controls.Add(this.simpleButtonMenuinfoDelete);
            this.Controls.Add(this.simpleButtonMenuinfoInsert);
            this.Controls.Add(this.simpleButtonMenuinfoAdd);
            this.Controls.Add(this.textEditChildform);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditRemark);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEditMenuimage);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditMenudesc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditMenuname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditMenumark);
            this.Controls.Add(this.textEditFormdialog);
            this.Controls.Add(this.lookupEditMenurule);
            this.Controls.Add(this.menuinfoLookupEdit);
            this.Controls.Add(this.CheckEditTransparams);
            this.Controls.Add(this.textEditMenuindex);
            this.Name = "MenuInfoControl";
            this.Size = new System.Drawing.Size(1009, 350);
            this.Load += new System.EventHandler(this.MenuInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenuInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuindexItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuruleItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menumarkItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransparamsItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChildform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuimage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenudesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenumark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFormdialog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditMenurule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuinfoLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditTransparams.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuindex.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListMenuInfo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenudesc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenuimage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenuindex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenurule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnFormdialog;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnChildform;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenumark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnTransparams;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnMenuname;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMenuinfoDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMenuinfoInsert;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMenuinfoAdd;
        private DevExpress.XtraEditors.TextEdit textEditChildform;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditRemark;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditMenuimage;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditMenudesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditMenuname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit textEditMenumark;
        private DevExpress.XtraEditors.TextEdit textEditFormdialog;
        private DevExpress.XtraEditors.LookUpEdit lookupEditMenurule;
        private DevExpress.XtraEditors.LookUpEdit menuinfoLookupEdit;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit CheckEditTransparams;
        private DevExpress.XtraEditors.SpinEdit textEditMenuindex;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit MenuindexItemSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MenuruleItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox menumarkItemComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TransparamsItemCheckEdit;
        private DevExpress.XtraEditors.SimpleButton Excel导出;
    }
}
