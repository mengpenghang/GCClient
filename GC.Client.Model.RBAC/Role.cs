using FHEC.GC.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC.Client.Model
{
   public partial class Role : RoleDto,IRight
    {

        public Role(string rolename, string roledesc)
        {
            this.Rolename = rolename;
            this.Roledesc = roledesc;
        }

        private bool checkValue;

        public bool CheckValue
        {
            get { return checkValue; }
            set 
            {
              
                    checkValue = value;
                
            }
        }

    }
}
