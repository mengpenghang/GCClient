using FHEC.GC.RBAC;
using GC.Client.Model;
using System.Collections.Generic;

namespace GC.Client.RBAC
{
    internal class ResButtonClient : PowerClientBase<Resbutton>
    {
        public ResButtonClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
            : base(_rightsUploadService, _rightsQueryService)
        { }


        protected override void Checked(Resbutton item)
        {
            //rightManager.AddRolePowerById(this.roleSysid, item.Sysid, "按键", "True");
        }


        protected override void UnChecked(Resbutton item)
        {
            //rightManager.DeleteRolePowerById(roleSysid, item.Sysid);
        }

        protected override IList<Resbutton> SendGetList()
        {
            //return rightManager.GetResButtonList();
            return null;
        }
    }
}
