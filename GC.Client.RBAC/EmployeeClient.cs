using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GC.Client.RBAC
{
    public class EmployeeClient : RightsClientBase<Employee>
    {
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public EmployeeClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
            : base(_rightsUploadService, _rightsQueryService)
        {
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected override string SendSave(Employee item)
        {
            if (null != _rightsQueryService.GetUserByLoginName(item.Emplcode))
                throw new Exception("此编号员工已经存在");
            Employee employee = (Employee)_rightsUploadService.CreateUserAsync(item).GetAwaiter().GetResult();
            return employee.Sysid;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="item"></param>
        protected override void SendModify(Employee item)
        {
            _rightsUploadService.ModifyUserAsync(item).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="item"></param>
        protected override void SendDelete(Employee item)
        {
            _rightsUploadService.DeleteUserAsync(item).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取批量数据
        /// </summary>
        /// <returns></returns>
        protected override IList<Employee> SendGetList()
        {
            return (IList<Employee>)_rightsQueryService.GetAllUserAsync().GetAwaiter().GetResult().rows.ToList();
        }

        public void GetListByParam(string username, string usercode, string Departmentname, out IList<Employee> employeeList)
        {
            try
            {
                employeeList = (IList<Employee>)_rightsQueryService.GetUserByParam(username, usercode, Departmentname).rows.ToList(); ;
            }
            catch (Exception ex)
            {
                employeeList = new List<Employee>();
                throw new Exception(ex.Message);
            }
        }
    }
}
