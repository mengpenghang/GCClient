using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GC.Client.Model
{
    public interface IPower:IRight
    {
        bool CheckValue { get; set; }
        void Check(bool checkValue);
    }
}
