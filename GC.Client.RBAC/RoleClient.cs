using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;


namespace GC.Client.RBAC
{
    public class RoleClient : RightsClientBase<Role>
    {

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        public RoleClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
           : base(_rightsUploadService, _rightsQueryService)
        {

        }

        protected override void SendModify(Role item)
        {
            //IRightsUploadServicePrx.ModifyRole(item);
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="item"></param>
        protected override void SendDelete(Role item)
        {
            //rightsManageSrv.DeleteRole(item.Sysid);
        }

        /// <summary>
        /// 获取批量数据
        /// </summary>
        /// <returns></returns>
        protected override IList<Role> SendGetList()
        {
            //return rightsManageSrv.GetRoleList();
            return null;
        }

        protected override string SendSave(Role item)
        {
            //return rightsManageSrv.CreateRole(item);
            return "";
        }

        public void GetListByParam(string rolename, out IList<Role> roleList)
        {
            try
            {
                //roleList = rightsManageSrv.GetRoleListByParam(rolename);
                roleList = new List<Role>();
            }
            catch (Exception ex)
            {
                roleList = new List<Role>();
                throw new Exception(ex.Message);
            }
        }

    }
}
