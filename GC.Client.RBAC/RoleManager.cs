using GC.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GC.Client.RBAC
{
    public static class RoleManager
    {
        public static void GetListByParam(this RightManagerBase<Role> roleManager, string rolename)
        {
            try
            {
                IList<Role> roleList;
                ((RoleClient)roleManager.RightsClient).GetListByParam(rolename, out roleList);
                roleManager.BindingList = new System.ComponentModel.BindingList<Role>(roleList.ToList());
            }
            catch (Exception ex)
            {
                roleManager.ExceptionAction(ex);
            }
        }
    }
}
