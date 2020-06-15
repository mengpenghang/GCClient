using FHEC.GC.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GC.Model
{
    public class RightManageC
    {
        public EmployeeDto employee { get; set; }
        //[DataMember]
        //public IList<Vuserrole> vuserroleList { get; set; }
        public IList<VusermenuDto> vusermenuList { get; set; }
        //[DataMember]
        //public IList<Vuserrule> vuserruleList { get; set; }
        //[DataMember]
        //public IList<Vuserbutton> vuserbuttonList { get; set; }
        //[DataMember]
        //public IList<Vuserresource> vuserresourceList { get; set; }
        //[DataMember]
        //public IList<Vusercolumn> vusercolumnList { get; set; }
        public RightManageC()
        {
            employee = new EmployeeDto();
            //vuserroleList = new List<Vuserrole>();
            vusermenuList = new List<VusermenuDto>();
            //vuserruleList = new List<Vuserrule>();
            //vuserbuttonList = new List<Vuserbutton>();
            //vuserresourceList = new List<Vuserresource>();
            //vusercolumnList = new List<Vusercolumn>();
        }
    }
}
