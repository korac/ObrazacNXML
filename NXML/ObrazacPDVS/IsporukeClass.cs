using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class IsporukeClass
    {
        public string RedBr { get; set; }
        public string KodDrzave { get; set; }
        public string PDVID { get; set; }
        public string I1 { get; set; }
        public string I2 { get; set; }

        public IsporukeClass(string redBr = "", string kodDrzave = "", string pdvid = "", string i1 = "", string i2 = "")
        {
            this.RedBr      = redBr;
            this.KodDrzave  = kodDrzave;
            this.PDVID      = pdvid;
            this.I1         = i1;
            this.I2         = i2;
        }
    }
}
