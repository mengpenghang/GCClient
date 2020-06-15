using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FHEC.GC.Contract;
using FHEC.GC.RBAC;
using GC.Client.Model;

namespace GC.Client.Model
{
    public partial class Employee : EmployeeDto, IRight
    {
        public Employee()
        { }

        public Employee(string strDepartment,string emplcode, string username, string userpassword, 
                        string sex, string telephone, string mobphone, string empladd, int days)
        {
            this.Emplcode= emplcode;
            this.Username= username;
            this.Userpassword= userpassword;
            this.Sex= sex;
            this.Telephone= telephone;
            this.Mobphone= mobphone;
            this.Empladd= empladd;
            this.Departmentname = strDepartment;
            this.Jobnumber = emplcode;
            this.Lastchangedate = DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss");
            this.Lasteddatenum = days;
        }

        public void SetScmtimestamp(decimal scmtimestamp)
        {
            this.Ts= Convert.ToInt64(scmtimestamp);
        }

        public void InitSysid(string sysid)
        {
            if (this.Sysid== null)
                this.Sysid= sysid;
        }

        /// <summary>
        /// 判断是否在线
        /// </summary>
        public bool IsOnLine
        {
            get
            {
                if (Isline== "未在线")
                    return false;
                return true;
            }
        }

        /// <summary>
        /// 下线
        /// </summary>
        public void Offline()
        {
            this.Isline= "未在线";
        }
    }
}
