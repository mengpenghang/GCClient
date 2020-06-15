using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;


namespace GC.Client.RBAC
{
    internal class MenuinfoClient : RightsClientBase<Menuinfo>
    {
        public MenuinfoClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
            : base(_rightsUploadService, _rightsQueryService)
        { }

        protected override void SendDelete(Menuinfo item)
        {

        }

        protected override string SendSave(Menuinfo item)
        {
            throw new NotImplementedException();
        }

        protected override void SendModify(Menuinfo item)
        {
            throw new NotImplementedException();
        }

        protected override IList<Menuinfo> SendGetList()
        {
            throw new NotImplementedException();
        }
    }
}
