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

            Behandlung ultraschall = new Behandlung();
            ultraschall.Behandlungart = "Ultraschall";
            ultraschall.Behandlungsdauer = new TimeSpan(0, 30, 0);

            Behandlung impfung = new Behandlung();
            impfung.Behandlungart = "Impfung";
            impfung.Behandlungsdauer = new TimeSpan(0, 15, 0);

            Behandlung blutabnahme = new Behandlung();
            blutabnahme.Behandlungart = "Blutabnahme";
            blutabnahme.Behandlungsdauer = new TimeSpan(0, 10, 0);

            Behandlung röntgen = new Behandlung();
            röntgen.Behandlungart = "Röntgen";
            röntgen.Behandlungsdauer = new TimeSpan(0, 20, 0);

            Behandlung diagnostischesGespräch = new Behandlung();
            diagnostischesGespräch.Behandlungart = "Diagnostisches Gespräch";
            diagnostischesGespräch.Behandlungsdauer = new TimeSpan(0, 30, 0);

            Behandlung akupunktur = new Behandlung();
            akupunktur.Behandlungart = "Akupunktur";
            akupunktur.Behandlungsdauer = new TimeSpan(0, 45, 0);

            Behandlung verbinden = new Behandlung();
            verbinden.Behandlungart = "Verbinden";
            verbinden.Behandlungsdauer = new TimeSpan(0, 15, 0);

            Behandlung elektrokardiogramm = new Behandlung();
            elektrokardiogramm.Behandlungart = "Elektrokardiogramm";
            elektrokardiogramm.Behandlungsdauer = new TimeSpan(0, 20, 0);

            Behandlung opration = new Behandlung();
            opration.Behandlungart = "Operation";
            opration.Behandlungsdauer = new TimeSpan(1, 0, 0);


            //Instanziierung der UserÄrzte

            User drSchlingenbein = new User();
            drSchlingenbein.Vorname = "Jens";
            drSchlingenbein.Nachname = "Dr. Schlingenbein";
            drSchlingenbein.Geburtsdatum = "03.10.1970";
            drSchlingenbein.Telefon = "0176 1737639";
            drSchlingenbein.EMail = "jens.schlingenbein@gmail.com";
            drSchlingenbein.Arzt = true;
            drSchlingenbein.Admin = false;
            drSchlingenbein.Passwort = "Sonne1";

            User drLeiserbach = new User();
            drLeiserbach.Vorname = "Carola";
            drLeiserbach.Nachname = "Dr. Leiserbach";
            drLeiserbach.Geburtsdatum = "12.12.1980";
            drLeiserbach.Telefon = "0146 1737639";
            drLeiserbach.EMail = "crola.leiserbach@gmail.com";
            drLeiserbach.Arzt = true;
            drLeiserbach.Admin = false;
            drLeiserbach.Passwort = "Susanne#";

            User drFreud = new User();
            drFreud.Vorname = "Sigmund";
            drFreud.Nachname = "Dr. Freud";
            drFreud.Geburtsdatum = "06.05.1856";
            drFreud.Telefon = "0176 5027639";
            drFreud.EMail = "sigmund.freud@gmail.com";
            drFreud.Arzt = true;
            drFreud.Admin = false;
            drFreud.Passwort = "Psycho1";

            User drSchönberger = new User();
            drSchönberger.Vorname = "Thomas";

            drSchönberger.Nachname = "Dr. Schönberger";
            drSchönberger.Geburtsdatum = "03.10.1975";
            drSchönberger.Telefon = "0156 1734269";
            drSchönberger.EMail = "thomas.schoenberger@gmail.com";
            drSchönberger.Arzt = true;
            drSchönberger.Admin = false;
            drSchönberger.Passwort = "SchönergroßerBergg";

            User drMaxwell = new User();
            drMaxwell.Vorname = "Hamilton";
            drMaxwell.Nachname = "Dr. Maxwell";
            drMaxwell.Geburtsdatum = "07.08.1985";
            drMaxwell.Telefon = "0122 1749639";
            drMaxwell.EMail = "hamilton.maxwell@gmail.com";
            drMaxwell.Arzt = true;
            drMaxwell.Admin = false;
            drMaxwell.Passwort = "CircusMa#imus";

            User drKocht = new User();
            drKocht.Vorname = "Robert";
            drKocht.Nachname = "Dr. Kocht";
            drKocht.Geburtsdatum = "03.10.1968";
            drKocht.Telefon = "0176 6589339";
            drKocht.EMail = "robert.kocht@gmail.com";
            drKocht.Arzt = true;
            drKocht.Admin = false;
            drKocht.Passwort = "Kochtopf1";

            User drPlankton = new User();
            drPlankton.Vorname = "Max";
            drPlankton.Nachname = "Dr. Plankton";
            drPlankton.Geburtsdatum = "23.06.1968";
            drPlankton.Telefon = "01520 174t62339";
            drPlankton.EMail = "max.plankton@gmail.com";
            drPlankton.Arzt = true;
            drPlankton.Admin = false;
            drPlankton.Passwort = "Sp0ng3B00B";


            //Instanziierung der UserAdmin

            User polo = new User();

            polo.Vorname = "Marco";
            polo.Nachname = "Polo";
            polo.Geburtsdatum = "05.04.2002";
            polo.Telefon = "0176 12345678";
            polo.EMail = "mab6887@thi.de";
            polo.Arzt = false;
            polo.Admin = true;
            polo.Passwort = "1234";
            

            //Instanziierung der UserPatienten

            User lovelace = new User();
            lovelace.Vorname = "Ada";
            lovelace.Nachname = "Lovelace";
            lovelace.Geburtsdatum = "10.12.1815";
            lovelace.Telefon = "015 35792493";
            lovelace.EMail = "ada.lovelace@icloud.com";
            lovelace.Krankenkasse = "AOK";
            lovelace.Arzt = false;
            lovelace.Admin = false;
            lovelace.Passwort = "AdamandEva";

            User bubble = new User();
            bubble.Vorname = "Edwin";
            bubble.Nachname = "Bubble";
            bubble.Geburtsdatum = "10.12.1815";
            bubble.Telefon = "015 35792493";
            bubble.EMail = "edwin.bubble@gmx.de";
            bubble.Krankenkasse = "DAK";
            bubble.Arzt = false;
            bubble.Admin = false;
            bubble.Passwort = "Bubblegum";

            User deckenbauer = new User();
            deckenbauer.Vorname = "Franz";
            deckenbauer.Nachname = "Deckenbauer";
            deckenbauer.Geburtsdatum = "10.12.1960";
            deckenbauer.Telefon = "0174 8402ß4582";
            deckenbauer.EMail = "franz.deckenbauer@gmail.com";
            deckenbauer.Krankenkasse = "TK";
            deckenbauer.Arzt = false;
            deckenbauer.Admin = false;
            deckenbauer.Passwort = "Dachdecker";

            User hopper = new User();
            hopper.Vorname = "Grace";
            hopper.Nachname = "Hopper";
            hopper.Geburtsdatum = "09.12.1906";
            hopper.Telefon = "0176 12348648";
            hopper.EMail = "grace.hopper@hotmail.com";
            hopper.Krankenkasse = "BKK";
            hopper.Arzt = false;
            hopper.Admin = false;
            hopper.Passwort = "GrasHopper";

            User hamilton = new User();
            hamilton.Vorname = "Margaret";
            hamilton.Nachname = "Hamilton";
            hamilton.Geburtsdatum = "17.08.1936";
            hamilton.Telefon = "0176 53748648";
            hamilton.EMail = "margarez.hamilton.web.de";
            hamilton.Krankenkasse = "Barmer";
            hamilton.Arzt = false;
            hamilton.Admin = false;
            hamilton.Passwort = "HamiltonsRule";

            User perlman = new User();
            perlman.Vorname = "Radia";
            perlman.Nachname = "Perlman";
            perlman.Geburtsdatum = "01.01.1951";
            perlman.Telefon = "0176 12348648";
            perlman.EMail = "radia.perlman@gmail.com";
            perlman.Krankenkasse = "IKK";
            perlman.Arzt = false;
            perlman.Admin = false;
            perlman.Passwort = "PearlBracelet";


            //Instanziierung der Zeitslots


            //Instanziierung eines Tages möglicherweise später mit Mittagspause und 30 min Slots weitere for schleife für woche, weitere for schleife für jahr
           
            for (int i = 0; i < 8; i++)
            {
                Zeitslot slot = new Zeitslot();
                slot.Startzeitpunkt = new DateTime(2025, 1, 1, 8 + i, 0, 0);
                slot.Dauer = new TimeSpan(1, 0, 0);
            }
            




        }
    }
}
