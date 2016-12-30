using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXML
{
    class ObrazacPDVArgs
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
        public string Ispostava { get; set; }

        public string Podatak000 { get; set; }
        public string Podatak100 { get; set; }
        public string Podatak101 { get; set; }
        public string Podatak102 { get; set; }
        public string Podatak103 { get; set; }
        public string Podatak104 { get; set; }
        public string Podatak105 { get; set; }
        public string Podatak106 { get; set; }
        public string Podatak107 { get; set; }
        public string Podatak108 { get; set; }
        public string Podatak109 { get; set; }
        public string Podatak110 { get; set; }

        public string Podatak200Vrijednost { get; set; }
        public string Podatak200Porez { get; set; }

        public string Podatak201Vrijednost { get; set; }
        public string Podatak201Porez { get; set; }

        public string Podatak202Vrijednost { get; set; }
        public string Podatak202Porez { get; set; }

        public string Podatak203Vrijednost { get; set; }
        public string Podatak203Porez { get; set; }

        public string Podatak204Vrijednost { get; set; }
        public string Podatak204Porez { get; set; }

        public string Podatak205Vrijednost { get; set; }
        public string Podatak205Porez { get; set; }

        public string Podatak206Vrijednost { get; set; }
        public string Podatak206Porez { get; set; }

        public string Podatak207Vrijednost { get; set; }
        public string Podatak207Porez { get; set; }

        public string Podatak208Vrijednost { get; set; }
        public string Podatak208Porez { get; set; }

        public string Podatak209Vrijednost { get; set; }
        public string Podatak209Porez { get; set; }

        public string Podatak210Vrijednost { get; set; }
        public string Podatak210Porez { get; set; }

        public string Podatak211Vrijednost { get; set; }
        public string Podatak211Porez { get; set; }

        public string Podatak212Vrijednost { get; set; }
        public string Podatak212Porez { get; set; }

        public string Podatak213Vrijednost { get; set; }
        public string Podatak213Porez { get; set; }

        public string Podatak214Vrijednost { get; set; }
        public string Podatak214Porez { get; set; }

        public string Podatak215Vrijednost { get; set; }
        public string Podatak215Porez { get; set; }


        public string Podatak300Vrijednost { get; set; }
        public string Podatak300Porez { get; set; }

        public string Podatak301Vrijednost { get; set; }
        public string Podatak301Porez { get; set; }

        public string Podatak302Vrijednost { get; set; }
        public string Podatak302Porez { get; set; }

        public string Podatak303Vrijednost { get; set; }
        public string Podatak303Porez { get; set; }

        public string Podatak304Vrijednost { get; set; }
        public string Podatak304Porez { get; set; }

        public string Podatak305Vrijednost { get; set; }
        public string Podatak305Porez { get; set; }

        public string Podatak306Vrijednost { get; set; }
        public string Podatak306Porez { get; set; }

        public string Podatak307Vrijednost { get; set; }
        public string Podatak307Porez { get; set; }

        public string Podatak308Vrijednost { get; set; }
        public string Podatak308Porez { get; set; }

        public string Podatak309Vrijednost { get; set; }
        public string Podatak309Porez { get; set; }

        public string Podatak310Vrijednost { get; set; }
        public string Podatak310Porez { get; set; }

        public string Podatak311Vrijednost { get; set; }
        public string Podatak311Porez { get; set; }

        public string Podatak312Vrijednost { get; set; }
        public string Podatak312Porez { get; set; }

        public string Podatak313Vrijednost { get; set; }
        public string Podatak313Porez { get; set; }

        public string Podatak314Vrijednost { get; set; }
        public string Podatak314Porez { get; set; }

        public string Podatak315 { get; set; }
        public string Podatak400 { get; set; }
        public string Podatak500 { get; set; }
        public string Podatak600 { get; set; }
        public string Podatak700 { get; set; }
        public string Podatak810 { get; set; }
        public string Podatak811 { get; set; }
        public string Podatak812 { get; set; }
        public string Podatak813 { get; set; }
        public string Podatak814 { get; set; }
        public string Podatak815 { get; set; }
        public string Podatak820 { get; set; }
        public string Podatak830 { get; set; }

        public string Podatak831Vrijednost { get; set; }
        public string Podatak831Broj { get; set; }
        public string Podatak832Vrijednost { get; set; }
        public string Podatak832Broj { get; set; }
        public string Podatak833Vrijednost { get; set; }
        public string Podatak833Broj { get; set; }

        public string Podatak840 { get; set; }
        public string Podatak850 { get; set; }
        public string Podatak860 { get; set; }
        public string Podatak870 { get; set; }
        #endregion

        public ObrazacPDVArgs()
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
            this.Ispostava  = String.Empty;

            this.Podatak000 = String.Empty;
            this.Podatak100 = String.Empty;
            this.Podatak101 = String.Empty;
            this.Podatak102 = String.Empty;
            this.Podatak103 = String.Empty;
            this.Podatak104 = String.Empty;
            this.Podatak105 = String.Empty;
            this.Podatak106 = String.Empty;
            this.Podatak107 = String.Empty;
            this.Podatak108 = String.Empty;
            this.Podatak109 = String.Empty;
            this.Podatak110 = String.Empty;

            this.Podatak200Vrijednost   = String.Empty;
            this.Podatak200Porez        = String.Empty;
            this.Podatak201Vrijednost   = String.Empty;
            this.Podatak201Porez        = String.Empty;
            this.Podatak202Vrijednost   = String.Empty;
            this.Podatak202Porez        = String.Empty;
            this.Podatak203Vrijednost   = String.Empty;
            this.Podatak203Porez        = String.Empty;
            this.Podatak204Vrijednost   = String.Empty;
            this.Podatak204Porez        = String.Empty;
            this.Podatak205Vrijednost   = String.Empty;
            this.Podatak205Porez        = String.Empty;
            this.Podatak206Vrijednost   = String.Empty;
            this.Podatak206Porez        = String.Empty;
            this.Podatak207Vrijednost   = String.Empty;
            this.Podatak207Porez        = String.Empty;
            this.Podatak208Vrijednost   = String.Empty;
            this.Podatak208Porez        = String.Empty;
            this.Podatak209Vrijednost   = String.Empty;
            this.Podatak209Porez        = String.Empty;
            this.Podatak210Vrijednost   = String.Empty;
            this.Podatak210Porez        = String.Empty;
            this.Podatak211Vrijednost   = String.Empty;
            this.Podatak211Porez        = String.Empty;
            this.Podatak212Vrijednost   = String.Empty;
            this.Podatak212Porez        = String.Empty;
            this.Podatak213Vrijednost   = String.Empty;
            this.Podatak213Porez        = String.Empty;
            this.Podatak214Vrijednost   = String.Empty;
            this.Podatak214Porez        = String.Empty;
            this.Podatak215Vrijednost   = String.Empty;
            this.Podatak215Porez        = String.Empty;

            this.Podatak300Vrijednost   = String.Empty;
            this.Podatak300Porez        = String.Empty;
            this.Podatak301Vrijednost   = String.Empty;
            this.Podatak301Porez        = String.Empty;
            this.Podatak302Vrijednost   = String.Empty;
            this.Podatak302Porez        = String.Empty;
            this.Podatak303Vrijednost   = String.Empty;
            this.Podatak303Porez        = String.Empty;
            this.Podatak304Vrijednost   = String.Empty;
            this.Podatak304Porez        = String.Empty;
            this.Podatak305Vrijednost   = String.Empty;
            this.Podatak305Porez        = String.Empty;
            this.Podatak306Vrijednost   = String.Empty;
            this.Podatak306Porez        = String.Empty;
            this.Podatak307Vrijednost   = String.Empty;
            this.Podatak307Porez        = String.Empty;
            this.Podatak308Vrijednost   = String.Empty;
            this.Podatak308Porez        = String.Empty;
            this.Podatak309Vrijednost   = String.Empty;
            this.Podatak309Porez        = String.Empty;
            this.Podatak310Vrijednost   = String.Empty;
            this.Podatak310Porez        = String.Empty;
            this.Podatak311Vrijednost   = String.Empty;
            this.Podatak311Porez        = String.Empty;
            this.Podatak312Vrijednost   = String.Empty;
            this.Podatak312Porez        = String.Empty;
            this.Podatak313Vrijednost   = String.Empty;
            this.Podatak313Porez        = String.Empty;
            this.Podatak314Vrijednost   = String.Empty;
            this.Podatak314Porez        = String.Empty;

            this.Podatak315 = String.Empty;
            this.Podatak400 = String.Empty;
            this.Podatak500 = String.Empty;
            this.Podatak600 = String.Empty;
            this.Podatak700 = String.Empty;
            this.Podatak810 = String.Empty;
            this.Podatak811 = String.Empty;
            this.Podatak812 = String.Empty;
            this.Podatak813 = String.Empty;
            this.Podatak814 = String.Empty;
            this.Podatak815 = String.Empty;
            this.Podatak820 = String.Empty;
            this.Podatak830 = String.Empty;

            this.Podatak831Vrijednost = String.Empty;
            this.Podatak831Broj       = String.Empty;
            this.Podatak832Vrijednost = String.Empty;
            this.Podatak832Broj       = String.Empty;
            this.Podatak833Vrijednost = String.Empty;
            this.Podatak833Broj       = String.Empty;

            this.Podatak840 = String.Empty;
            this.Podatak850 = String.Empty;
            this.Podatak860 = String.Empty;
            this.Podatak870 = String.Empty;

        }
    }
}
