using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GC.Client.RBAC
{
    public class RightManagerBase<T> where T : IRight
    {
        private BindingList<T> bindingList = null;

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        //IRightsManageSrv rightsManagerSrv = null;

        private readonly RightsClientBase<T> rightsClient = null;

        public RightsClientBase<T> RightsClient
        {
            get { return rightsClient; }
        }

        public BindingList<T> BindingList
        {
            get { return bindingList; }
            set { bindingList = value; }
        }

        public RightManagerBase(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService, RightsClientBase<T> rightsClient)
        {
            this._rightsUploadService = _rightsUploadService;
            this._rightsQueryService = _rightsQueryService;
            this.rightsClient = rightsClient;
            bindingList = new BindingList<T>();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PropertyValueChange(T item, String fieldName)
        {
            try
            {
                if (item == null)
                    return;
                if (fieldName == "Sysid")
                {
                    return;
                }
                if (item.Sysid != null)
                    rightsClient.Modify(item);
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        public void Add()
        {
            this.bindingList.AddNew();
        }

        public void Add(T item)
        {
            bindingList.Add(item);
        }



        public bool Save(T item)
        {
            try
            {
                rightsClient.Save(item);
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Delete(T item)
        {
            try
            {
                rightsClient.Delete(item);
                this.bindingList.Remove(item);
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
                return false;
            }
            return true;
        }

        public void RedfreshData()
        {
            try
            {
                IList<T> itemList;
                rightsClient.GetList(out itemList);
                if (bindingList != null)
                    this.bindingList = new BindingList<T>(itemList.ToList());
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
                {
                    exceptionAction = value;
                }
            }
        }

        /// <summary>
        /// 处理错误信息
        /// </summary>
        /// <param name="ex"></param>
        private void OnExceptionAction(Exception ex)
        {
            if (exceptionAction != null)
                exceptionAction(ex);
        }

        #endregion

        #region 刷新子表数据

        private Action<EmployeeDto> employeeSaved;

        public Action<EmployeeDto> EmployeeSaved
        {
            get { return employeeSaved; }
            set
            {
                if (ReferenceEquals(value, employeeSaved) == false)
                {
                    employeeSaved = value;
                }
            }
        }

        private void OnEmployeeSaved(EmployeeDto employee)
        {
            if (employeeSaved != null)
            {
                employeeSaved(employee);
            }
        }

        #endregion
    }
}
