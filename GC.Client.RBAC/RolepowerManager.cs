using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GC.Client.RBAC
{
    public class RolepowerManager
    {
        //protected IRightsManageSrv rightManager;

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        protected Role role;

        protected string powerType;

        protected BindingList<IPower> bindingList;

        protected RolepowerClient rolepowerClient = null;
        private readonly RightsClientBase<IPower> powerClient;

        public BindingList<IPower> BindingList
        {
            get { return bindingList; }
            set { bindingList = value; }
        }

        public RolepowerManager(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService, RightsClientBase<IPower> powerClient)
        {
            this._rightsUploadService = _rightsUploadService;
            this._rightsQueryService = _rightsQueryService;
            rolepowerClient = new RolepowerClient(_rightsUploadService, _rightsQueryService);
            this.powerClient = powerClient;
        }

        private void menuinfoBindingList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.NewIndex < 0)
                return;
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                IPower item = this.bindingList[e.NewIndex];
                if (e.PropertyDescriptor != null && e.PropertyDescriptor.Name == "CheckValue")
                {
                    if (item.CheckValue == true)
                    {
                        if (Checked(item) == false)
                        {
                            item.Check(false);
                            this.bindingList.ResetBindings();
                        }
                    }
                    else
                    {
                        if (UnChecked(item) == false)
                        {
                            item.Check(true);
                            this.bindingList.ResetBindings();
                        }
                    }
                    return;
                }
            }
        }

        protected bool Checked(IPower item)
        {
            try
            {
                //rolepowerClient.Save(role, item, powerType);
                return true;
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
                return false;
            }
        }

        protected bool UnChecked(IPower item)
        {
            try
            {
                //rolepowerClient.Delete(role, item);
                return true;
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
                return false;
            }
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="role"></param>
        /// <param name="powertype"></param>
        public void RefreshData(Role role, string powertype)
        {
            try
            {
                this.role = role;
                this.powerType = powertype;
                if (role.Sysid == null)
                {
                    throw new Exception("角色未保存");
                }
                if (bindingList != null)
                    bindingList.ListChanged -= new ListChangedEventHandler(menuinfoBindingList_ListChanged);
                IList<IPower> powerList;
                powerClient.GetList(out powerList);
                bindingList = new BindingList<IPower>(powerList);
                bindingList.ListChanged += new ListChangedEventHandler(menuinfoBindingList_ListChanged);
                Merge();
            }
            catch (Exception ex)
            {
                OnExceptionAction(ex);
            }
        }

        private void Merge()
        {
            IList<Rolepower> rolepowerList;
            //rolepowerClient.GetListByRole(role, out rolepowerList);

            //IEnumerable<Rolepower> rolepowerEnumerable = rolepowerList.Where(i => i.Powertype == powerType);
            //var qurey = from r in rolepowerList
            //            from p in bindingList
            //            where r.Powertype == powerType && p.Sysid == r.Powersysid
            //            select new { r, p };
            //foreach (var item in qurey)
            //{
            //    item.p.Check(true);
            //}
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
