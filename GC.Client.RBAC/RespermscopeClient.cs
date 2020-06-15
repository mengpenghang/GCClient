using FHEC.GC.RBAC;
using GC.Client.Model;
using System.Collections.Generic;

namespace GC.Client.RBAC
{
    internal class RespermscopeClient : PowerClientBase<Respermscope>
    {
        public RespermscopeClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
            : base(_rightsUploadService, _rightsQueryService)
        {
        }

        protected override void Checked(Respermscope item)
        {
            //rightManager.AddRolePowerById(roleSysid, item.Sysid, "资源","True");
        }


        protected override void UnChecked(Respermscope item)
        {
            //rightManager.DeleteRolePowerById(roleSysid, item.Sysid);
        }

        protected override IList<Respermscope> SendGetList()
        {
            //return rightManager.GetResourceList();
            return null;
        }
    }
}
