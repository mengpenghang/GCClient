using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Base;
using GC.Client.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GC.Client.RBAC
{
    public partial class UserEditForm : DevExpress.XtraEditors.XtraForm, IAppForm
    {
        //IRightsManageSrv rightsManageSrv = ServiceFactory.GetService<IRightsManageSrv>();
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        private readonly RightManagerBase<Employee> employeeManager = null;
        private readonly EmpltoroleClient empltoroleClient = null;

        public UserEditForm()
        {
            InitializeComponent();
            //employeeManager = new RightManagerBase<Employee>(_rightsUploadService, _rightsQueryService, new EmployeeClient(_rightsUploadService, _rightsQueryService));
            //employeeManager.ExceptionAction = ExceptionAction;
            //empltoroleClient = new EmpltoroleClient(_rightsUploadService, _rightsQueryService);
            //empltoroleClient.ExceptionAction = ExceptionAction;
        }

        public UserEditForm(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            InitializeComponent();
            this._rightsUploadService = _rightsUploadService;
            this._rightsQueryService = _rightsQueryService;
            employeeManager = new RightManagerBase<Employee>(_rightsUploadService, _rightsQueryService, new EmployeeClient(_rightsUploadService, _rightsQueryService));
            employeeManager.ExceptionAction = ExceptionAction;
            empltoroleClient = new EmpltoroleClient(_rightsUploadService, _rightsQueryService);
            empltoroleClient.ExceptionAction = ExceptionAction;
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            InitUserRole();
        }


        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void QuerySimpleButton_Click(object sender, EventArgs e)
        {
            employeeManager.GetEmployeeListByParam(textEditUsername.Text.Trim(),textEditEmplcode.Text.Trim(),txtDepartment.Text.Trim());
            gridControlEmployee.DataSource = employeeManager.BindingList;
            if (employeeManager.BindingList.Count == 1)
                RefreshRoleData(employeeManager.BindingList[0]);
        }

        #region 员工

        /// <summary>
        /// 删除数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonEmployeeDelete_Click(object sender, EventArgs e)
        {
            CurrentEmployeeAction(employee =>
            {
                if (DialogResult.No == XtraMessageBox.Show("是否确认删除", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    return;
                employeeManager.Delete(employee);
            });
        }

        private void gridViewEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrentEmployeeAction(RefreshRoleData);
        }

        /// <summary>
        /// 当前employee数据操作
        /// </summary>
        /// <param name="action"></param>
        private void CurrentEmployeeAction(Action<Employee> action)
        {
            Employee employee = gridViewEmployee.GetFocusedRow() as Employee;
            if (employee == null)
                return;
            action(employee);
        }

        #endregion

        #region 权限
        private BindingList<Role> bindingListRole = null;

        public void InitUserRole()
        {
            bindingListRole = new BindingList<Role>();
            gridControlUserRole.DataSource = bindingListRole;
        }


        public void CheckValue(Employee employee, Role role)
        {
            if (employee == null || role == null)
                return;
           // empltoroleClient.Save(employee, role);
        }

        public void UnCheckValue(Employee employee, Role role)
        {
            if (employee == null || role == null)
                return;
            //empltoroleClient.Delete(employee, role);
        }

        private void gridViewUserRole_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CurrentEmployeeAction(employee =>
            {
                Role role = gridViewUserRole.GetFocusedRow() as Role;
                if (role == null)
                    return;
                if (e.Column.FieldName == "CheckValue")
                {
                    bool checkValue = (bool)e.Value;
                    if (checkValue == true)
                        CheckValue(employee, role);
                    else
                        UnCheckValue(employee, role);
                }
            });
        }

        public void RefreshRoleData(Employee employee)
        {
            this.bindingListRole.Clear();
            if (employee.Sysid == null)
                return;
            //IList<Role> roleList = rightsManageSrv.GetRoleList();
            //IList<Empltorole> empltoroleList = rightsManageSrv.GetEmpltoroleByEmployee(employee);
            //if (empltoroleList == null)
            //    return;
            //foreach (var item in roleList)
            //{
            //    if (empltoroleList.Count(e => e.Roleid == item.Sysid) > 0)
            //        item.CheckValue = true;
            //    bindingListRole.Add(item);
            //}
        }
        #endregion

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = false;
            base.OnClosing(e);
        }

        private void gridViewEmployee_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewEmployee.FocusedColumn.FieldName == "Username" ||
                gridViewEmployee.FocusedColumn.FieldName == "Userpassword")
            {
                if (e.Value == null || (e.Value as string) == "")
                    e.Valid = false;
                e.ErrorText = "不能为空";
            }
        }

        private void btnRetsetPassword_Click(object sender, EventArgs e)
        {
            string strNewPassword;
            string strUserName = gridViewEmployee.GetRowCellValue(gridViewEmployee.FocusedRowHandle, "Emplcode").ToString();

            if (gridViewEmployee.FocusedRowHandle < 0)
                return;
            //Employee employee = rightsManageSrv.GetUserByCode(strUserName);
            //if (employee == null)
            //{
            //    XtraMessageBox.Show("无效的工号");
            //    return;
            //}
            strNewPassword = "123456";

            try
            {
                //if (true == rightsManageSrv.ChangePassWord(employee.Emplcode, employee.Userpassword, strNewPassword))
                //{
                //    this.DialogResult = DialogResult.OK;
                //    XtraMessageBox.Show("密码重置成功,新密码:123456 ");
                //}
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
        }

        private void gridViewEmployee_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CurrentEmployeeAction(employee =>
            {
                employeeManager.PropertyValueChange(employee, e.Column.FieldName);
            });
        }
    }
}
