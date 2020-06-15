using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;

namespace GC.Client.RBAC
{
    public abstract class RightsClientBase<T> where T : IRight
    {
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public RightsClientBase(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Save(T item)
        {
            try
            {
                if (item.Sysid != "")
                    throw new Exception("数据已经保存");
                item.Sysid = SendSave(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }


        protected abstract string SendSave(T item);

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="employee"></param>
        public bool Modify(T item)
        {
            try
            {
                if (item.Sysid == null)
                    throw new Exception("员工数据未保存");
                SendModify(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }


        protected abstract void SendModify(T item);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Delete(T item)
        {
            try
            {
                if (item.Sysid == "")
                    throw new Exception("此数据未保存");
                SendDelete(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        protected abstract void SendDelete(T item);

        public bool GetList(out IList<T> itemList)
        {
            try
            {
                itemList = SendGetList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        protected abstract IList<T> SendGetList();
    }
}
