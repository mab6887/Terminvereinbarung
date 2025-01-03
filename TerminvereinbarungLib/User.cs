
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace TerminvereinbarungLib
{

using System;
    using System.Collections.Generic;
    
public partial class User
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public User()
    {

        this.Behandlungungen = new HashSet<Behandlung>();

        this.TerminArzt = new HashSet<Termin>();

        this.TerminPatient = new HashSet<Termin>();

        this.ZeitslotArzt = new HashSet<Zeitslot>();

    }


    public int Id { get; set; }

    public string Vorname { get; set; }

    public string Nachname { get; set; }

    public string Geburtsdatum { get; set; }

    public string Telefon { get; set; }

    public string EMail { get; set; }

    public string Krankenkasse { get; set; }

    public bool Arzt { get; set; }

    public bool Admin { get; set; }

    public string Passwort { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Behandlung> Behandlungungen { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Termin> TerminArzt { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Termin> TerminPatient { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Zeitslot> ZeitslotArzt { get; set; }

}

}
