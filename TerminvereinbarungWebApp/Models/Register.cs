using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TerminvereinbarungWebApp.Models
{
    public class Register
    {
        [Required]
        public string Vorname { get; set; }

        [Required]
        public string Nachname { get; set; }

        [Required]
        public string Geburtsdatum { get; set; }

        [Required]
        public string Telefon { get; set; }

        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        public string Krankenkasse { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Passwort { get; set; }


        public bool Arzt;
            public bool Admin;
    }

}
