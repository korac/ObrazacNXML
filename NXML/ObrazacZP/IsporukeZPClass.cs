using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class IsporukeZPClass
    {
        #region Properties
        public string RedBr { get; set; }
        public string KodDrzave { get; set; }
        public string PDVID { get; set; }
        public string I1 { get; set; }
        public string I2 { get; set; }
        public string I3 { get; set; }
        public string I4 { get; set; }
        #endregion

        public IsporukeZPClass(string redbr = "", string kodDrz = "", string pdvid = "", string i1 = "", string i2 = "", string i3 = "", string i4 = "")
        {
            this.RedBr      = redbr;
            this.KodDrzave  = kodDrz;
            this.PDVID      = pdvid;
            this.I1         = i1;
            this.I2         = i2;
            this.I3         = i3;
            this.I4         = i4;
        }
    }
}
