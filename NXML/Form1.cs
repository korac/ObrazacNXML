using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var args = new ObrazacPDVArgs();
                args.Naslov         = "Prijava poreza";
                args.Autor          = "Kristijan Korać";
                args.Datum          = "2015-01-02";
                args.Format         = "text/xml";
                args.Jezik          = "hr-HR";
                args.Identifikator  = "kodawkdawkodw";
                args.Uskladjenost   = "ObrazacPDV";
                args.Tip            = "Elektronicki obrazac";
                args.Adresant       = "Ministarstvo Financija, Porezna Uprava, Zagreb";

                args.DatumOd    = "2014-02-02";
                args.DatumDo    = "2015-02-02";
                args.Naziv      = "Infos d.o.o";
                args.OIB        = "12334534345";
                args.Mjesto     = "Zagreb";
                args.Ulica      = "Radnicka";
                args.BrojUlice  = "80";
                args.Ime        = "Kristijan";
                args.Prezime    = "Korać";
                args.Ispostava  = "3243";
    
                args.Podatak000 = "Podatak000";
                args.Podatak100 = "Podatak100";
                args.Podatak101 = "Podatak101";
                args.Podatak102 = "Podatak102";
                args.Podatak103 = "Podatak103";
                args.Podatak104 = "Podatak104";
                args.Podatak105 = "Podatak105";
                args.Podatak106 = "Podatak106";
                args.Podatak107 = "Podatak107";
                args.Podatak108 = "Podatak108";
                args.Podatak109 = "Podatak109";
                args.Podatak110 = "Podatak110";
  
                args.Podatak200Vrijednost   = "Podatak200Vrijednost";
                args.Podatak200Porez        = "Podatak200Porez";
                args.Podatak201Vrijednost   = "Podatak201Vrijednost";
                args.Podatak201Porez        = "Podatak201Porez";
                args.Podatak202Vrijednost   = "Podatak202Vrijednost";
                args.Podatak202Porez        = "Podatak202Porez";
                args.Podatak203Vrijednost   = "Podatak203Vrijednost";
                args.Podatak203Porez        = "Podatak203Porez";
                args.Podatak204Vrijednost   = "Podatak204Vrijednost";
                args.Podatak204Porez        = "Podatak204Porez";
                args.Podatak205Vrijednost   = "Podatak205Vrijednost";
                args.Podatak205Porez        = "Podatak205Porez";
                args.Podatak206Vrijednost   = "Podatak206Vrijednost";
                args.Podatak206Porez        = "Podatak206Porez";
                args.Podatak207Vrijednost   = "Podatak207Vrijednost";
                args.Podatak207Porez        = "Podatak207Porez";
                args.Podatak208Vrijednost   = "Podatak208Vrijednost";
                args.Podatak208Porez        = "Podatak208Porez";
                args.Podatak209Vrijednost   = "Podatak209Vrijednost";
                args.Podatak209Porez        = "Podatak209Porez";
                args.Podatak210Vrijednost   = "Podatak210Vrijednost";
                args.Podatak210Porez        = "Podatak210Porez";
                args.Podatak211Vrijednost   = "Podatak211Vrijednost";
                args.Podatak211Porez        = "Podatak211Porez";
                args.Podatak212Vrijednost   = "Podatak212Vrijednost";
                args.Podatak212Porez        = "Podatak212Porez";
                args.Podatak213Vrijednost   = "Podatak213Vrijednost";
                args.Podatak213Porez        = "Podatak213Porez";
                args.Podatak214Vrijednost   = "Podatak214Vrijednost";
                args.Podatak214Porez        = "Podatak214Porez";
                args.Podatak215Vrijednost   = "Podatak215Vrijednost";
                args.Podatak215Porez        = "Podatak215Porez";
   
                args.Podatak300Vrijednost   = "Podatak300Vrijednost";
                args.Podatak300Porez        = "Podatak300Porez";
                args.Podatak301Vrijednost   = "Podatak301Vrijednost";
                args.Podatak301Porez        = "Podatak301Porez";
                args.Podatak302Vrijednost   = "Podatak302Vrijednost";
                args.Podatak302Porez        = "Podatak302Porez";
                args.Podatak303Vrijednost   = "Podatak303Vrijednost";
                args.Podatak303Porez        = "Podatak303Porez";
                args.Podatak304Vrijednost   = "Podatak304Vrijednost";
                args.Podatak304Porez        = "Podatak304Porez";
                args.Podatak305Vrijednost   = "Podatak305Vrijednost";
                args.Podatak305Porez        = "Podatak305Porez";
                args.Podatak306Vrijednost   = "Podatak306Vrijednost";
                args.Podatak306Porez        = "Podatak306Porez";
                args.Podatak307Vrijednost   = "Podatak307Vrijednost";
                args.Podatak307Porez        = "Podatak307Porez";
                args.Podatak308Vrijednost   = "Podatak308Vrijednost";
                args.Podatak308Porez        = "Podatak308Porez";
                args.Podatak309Vrijednost   = "Podatak309Vrijednost";
                args.Podatak309Porez        = "Podatak309Porez";
                args.Podatak310Vrijednost   = "Podatak310Vrijednost";
                args.Podatak310Porez        = "Podatak310Porez";
                args.Podatak311Vrijednost   = "Podatak311Vrijednost";
                args.Podatak311Porez        = "Podatak311Porez";
                args.Podatak312Vrijednost   = "Podatak312Vrijednost";
                args.Podatak312Porez        = "Podatak312Porez";
                args.Podatak313Vrijednost   = "Podatak313Vrijednost";
                args.Podatak313Porez        = "Podatak313Porez";
                args.Podatak314Vrijednost   = "Podatak314Vrijednost";
                args.Podatak314Porez        = "Podatak314Porez";
                                          
                args.Podatak315 = "Podatak315";
                args.Podatak400 = "Podatak400";
                args.Podatak500 = "Podatak500";
                args.Podatak600 = "Podatak600";
                args.Podatak700 = "Podatak700";
                args.Podatak810 = "Podatak810";
                args.Podatak811 = "Podatak811";
                args.Podatak812 = "Podatak812";
                args.Podatak813 = "Podatak813";
                args.Podatak814 = "Podatak814";
                args.Podatak815 = "Podatak815";
                args.Podatak820 = "Podatak820";
                args.Podatak830 = "Podatak830";
      
                args.Podatak831Vrijednost = "Podatak831Vrijednost";
                args.Podatak831Broj       = "Podatak831Porez";
                args.Podatak832Vrijednost = "Podatak832Vrijednost";
                args.Podatak832Broj       = "Podatak832Porez";
                args.Podatak833Vrijednost = "Podatak833Vrijednost";
                args.Podatak833Broj       = "Podatak833Porez";

                args.Podatak840 = "Podatak840";
                args.Podatak850 = "Podatak850";
                args.Podatak860 = "Podatak860";
                args.Podatak870 = "Podatak870";

                ObrazacPDV oPDV = new ObrazacPDV(args);
                bool jel = oPDV.CreateObrazacPDV();


                //********* PDVS **********//
                ObrazacPDVSArgs sArgs   = new ObrazacPDVSArgs();           

                sArgs.Naslov         = "Prijava poreza";
                sArgs.Autor          = "Kristijan Korać";
                sArgs.Datum          = "2015-01-02";
                sArgs.Format         = "text/xml";
                sArgs.Jezik          = "hr-HR";
                sArgs.Identifikator  = "kodawkdawkodw";
                sArgs.Uskladjenost   = "ObrazacPDV";
                sArgs.Tip            = "Elektronicki obrazac";
                sArgs.Adresant       = "Ministarstvo Financija, Porezna Uprava, Zagreb";
            
                sArgs.DatumOd    = "2014-02-02";
                sArgs.DatumDo    = "2015-02-02";
                sArgs.Naziv      = "Infos d.o.o";
                sArgs.OIB        = "12334534345";
                sArgs.Mjesto     = "Zagreb";
                sArgs.Ulica      = "Radnicka";
                sArgs.BrojUlice  = "80";
                sArgs.Ime        = "Kristijan";
                sArgs.Prezime    = "Korać";
                sArgs.Telefon    = "123-123";
                sArgs.Email      = "kristijan@korac.com";
                sArgs.Ispostava  = "3243";    
            
                sArgs.I1         = "121321";
                sArgs.I2         = "34534";        

                for (int i = 0; i < 5; i++)
                {
                    IsporukeClass isporuka  = new IsporukeClass();
                    isporuka.RedBr          = i.ToString();
                    isporuka.KodDrzave      = "DR" + i.ToString();
                    isporuka.PDVID          = "33893489";
                    isporuka.I1             = "100.00";
                    isporuka.I2             = "100.00";

                    sArgs.DodajIsporuku(isporuka);
                }

                ObrazacPDVS oPDVS   = new ObrazacPDVS(sArgs);
                bool jelS           = oPDVS.CreateObrazacPDVS();

                //*************************//


                //********* PPO **********//
                ObrazacPPOArgs ppoArgs  = new ObrazacPPOArgs();

                ppoArgs.Naslov         = "Prijava poreza";
                ppoArgs.Autor          = "Kristijan Korać";
                ppoArgs.Datum          = "2015-01-02";
                ppoArgs.Format         = "text/xml";
                ppoArgs.Jezik          = "hr-HR";
                ppoArgs.Identifikator  = "kodawkdawkodw";
                ppoArgs.Uskladjenost   = "ObrazacPDV";
                ppoArgs.Tip            = "Elektronicki obrazac";
                ppoArgs.Adresant       = "Ministarstvo Financija, Porezna Uprava, Zagreb";
            
                ppoArgs.DatumOd         = "2014-02-02";
                ppoArgs.DatumDo         = "2015-02-02";
                ppoArgs.Tromjesecje     = 1;
                ppoArgs.Godina          = "2016";
                ppoArgs.Naziv           = "Infos d.o.o";
                ppoArgs.OIB             = "12334534345";
                ppoArgs.Mjesto          = "Zagreb";
                ppoArgs.Ulica           = "Radnicka";
                ppoArgs.BrojUlice       = "80";
                ppoArgs.Ime             = "Kristijan";
                ppoArgs.Prezime         = "Korać";
                ppoArgs.Ispostava       = "3243";
                ppoArgs.Ukupno          = "345232";

                for(int i = 0; i < 3; i++)
                {
                    IsporukePPOClass ppoIsporuka    = new IsporukePPOClass();
                    ppoIsporuka.Iznos   = "121414";
                    ppoIsporuka.DatumOd = "2016-01-01";
                    ppoIsporuka.DatumDo = "2016-01-31";

                    for(int j = 1; j < 4; j++)
                    {
                        PodaciPPOClass ppoPodatak   = new PodaciPPOClass();
                        ppoPodatak.RedniBroj        = j.ToString();
                        ppoPodatak.OIB              = "61877856058";
                        ppoPodatak.Iznos            = "3423";

                        ppoIsporuka.DodajPodatak(ppoPodatak);
                    }

                    ppoArgs.DodajPPOIsporuku(ppoIsporuka);
                }

                ObrazacPPO PPO  = new ObrazacPPO(ppoArgs);
                bool jelPPO     = PPO.CreateObrazacPPO();
                //************************//

                //********* ZP **********//
                ObrazacZPArgs zpArgs = new ObrazacZPArgs();

                zpArgs.Naslov         = "Zbirna prijavu za isporuke dobara i usluga u druge države članice Europske unije";
                zpArgs.Autor          = "Kristijan Korać";
                zpArgs.Datum          = "2015-01-02";
                zpArgs.Format         = "text/xml";
                zpArgs.Jezik          = "hr-HR";
                zpArgs.Identifikator  = "kodawkdawkodw";
                zpArgs.Uskladjenost   = "ObrazacPDV";
                zpArgs.Tip            = "Elektronicki obrazac";
                zpArgs.Adresant       = "Ministarstvo Financija, Porezna Uprava, Zagreb";
                
                zpArgs.DatumOd         = "2014-02-02";
                zpArgs.DatumDo         = "2015-02-02";
                zpArgs.Naziv           = "Infos d.o.o";
                zpArgs.OIB             = "12334534345";
                zpArgs.Mjesto          = "Zagreb";
                zpArgs.Ulica           = "Radnicka";
                zpArgs.BrojUlice       = "80";
                zpArgs.Ime             = "Kristijan";
                zpArgs.Prezime         = "Korać";
                zpArgs.Telefon         = "012 2310 223";
                zpArgs.Email           = "kox@mox.hr";
                zpArgs.Ispostava       = "3243";

                zpArgs.I1   = "2131";
                zpArgs.I2   = "11231";
                zpArgs.I3   = "4521";
                zpArgs.I4   = "3475";

                for(int i = 1; i < 21; i++)
                {
                    IsporukeZPClass zpIsporuka = new IsporukeZPClass();
                    zpIsporuka.RedBr        = i.ToString();
                    zpIsporuka.KodDrzave    = "HR";
                    zpIsporuka.PDVID        = "1235463445";
                    zpIsporuka.I1           = "700";
                    zpIsporuka.I2           = "700";
                    zpIsporuka.I3           = "700";
                    zpIsporuka.I4           = "700";

                    zpArgs.DodajIsporuku(zpIsporuka);
                }

                ObrazacZP oZP   = new ObrazacZP(zpArgs);
                bool jelZP      = oZP.CreateObrazacZP();
                //************************//


                //********* OPZ **********//
                ObrazacOPZArgs opzArgs = new ObrazacOPZArgs();

                opzArgs.Naslov         = "Obrazac OPZ";
                opzArgs.Autor          = "Kristijan Korać";
                opzArgs.Datum          = "2015-01-02";
                opzArgs.Format         = "text/xml";
                opzArgs.Jezik          = "hr-HR";
                opzArgs.Identifikator  = "kodawkdawkodw";
                opzArgs.Uskladjenost   = "ObrazacPDV";
                opzArgs.Tip            = "Elektronicki obrazac";
                opzArgs.Adresant       = "Ministarstvo Financija, Porezna Uprava, Zagreb";
                
                opzArgs.DatumOd         = "2014-02-02";
                opzArgs.DatumDo         = "2015-02-02";
                opzArgs.Naziv           = "Infos d.o.o";
                opzArgs.OIB             = "12334534345";
                opzArgs.Mjesto          = "Zagreb";
                opzArgs.Ulica           = "Radnicka";
                opzArgs.BrojUlice       = "80";
                opzArgs.PorezniEmail    = "apis@apis-it.hr";
                opzArgs.Ime             = "Kristijan";
                opzArgs.Prezime         = "Korać";
                opzArgs.Telefon         = "012 2310 223";
                opzArgs.Fax             = "012 2310 224";
                opzArgs.Email           = "kox@mox.hr";
                
                opzArgs.NaDan           = "2015-12-31";
                opzArgs.NisuNaplaceniDo = "2016-01-31";
                
                opzArgs.UkupanIznosRacunaObrasca           = "2100.00";
                opzArgs.UkupanIznosPdvObrasca              = "625.00";
                opzArgs.UkupanIznosRacunaSPdvObrasca       = "2625.00";
                opzArgs.UkupniPlaceniIznosRacunaObrasca    = "50.00";
                opzArgs.NeplaceniIznosRacunaObrasca        = "2575.00";
                opzArgs.OPZUkupanIznosRacunaSPdv           = "0.00";
                opzArgs.OPZUkupanIznosPdv                  = "0.00";

                for(int i = 1; i < 3; i++)
                {
                    KupciClass kupac = new KupciClass();
                    kupac.K1 = "1";
                    kupac.K2 = "1";
                    kupac.K3 = "00000000001";
                    kupac.K4 = "Mala firma d.o.o.";
                    kupac.K5 = "1100.00";
                    kupac.K6 = "275.00";
                    kupac.K7 = "1375.00";
                    kupac.K8 = "50.00";
                    kupac.K9 = "1325.00";

                    for(int j = 1; j < 3; j++)
                    {
                        RacuniClass racun = new RacuniClass();
                        racun.R1  = "1";
                        racun.R2  = "2015-01";
                        racun.R3  = "2015-01-10";
                        racun.R4  = "2015-01-25";
                        racun.R5  = "340";
                        racun.R6  = "1000.00";
                        racun.R7  = "250.00";
                        racun.R8  = "1250.00";
                        racun.R9  = "0.00";
                        racun.R10 = "1250.00";

                        kupac.DodajRacune(racun);
                    }

                    opzArgs.DodajKupca(kupac);
                }

                ObrazacOPZ oOPZ = new ObrazacOPZ(opzArgs);
                bool jelOPZ     = oOPZ.CreateObrazacOPZ();
                //************************//


                MessageBox.Show("Spremljeno: " + jel.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int start = 315;
                int stop = 315;
                int korak = 1;
                for (int i = start; i < stop; i += korak )
                {
                    Console.WriteLine(@"Podatak" + i + "    = xmlDoc.CreateElement(\"Podatak" + i + "\")");
                    Console.WriteLine("Podatak" + i + ".InnerText    = obrazacArgs.Podatak" + i + ";");

                    //Console.WriteLine("Podatak"+i+" = xmlDoc.CreateElement(\"Podatak"+i+"\");");
                    //Console.WriteLine("Podatak"+i+"Vrijednost = xmlDoc.CreateElement(\"Podatak"+i+"Vrijednost\");");
                    //Console.WriteLine("Podatak"+i+"Porez = xmlDoc.CreateElement(\"Podatak"+i+"Porez\");");

                    //Console.WriteLine("xml.AppendChild(Podatak"+i+", Podatak"+i+"Vrijednost);");
                    //Console.WriteLine("xml.AppendChild(Podatak"+i+", Podatak"+i+"Porez); ");

                    //Console.WriteLine("xml.AppendChild(Tijelo, Podatak"+i+");");
                    //Console.WriteLine("xml.AppendChild(Podatak"+i+", Podatak"+i+"Vrijednost);");
                    //Console.WriteLine("xml.AppendChild(Podatak"+i+", Podatak"+i+"Porez);");                    


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
