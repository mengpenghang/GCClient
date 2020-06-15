using FHEC.GC.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC.Client.Model
{
    public partial class Restablecolumn : RestablecolumnDto,IPower
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

        /// <summary>
        /// 选择
        /// </summary>
        /// <param name="checkValue"></param>
        public void Check(bool checkValue)
        {
            this.checkValue = checkValue;
        }
    }
}
