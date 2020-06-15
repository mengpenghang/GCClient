using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GC.Client.RBAC
{
    internal abstract class PowerClientBase<T> where T : IPower
    {
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        protected string roleSysid;

        protected BindingList<T> bindingList;

        protected RolepowerClient rolepowerClient = null;

        public BindingList<T> BindingList
        {
            get { return bindingList; }
            set { bindingList = value; }
        }

        public PowerClientBase(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;
            rolepowerClient = new RolepowerClient(_rightsUploadService, _rightsQueryService);
        }

        public void PropertyValueChanged(T item, String fieldName)
        {
            try
            {
                if (fieldName == "CheckValue")
                {
                    if (item.CheckValue == true)
                    {
                        Checked(item);
                        this.bindingList.ResetBindings();
                    }
                    else
                    {
                        UnChecked(item);
                        this.bindingList.ResetBindings();
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                item.Check(!item.CheckValue);
                ExceptionAction(ex);
            }

        }

        protected abstract void Checked(T item);

        protected abstract void UnChecked(T item);

        private void Modify(string powerSysid, bool isShow)
        {
            //Rolepower rolepower = rightManager.GetRolePowerByRoleAndPowerSysid(roleSysid, powerSysid);
            //if (rolepower == null)
            //{
            //    XtraMessageBox.Show("此角色没有此权限", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //rolepower.Isshow = isShow.ToString();
            //if (0 != rightManager.ModifyRolePower(rolepower))
            //    XtraMessageBox.Show("修改数据失败");
        }

        public void RefreshData(string roleSysid, IList<Rolepower> rolepowerList, string powertype)
        {
            this.roleSysid = roleSysid;
            if (roleSysid == null)
            {
                bindingList = null;
                return;
            }
            bindingList = new BindingList<T>(SendGetList());
            IEnumerable<Rolepower> rolepowerEnumerable = rolepowerList.Where(i => i.Powertype == powertype);
            var qurey = from r in rolepowerList
                        from p in bindingList
                        where r.Powertype == powertype && p.Sysid == r.Powersysid
                        select new { r, p };
            foreach (var item in qurey)
            {
                item.p.Check(true);
            }
        }

        protected abstract IList<T> SendGetList();

        private IEnumerable<Rolepower> PowerEnumerable(IList<Rolepower> rolepowerList, string powertype)
        {
            return rolepowerList.Where(i => i.Powertype == powertype);
        }

        #region 

        protected Action<Exception> exceptionAction = null;

        public Action<Exception> ExceptionAction
        {
            get { return exceptionAction; }
            set
            {
                if (ReferenceEquals(value, exceptionAction) == false)
                {
                    exceptionAction = value;
                }
            }
        }

        protected void OnExceptionAction(Exception ex)
        {
            if (exceptionAction != null)
                exceptionAction(ex);
        }

        #endregion

    }
}
