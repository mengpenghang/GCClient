using FHEC.GC.RBAC;
using GC.Client.Model;
using System;
using System.Collections.Generic;


namespace GC.Client.RBAC
{
    public class RolepowerClient
    {
        private readonly IRightsUploadServicePrx _rightsUploadService;
        private readonly IRightsQueryServicePrx _rightsQueryService;

        public RolepowerClient(IRightsUploadServicePrx _rightsUploadService, IRightsQueryServicePrx _rightsQueryService)
        {
            this._rightsQueryService = _rightsQueryService;
            this._rightsUploadService = _rightsUploadService;
        }

        public bool Delete(Role role, IPower power)
        {
            try
            {
                if (role.Sysid == null)
                    throw new Exception("此角色未保存");
                if (power.Sysid == null)
                    throw new Exception("未指定权限");
                //rightsManagerSrv.DeleteRolePowerById(role.Sysid, power.Sysid);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        public bool Save(Role role, IPower power, string type)
        {
            try
            {
                if (role.Sysid == null)
                    throw new Exception("此角色未保存");
                if (power.Sysid == null)
                    throw new Exception("未指定权限");
                //rightsManagerSrv.AddRolePowerById(role.Sysid, power.Sysid, type, true.ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool GetListByRole(Role role, out IList<Rolepower> rolepowerList)
        {
            try
            {
                if (role.Sysid == null)
                    throw new Exception("此角色未保存");
                //rolepowerList=rightsManagerSrv.GetRolePowerByRoleSysid(role.Sysid);
                rolepowerList = new List<Rolepower>();
                return true;
            }
            catch (Exception ex)
            {
                rolepowerList = new List<Rolepower>();
                throw new Exception(ex.Message);
            }
        }


    }
}
