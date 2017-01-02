using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class ObrazacPPOArgs
    {
        #region Properties
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public string Datum { get; set; }
        public string Format { get; set; }
        public string Jezik { get; set; }
        public string Identifikator { get; set; }
        public string Uskladjenost { get; set; }
        public string Tip { get; set; }
        public string Adresant { get; set; }


        public string DatumOd { get; set; }
        public string DatumDo { get; set; }
        private int tromjesecje;
        public int Tromjesecje {
            get { return tromjesecje; }
            set {
                    if(value != 0)
                    {
                        if (value < 1 || value > 4)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }    
                    tromjesecje = value;
                }
        }
        public string Godina { get; set; }
        public string Naziv { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ispostava { get; set; }
        public string Ukupno { get; set; }

        public List<IsporukePPOClass> isporukePPOList { get; set; }
        #endregion

        public ObrazacPPOArgs()
        {
            this.Naslov         = String.Empty;
            this.Autor          = String.Empty;
            this.Datum          = String.Empty;
            this.Format         = String.Empty;
            this.Jezik          = String.Empty;
            this.Identifikator  = String.Empty;
            this.Uskladjenost   = String.Empty;
            this.Tip            = String.Empty;
            this.Adresant       = String.Empty;

            this.DatumOd        = String.Empty;
            this.DatumDo        = String.Empty;
            this.Tromjesecje    = 0;
            this.Godina         = String.Empty;
            this.Naziv          = String.Empty;
            this.OIB            = String.Empty;
            this.Adresa         = String.Empty;
            this.Mjesto         = String.Empty;
            this.Ulica          = String.Empty;
            this.BrojUlice      = String.Empty;
            this.Ime            = String.Empty;
            this.Prezime        = String.Empty;
            this.Ispostava      = String.Empty;
            this.Ukupno         = String.Empty;
        }

        public void DodajPPOIsporuku(IsporukePPOClass isp)
        {
            try
            {
                if(isporukePPOList == null)
                {
                    isporukePPOList = new List<IsporukePPOClass>();
                }
                isporukePPOList.Add(isp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška kod dodavanja isporuke: " + ex.Message);
            }
        }
    }
}
