using FHEC.GC.RBAC;
using GC.Client.Model;
using System;


namespace GC.Client.RBAC
{
    /// <summary>
    /// 员工角色关联
    /// </summary>
    public class EmpltoroleClient
    {
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        public EmpltoroleClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;

        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="role"></param>
        public void Save(Employee employee, Role role)
        {
            try
            {
                if (employee.Sysid == null)
                    throw new Exception("此员工未保存");
                if (role.Sysid == null)
                    throw new Exception("此角色未指定");
                //if (null != rightsManageSrv.GetEmplRoleByUserAndRoleSysid(employee.Sysid, role.Sysid))
                //    throw new Exception("此员工已经有此角色");
                //rightsManageSrv.AddUserRoleByID(employee.Sysid, role.Sysid);
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="role"></param>
        public void Delete(Employee employee, Role role)
        {
            try
            {
                if (employee.Sysid == null)
                    throw new Exception("此员工未保存");
                if (role.Sysid == null)
                    throw new Exception("此角色未指定");
                //rightsManageSrv.DeleteUserRoleById(employee.Sysid, role.Sysid);
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
            }
        }

        #region IExceptionAction 成员

        private Action<Exception> exceptionAction;

        public Action<Exception> ExceptionAction
        {
            get
            {
                return exceptionAction;
            }
            set
            {
                if (ReferenceEquals(value, exceptionAction) == false)
                    exceptionAction = value;
            }
        }

        private void OnExceptionAction(Exception ex)
        {
            if (this.exceptionAction != null)
                exceptionAction(ex);
        }

        #endregion
    }
}
