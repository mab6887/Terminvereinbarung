
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
    
public partial class Behandlung
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Behandlung()
    {

        this.qualifizierteÄrzte = new HashSet<User>();

        this.TerminBehandlung = new HashSet<Termin>();

    }


    public int Id { get; set; }

    public string Behandlungart { get; set; }

    public System.TimeSpan Behandlungsdauer { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<User> qualifizierteÄrzte { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Termin> TerminBehandlung { get; set; }

}

}
