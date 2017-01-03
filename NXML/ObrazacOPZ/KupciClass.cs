using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class KupciClass
    {
        #region Properties
        public string K1 { get; set; }
        public string K2 { get; set; }
        public string K3 { get; set; }
        public string K4 { get; set; }
        public string K5 { get; set; }
        public string K6 { get; set; }
        public string K7 { get; set; }
        public string K8 { get; set; }
        public string K9 { get; set; }

        public List<RacuniClass> racuniList { get; set; }
        #endregion

        public KupciClass()
        {
            this.K1 = String.Empty;
            this.K2 = String.Empty;
            this.K3 = String.Empty;
            this.K4 = String.Empty;
            this.K5 = String.Empty;
            this.K6 = String.Empty;
            this.K7 = String.Empty;
            this.K8 = String.Empty;
            this.K9 = String.Empty;
        }

        public void DodajRacune(RacuniClass racun)
        {
            try
            {
                if(racuniList == null)
                {
                    racuniList = new List<RacuniClass>();
                }
                racuniList.Add(racun);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
            }
        }
    }
}
