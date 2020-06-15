using FHEC.GC.RBAC;
using GC.Client.Model;
using System.Collections.Generic;

namespace GC.Client.RBAC
{
    internal class MenuinfoPowerClient : PowerClientBase<Menuinfo>
    {

        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;
        public MenuinfoPowerClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
            : base(_rightsUploadService, _rightsQueryService)
        {
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;
        }


        protected override void Checked(Menuinfo item)
        {
           //rightManager.AddRolePowerById(roleSysid, item.Sysid, "菜单", "True");
        }

        protected override void UnChecked(Menuinfo item)
        {

            //rightManager.DeleteRolePowerById(roleSysid, item.Sysid);
        }

        protected override IList<Menuinfo> SendGetList()
        {
            //return rightManager.GetMenuList();
            return null;
        }
    }
}
