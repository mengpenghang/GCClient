using FHEC.GC.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC.Client.Model
{
    public partial class Resbutton : ResbuttonDto,IPower
    {
        private bool checkValue;

        public bool CheckValue
        {
            get { return checkValue; }
            set
            {
              
                    checkValue = value;
                
            }
        }


        #region IPower 成员


        public void Check(bool checkValue)
        {
            this.checkValue = checkValue;
        }
        #endregion
    }
}
