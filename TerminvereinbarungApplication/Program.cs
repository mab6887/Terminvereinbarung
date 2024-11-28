using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminvereinbarungLib;

namespace TerminvereinbarungApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //Instanziierung der Behandlungen

            Behandlung ultraschall = new Behandlung
            {
                Behandlungart = "Ultraschall",
                Behandlungsdauer = new TimeSpan(0, 30, 0)
            };

            Behandlung impfung = new Behandlung
            {
                Behandlungart = "Impfung",
                Behandlungsdauer = new TimeSpan(0, 15, 0)
            };

            Behandlung blutabnahme = new Behandlung
            {
                Behandlungart = "Blutabnahme",
                Behandlungsdauer = new TimeSpan(0, 10, 0)
            };

            Behandlung röntgen = new Behandlung
            {
                Behandlungart = "Röntgen",
                Behandlungsdauer = new TimeSpan(0, 20, 0)
            };

            Behandlung diagnostischesGespräch = new Behandlung
            {
                Behandlungart = "Diagnostisches Gespräch",
                Behandlungsdauer = new TimeSpan(0, 30, 0)
            };

            Behandlung akupunktur = new Behandlung
            {
                Behandlungart = "Akupunktur",
                Behandlungsdauer = new TimeSpan(0, 45, 0)
            };

            Behandlung verbinden = new Behandlung
            {
                Behandlungart = "Verbinden",
                Behandlungsdauer = new TimeSpan(0, 15, 0)
            };

            Behandlung elektrokardiogramm = new Behandlung
            {
                Behandlungart = "Elektrokardiogramm",
                Behandlungsdauer = new TimeSpan(0, 20, 0)
            };

            Behandlung opration = new Behandlung
            {
                Behandlungart = "Operation",
                Behandlungsdauer = new TimeSpan(1, 0, 0)
            };


            //Instanziierung der UserÄrzte

            User drSchlingenbein = new User
            {
                Vorname = "Jens",
                Nachname = "Dr. Schlingenbein",
                Geburtsdatum = "03.10.1970",
                Telefon = "0176 1737639",
                EMail = "jens.schlingenbein@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "Sonne1"
            };

            User drLeiserbach = new User
            {
                Vorname = "Carola",
                Nachname = "Dr. Leiserbach",
                Geburtsdatum = "12.12.1980",
                Telefon = "0146 1737639",
                EMail = "crola.leiserbach@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "Susanne#"
            };

            User drFreud = new User
            {
                Vorname = "Sigmund",
                Nachname = "Dr. Freud",
                Geburtsdatum = "06.05.1856",
                Telefon = "0176 5027639",
                EMail = "sigmund.freud@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "hübscheMütter"
            };

            User drSchönberger = new User
            {
                Vorname = "Thomas",
                Nachname = "Dr. Schönberger",
                Geburtsdatum = "03.10.1975",
                Telefon = "0156 1734269",
                EMail = "thomas.schoenberger@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "SchönergroßerBergg"
            };

            User drMaxwell = new User
            {
                Vorname = "Hamilton",
                Nachname = "Dr. Maxwell",
                Geburtsdatum = "07.08.1985",
                Telefon = "0122 1749639",
                EMail = "hamilton.maxwell@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "CircusMa#imus"
            };

            User drKocht = new User
            {
                Vorname = "Robert",
                Nachname = "Dr. Kocht",
                Geburtsdatum = "03.10.1968",
                Telefon = "0176 6589339",
                EMail = "robert.kocht@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "Kochtopf1"
            };

            User drPlankton = new User
            {
                Vorname = "Max",
                Nachname = "Dr. Plankton",
                Geburtsdatum = "23.06.1968",
                Telefon = "01520 174t62339",
                EMail = "max.plankton@gmail.com",
                Arzt = true,
                Admin = false,
                Passwort = "Sp0ng3B00B"
            };


            //Instanziierung der UserAdmin

            User polo = new User
            {
                Vorname = "Marco",
                Nachname = "Polo",
                Geburtsdatum = "05.04.2002",
                Telefon = "0176 12345678",
                EMail = "mab6887@thi.de",
                Arzt = false,
                Admin = true,
                Passwort = "1234"
            };


            //Instanziierung der UserPatienten

            User lovelace = new User
            {
                Vorname = "Ada",
                Nachname = "Lovelace",
                Geburtsdatum = "10.12.1815",
                Telefon = "015 35792493",
                EMail = "ada.lovelace@icloud.com",
                Krankenkasse = "AOK",
                Arzt = false,
                Admin = false,
                Passwort = "AdamandEva"
            };

            User bubble = new User
            {
                Vorname = "Edwin",
                Nachname = "Bubble",
                Geburtsdatum = "10.12.1815",
                Telefon = "015 35792493",
                EMail = "edwin.bubble@gmx.de",
                Krankenkasse = "DAK",
                Arzt = false,
                Admin = false,
                Passwort = "Bubblegum"
            };

            User deckenbauer = new User
            {
                Vorname = "Franz",
                Nachname = "Deckenbauer",
                Geburtsdatum = "10.12.1960",
                Telefon = "0174 8402ß4582",
                EMail = "franz.deckenbauer@gmail.com",
                Krankenkasse = "TK",
                Arzt = false,
                Admin = false,
                Passwort = "Dachdecker"
            };

            User hopper = new User
            {
                Vorname = "Grace",
                Nachname = "Hopper",
                Geburtsdatum = "09.12.1906",
                Telefon = "0176 12348648",
                EMail = "grace.hopper@hotmail.com",
                Krankenkasse = "BKK",
                Arzt = false,
                Admin = false,
                Passwort = "GrasHopper"
            };

            User dingle = new User
            {
                Vorname = "Quandale",
                Nachname = "Dingle",
                Geburtsdatum = "17.08.1936",
                Telefon = "0176 53748648",
                EMail = "quandale.dingle@web.de",
                Krankenkasse = "Barmer",
                Arzt = false,
                Admin = false,
                Passwort = "goofyahh"
            };

            User pork = new User
            {
                Vorname = "John",
                Nachname = "Pork",
                Geburtsdatum = "01.04.1951",
                Telefon = "0176 12348648",
                EMail = "john.pork@gmail.com",
                Krankenkasse = "IKK",
                Arzt = false,
                Admin = false,
                Passwort = "SchinkenzumFrühstück"
            };

            User wickson = new User
            {
                Vorname = "Willhard",
                Nachname = "Wickson",
                Geburtsdatum = "20.04.1947",
                Telefon = "0176 1239473",
                EMail = "willhard.wickson@gmail.com",
                Krankenkasse = "TK",
                Arzt = false,
                Admin = false,
                Passwort = "mArceldAvis"
            };


            //Instanziierung der Zeitslots


            //Instanziierung eines Tages möglicherweise später mit Mittagspause und 30 min Slots weitere for schleife für woche, weitere for schleife für jahr

            for (int i = 0; i < 8; i++)
            {
                Zeitslot slot = new Zeitslot
                {
                    Startzeitpunkt = new DateTime(2025, 1, 1, 8 + i, 0, 0),
                    Dauer = new TimeSpan(1, 0, 0)
                };
            }
            




        }
    }
}
