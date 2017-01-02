using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class IsporukePPOClass
    {
        public List<PodaciPPOClass> PodaciList { get; set; }
        public string Iznos { get; set; }
        public string DatumOd { get; set; }
        public string DatumDo { get; set; }

        public IsporukePPOClass(string iznos = "", string datumOd = "", string datumDo = "")
        {
            this.Iznos      = iznos;
            this.DatumOd    = datumOd;
            this.DatumDo    = datumDo;
        }

        public void DodajPodatak(PodaciPPOClass podatak)
        {
            try
            {
                if(PodaciList == null)
                {
                    PodaciList  = new List<PodaciPPOClass>();
                }
                PodaciList.Add(podatak);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška kod dodavanja podataka: " + ex.Message);
            }
        }
    }
}
