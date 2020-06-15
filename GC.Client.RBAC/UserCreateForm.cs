using DevExpress.XtraEditors;
using FHEC.GC.RBAC;
using GC.Client.Base;
using GC.Client.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;
//using MESClient.WCFClient.DieStorSrv;

namespace GC.Client.RBAC
{
    public partial class UserCreateForm : XtraForm, IAppForm
    {
        private readonly RightManagerBase<Employee> employeeManager = null;
        private readonly EmpltoroleClient empltoroleClient = null;
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public UserCreateForm()
        {
            InitializeComponent();
        }

        public UserCreateForm(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
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
            InitEmployeeControl();
        }


        private void ExceptionAction(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region 员工

        /// <summary>
        /// 登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitEmployeeControl()
        {
            gridControlEmployee.DataSource = _rightsQueryService.GetAllUserAsync().GetAwaiter().GetResult().rows;
        }


        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == false)
                return;

            decimal? telephone = textEditEmplcode.EditValue as decimal?;
            decimal? mobphone = textEditMobphone.EditValue as decimal?;
            Employee employee = new Employee(
                                    txtDepartment.Text,
                                    textEditEmplcode.Text,
                                    textEditUsername.Text,
                                    PasswordTextEdit.Text,
                                    comboBoxEditSex.Text,
                                    textEditTelephone.Text.ToString(),
                                    textEditMobphone.Text.ToString(),
                                    textEditEmpladd.Text,
                                    Convert.ToInt32(txtLastedDate.Text.Trim())); ;
            if (employeeManager.Save(employee))
            {
                employeeManager.Add(employee);
            }
            gridControlEmployee.DataSource = _rightsQueryService.GetAllUserAsync().GetAwaiter().GetResult().rows;
        }

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
            empltoroleClient.Save(employee, role);
        }

        public void UnCheckValue(Employee employee, Role role)
        {
            if (employee == null || role == null)
                return;
            empltoroleClient.Delete(employee, role);
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

        /// <summary>
        /// 验证编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditEmplcode_Validating(object sender, CancelEventArgs e)
        {
            textEdit_Validating(sender, e);
            try
            {

                return;
            }
            catch (Exception ex)
            {
                ExceptionAction(ex);
            }
        }

        /// <summary>
        /// 开始验证

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEdit_Validating(object sender, CancelEventArgs e)
        {
            TextEdit textEdit = sender as TextEdit;
            if (textEdit == null)
                return;
            if (textEdit.Text.Trim() == string.Empty || textEdit.Text.Trim() == null)
            {
                textEdit.ErrorText = "不能为空";
                textEdit.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                e.Cancel = true;
            }
        }

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

        public new bool ValidateChildren()
        {
            SetChildrenCauseValidation(true);
            bool value = base.ValidateChildren();
            SetChildrenCauseValidation(false);
            return value;
        }

        public void SetChildrenCauseValidation(bool value)
        {
            textEditEmplcode.CausesValidation = value;
            PasswordTextEdit.CausesValidation = value;
        }

        private void textEditEmplcode_Properties_Leave(object sender, EventArgs e)
        {
            string stremplcode = textEditEmplcode.Text.Trim();
            //Worker worker = MESClientData.GetWcfClient().GetDieStorSrv().GetWorkerInfo(textEditEmplcode.Text.Trim());
            //if (null != worker)
            //{
            if (stremplcode.Length < 5)
                stremplcode = stremplcode.PadLeft(5, '0');
            textEditEmplcode.Text = stremplcode;
            //textEditUsername.Text = worker.Name;
            //txtDepartment.Text = worker.Deptname;
            PasswordTextEdit.Focus();
            PasswordTextEdit.SelectAll();
            // }
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
