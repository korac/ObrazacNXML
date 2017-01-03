using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NXML
{
    class ObrazacZP
    {
        //*****************************************************************************************//
        //-----------------------------------------------------------------------------------------//
        //                       OBRAZAC ZP (03.01.2017 by K.KORAĆ ;) )                            //
        //-----------------------------------------------------------------------------------------//
        //*****************************************************************************************//

        private XMLHelpBuilder xml;
        private XmlDocument xmlDoc;
        private ObrazacZPArgs obrazacArgs;

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
                XmlNode Telefon;
                XmlNode Email;
            XmlNode Ispostava;
        //--------

        //BODY
        XmlNode Tijelo;
        // + subnodes
            XmlNode Isporuke;
            XmlNode IsporukeUkupno;
            // + subnodes
                XmlNode I1;
                XmlNode I2;
                XmlNode I3;
                XmlNode I4;
        #endregion

        #region Strings
        string rootAttributeXmlnsName   = "xmlns";
        string rootAttributeXmlnsText   = "http://e-porezna.porezna-uprava.hr/sheme/zahtjevi/ObrazacZP/v1-0";
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

        public ObrazacZP(ObrazacZPArgs args)
        {
            this.obrazacArgs = args;
        }

        public bool CreateObrazacZP()
        {
            try
            {
                xmlDoc  = new XmlDocument();
                xml     = new XMLHelpBuilder(xmlDoc);

                xml     .CreateXmlDeclaration();

                //ROOT -----------------------
                rootNode                        = xmlDoc.CreateElement("ObrazacZP");

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
                    Obveznik        = xmlDoc.CreateElement("Obveznik");
                    Naziv           = xmlDoc.CreateElement("Naziv");
                    OIB             = xmlDoc.CreateElement("OIB");
                    Adresa          = xmlDoc.CreateElement("Adresa");
                    Mjesto          = xmlDoc.CreateElement("Mjesto");
                    Ulica           = xmlDoc.CreateElement("Ulica");
                    BrojUlice       = xmlDoc.CreateElement("Broj");
                    Ime             = xmlDoc.CreateElement("Ime");
                    Prezime         = xmlDoc.CreateElement("Prezime");
                    Telefon         = xmlDoc.CreateElement("Telefon");
                    Email           = xmlDoc.CreateElement("Email");
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
                    Telefon.InnerText       = obrazacArgs.Telefon;
                    Email.InnerText         = obrazacArgs.Email;
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
                    xml.AppendChild(ObracunSastavio, Telefon);
                    xml.AppendChild(ObracunSastavio, Email);

                xml.AppendChild(Zaglavlje, Ispostava);
                //HEADER END -------------------

                //BODY -------------------------
                Tijelo  = xmlDoc.CreateElement("Tijelo");
                xml     .AppendChild(rootNode, Tijelo);
                // + subnodes
                    Isporuke        = xmlDoc.CreateElement("Isporuke");
                    // + subnodes
                    CreateIsporuke();    

                    xml             .AppendChild(Tijelo, Isporuke);                    
                    

                    IsporukeUkupno  = xmlDoc.CreateElement("IsporukeUkupno");
                    // + subnodes
                        I1  = xmlDoc.CreateElement("I1");
                        I2  = xmlDoc.CreateElement("I2");
                        I3  = xmlDoc.CreateElement("I3");
                        I4  = xmlDoc.CreateElement("I4");

                        I1.InnerText = obrazacArgs.I1;
                        I2.InnerText = obrazacArgs.I2;
                        I3.InnerText = obrazacArgs.I3;
                        I4.InnerText = obrazacArgs.I4;

                    xml.AppendChild(Tijelo, IsporukeUkupno);
                        xml.AppendChild(IsporukeUkupno, I1);
                        xml.AppendChild(IsporukeUkupno, I2);
                        xml.AppendChild(IsporukeUkupno, I3);
                        xml.AppendChild(IsporukeUkupno, I4);                    
                //BODY END ---------------------

                xmlDoc.Save(@"C:\Users\Kristijan\Desktop\TEMP3\ObrazacZP.xml");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
                return false;
            }
        }

        private void CreateIsporuke()
        {
            foreach(IsporukeZPClass isporuka in obrazacArgs.isporukeList)
            {
                XmlNode isporukaNode = xmlDoc.CreateElement("Isporuka");
                // + subnodes
                    XmlNode isporukaRedBr       = xmlDoc.CreateElement("RedBr");
                    XmlNode isporukaKodDrzave   = xmlDoc.CreateElement("KodDrzave");
                    XmlNode isporukaPDVID       = xmlDoc.CreateElement("PDVID");
                    XmlNode isporukaI1          = xmlDoc.CreateElement("I1");
                    XmlNode isporukaI2          = xmlDoc.CreateElement("I2");
                    XmlNode isporukaI3          = xmlDoc.CreateElement("I3");
                    XmlNode isporukaI4          = xmlDoc.CreateElement("I4");

                    isporukaRedBr.InnerText     = isporuka.RedBr;
                    isporukaKodDrzave.InnerText = isporuka.KodDrzave;
                    isporukaPDVID.InnerText     = isporuka.PDVID;
                    isporukaI1.InnerText        = isporuka.I1;
                    isporukaI2.InnerText        = isporuka.I2;
                    isporukaI3.InnerText        = isporuka.I3;
                    isporukaI4.InnerText        = isporuka.I4;

                    xml.AppendChild(isporukaNode, isporukaRedBr);
                    xml.AppendChild(isporukaNode, isporukaKodDrzave);
                    xml.AppendChild(isporukaNode, isporukaPDVID);
                    xml.AppendChild(isporukaNode, isporukaI1);
                    xml.AppendChild(isporukaNode, isporukaI2);
                    xml.AppendChild(isporukaNode, isporukaI3);
                    xml.AppendChild(isporukaNode, isporukaI4);

                xml.AppendChild(Isporuke, isporukaNode);
            }
        }

    }
}
