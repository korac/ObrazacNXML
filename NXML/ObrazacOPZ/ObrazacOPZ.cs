using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NXML
{
    class ObrazacOPZ
    {
        //*****************************************************************************************//
        //-----------------------------------------------------------------------------------------//
        //                       OBRAZAC OPZ (03.01.2017 by K.KORAĆ ;) )                           //
        //-----------------------------------------------------------------------------------------//
        //*****************************************************************************************//

        private XMLHelpBuilder xml;
        private XmlDocument xmlDoc;
        private ObrazacOPZArgs obrazacArgs;
        
        #region Nodes
        //ROOT
        XmlNode rootNode;
            XmlAttribute rootAttributeXmlns;
            XmlAttribute rootAttributeVerzija;
        //--------

        //HEADER
        XmlNode Metapodaci;
            // + subnodes
            XmlNode Naslov;
            XmlNode Autor;
            XmlNode Datum;
            XmlNode Format;
            XmlNode Jezik;
            XmlNode Identifikator;
            XmlNode Uskladjenost;
            XmlNode Tip;
            XmlNode Adresant;

        XmlNode Zaglavlje;
        // + subnodes
            XmlNode Razdoblje;
            // + subnodes
                XmlNode DatumOd;
                XmlNode DatumDo;
                XmlNode Tromjesecje;
                XmlNode Godina;
            XmlNode PorezniObveznik;
            // + subnodes
                XmlNode OIB;
                XmlNode Naziv;
                XmlNode Adresa;
                // + subnodes
                    XmlNode Mjesto;
                    XmlNode Ulica;
                    XmlNode BrojUlice;
                XmlNode PorezniEmail;
            XmlNode IzvjesceSastavio;
            // + subnodes
                XmlNode Ime;
                XmlNode Prezime;
                XmlNode Telefon;
                XmlNode Fax;
                XmlNode Email;
            XmlNode NaDan;
            XmlNode NisuNaplaceniDo;
        //--------

        //BODY
        XmlNode Tijelo;
        // + subnodes
            XmlNode Kupci;
            XmlNode UkupanIznosRacunaObrasca;
            XmlNode UkupanIznosPdvObrasca;
            XmlNode UkupanIznosRacunaSPdvObrasca;
            XmlNode UkupniPlaceniIznosRacunaObrasca;
            XmlNode NeplaceniIznosRacunaObrasca;
            XmlNode OPZUkupanIznosRacunaSPdv;
            XmlNode OPZUkupanIznosPdv;
        #endregion

        #region Strings
        string rootAttributeXmlnsName   = "xmlns";
        string rootAttributeXmlnsText   = "http://e-porezna.porezna-uprava.hr/sheme/zahtjevi/ObrazacOPZ/v1-0";
        string rootAttributeVerzijaName = "verzijaSheme";
        string rootAttributeVerzijaText = "1.0";
        string metapodaciXmlnsAttribute = "http://e-porezna.porezna-uprava.hr/sheme/Metapodaci/v2-0";
        string naslovDcText             = "http://purl.org/dc/elements/1.1/title";
        string autorDcText              = "http://purl.org/dc/elements/1.1/creator";
        string datumDcText              = "http://purl.org/dc/elements/1.1/date";
        string formatDcText             = "http://purl.org/dc/elements/1.1/format";
        string jezikDcText              = "http://purl.org/dc/elements/1.1/language";
        string identifikatorDcText      = "http://purl.org/dc/elements/1.1/identifier";
        string uskladjenostDcText       = "http://purl.org/dc/terms/conformsTo";
        string tipDcText                = "http://purl.org/dc/elements/1.1/type";
        #endregion

        public ObrazacOPZ(ObrazacOPZArgs args)
        {
            this.obrazacArgs = args;
        }

        public bool CreateObrazacOPZ()
        {
            try
            {
                xmlDoc  = new XmlDocument();
                xml     = new XMLHelpBuilder(xmlDoc);

                xml     .CreateXmlDeclaration();

                //ROOT -----------------------
                rootNode                        = xmlDoc.CreateElement("ObrazacOPZ");

                rootAttributeXmlns              = xmlDoc.CreateAttribute(rootAttributeXmlnsName);
                rootAttributeXmlns.InnerText    = rootAttributeXmlnsText;

                rootAttributeVerzija            = xmlDoc.CreateAttribute(rootAttributeVerzijaName);
                rootAttributeVerzija.InnerText  = rootAttributeVerzijaText;

                rootNode.Attributes.Append(rootAttributeXmlns);
                rootNode.Attributes.Append(rootAttributeVerzija);

                xml.CreateRoot(rootNode);
                //ROOT END -------------------

                //HEADER -----------------------
                Metapodaci                      = xmlDoc.CreateElement("Metapodaci");
                XmlAttribute metapodaciXmlns    = xmlDoc.CreateAttribute("xmlns");
                metapodaciXmlns.InnerText       = metapodaciXmlnsAttribute;
                Metapodaci.Attributes           .Append(metapodaciXmlns);

                xml.AppendChild(rootNode, Metapodaci);
                // + subnodes
                    Naslov                  = xmlDoc.CreateElement("Naslov");
                    XmlAttribute dcNaslov   = xmlDoc.CreateAttribute("dc");
                    dcNaslov.InnerText      = naslovDcText;
                    Naslov.Attributes       .Append(dcNaslov);
                    Naslov.InnerText        = obrazacArgs.Naslov;

                    Autor                   = xmlDoc.CreateElement("Autor");
                    XmlAttribute dcAutor    = xmlDoc.CreateAttribute("dc");
                    dcAutor.InnerText       = autorDcText;
                    Autor.Attributes        .Append(dcAutor);
                    Autor.InnerText         = obrazacArgs.Autor;

                    Datum                   = xmlDoc.CreateElement("Datum");
                    XmlAttribute dcDatum    = xmlDoc.CreateAttribute("dc");
                    dcDatum.InnerText       = datumDcText;
                    Datum.Attributes        .Append(dcDatum);
                    Datum.InnerText         = obrazacArgs.Datum;

                    Format                  = xmlDoc.CreateElement("Format");
                    XmlAttribute dcFormat   = xmlDoc.CreateAttribute("dc");
                    dcFormat.InnerText      = formatDcText;
                    Format.Attributes       .Append(dcFormat);
                    Format.InnerText        = obrazacArgs.Format;

                    Jezik                   = xmlDoc.CreateElement("Jezik");
                    XmlAttribute dcJezik    = xmlDoc.CreateAttribute("dc");
                    dcJezik.InnerText       = jezikDcText;
                    Jezik.Attributes        .Append(dcJezik);
                    Jezik.InnerText         = obrazacArgs.Jezik;

                    Identifikator           = xmlDoc.CreateElement("Identifikator");
                    XmlAttribute dcIdent    = xmlDoc.CreateAttribute("dc");
                    dcIdent.InnerText       = identifikatorDcText;
                    Identifikator.Attributes.Append(dcIdent);
                    Identifikator.InnerText = obrazacArgs.Identifikator;

                    Uskladjenost            = xmlDoc.CreateElement("Uskladjenost");
                    XmlAttribute dcUskl     = xmlDoc.CreateAttribute("dc");
                    dcUskl.InnerText        = uskladjenostDcText;
                    Uskladjenost.Attributes .Append(dcUskl);
                    Uskladjenost.InnerText  = obrazacArgs.Uskladjenost;

                    Tip                     = xmlDoc.CreateElement("Tip");
                    XmlAttribute dcTip      = xmlDoc.CreateAttribute("dc");
                    dcTip.InnerText         = tipDcText;
                    Tip.Attributes          .Append(dcTip);
                    Tip.InnerText           = obrazacArgs.Tip;

                    Adresant                = xmlDoc.CreateElement("Adresant");
                    Adresant.InnerText      = obrazacArgs.Adresant;

                xml.AppendChild(Metapodaci, Naslov);
                xml.AppendChild(Metapodaci, Autor);
                xml.AppendChild(Metapodaci, Datum);
                xml.AppendChild(Metapodaci, Format);
                xml.AppendChild(Metapodaci, Jezik);
                xml.AppendChild(Metapodaci, Identifikator);
                xml.AppendChild(Metapodaci, Uskladjenost);
                xml.AppendChild(Metapodaci, Tip);
                xml.AppendChild(Metapodaci, Adresant);

                Zaglavlje   = xmlDoc.CreateElement("Zaglavlje");
                xml.AppendChild(rootNode, Zaglavlje);
                // + subnodes
                    Razdoblje       = xmlDoc.CreateElement("Razdoblje");
                    DatumOd         = xmlDoc.CreateElement("DatumOd");
                    DatumDo         = xmlDoc.CreateElement("DatumDo");
                    PorezniObveznik = xmlDoc.CreateElement("PorezniObveznik");
                    OIB             = xmlDoc.CreateElement("OIB");
                    Naziv           = xmlDoc.CreateElement("Naziv");
                    Adresa          = xmlDoc.CreateElement("Adresa");
                    Mjesto          = xmlDoc.CreateElement("Mjesto");
                    Ulica           = xmlDoc.CreateElement("Ulica");
                    BrojUlice       = xmlDoc.CreateElement("Broj");
                    PorezniEmail    = xmlDoc.CreateElement("Email");
                    IzvjesceSastavio= xmlDoc.CreateElement("IzvjesceSastavio");
                    Ime             = xmlDoc.CreateElement("Ime");
                    Prezime         = xmlDoc.CreateElement("Prezime");
                    Telefon         = xmlDoc.CreateElement("Telefon");
                    Fax             = xmlDoc.CreateElement("Fax");
                    Email           = xmlDoc.CreateElement("Email");
                    NaDan           = xmlDoc.CreateElement("NaDan");
                    NisuNaplaceniDo = xmlDoc.CreateElement("NisuNaplaćeniDo");

                    DatumOd.InnerText           = obrazacArgs.DatumOd;
                    DatumDo.InnerText           = obrazacArgs.DatumDo;
                    OIB.InnerText               = obrazacArgs.OIB;
                    Naziv.InnerText             = obrazacArgs.Naziv;
                    Mjesto.InnerText            = obrazacArgs.Mjesto;
                    Ulica.InnerText             = obrazacArgs.Ulica;
                    BrojUlice.InnerText         = obrazacArgs.BrojUlice;
                    PorezniEmail.InnerText      = obrazacArgs.PorezniEmail;
                    Ime.InnerText               = obrazacArgs.Ime;
                    Prezime.InnerText           = obrazacArgs.Prezime;
                    Telefon.InnerText           = obrazacArgs.Telefon;
                    Fax.InnerText               = obrazacArgs.Fax;
                    Email.InnerText             = obrazacArgs.Email;
                    NaDan.InnerText             = obrazacArgs.NaDan;
                    NisuNaplaceniDo.InnerText   = obrazacArgs.NisuNaplaceniDo;

                xml.AppendChild(Zaglavlje, Razdoblje);
                    xml.AppendChild(Razdoblje, DatumOd);
                    xml.AppendChild(Razdoblje, DatumDo);

                xml.AppendChild(Zaglavlje, PorezniObveznik);
                    xml.AppendChild(PorezniObveznik, OIB);
                    xml.AppendChild(PorezniObveznik, Naziv);
                    xml.AppendChild(PorezniObveznik, Adresa);
                        xml.AppendChild(Adresa, Mjesto);
                        xml.AppendChild(Adresa, Ulica);
                        xml.AppendChild(Adresa, BrojUlice);
                    xml.AppendChild(PorezniObveznik, PorezniEmail);

                xml.AppendChild(Zaglavlje, IzvjesceSastavio);
                    xml.AppendChild(IzvjesceSastavio, Ime);
                    xml.AppendChild(IzvjesceSastavio, Prezime);
                    xml.AppendChild(IzvjesceSastavio, Telefon);
                    xml.AppendChild(IzvjesceSastavio, Fax);
                    xml.AppendChild(IzvjesceSastavio, Email);

                xml.AppendChild(Zaglavlje, NaDan);
                xml.AppendChild(Zaglavlje, NisuNaplaceniDo);
                //HEADER END -------------------

                //BODY -------------------------
                Tijelo  = xmlDoc.CreateElement("Tijelo");
                xml     .AppendChild(rootNode, Tijelo);
                // + subnodes
                    Kupci                           = xmlDoc.CreateElement("Kupci");
                    UkupanIznosRacunaObrasca        = xmlDoc.CreateElement("UkupanIznosRacunaObrasca");
                    UkupanIznosPdvObrasca           = xmlDoc.CreateElement("UkupanIznosPdvObrasca");
                    UkupanIznosRacunaSPdvObrasca    = xmlDoc.CreateElement("UkupanIznosRacunaSPdvObrasca");
                    UkupniPlaceniIznosRacunaObrasca = xmlDoc.CreateElement("UkupniPlaceniIznosRacunaObrasca");
                    NeplaceniIznosRacunaObrasca     = xmlDoc.CreateElement("NeplaceniIznosRacunaObrasca");
                    OPZUkupanIznosRacunaSPdv        = xmlDoc.CreateElement("OPZUkupanIznosRacunaSPdv");
                    OPZUkupanIznosPdv               = xmlDoc.CreateElement("OPZUkupanIznosPdv");

                    if(obrazacArgs.kupciList != null)
                    {
                        CreateKupci();
                    }

                    UkupanIznosRacunaObrasca.InnerText          = obrazacArgs.UkupanIznosRacunaObrasca;
                    UkupanIznosPdvObrasca.InnerText             = obrazacArgs.UkupanIznosPdvObrasca;
                    UkupanIznosRacunaSPdvObrasca.InnerText      = obrazacArgs.UkupanIznosRacunaSPdvObrasca;
                    UkupniPlaceniIznosRacunaObrasca.InnerText   = obrazacArgs.UkupniPlaceniIznosRacunaObrasca;
                    NeplaceniIznosRacunaObrasca.InnerText       = obrazacArgs.NeplaceniIznosRacunaObrasca;
                    OPZUkupanIznosRacunaSPdv.InnerText          = obrazacArgs.OPZUkupanIznosRacunaSPdv;
                    OPZUkupanIznosPdv.InnerText                 = obrazacArgs.OPZUkupanIznosPdv;

                    xml.AppendChild(Tijelo, Kupci);
                    xml.AppendChild(Tijelo, UkupanIznosRacunaObrasca);
                    xml.AppendChild(Tijelo, UkupanIznosPdvObrasca);
                    xml.AppendChild(Tijelo, UkupanIznosRacunaSPdvObrasca);
                    xml.AppendChild(Tijelo, UkupniPlaceniIznosRacunaObrasca);
                    xml.AppendChild(Tijelo, NeplaceniIznosRacunaObrasca);
                    xml.AppendChild(Tijelo, OPZUkupanIznosRacunaSPdv);
                    xml.AppendChild(Tijelo, OPZUkupanIznosPdv);
                //BODY END ---------------------

                xmlDoc.Save(@"C:\Users\Kristijan\Desktop\TEMP3\ObrazacOPZ.xml");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
                return false;
            }
        }

        public void CreateKupci()
        {
            foreach(KupciClass kupac in obrazacArgs.kupciList)
            {
                XmlNode kupacNode   = xmlDoc.CreateElement("Kupac");
                // + subnodes
                    XmlNode K1 = xmlDoc.CreateElement("K1");
                    XmlNode K2 = xmlDoc.CreateElement("K2");
                    XmlNode K3 = xmlDoc.CreateElement("K3");
                    XmlNode K4 = xmlDoc.CreateElement("K4");
                    XmlNode K5 = xmlDoc.CreateElement("K5");
                    XmlNode K6 = xmlDoc.CreateElement("K6");
                    XmlNode K7 = xmlDoc.CreateElement("K7");
                    XmlNode K8 = xmlDoc.CreateElement("K8");
                    XmlNode K9 = xmlDoc.CreateElement("K9");

                    K1.InnerText = kupac.K1;
                    K2.InnerText = kupac.K2;
                    K3.InnerText = kupac.K3;
                    K4.InnerText = kupac.K4;
                    K5.InnerText = kupac.K5;
                    K6.InnerText = kupac.K6;
                    K7.InnerText = kupac.K7;
                    K8.InnerText = kupac.K8;
                    K9.InnerText = kupac.K9;

                    xml.AppendChild(kupacNode, K1);
                    xml.AppendChild(kupacNode, K2);
                    xml.AppendChild(kupacNode, K3);
                    xml.AppendChild(kupacNode, K4);
                    xml.AppendChild(kupacNode, K5);
                    xml.AppendChild(kupacNode, K6);
                    xml.AppendChild(kupacNode, K7);
                    xml.AppendChild(kupacNode, K8);
                    xml.AppendChild(kupacNode, K9);

                    XmlNode Racuni  = xmlDoc.CreateElement("Racuni");
                    foreach(RacuniClass racun in kupac.racuniList)
                    {
                        XmlNode racunNode = xmlDoc.CreateElement("Racun");
                        // + subnodes
                            XmlNode R1  = xmlDoc.CreateElement("R1");
                            XmlNode R2  = xmlDoc.CreateElement("R2");
                            XmlNode R3  = xmlDoc.CreateElement("R3");
                            XmlNode R4  = xmlDoc.CreateElement("R4");
                            XmlNode R5  = xmlDoc.CreateElement("R5");
                            XmlNode R6  = xmlDoc.CreateElement("R6");
                            XmlNode R7  = xmlDoc.CreateElement("R7");
                            XmlNode R8  = xmlDoc.CreateElement("R8");
                            XmlNode R9  = xmlDoc.CreateElement("R9");
                            XmlNode R10 = xmlDoc.CreateElement("R10");

                            R1.InnerText  = racun.R1;
                            R2.InnerText  = racun.R2;
                            R3.InnerText  = racun.R3;
                            R4.InnerText  = racun.R4;
                            R5.InnerText  = racun.R5;
                            R6.InnerText  = racun.R6;
                            R7.InnerText  = racun.R7;
                            R8.InnerText  = racun.R8;
                            R9.InnerText  = racun.R9;
                            R10.InnerText = racun.R10;

                            xml.AppendChild(racunNode, R1);
                            xml.AppendChild(racunNode, R2);
                            xml.AppendChild(racunNode, R3);
                            xml.AppendChild(racunNode, R4);
                            xml.AppendChild(racunNode, R5);
                            xml.AppendChild(racunNode, R6);
                            xml.AppendChild(racunNode, R7);
                            xml.AppendChild(racunNode, R8);
                            xml.AppendChild(racunNode, R9);
                            xml.AppendChild(racunNode, R10);

                        xml.AppendChild(Racuni, racunNode);
                    }

                    xml.AppendChild(kupacNode, Racuni);
                    xml.AppendChild(Kupci, kupacNode);
            }
        }
    }
}
