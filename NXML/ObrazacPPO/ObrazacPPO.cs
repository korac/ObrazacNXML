using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NXML
{
    class ObrazacPPO
    {
        //*****************************************************************************************//
        //-----------------------------------------------------------------------------------------//
        //                       OBRAZAC PPO (01.02.2017 by K.KORAĆ ;) )                           //
        //-----------------------------------------------------------------------------------------//
        //*****************************************************************************************//

        private XMLHelpBuilder xml;
        private XmlDocument xmlDoc;
        private ObrazacPPOArgs obrazacArgs;

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
            XmlNode Obveznik;
            // + subnodes
                XmlNode Naziv;
                XmlNode OIB;
                XmlNode Adresa;
                // + subnodes
                    XmlNode Mjesto;
                    XmlNode Ulica;
                    XmlNode BrojUlice;
            XmlNode ObracunSastavio;
            // + subnodes
                XmlNode Ime;
                XmlNode Prezime;
            XmlNode Ispostava;
        //--------

        //BODY
        XmlNode Tijelo;
        // + subnodes
            XmlNode Isporuke;
            XmlNode Ukupno;
        #endregion

        #region Strings
        string rootAttributeXmlnsName   = "xmlns";
        string rootAttributeXmlnsText   = "http://e-porezna.porezna-uprava.hr/sheme/zahtjevi/ObrazacPPO/v1-0";
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
        public ObrazacPPO(ObrazacPPOArgs args)
        {
            this.obrazacArgs = args;
        }

        public bool CreateObrazacPPO()
        {
            try
            {
                xmlDoc  = new XmlDocument();
                xml     = new XMLHelpBuilder(xmlDoc);

                xml     .CreateXmlDeclaration();

                //ROOT -----------------------
                rootNode                        = xmlDoc.CreateElement("ObrazacPPO");

                rootAttributeXmlns              = xmlDoc.CreateAttribute(rootAttributeXmlnsName);
                rootAttributeXmlns.InnerText    = rootAttributeXmlnsText;

                rootAttributeVerzija            = xmlDoc.CreateAttribute(rootAttributeVerzijaName);
                rootAttributeVerzija.InnerText  = rootAttributeVerzijaText;

                rootNode.Attributes.Append(rootAttributeXmlns);
                rootNode.Attributes.Append(rootAttributeVerzija);

                xml.CreateRoot(rootNode);
                //END ROOT -------------------

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
                    Uskladjenost.InnerText  = obrazacArgs.Identifikator;

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
                    Obveznik        = xmlDoc.CreateElement("Obveznik");
                    Naziv           = xmlDoc.CreateElement("Naziv");
                    OIB             = xmlDoc.CreateElement("OIB");
                    Adresa          = xmlDoc.CreateElement("Adresa");
                    Mjesto          = xmlDoc.CreateElement("Mjesto");
                    Ulica           = xmlDoc.CreateElement("Ulica");
                    BrojUlice       = xmlDoc.CreateElement("Broj");
                    Ime             = xmlDoc.CreateElement("Ime");
                    Prezime         = xmlDoc.CreateElement("Prezime");
                    ObracunSastavio = xmlDoc.CreateElement("ObracunSastavio");
                    Ispostava       = xmlDoc.CreateElement("Ispostava");

                    DatumOd.InnerText       = obrazacArgs.DatumOd;
                    DatumDo.InnerText       = obrazacArgs.DatumDo;
                    Naziv.InnerText         = obrazacArgs.Naziv;
                    OIB.InnerText           = obrazacArgs.OIB;
                    Mjesto.InnerText        = obrazacArgs.Mjesto;
                    Ulica.InnerText         = obrazacArgs.Ulica;
                    BrojUlice.InnerText     = obrazacArgs.BrojUlice;
                    Ime.InnerText           = obrazacArgs.Ime;
                    Prezime.InnerText       = obrazacArgs.Prezime;
                    Ispostava.InnerText     = obrazacArgs.Ispostava;

                xml.AppendChild(Zaglavlje, Razdoblje);
                    xml.AppendChild(Razdoblje, DatumOd);
                    xml.AppendChild(Razdoblje, DatumDo);

                xml.AppendChild(Zaglavlje, Obveznik);
                    xml.AppendChild(Obveznik, Naziv);
                    xml.AppendChild(Obveznik, OIB);
                    xml.AppendChild(Obveznik, Adresa);
                        xml.AppendChild(Adresa, Mjesto);
                        xml.AppendChild(Adresa, Ulica);
                        xml.AppendChild(Adresa, BrojUlice);

                xml.AppendChild(Zaglavlje, ObracunSastavio);
                    xml.AppendChild(ObracunSastavio, Ime);
                    xml.AppendChild(ObracunSastavio, Prezime);

                if(obrazacArgs.Tromjesecje != 0 && !String.IsNullOrEmpty(obrazacArgs.Godina))
                {
                    Tromjesecje     = xmlDoc.CreateElement("Tromjesecje");
                    Godina          = xmlDoc.CreateElement("Godina");       

                    Tromjesecje.InnerText   = obrazacArgs.Tromjesecje.ToString();
                    Godina.InnerText        = obrazacArgs.Godina;

                    xml.AppendChild(Razdoblje, Tromjesecje);
                    xml.AppendChild(Razdoblje, Godina);
                }
                

                xml.AppendChild(Zaglavlje, Ispostava);
                //HEADER END -------------------

                //BODY -------------------------
                Tijelo  = xmlDoc.CreateElement("Tijelo");
                xml     .AppendChild(rootNode, Tijelo);
                // + subnodes
                    Isporuke    = xmlDoc.CreateElement("Isporuke");
                    Ukupno      = xmlDoc.CreateElement("Ukupno");

                    xml.AppendChild(Tijelo, Isporuke);
                    xml.AppendChild(Tijelo, Ukupno);

                    CreateIsporuke();
                    Ukupno.InnerText    = obrazacArgs.Ukupno;

                    xml.AppendChild(Tijelo, Isporuke);
                    xml.AppendChild(Tijelo, Ukupno);
                //BODY END ------------------------

                xmlDoc.Save(@"C:\Users\Kristijan\Desktop\TEMP3\ObrazacPPO.xml");

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void CreateIsporuke()
        {
            try
            {
                foreach(IsporukePPOClass ppoIsporuka in obrazacArgs.isporukePPOList)
                {
                    XmlNode isporukaNode    = xmlDoc.CreateElement("Isporuka");
                    // + subnodes
                        XmlNode podaci  = xmlDoc.CreateElement("Podaci");
                        XmlNode iznos   = xmlDoc.CreateElement("Iznos");
                        XmlNode datumOd = xmlDoc.CreateElement("DatumOd");
                        XmlNode datumDo = xmlDoc.CreateElement("DatumDo");

                        iznos.InnerText     = ppoIsporuka.Iznos;
                        datumOd.InnerText   = ppoIsporuka.DatumOd;
                        datumDo.InnerText   = ppoIsporuka.DatumDo;

                        xml.AppendChild(isporukaNode, podaci);
                        xml.AppendChild(isporukaNode, iznos);
                        xml.AppendChild(isporukaNode, datumOd);
                        xml.AppendChild(isporukaNode, datumDo);

                    foreach (PodaciPPOClass podatak in ppoIsporuka.PodaciList)
                    {
                        XmlNode podatakNode = xmlDoc.CreateElement("Podatak");
                        // + subnodes
                            XmlNode podatakRedBr = xmlDoc.CreateElement("RedniBroj");
                            XmlNode podatakOIB   = xmlDoc.CreateElement("OIB");
                            XmlNode podatakIznos = xmlDoc.CreateElement("Iznos");

                            podatakRedBr.InnerText  = podatak.RedniBroj;
                            podatakOIB.InnerText    = podatak.OIB;
                            podatakIznos.InnerText  = podatak.Iznos;

                            xml.AppendChild(podatakNode, podatakRedBr);
                            xml.AppendChild(podatakNode, podatakOIB);
                            xml.AppendChild(podatakNode, podatakIznos);

                        xml.AppendChild(podaci, podatakNode);
                    }

                    xml.AppendChild(Isporuke, isporukaNode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška kod pisanja isporuka i podataka: " + ex.Message);
            }
        }
    }
}
