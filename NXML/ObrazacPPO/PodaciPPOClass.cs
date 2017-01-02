using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class PodaciPPOClass
    {
        public string RedniBroj { get; set; }
        public string OIB { get; set; }
        public string Iznos { get; set; }

        public PodaciPPOClass(string redBroj = "", string oib = "", string iznos = "")
        {
            this.RedniBroj  = redBroj;
            this.OIB        = oib;
            this.Iznos      = iznos;
        }
    }
}
