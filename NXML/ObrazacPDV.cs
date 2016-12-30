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
                XmlNode Podatak200Vrijednost;
                XmlNode Podatak200Porez;

            XmlNode Podatak201;
            // + subnodes
                XmlNode Podatak201Vrijednost;
                XmlNode Podatak201Porez;
            XmlNode Podatak202;
            // + subnodes
                XmlNode Podatak202Vrijednost;
                XmlNode Podatak202Porez;

            XmlNode Podatak203;
            // + subnodes
                XmlNode Podatak203Vrijednost;
                XmlNode Podatak203Porez;

            XmlNode Podatak204;
            // + subnodes
                XmlNode Podatak204Vrijednost;
                XmlNode Podatak204Porez;

            XmlNode Podatak205;
            // + subnodes
                XmlNode Podatak205Vrijednost;
                XmlNode Podatak205Porez;

            XmlNode Podatak206;
            // + subnodes
                XmlNode Podatak206Vrijednost;
                XmlNode Podatak206Porez;

            XmlNode Podatak207;
            // + subnodes
                XmlNode Podatak207Vrijednost;
                XmlNode Podatak207Porez;

            XmlNode Podatak208;
            // + subnodes
                XmlNode Podatak208Vrijednost;
                XmlNode Podatak208Porez;

            XmlNode Podatak209;
            // + subnodes
                XmlNode Podatak209Vrijednost;
                XmlNode Podatak209Porez;

            XmlNode Podatak210;
            // + subnodes
                XmlNode Podatak210Vrijednost;
                XmlNode Podatak210Porez;

            XmlNode Podatak211;
            // + subnodes
                XmlNode Podatak211Vrijednost;
                XmlNode Podatak211Porez;

            XmlNode Podatak212;
            // + subnodes
                XmlNode Podatak212Vrijednost;
                XmlNode Podatak212Porez;

            XmlNode Podatak213;
            // + subnodes
                XmlNode Podatak213Vrijednost;
                XmlNode Podatak213Porez;

            XmlNode Podatak214;
            // + subnodes
                XmlNode Podatak214Vrijednost;
                XmlNode Podatak214Porez;

            XmlNode Podatak215;
            // + subnodes
                XmlNode Podatak215Vrijednost;
                XmlNode Podatak215Porez;

            XmlNode Podatak300;
            // + subnodes
                XmlNode Podatak300Vrijednost;
                XmlNode Podatak300Porez;

            XmlNode Podatak301;
            // + subnodes
                XmlNode Podatak301Vrijednost;
                XmlNode Podatak301Porez;

            XmlNode Podatak302;
            // + subnodes
                XmlNode Podatak302Vrijednost;
                XmlNode Podatak302Porez;

            XmlNode Podatak303;
            // + subnodes
                XmlNode Podatak303Vrijednost;
                XmlNode Podatak303Porez;

            XmlNode Podatak304;
            // + subnodes
                XmlNode Podatak304Vrijednost;
                XmlNode Podatak304Porez;

            XmlNode Podatak305;
            // + subnodes
                XmlNode Podatak305Vrijednost;
                XmlNode Podatak305Porez;

            XmlNode Podatak306;
            // + subnodes
                XmlNode Podatak306Vrijednost;
                XmlNode Podatak306Porez;

            XmlNode Podatak307;
            // + subnodes
                XmlNode Podatak307Vrijednost;
                XmlNode Podatak307Porez;

            XmlNode Podatak308;
            // + subnodes
                XmlNode Podatak308Vrijednost;
                XmlNode Podatak308Porez;

            XmlNode Podatak309;
            // + subnodes
                XmlNode Podatak309Vrijednost;
                XmlNode Podatak309Porez;

            XmlNode Podatak310;
            // + subnodes
                XmlNode Podatak310Vrijednost;
                XmlNode Podatak310Porez;

            XmlNode Podatak311;
            // + subnodes
                XmlNode Podatak311Vrijednost;
                XmlNode Podatak311Porez;

            XmlNode Podatak312;
            // + subnodes
                XmlNode Podatak312Vrijednost;
                XmlNode Podatak312Porez;

            XmlNode Podatak313;
            // + subnodes
                XmlNode Podatak313Vrijednost;
                XmlNode Podatak313Porez;

            XmlNode Podatak314;
            // + subnodes
                XmlNode Podatak314Vrijednost;
                XmlNode Podatak314Porez;

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
                XmlNode Podatak831Vrijednost;
                XmlNode Podatak831Broj;

            XmlNode Podatak832;
            // + subnodes
                XmlNode Podatak832Vrijednost;
                XmlNode Podatak832Broj;

            XmlNode Podatak833;
            // + subnodes
                XmlNode Podatak833Vrijednost;
                XmlNode Podatak833Broj;

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

                //BODY -------------------------
                Tijelo  = xmlDoc.CreateElement("Tijelo");
                xml     .AppendChild(rootNode, Tijelo);
                // + subnodes
                Podatak000              = xmlDoc.CreateElement("Podatak000");
                Podatak000.InnerText    = obrazacArgs.Podatak000;
                Podatak100              = xmlDoc.CreateElement("Podatak100");
                Podatak100.InnerText    = obrazacArgs.Podatak100;
                Podatak101              = xmlDoc.CreateElement("Podatak101");
                Podatak101.InnerText    = obrazacArgs.Podatak101;
                Podatak102              = xmlDoc.CreateElement("Podatak102");
                Podatak102.InnerText    = obrazacArgs.Podatak102;
                Podatak103              = xmlDoc.CreateElement("Podatak103");
                Podatak103.InnerText    = obrazacArgs.Podatak103;
                Podatak104              = xmlDoc.CreateElement("Podatak104");
                Podatak104.InnerText    = obrazacArgs.Podatak104;
                Podatak105              = xmlDoc.CreateElement("Podatak105");
                Podatak105.InnerText    = obrazacArgs.Podatak105;
                Podatak106              = xmlDoc.CreateElement("Podatak106");
                Podatak106.InnerText    = obrazacArgs.Podatak106;
                Podatak107              = xmlDoc.CreateElement("Podatak107");
                Podatak107.InnerText    = obrazacArgs.Podatak107;
                Podatak108              = xmlDoc.CreateElement("Podatak108");
                Podatak108.InnerText    = obrazacArgs.Podatak108;
                Podatak109              = xmlDoc.CreateElement("Podatak109");
                Podatak109.InnerText    = obrazacArgs.Podatak109;
                Podatak110              = xmlDoc.CreateElement("Podatak110");
                Podatak110.InnerText    = obrazacArgs.Podatak110;

                xml.AppendChild(Tijelo, Podatak000);
                xml.AppendChild(Tijelo, Podatak100);
                xml.AppendChild(Tijelo, Podatak101);
                xml.AppendChild(Tijelo, Podatak102);
                xml.AppendChild(Tijelo, Podatak103);
                xml.AppendChild(Tijelo, Podatak104);
                xml.AppendChild(Tijelo, Podatak105);
                xml.AppendChild(Tijelo, Podatak106);
                xml.AppendChild(Tijelo, Podatak107);
                xml.AppendChild(Tijelo, Podatak108);
                xml.AppendChild(Tijelo, Podatak109);

                Podatak200                      = xmlDoc.CreateElement("Podatak200");
                Podatak200Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak200Vrijednost.InnerText  = obrazacArgs.Podatak200Vrijednost;
                Podatak200Porez                 = xmlDoc.CreateElement("Porez");
                Podatak200Porez.InnerText       = obrazacArgs.Podatak200Porez;

                Podatak201                      = xmlDoc.CreateElement("Podatak201");
                Podatak201Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak201Vrijednost.InnerText  = obrazacArgs.Podatak201Vrijednost;
                Podatak201Porez                 = xmlDoc.CreateElement("Porez");
                Podatak201Porez.InnerText       = obrazacArgs.Podatak201Porez;

                Podatak202                      = xmlDoc.CreateElement("Podatak202");
                Podatak202Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak202Vrijednost.InnerText  = obrazacArgs.Podatak202Vrijednost;
                Podatak202Porez                 = xmlDoc.CreateElement("Porez");
                Podatak202Porez.InnerText       = obrazacArgs.Podatak202Porez;

                Podatak203                      = xmlDoc.CreateElement("Podatak203");
                Podatak203Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak203Vrijednost.InnerText  = obrazacArgs.Podatak203Vrijednost;
                Podatak203Porez                 = xmlDoc.CreateElement("Porez");
                Podatak203Porez.InnerText       = obrazacArgs.Podatak203Porez;

                Podatak204                      = xmlDoc.CreateElement("Podatak204");
                Podatak204Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak204Vrijednost.InnerText  = obrazacArgs.Podatak204Vrijednost;
                Podatak204Porez                 = xmlDoc.CreateElement("Porez");
                Podatak204Porez.InnerText       = obrazacArgs.Podatak204Porez;

                Podatak205                      = xmlDoc.CreateElement("Podatak205");
                Podatak205Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak205Vrijednost.InnerText  = obrazacArgs.Podatak205Vrijednost;
                Podatak205Porez                 = xmlDoc.CreateElement("Porez");
                Podatak205Porez.InnerText       = obrazacArgs.Podatak205Porez;

                Podatak206                      = xmlDoc.CreateElement("Podatak206");
                Podatak206Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak206Vrijednost.InnerText  = obrazacArgs.Podatak206Vrijednost;
                Podatak206Porez                 = xmlDoc.CreateElement("Porez");
                Podatak206Porez.InnerText       = obrazacArgs.Podatak206Porez;

                Podatak207                      = xmlDoc.CreateElement("Podatak207");
                Podatak207Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak207Vrijednost.InnerText  = obrazacArgs.Podatak207Vrijednost;
                Podatak207Porez                 = xmlDoc.CreateElement("Porez");
                Podatak207Porez.InnerText       = obrazacArgs.Podatak207Porez;

                Podatak208                      = xmlDoc.CreateElement("Podatak208");
                Podatak208Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak208Vrijednost.InnerText  = obrazacArgs.Podatak208Vrijednost;
                Podatak208Porez                 = xmlDoc.CreateElement("Porez");
                Podatak208Porez.InnerText       = obrazacArgs.Podatak208Porez;

                Podatak209                      = xmlDoc.CreateElement("Podatak209");
                Podatak209Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak209Vrijednost.InnerText  = obrazacArgs.Podatak209Vrijednost;
                Podatak209Porez                 = xmlDoc.CreateElement("Porez");
                Podatak209Porez.InnerText       = obrazacArgs.Podatak209Porez;

                Podatak210                      = xmlDoc.CreateElement("Podatak210");
                Podatak210Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak210Vrijednost.InnerText  = obrazacArgs.Podatak210Vrijednost;
                Podatak210Porez                 = xmlDoc.CreateElement("Porez");
                Podatak210Porez.InnerText       = obrazacArgs.Podatak210Porez;

                Podatak211                      = xmlDoc.CreateElement("Podatak211");
                Podatak211Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak211Vrijednost.InnerText  = obrazacArgs.Podatak211Vrijednost;
                Podatak211Porez                 = xmlDoc.CreateElement("Porez");
                Podatak211Porez.InnerText       = obrazacArgs.Podatak211Porez;

                Podatak212                      = xmlDoc.CreateElement("Podatak212");
                Podatak212Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak212Vrijednost.InnerText  = obrazacArgs.Podatak212Vrijednost;
                Podatak212Porez                 = xmlDoc.CreateElement("Porez");
                Podatak212Porez.InnerText       = obrazacArgs.Podatak212Porez;

                Podatak213                      = xmlDoc.CreateElement("Podatak213");
                Podatak213Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak213Vrijednost.InnerText  = obrazacArgs.Podatak213Vrijednost;
                Podatak213Porez                 = xmlDoc.CreateElement("Porez");
                Podatak213Porez.InnerText       = obrazacArgs.Podatak213Porez;

                Podatak214                      = xmlDoc.CreateElement("Podatak214");
                Podatak214Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak214Vrijednost.InnerText  = obrazacArgs.Podatak214Vrijednost;
                Podatak214Porez                 = xmlDoc.CreateElement("Porez");
                Podatak214Porez.InnerText       = obrazacArgs.Podatak214Porez;

                Podatak215                      = xmlDoc.CreateElement("Podatak215");
                Podatak215Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak215Vrijednost.InnerText  = obrazacArgs.Podatak215Vrijednost;
                Podatak215Porez                 = xmlDoc.CreateElement("Porez");
                Podatak215Porez.InnerText       = obrazacArgs.Podatak215Porez;

                xml.AppendChild(Tijelo, Podatak200);
                    xml.AppendChild(Podatak200, Podatak200Vrijednost);
                    xml.AppendChild(Podatak200, Podatak200Porez);

                xml.AppendChild(Tijelo, Podatak201);
                    xml.AppendChild(Podatak201, Podatak201Vrijednost);
                    xml.AppendChild(Podatak201, Podatak201Porez);

                xml.AppendChild(Tijelo, Podatak202);
                    xml.AppendChild(Podatak202, Podatak202Vrijednost);
                    xml.AppendChild(Podatak202, Podatak202Porez);

                xml.AppendChild(Tijelo, Podatak203);
                    xml.AppendChild(Podatak203, Podatak203Vrijednost);
                    xml.AppendChild(Podatak203, Podatak203Porez);

                xml.AppendChild(Tijelo, Podatak204);
                    xml.AppendChild(Podatak204, Podatak204Vrijednost);
                    xml.AppendChild(Podatak204, Podatak204Porez);

                xml.AppendChild(Tijelo, Podatak205);
                    xml.AppendChild(Podatak205, Podatak205Vrijednost);
                    xml.AppendChild(Podatak205, Podatak205Porez);

                xml.AppendChild(Tijelo, Podatak206);
                    xml.AppendChild(Podatak206, Podatak206Vrijednost);
                    xml.AppendChild(Podatak206, Podatak206Porez);

                xml.AppendChild(Tijelo, Podatak207);
                    xml.AppendChild(Podatak207, Podatak207Vrijednost);
                    xml.AppendChild(Podatak207, Podatak207Porez);

                xml.AppendChild(Tijelo, Podatak208);
                    xml.AppendChild(Podatak208, Podatak208Vrijednost);
                    xml.AppendChild(Podatak208, Podatak208Porez);

                xml.AppendChild(Tijelo, Podatak209);
                    xml.AppendChild(Podatak209, Podatak209Vrijednost);
                    xml.AppendChild(Podatak209, Podatak209Porez);

                xml.AppendChild(Tijelo, Podatak210);
                    xml.AppendChild(Podatak210, Podatak210Vrijednost);
                    xml.AppendChild(Podatak210, Podatak210Porez);

                xml.AppendChild(Tijelo, Podatak211);
                    xml.AppendChild(Podatak211, Podatak211Vrijednost);
                    xml.AppendChild(Podatak211, Podatak211Porez);

                xml.AppendChild(Tijelo, Podatak212);
                    xml.AppendChild(Podatak212, Podatak212Vrijednost);
                    xml.AppendChild(Podatak212, Podatak212Porez);

                xml.AppendChild(Tijelo, Podatak213);
                    xml.AppendChild(Podatak213, Podatak213Vrijednost);
                    xml.AppendChild(Podatak213, Podatak213Porez);

                xml.AppendChild(Tijelo, Podatak214);
                    xml.AppendChild(Podatak214, Podatak214Vrijednost);
                    xml.AppendChild(Podatak214, Podatak214Porez);

                xml.AppendChild(Tijelo, Podatak215);
                    xml.AppendChild(Podatak215, Podatak215Vrijednost);
                    xml.AppendChild(Podatak215, Podatak215Porez);

                //300+
                Podatak300                      = xmlDoc.CreateElement("Podatak300");
                Podatak300Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak300Vrijednost.InnerText  = obrazacArgs.Podatak300Vrijednost;
                Podatak300Porez                 = xmlDoc.CreateElement("Porez");
                Podatak300Porez.InnerText       = obrazacArgs.Podatak300Porez;
                       
                Podatak301                      = xmlDoc.CreateElement("Podatak301");
                Podatak301Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak301Vrijednost.InnerText  = obrazacArgs.Podatak301Vrijednost;
                Podatak301Porez                 = xmlDoc.CreateElement("Porez");
                Podatak301Porez.InnerText       = obrazacArgs.Podatak301Porez;
                       
                Podatak302                      = xmlDoc.CreateElement("Podatak302");
                Podatak302Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak302Vrijednost.InnerText  = obrazacArgs.Podatak302Vrijednost;
                Podatak302Porez                 = xmlDoc.CreateElement("Porez");
                Podatak302Porez.InnerText       = obrazacArgs.Podatak302Porez;
                       
                Podatak303                      = xmlDoc.CreateElement("Podatak303");
                Podatak303Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak303Vrijednost.InnerText  = obrazacArgs.Podatak303Vrijednost;
                Podatak303Porez                 = xmlDoc.CreateElement("Porez");
                Podatak303Porez.InnerText       = obrazacArgs.Podatak303Porez;
                       
                Podatak304                      = xmlDoc.CreateElement("Podatak304");
                Podatak304Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak304Vrijednost.InnerText  = obrazacArgs.Podatak304Vrijednost;
                Podatak304Porez                 = xmlDoc.CreateElement("Porez");
                Podatak304Porez.InnerText       = obrazacArgs.Podatak304Porez;
                       
                Podatak305                      = xmlDoc.CreateElement("Podatak305");
                Podatak305Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak305Vrijednost.InnerText  = obrazacArgs.Podatak305Vrijednost;
                Podatak305Porez                 = xmlDoc.CreateElement("Porez");
                Podatak305Porez.InnerText       = obrazacArgs.Podatak305Porez;
                       
                Podatak306                      = xmlDoc.CreateElement("Podatak306");
                Podatak306Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak306Vrijednost.InnerText  = obrazacArgs.Podatak306Vrijednost;
                Podatak306Porez                 = xmlDoc.CreateElement("Porez");
                Podatak306Porez.InnerText       = obrazacArgs.Podatak306Porez;
                       
                Podatak307                      = xmlDoc.CreateElement("Podatak307");
                Podatak307Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak307Vrijednost.InnerText  = obrazacArgs.Podatak307Vrijednost;
                Podatak307Porez                 = xmlDoc.CreateElement("Porez");
                Podatak307Porez.InnerText       = obrazacArgs.Podatak307Porez;
                       
                Podatak308                      = xmlDoc.CreateElement("Podatak308");
                Podatak308Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak308Vrijednost.InnerText  = obrazacArgs.Podatak308Vrijednost;
                Podatak308Porez                 = xmlDoc.CreateElement("Porez");
                Podatak308Porez.InnerText       = obrazacArgs.Podatak308Porez;
                       
                Podatak309                      = xmlDoc.CreateElement("Podatak309");
                Podatak309Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak309Vrijednost.InnerText  = obrazacArgs.Podatak309Vrijednost;
                Podatak309Porez                 = xmlDoc.CreateElement("Porez");
                Podatak309Porez.InnerText       = obrazacArgs.Podatak309Porez;
                       
                Podatak310                      = xmlDoc.CreateElement("Podatak310");
                Podatak310Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak310Vrijednost.InnerText  = obrazacArgs.Podatak310Vrijednost;
                Podatak310Porez                 = xmlDoc.CreateElement("Porez");
                Podatak310Porez.InnerText       = obrazacArgs.Podatak310Porez;
                       
                Podatak311                      = xmlDoc.CreateElement("Podatak311");
                Podatak311Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak311Vrijednost.InnerText  = obrazacArgs.Podatak311Vrijednost;
                Podatak311Porez                 = xmlDoc.CreateElement("Porez");
                Podatak311Porez.InnerText       = obrazacArgs.Podatak311Porez;
                       
                Podatak312                      = xmlDoc.CreateElement("Podatak312");
                Podatak312Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak312Vrijednost.InnerText  = obrazacArgs.Podatak312Vrijednost;
                Podatak312Porez                 = xmlDoc.CreateElement("Porez");
                Podatak312Porez.InnerText       = obrazacArgs.Podatak312Porez;
                       
                Podatak313                      = xmlDoc.CreateElement("Podatak313");
                Podatak313Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak313Vrijednost.InnerText  = obrazacArgs.Podatak313Vrijednost;
                Podatak313Porez                 = xmlDoc.CreateElement("Porez");
                Podatak313Porez.InnerText       = obrazacArgs.Podatak313Porez;
                       
                Podatak314                      = xmlDoc.CreateElement("Podatak314");
                Podatak314Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak314Vrijednost.InnerText  = obrazacArgs.Podatak314Vrijednost;
                Podatak314Porez                 = xmlDoc.CreateElement("Porez");
                Podatak314Porez.InnerText       = obrazacArgs.Podatak314Porez;

                xml.AppendChild(Tijelo, Podatak300);
                    xml.AppendChild(Podatak300, Podatak300Vrijednost);
                    xml.AppendChild(Podatak300, Podatak300Porez);

                xml.AppendChild(Tijelo, Podatak301);
                    xml.AppendChild(Podatak301, Podatak301Vrijednost);
                    xml.AppendChild(Podatak301, Podatak301Porez);

                xml.AppendChild(Tijelo, Podatak302);
                    xml.AppendChild(Podatak302, Podatak302Vrijednost);
                    xml.AppendChild(Podatak302, Podatak302Porez);

                xml.AppendChild(Tijelo, Podatak303);
                    xml.AppendChild(Podatak303, Podatak303Vrijednost);
                    xml.AppendChild(Podatak303, Podatak303Porez);

                xml.AppendChild(Tijelo, Podatak304);
                    xml.AppendChild(Podatak304, Podatak304Vrijednost);
                    xml.AppendChild(Podatak304, Podatak304Porez);

                xml.AppendChild(Tijelo, Podatak305);
                    xml.AppendChild(Podatak305, Podatak305Vrijednost);
                    xml.AppendChild(Podatak305, Podatak305Porez);

                xml.AppendChild(Tijelo, Podatak306);
                    xml.AppendChild(Podatak306, Podatak306Vrijednost);
                    xml.AppendChild(Podatak306, Podatak306Porez);

                xml.AppendChild(Tijelo, Podatak307);
                    xml.AppendChild(Podatak307, Podatak307Vrijednost);
                    xml.AppendChild(Podatak307, Podatak307Porez);

                xml.AppendChild(Tijelo, Podatak308);
                    xml.AppendChild(Podatak308, Podatak308Vrijednost);
                    xml.AppendChild(Podatak308, Podatak308Porez);

                xml.AppendChild(Tijelo, Podatak309);
                    xml.AppendChild(Podatak309, Podatak309Vrijednost);
                    xml.AppendChild(Podatak309, Podatak309Porez);

                xml.AppendChild(Tijelo, Podatak310);
                    xml.AppendChild(Podatak310, Podatak310Vrijednost);
                    xml.AppendChild(Podatak310, Podatak310Porez);

                xml.AppendChild(Tijelo, Podatak311);
                    xml.AppendChild(Podatak311, Podatak311Vrijednost);
                    xml.AppendChild(Podatak311, Podatak311Porez);

                xml.AppendChild(Tijelo, Podatak312);
                    xml.AppendChild(Podatak312, Podatak312Vrijednost);
                    xml.AppendChild(Podatak312, Podatak312Porez);

                xml.AppendChild(Tijelo, Podatak313);
                    xml.AppendChild(Podatak313, Podatak313Vrijednost);
                    xml.AppendChild(Podatak313, Podatak313Porez);

                xml.AppendChild(Tijelo, Podatak314);
                    xml.AppendChild(Podatak314, Podatak314Vrijednost);
                    xml.AppendChild(Podatak314, Podatak314Porez);

                
                //315
                Podatak315              = xmlDoc.CreateElement("Podatak315");
                Podatak315.InnerText    = obrazacArgs.Podatak315;

                Podatak400              = xmlDoc.CreateElement("Podatak400");
                Podatak400.InnerText    = obrazacArgs.Podatak400;

                Podatak500              = xmlDoc.CreateElement("Podatak500");
                Podatak500.InnerText    = obrazacArgs.Podatak500;
                        
                Podatak600              = xmlDoc.CreateElement("Podatak600");
                Podatak600.InnerText    = obrazacArgs.Podatak600;
                        
                Podatak700              = xmlDoc.CreateElement("Podatak700");
                Podatak700.InnerText    = obrazacArgs.Podatak700;

                Podatak810              = xmlDoc.CreateElement("Podatak810");
                Podatak810.InnerText    = obrazacArgs.Podatak810;

                Podatak811              = xmlDoc.CreateElement("Podatak811");
                Podatak811.InnerText    = obrazacArgs.Podatak811;
                       
                Podatak812              = xmlDoc.CreateElement("Podatak812");
                Podatak812.InnerText    = obrazacArgs.Podatak812;
                       
                Podatak813              = xmlDoc.CreateElement("Podatak813");
                Podatak813.InnerText    = obrazacArgs.Podatak813;
                       
                Podatak814              = xmlDoc.CreateElement("Podatak814");
                Podatak814.InnerText    = obrazacArgs.Podatak814;

                Podatak815              = xmlDoc.CreateElement("Podatak815");
                Podatak815.InnerText    = obrazacArgs.Podatak815;

                Podatak820              = xmlDoc.CreateElement("Podatak820");
                Podatak820.InnerText    = obrazacArgs.Podatak820;

                Podatak830              = xmlDoc.CreateElement("Podatak830");
                Podatak830.InnerText    = obrazacArgs.Podatak830;

                xml.AppendChild(Tijelo, Podatak315);
                xml.AppendChild(Tijelo, Podatak400);
                xml.AppendChild(Tijelo, Podatak500);
                xml.AppendChild(Tijelo, Podatak600);
                xml.AppendChild(Tijelo, Podatak700);
                xml.AppendChild(Tijelo, Podatak810);
                xml.AppendChild(Tijelo, Podatak811);
                xml.AppendChild(Tijelo, Podatak812);
                xml.AppendChild(Tijelo, Podatak813);
                xml.AppendChild(Tijelo, Podatak814);
                xml.AppendChild(Tijelo, Podatak815);
                xml.AppendChild(Tijelo, Podatak820);
                xml.AppendChild(Tijelo, Podatak830);

                //831
                Podatak831                      = xmlDoc.CreateElement("Podatak831");
                Podatak831Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak831Vrijednost.InnerText  = obrazacArgs.Podatak831Vrijednost;
                Podatak831Broj                  = xmlDoc.CreateElement("Broj");
                Podatak831Broj.InnerText        = obrazacArgs.Podatak831Broj;

                Podatak832                      = xmlDoc.CreateElement("Podatak832");
                Podatak832Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak832Vrijednost.InnerText  = obrazacArgs.Podatak832Vrijednost;
                Podatak832Broj                  = xmlDoc.CreateElement("Broj");
                Podatak832Broj.InnerText        = obrazacArgs.Podatak832Broj;

                Podatak833                      = xmlDoc.CreateElement("Podatak833");
                Podatak833Vrijednost            = xmlDoc.CreateElement("Vrijednost");
                Podatak833Vrijednost.InnerText  = obrazacArgs.Podatak833Vrijednost;
                Podatak833Broj                  = xmlDoc.CreateElement("Broj");
                Podatak833Broj.InnerText        = obrazacArgs.Podatak833Broj;

                xml.AppendChild(Tijelo, Podatak831);
                    xml.AppendChild(Podatak831, Podatak831Vrijednost);
                    xml.AppendChild(Podatak831, Podatak831Broj);

                xml.AppendChild(Tijelo, Podatak832);
                    xml.AppendChild(Podatak832, Podatak832Vrijednost);
                    xml.AppendChild(Podatak832, Podatak832Broj);

                xml.AppendChild(Tijelo, Podatak833);
                    xml.AppendChild(Podatak833, Podatak833Vrijednost);
                    xml.AppendChild(Podatak833, Podatak833Broj);

                //840
                Podatak840              = xmlDoc.CreateElement("Podatak840");
                Podatak840.InnerText    = obrazacArgs.Podatak840;

                Podatak850              = xmlDoc.CreateElement("Podatak850");
                Podatak850.InnerText    = obrazacArgs.Podatak850;

                Podatak860              = xmlDoc.CreateElement("Podatak860");
                Podatak860.InnerText    = obrazacArgs.Podatak860;

                Podatak870              = xmlDoc.CreateElement("Podatak870");
                Podatak870.InnerText    = obrazacArgs.Podatak870;

                xml.AppendChild(Tijelo, Podatak840);
                xml.AppendChild(Tijelo, Podatak850);
                xml.AppendChild(Tijelo, Podatak860);
                xml.AppendChild(Tijelo, Podatak870);


                //BODY END ---------------------

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
