using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Base;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GC.Client.RBAC
{
    public partial class UserRoleCreateForm : DevExpress.XtraEditors.XtraForm, IAppForm
    {

        //IRightsManageSrv rightManageSrv = ServiceFactory.GetService<IRightsManageSrv>();

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        private readonly RightManagerBase<Role> roleManager = null;

        public UserRoleCreateForm()
        {
            InitializeComponent();
            //roleManager = new RightManagerBase<Role>(_rightsUploadService,_rightsQueryService, new RoleClient(_rightsUploadService, _rightsQueryService));
            //roleManager.ExceptionAction = ExceptionAction;
        }

        public UserRoleCreateForm(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            InitializeComponent();
            this._rightsUploadService = _rightsUploadService;
            this._rightsQueryService = _rightsQueryService;
            roleManager = new RightManagerBase<Role>(_rightsUploadService, _rightsQueryService, new RoleClient(_rightsUploadService, _rightsQueryService));
            roleManager.ExceptionAction = ExceptionAction;
        }


        private void UserRoleManageForm_Load(object sender, EventArgs e)
        {
            InitRolepowerControl();
            InitRoleControl();
        }

        /// <summary>
        /// 错误提示框

        /// </summary>
        /// <param name="ex"></param>
        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// TextEdit验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEdit_Validating(object sender, CancelEventArgs e)
        {
            DevExpress.XtraEditors.TextEdit textEdit = sender as DevExpress.XtraEditors.TextEdit;
            if (textEdit == null)
                return;
            if (textEdit.Text == null || textEdit.Text == string.Empty)
            {
                textEdit.ErrorText = "不能为空";
                textEdit.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                e.Cancel = true;
            }
        }

        public override bool ValidateChildren()
        {
            CancelEventArgs e = new CancelEventArgs();
            textEdit_Validating(textEditRoledesc, e);
            textEdit_Validating(textEditRolename, e);
            return !e.Cancel;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = false;
            base.OnClosing(e);
        }

        /// <summary>
        /// 验证GridControl编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewRole_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null || e.Value.ToString().Trim() == string.Empty)
            {
                e.Valid = false;
                e.ErrorText = "不能为空";
            }
        }


        #region 角色

        private void CurrentRoleAction(Action<Role> action)
        {
            Role role = gridViewRole.GetFocusedRow() as Role;
            if (role == null)
                return;
            action(role);
        }

        /// <summary>
        /// 初始化

        /// </summary>
        private void InitRoleControl()
        {
            //this.gridControlRole.DataSource = roleManager.BindingList;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonRoleAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;
            Role role = new Role(textEditRolename.Text, textEditRoledesc.Text);
            if (roleManager.Save(role))
                this.roleManager.Add(role);
            this.ValidateChildren();
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonRoleDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == XtraMessageBox.Show("是否确认删除", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                return;
            CurrentRoleAction(role => roleManager.Delete(role));
        }

        private void gridViewRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            CurrentRoleAction(RefreshRolepowerData);
        }

        private void gridViewRole_ShowingEditor(object sender, CancelEventArgs e)
        {
            CurrentRoleAction(role =>
            {
                if (role.Rolename == "管理员")
                    e.Cancel = true;
            });
        }

        #endregion

        #region 权限

        private void InitRolepowerControl()
        {
            InitMenuinfo();
            InitResbutton();
            InitResscope();
            InitRestable();
        }

        public void RefreshRolepowerData(Role role)
        {
            if (role == null)
                return;
            RefrshCurrentPage(xtraTabControl1.SelectedTabPage, role);
        }

        private void xtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            CurrentRoleAction(role =>
            {
                RefrshCurrentPage(e.Page, role);
            });
        }

        private void RefrshCurrentPage(DevExpress.XtraTab.XtraTabPage page, Role role)
        {

            //IList<Rolepower> rolepowerList = rightManageSrv.GetRolePowerByRoleSysid(role.Sysid);
            //if (rolepowerList == null)
            //    return;
            //if (page.Name == xtraTabPageMenuinfo.Name)
            //    RefreshMenuinfo(rolepowerList, role);
            //if (page.Name == xtraTabPageBtn.Name)
            //    RefreshResbutton(rolepowerList, role);
            //if (page.Name == xtraTabPageRes.Name)
            //    RefreshRespermscope(rolepowerList, role);
            //if (page.Name == xtraTabPageTable.Name)
            //    RefreshRestablecolumn(rolepowerList, role);
        }



        #region 菜单

        private PowerClientBase<Menuinfo> menuinfoPowerClient = null;

        private void InitMenuinfo()
        {
            menuinfoPowerClient = new MenuinfoPowerClient(this._rightsUploadService, this._rightsQueryService);
            menuinfoPowerClient.ExceptionAction = ExceptionAction;
        }

        private void RefreshMenuinfo(IList<Rolepower> rolepowerList, Role role)
        {
            menuinfoPowerClient.RefreshData(role.Sysid, rolepowerList, "菜单");
            treeListMenuInfo.DataSource = menuinfoPowerClient.BindingList;
        }

        private void treeListMenuInfo_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            Menuinfo menuinfo = treeListMenuInfo.GetDataRecordByNode(e.Node) as Menuinfo;
            menuinfoPowerClient.PropertyValueChanged(menuinfo, e.Column.FieldName);
            if (e.Value.ToString() == "True")
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode node = e.Node.ParentNode;
                while (node != null)
                {
                    if (node.GetValue("CheckValue").ToString() == "True")
                    {
                        node = node.ParentNode;
                        continue;
                    }

                    menuinfo = treeListMenuInfo.GetDataRecordByNode(node) as Menuinfo;
                    menuinfo.Check(true);
                    menuinfoPowerClient.PropertyValueChanged(menuinfo, e.Column.FieldName);
                    node.SetValue("CheckValue", true);
                    node = node.ParentNode;

                }
            }
        }



        #endregion

        #region 按钮
        private PowerClientBase<Resbutton> resbuttonClient = null;

        private void InitResbutton()
        {
            resbuttonClient = new ResButtonClient(_rightsUploadService, _rightsQueryService);
            resbuttonClient.ExceptionAction = ExceptionAction;
        }

        private void RefreshResbutton(IList<Rolepower> rolepowerList, Role role)
        {
            resbuttonClient.RefreshData(role.Sysid, rolepowerList, "按键");
            gridControlResButton.DataSource = resbuttonClient.BindingList;
        }

        private void gridViewResButton_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Resbutton resbutton = gridViewResButton.GetFocusedRow() as Resbutton;
            this.resbuttonClient.PropertyValueChanged(resbutton, e.Column.FieldName);
        }

        #endregion

        #region 资源

        private PowerClientBase<Respermscope> respermscopeClient = null;

        private void InitResscope()
        {
            respermscopeClient = new RespermscopeClient(this._rightsUploadService, _rightsQueryService);
            respermscopeClient.ExceptionAction = ExceptionAction;
        }

        private void RefreshRespermscope(IList<Rolepower> rolepowerList, Role role)
        {
            respermscopeClient.RefreshData(role.Sysid, rolepowerList, "资源");
            gridControlResPermScope.DataSource = respermscopeClient.BindingList;
        }

        private void gridViewResPermScope_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Respermscope respermscope = gridViewResPermScope.GetFocusedRow() as Respermscope;
            this.respermscopeClient.PropertyValueChanged(respermscope, e.Column.FieldName);
        }

        #endregion

        #region 表


        private PowerClientBase<Restablecolumn> restablecolumnClient = null;

        private void InitRestable()
        {
            restablecolumnClient = new RestablecolumnClient(_rightsUploadService, _rightsQueryService);
            restablecolumnClient.ExceptionAction = ExceptionAction;
        }

        private void RefreshRestablecolumn(IList<Rolepower> rolepowerList, Role role)
        {
            restablecolumnClient.RefreshData(role.Sysid, rolepowerList, "字段");
            gridControlResTableColumn.DataSource = restablecolumnClient.BindingList;
        }

        private void gridViewRestablecolumn_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Restablecolumn restablecolumn = gridViewResTableColumn.GetFocusedRow() as Restablecolumn;
            this.restablecolumnClient.PropertyValueChanged(restablecolumn, e.Column.FieldName);
        }




        #endregion

        #endregion

        private void gridViewRole_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CurrentRoleAction(role =>
            {
                roleManager.PropertyValueChange(role, e.Column.FieldName);
            });
        }
    }
}
