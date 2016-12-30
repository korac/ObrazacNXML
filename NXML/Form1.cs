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
            MessageBox.Show("Spremljeno: " + jel.ToString());
            
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
            }
        }
    }
}
