using FHEC.GC.RBAC;
using GC.Client.Model;
using System.Collections.Generic;

namespace GC.Client.RBAC
{
    internal class RestablecolumnClient : PowerClientBase<Restablecolumn>
    {

        public RestablecolumnClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
            : base(_rightsUploadService, _rightsQueryService)
        {

        }

        protected override void Checked(Restablecolumn item)
        {
            //rightManager.AddRolePowerById(roleSysid, item.Sysid, "字段", "True");
        }

        protected override void UnChecked(Restablecolumn item)
        {
            //rightManager.DeleteRolePowerById(roleSysid, item.Sysid);
        }

        protected override IList<Restablecolumn> SendGetList()
        {
            //return rightManager.GetResColumnList();
            return null;
        }
    }
}
