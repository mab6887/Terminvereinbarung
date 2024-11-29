using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TerminvereinbarungWebApp.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Passwort { get; set; }

    }
}