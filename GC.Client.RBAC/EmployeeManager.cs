using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GC.Client.RBAC
{
    public static class EmployeeManager
    {
        /// <summary>
        /// 检查是否员工编号重复

        /// </summary>
        /// <param name="emplcode"></param>
        /// <returns></returns>
        public static bool IsUnique(this RightManagerBase<Employee> employeeManager, string usercode)
        {
            if (usercode == null)
                return true;
            int count = employeeManager.BindingList.Count(m => m.Emplcode == usercode.Trim());
            if (count > 0)
            {
                return false;
            }
            return true;
        }

        public static void GetEmployeeListByParam(this RightManagerBase<Employee> employeeManager, string username, string usercode, string Departmentname)
        {
            try
            {
                IList<Employee> employeeList;
                ((EmployeeClient)employeeManager.RightsClient).GetListByParam(username, usercode, Departmentname, out employeeList);
                employeeManager.BindingList = new BindingList<Employee>(employeeList.ToList());
            }
            catch (Exception ex)
            {
                employeeManager.ExceptionAction(ex);
            }
        }
    }
}
