using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminvereinbarungLib
{
    public partial class User
    {
        public User(string Vorname, string Nachname, string Geburtsdatum, string Telefon, string EMail, string Krankenkasse,bool Arzt, bool Admin,  string Passwort)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtsdatum = Geburtsdatum;
            this.Telefon = Telefon;
            this.EMail = EMail;
            this.Krankenkasse = Krankenkasse;
            this.Arzt = Arzt;
            this.Admin = Admin;
            this.Passwort = Passwort;
        }
    }
}
