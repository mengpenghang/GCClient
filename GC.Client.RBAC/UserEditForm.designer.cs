namespace GC.Client.RBAC
{
    partial class UserEditForm
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
            this.usernameItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.userpasswordItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sexItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.phoneItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.splitContainerControlEmployee = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnRetsetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
            this.lblDepartment = new DevExpress.XtraEditors.LabelControl();
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmplcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpladd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastchangedate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLasteddatenum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPowerchanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuerySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEmployeeDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditEmplcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlUserRole = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheckValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkValueItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumnRolename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRoledesc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usernameItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpasswordItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlEmployee)).BeginInit();
            this.splitContainerControlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmplcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValueItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameItemTextEdit
            // 
            this.usernameItemTextEdit.AutoHeight = false;
            this.usernameItemTextEdit.Name = "usernameItemTextEdit";
            // 
            // userpasswordItemTextEdit
            // 
            this.userpasswordItemTextEdit.AutoHeight = false;
            this.userpasswordItemTextEdit.Name = "userpasswordItemTextEdit";
            this.userpasswordItemTextEdit.PasswordChar = '·';
            this.userpasswordItemTextEdit.UseSystemPasswordChar = true;
            this.userpasswordItemTextEdit.ValidateOnEnterKey = true;
            // 
            // sexItemComboBox
            // 
            this.sexItemComboBox.AutoHeight = false;
            this.sexItemComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexItemComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexItemComboBox.Name = "sexItemComboBox";
            this.sexItemComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.sexItemComboBox.ValidateOnEnterKey = true;
            // 
            // phoneItemTextEdit
            // 
            this.phoneItemTextEdit.AutoHeight = false;
            this.phoneItemTextEdit.Mask.BeepOnError = true;
            this.phoneItemTextEdit.Mask.EditMask = "\\d*";
            this.phoneItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.phoneItemTextEdit.Mask.ShowPlaceHolders = false;
            this.phoneItemTextEdit.Name = "phoneItemTextEdit";
            // 
            // splitContainerControlEmployee
            // 
            this.splitContainerControlEmployee.CausesValidation = false;
            this.splitContainerControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlEmployee.Name = "splitContainerControlEmployee";
            this.splitContainerControlEmployee.Panel1.AutoScroll = true;
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.btnRetsetPassword);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.txtDepartment);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.lblDepartment);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.gridControlEmployee);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.QuerySimpleButton);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.simpleButtonEmployeeDelete);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.textEditUsername);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.textEditEmplcode);
            this.splitContainerControlEmployee.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControlEmployee.Panel1.Text = "Panel1";
            this.splitContainerControlEmployee.Panel2.AutoScroll = true;
            this.splitContainerControlEmployee.Panel2.Controls.Add(this.gridControlUserRole);
            this.splitContainerControlEmployee.Panel2.Text = "Panel2";
            this.splitContainerControlEmployee.Size = new System.Drawing.Size(1202, 686);
            this.splitContainerControlEmployee.SplitterPosition = 901;
            this.splitContainerControlEmployee.TabIndex = 0;
            this.splitContainerControlEmployee.Text = "splitContainerControlUser";
            // 
            // btnRetsetPassword
            // 
            this.btnRetsetPassword.Location = new System.Drawing.Point(698, 3);
            this.btnRetsetPassword.Name = "btnRetsetPassword";
            this.btnRetsetPassword.Size = new System.Drawing.Size(72, 23);
            this.btnRetsetPassword.TabIndex = 41;
            this.btnRetsetPassword.Text = "重置密码";
            this.btnRetsetPassword.Click += new System.EventHandler(this.btnRetsetPassword_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.EnterMoveNextControl = true;
            this.txtDepartment.Location = new System.Drawing.Point(351, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.ValidateOnEnterKey = true;
            this.txtDepartment.Size = new System.Drawing.Size(118, 20);
            this.txtDepartment.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(317, 7);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(28, 14);
            this.lblDepartment.TabIndex = 24;
            this.lblDepartment.Text = "部门:";
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlEmployee.CausesValidation = false;
            this.gridControlEmployee.Location = new System.Drawing.Point(0, 31);
            this.gridControlEmployee.MainView = this.gridViewEmployee;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.Size = new System.Drawing.Size(900, 655);
            this.gridControlEmployee.TabIndex = 11;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmplcode,
            this.colUsername,
            this.colUserpassword,
            this.colSex,
            this.colTelephone,
            this.colMobphone,
            this.colEmpladd,
            this.colDepartmentname,
            this.colJobnumber,
            this.colLastchangedate,
            this.colLasteddatenum,
            this.colPowerchanged});
            this.gridViewEmployee.GridControl = this.gridControlEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewEmployee.OptionsView.ColumnAutoWidth = false;
            this.gridViewEmployee.OptionsView.ShowGroupPanel = false;
            this.gridViewEmployee.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJobnumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewEmployee.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewEmployee_FocusedRowChanged);
            this.gridViewEmployee.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewEmployee_CellValueChanged);
            this.gridViewEmployee.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewEmployee_ValidatingEditor);
            // 
            // colEmplcode
            // 
            this.colEmplcode.Caption = "登录名";
            this.colEmplcode.FieldName = "Emplcode";
            this.colEmplcode.Name = "colEmplcode";
            this.colEmplcode.OptionsColumn.ReadOnly = true;
            this.colEmplcode.Visible = true;
            this.colEmplcode.VisibleIndex = 2;
            this.colEmplcode.Width = 82;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "姓名";
            this.colUsername.ColumnEdit = this.usernameItemTextEdit;
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 3;
            // 
            // colUserpassword
            // 
            this.colUserpassword.Caption = "密码";
            this.colUserpassword.ColumnEdit = this.userpasswordItemTextEdit;
            this.colUserpassword.FieldName = "Userpassword";
            this.colUserpassword.Name = "colUserpassword";
            this.colUserpassword.Visible = true;
            this.colUserpassword.VisibleIndex = 4;
            this.colUserpassword.Width = 100;
            // 
            // colSex
            // 
            this.colSex.Caption = "性别";
            this.colSex.ColumnEdit = this.sexItemComboBox;
            this.colSex.FieldName = "Sex";
            this.colSex.Name = "colSex";
            this.colSex.Visible = true;
            this.colSex.VisibleIndex = 5;
            this.colSex.Width = 50;
            // 
            // colTelephone
            // 
            this.colTelephone.Caption = "电话";
            this.colTelephone.ColumnEdit = this.phoneItemTextEdit;
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 6;
            this.colTelephone.Width = 98;
            // 
            // colMobphone
            // 
            this.colMobphone.Caption = "手机";
            this.colMobphone.ColumnEdit = this.phoneItemTextEdit;
            this.colMobphone.FieldName = "Mobphone";
            this.colMobphone.Name = "colMobphone";
            this.colMobphone.Visible = true;
            this.colMobphone.VisibleIndex = 7;
            this.colMobphone.Width = 93;
            // 
            // colEmpladd
            // 
            this.colEmpladd.Caption = "Email地址";
            this.colEmpladd.FieldName = "Empladd";
            this.colEmpladd.Name = "colEmpladd";
            this.colEmpladd.Visible = true;
            this.colEmpladd.VisibleIndex = 8;
            this.colEmpladd.Width = 136;
            // 
            // colDepartmentname
            // 
            this.colDepartmentname.Caption = "部门名称";
            this.colDepartmentname.FieldName = "Departmentname";
            this.colDepartmentname.Name = "colDepartmentname";
            this.colDepartmentname.Visible = true;
            this.colDepartmentname.VisibleIndex = 0;
            // 
            // colJobnumber
            // 
            this.colJobnumber.Caption = "工号";
            this.colJobnumber.FieldName = "Jobnumber";
            this.colJobnumber.Name = "colJobnumber";
            this.colJobnumber.OptionsColumn.ReadOnly = true;
            this.colJobnumber.Visible = true;
            this.colJobnumber.VisibleIndex = 1;
            // 
            // colLastchangedate
            // 
            this.colLastchangedate.Caption = "修改密码时间";
            this.colLastchangedate.FieldName = "Lastchangedate";
            this.colLastchangedate.Name = "colLastchangedate";
            this.colLastchangedate.Visible = true;
            this.colLastchangedate.VisibleIndex = 9;
            this.colLastchangedate.Width = 91;
            // 
            // colLasteddatenum
            // 
            this.colLasteddatenum.Caption = "多久需要修改";
            this.colLasteddatenum.FieldName = "Lasteddatenum";
            this.colLasteddatenum.Name = "colLasteddatenum";
            this.colLasteddatenum.Visible = true;
            this.colLasteddatenum.VisibleIndex = 10;
            this.colLasteddatenum.Width = 91;
            // 
            // colPowerchanged
            // 
            this.colPowerchanged.Caption = "权限变动";
            this.colPowerchanged.FieldName = "Powerchanged";
            this.colPowerchanged.Name = "colPowerchanged";
            this.colPowerchanged.Visible = true;
            this.colPowerchanged.VisibleIndex = 11;
            // 
            // QuerySimpleButton
            // 
            this.QuerySimpleButton.CausesValidation = false;
            this.QuerySimpleButton.Location = new System.Drawing.Point(475, 3);
            this.QuerySimpleButton.Name = "QuerySimpleButton";
            this.QuerySimpleButton.Size = new System.Drawing.Size(75, 23);
            this.QuerySimpleButton.TabIndex = 3;
            this.QuerySimpleButton.Text = "查询";
            this.QuerySimpleButton.Click += new System.EventHandler(this.QuerySimpleButton_Click);
            // 
            // simpleButtonEmployeeDelete
            // 
            this.simpleButtonEmployeeDelete.CausesValidation = false;
            this.simpleButtonEmployeeDelete.Location = new System.Drawing.Point(590, 3);
            this.simpleButtonEmployeeDelete.Name = "simpleButtonEmployeeDelete";
            this.simpleButtonEmployeeDelete.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEmployeeDelete.TabIndex = 3;
            this.simpleButtonEmployeeDelete.Text = "删除";
            this.simpleButtonEmployeeDelete.Click += new System.EventHandler(this.simpleButtonEmployeeDelete_Click);
            // 
            // textEditUsername
            // 
            this.textEditUsername.EnterMoveNextControl = true;
            this.textEditUsername.Location = new System.Drawing.Point(194, 4);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Properties.ValidateOnEnterKey = true;
            this.textEditUsername.Size = new System.Drawing.Size(118, 20);
            this.textEditUsername.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(160, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "姓名:";
            // 
            // textEditEmplcode
            // 
            this.textEditEmplcode.CausesValidation = false;
            this.textEditEmplcode.EnterMoveNextControl = true;
            this.textEditEmplcode.Location = new System.Drawing.Point(37, 4);
            this.textEditEmplcode.Name = "textEditEmplcode";
            this.textEditEmplcode.Properties.ValidateOnEnterKey = true;
            this.textEditEmplcode.Size = new System.Drawing.Size(118, 20);
            this.textEditEmplcode.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "工号:";
            // 
            // gridControlUserRole
            // 
            this.gridControlUserRole.CausesValidation = false;
            this.gridControlUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUserRole.Location = new System.Drawing.Point(0, 0);
            this.gridControlUserRole.MainView = this.gridViewUserRole;
            this.gridControlUserRole.Name = "gridControlUserRole";
            this.gridControlUserRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkValueItemCheckEdit});
            this.gridControlUserRole.Size = new System.Drawing.Size(296, 686);
            this.gridControlUserRole.TabIndex = 7;
            this.gridControlUserRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserRole});
            // 
            // gridViewUserRole
            // 
            this.gridViewUserRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheckValue,
            this.gridColumnRolename,
            this.gridColumnRoledesc});
            this.gridViewUserRole.GridControl = this.gridControlUserRole;
            this.gridViewUserRole.Name = "gridViewUserRole";
            this.gridViewUserRole.OptionsView.ShowGroupPanel = false;
            this.gridViewUserRole.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewUserRole_CellValueChanging);
            // 
            // colCheckValue
            // 
            this.colCheckValue.Caption = "选择";
            this.colCheckValue.ColumnEdit = this.checkValueItemCheckEdit;
            this.colCheckValue.FieldName = "CheckValue";
            this.colCheckValue.Name = "colCheckValue";
            this.colCheckValue.Visible = true;
            this.colCheckValue.VisibleIndex = 0;
            this.colCheckValue.Width = 28;
            // 
            // checkValueItemCheckEdit
            // 
            this.checkValueItemCheckEdit.AutoHeight = false;
            this.checkValueItemCheckEdit.Name = "checkValueItemCheckEdit";
            this.checkValueItemCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridColumnRolename
            // 
            this.gridColumnRolename.Caption = "角色名";
            this.gridColumnRolename.FieldName = "Rolename";
            this.gridColumnRolename.Name = "gridColumnRolename";
            this.gridColumnRolename.OptionsColumn.AllowEdit = false;
            this.gridColumnRolename.Visible = true;
            this.gridColumnRolename.VisibleIndex = 1;
            this.gridColumnRolename.Width = 98;
            // 
            // gridColumnRoledesc
            // 
            this.gridColumnRoledesc.Caption = "角色描述";
            this.gridColumnRoledesc.FieldName = "Roledesc";
            this.gridColumnRoledesc.Name = "gridColumnRoledesc";
            this.gridColumnRoledesc.OptionsColumn.AllowEdit = false;
            this.gridColumnRoledesc.Visible = true;
            this.gridColumnRoledesc.VisibleIndex = 2;
            this.gridColumnRoledesc.Width = 181;
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 686);
            this.Controls.Add(this.splitContainerControlEmployee);
            this.Name = "UserEditForm";
            this.Text = "用户信息修改";
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernameItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpasswordItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlEmployee)).EndInit();
            this.splitContainerControlEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmplcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValueItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlEmployee;
        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colEmplcode;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colUserpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colSex;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobphone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpladd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEmployeeDelete;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditEmplcode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlUserRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkValueItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRolename;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRoledesc;
        private DevExpress.XtraEditors.TextEdit txtDepartment;
        private DevExpress.XtraEditors.LabelControl lblDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentname;
        private DevExpress.XtraGrid.Columns.GridColumn colJobnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLastchangedate;
        private DevExpress.XtraGrid.Columns.GridColumn colLasteddatenum;
        private DevExpress.XtraGrid.Columns.GridColumn colPowerchanged;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit usernameItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit userpasswordItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox sexItemComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit phoneItemTextEdit;
        private DevExpress.XtraEditors.SimpleButton QuerySimpleButton;
        private DevExpress.XtraEditors.SimpleButton btnRetsetPassword;
    }
}