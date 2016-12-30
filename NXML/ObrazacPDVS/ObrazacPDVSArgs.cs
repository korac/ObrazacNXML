using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class ObrazacPDVSArgs
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
        public string Naziv { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }
        public string Mjesto { get; set; }
        public string Ulica { get; set; }
        public string BrojUlice { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Ispostava { get; set; }

        public List<IsporukeClass> isporukeList { get; set; }
        #endregion

        public void DodajIsporuku(IsporukeClass isp)
        {
            try
            {
                if (isporukeList == null)
                {
                    isporukeList = new List<IsporukeClass>();
                }
                isporukeList.Add(isp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška kod dodavanja isporuke: " + ex.Message);
            }
        }

        public ObrazacPDVSArgs()
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

            this.DatumOd    = String.Empty;
            this.DatumDo    = String.Empty;
            this.Naziv      = String.Empty;
            this.OIB        = String.Empty;
            this.Adresa     = String.Empty;
            this.Mjesto     = String.Empty;
            this.Ulica      = String.Empty;
            this.BrojUlice  = String.Empty;
            this.Ime        = String.Empty;
            this.Prezime    = String.Empty;
            this.Telefon    = String.Empty;
            this.Email      = String.Empty;
            this.Ispostava  = String.Empty;
        }
    }
}
