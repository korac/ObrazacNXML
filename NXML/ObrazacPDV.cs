using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NXML
{
    class ObrazacPDV
    {
        //*****************************************************************************************//
        //-----------------------------------------------------------------------------------------//
        //                       OBRAZAC PDV (29.12.2016 by K.KORAĆ ;) )                           //
        //-----------------------------------------------------------------------------------------//
        //*****************************************************************************************//

        private XMLHelpBuilder xml;
        private XmlDocument xmlDoc;
        private ObrazacPDVArgs obrazacArgs;

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
            XmlNode Podatak000;
            XmlNode Podatak100;
            XmlNode Podatak101;
            XmlNode Podatak102;
            XmlNode Podatak103;
            XmlNode Podatak104;
            XmlNode Podatak105;
            XmlNode Podatak106;
            XmlNode Podatak107;
            XmlNode Podatak108;
            XmlNode Podatak109;
            XmlNode Podatak110;

            XmlNode Podatak200;
            // + subnodes
                XmlNode Vrijednost;
                XmlNode Porez;

            XmlNode Podatak201;
            // + subnodes
            XmlNode Podatak202;
            // + subnodes
            XmlNode Podatak203;
            // + subnodes
            XmlNode Podatak204;
            // + subnodes
            XmlNode Podatak205;
            // + subnodes
            XmlNode Podatak206;
            // + subnodes
            XmlNode Podatak207;
            // + subnodes
            XmlNode Podatak208;
            // + subnodes
            XmlNode Podatak209;
            // + subnodes
            XmlNode Podatak210;
            // + subnodes
            XmlNode Podatak211;
            // + subnodes
            XmlNode Podatak212;
            // + subnodes
            XmlNode Podatak213;
            // + subnodes
            XmlNode Podatak214;
            // + subnodes
            XmlNode Podatak215;
            // + subnodes
            XmlNode Podatak300;
            // + subnodes
            XmlNode Podatak301;
            // + subnodes
            XmlNode Podatak302;
            // + subnodes
            XmlNode Podatak303;
            // + subnodes
            XmlNode Podatak304;
            // + subnodes
            XmlNode Podatak305;
            // + subnodes
            XmlNode Podatak306;
            // + subnodes
            XmlNode Podatak307;
            // + subnodes
            XmlNode Podatak308;
            // + subnodes
            XmlNode Podatak309;
            // + subnodes
            XmlNode Podatak310;
            // + subnodes
            XmlNode Podatak311;
            // + subnodes
            XmlNode Podatak312;
            // + subnodes
            XmlNode Podatak313;
            // + subnodes
            XmlNode Podatak314;
            // + subnodes

            XmlNode Podatak315;
            XmlNode Podatak400;
            XmlNode Podatak500;
            XmlNode Podatak600;
            XmlNode Podatak700;
            XmlNode Podatak810;
            XmlNode Podatak811;
            XmlNode Podatak812;
            XmlNode Podatak813;
            XmlNode Podatak814;
            XmlNode Podatak815;
            XmlNode Podatak820;
            XmlNode Podatak830;

            XmlNode Podatak831;
            // + subnodes
                //XmlNode Vrijednost;
                //XmlNode Broj;
            XmlNode Podatak832;
            // + subnodes
                //XmlNode Vrijednost;
                //XmlNode Broj;
            XmlNode Podatak833;
            // + subnodes
                //XmlNode Vrijednost;
                //XmlNode Broj;

            XmlNode Podatak840;
            XmlNode Podatak850;
            XmlNode Podatak860;
            XmlNode Podatak870;
        //--------
        #endregion

        #region Strings
        string rootAttributeXmlnsName   = "xmlns";
        string rootAttributeXmlnsText   = "http://e-porezna.porezna-uprava.hr/sheme/zahtjevi/ObrazacPDV/v9-0";
        string rootAttributeVerzijaName = "verzijaSheme";
        string rootAttributeVerzijaText = "9.0";
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

        public ObrazacPDV(ObrazacPDVArgs obArgs)
        {
            this.obrazacArgs = obArgs;
        }

        public bool CreateObrazacPDV()
        {
            try
            {
                xmlDoc  = new XmlDocument();
                xml     = new XMLHelpBuilder(xmlDoc);

                xml     .CreateXmlDeclaration();

                //ROOT -----------------------
                rootNode                        = xmlDoc.CreateElement("ObrazacPDV");

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
                ObracunSastavio = xmlDoc.CreateElement("ObracunSastavio");
                Ispostava       = xmlDoc.CreateElement("Ispostava");

                DatumOd.InnerText   = obrazacArgs.DatumOd;
                DatumDo.InnerText   = obrazacArgs.DatumDo;
                Naziv.InnerText     = obrazacArgs.Naziv;
                OIB.InnerText       = obrazacArgs.OIB;
                Mjesto.InnerText    = obrazacArgs.Mjesto;
                Ulica.InnerText     = obrazacArgs.Ulica;
                BrojUlice.InnerText = obrazacArgs.BrojUlice;
                Ime.InnerText       = obrazacArgs.Ime;
                Prezime.InnerText   = obrazacArgs.Prezime;
                Ispostava.InnerText = obrazacArgs.Ispostava;


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

                xml.AppendChild(Zaglavlje, Ispostava);
                //HEADER END -------------------


                //xml.AppendChild(Tijelo, Podatak100);
                //xml.AppendChild(Tijelo, Podatak101);
                //xml.AppendChild(Tijelo, Podatak102);
                //xml.AppendChild(Tijelo, Podatak103);
                //xml.AppendChild(Tijelo, Podatak104);
                //xml.AppendChild(Tijelo, Podatak105);
                //xml.AppendChild(Tijelo, Podatak106);
                //xml.AppendChild(Tijelo, Podatak107);
                //xml.AppendChild(Tijelo, Podatak108);
                //xml.AppendChild(Tijelo, Podatak109);

                //xml.AppendChild(Tijelo, Podatak200);
                //xml.AppendChild(Tijelo, Podatak201);
                //xml.AppendChild(Tijelo, Podatak202);
                //xml.AppendChild(Tijelo, Podatak203);
                //xml.AppendChild(Tijelo, Podatak204);
                //xml.AppendChild(Tijelo, Podatak205);
                //xml.AppendChild(Tijelo, Podatak206);
                //xml.AppendChild(Tijelo, Podatak207);
                //xml.AppendChild(Tijelo, Podatak208);
                //xml.AppendChild(Tijelo, Podatak209);
                //xml.AppendChild(Tijelo, Podatak210);
                //xml.AppendChild(Tijelo, Podatak211);
                //xml.AppendChild(Tijelo, Podatak212);
                //xml.AppendChild(Tijelo, Podatak213);
                //xml.AppendChild(Tijelo, Podatak214);

                xmlDoc.Save(@"C:\Users\Kristijan\Desktop\TEMP3\NXML.xml");
                

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
