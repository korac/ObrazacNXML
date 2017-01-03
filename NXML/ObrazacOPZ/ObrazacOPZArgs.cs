using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class ObrazacOPZArgs
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
        public string PorezniEmail { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NaDan { get; set; }
        public string NisuNaplaceniDo { get; set; }
        public List<KupciClass> kupciList { get; set; }
        public string UkupanIznosRacunaObrasca { get; set; }
        public string UkupanIznosPdvObrasca { get; set; }
        public string UkupanIznosRacunaSPdvObrasca { get; set; }
        public string UkupniPlaceniIznosRacunaObrasca { get; set; }
        public string NeplaceniIznosRacunaObrasca { get; set; }
        public string OPZUkupanIznosRacunaSPdv { get; set; }
        public string OPZUkupanIznosPdv { get; set; }
        #endregion

        public ObrazacOPZArgs()
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

            this.DatumOd         = String.Empty;
            this.DatumDo         = String.Empty;
            this.Naziv           = String.Empty;
            this.OIB             = String.Empty;
            this.Adresa          = String.Empty;
            this.Mjesto          = String.Empty;
            this.Ulica           = String.Empty;
            this.BrojUlice       = String.Empty;
            this.PorezniEmail    = String.Empty;
            this.Ime             = String.Empty;
            this.Prezime         = String.Empty;
            this.Telefon         = String.Empty;
            this.Fax             = String.Empty;
            this.Email           = String.Empty;
            this.NaDan           = String.Empty;
            this.NisuNaplaceniDo = String.Empty;

            this.UkupanIznosRacunaObrasca           = String.Empty;
            this.UkupanIznosPdvObrasca              = String.Empty;
            this.UkupanIznosRacunaSPdvObrasca       = String.Empty;
            this.UkupniPlaceniIznosRacunaObrasca    = String.Empty;
            this.NeplaceniIznosRacunaObrasca        = String.Empty;
            this.OPZUkupanIznosRacunaSPdv           = String.Empty;
            this.OPZUkupanIznosPdv                  = String.Empty;
        }

        public void DodajKupca(KupciClass kupac)
        {
            try
            {
                if (kupciList == null)
                {
                    kupciList = new List<KupciClass>();
                }
                kupciList.Add(kupac);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška kod dodavanja kupca: " + ex.Message);
            }
        }
    }
}
