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
    
    public partial class Zeitslot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zeitslot()
        {
            this.TerminZeitslot = new HashSet<Termin>();
            this.verfügbareÄrzte = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public System.DateTime Startzeitpunkt { get; set; }
        public System.TimeSpan Dauer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Termin> TerminZeitslot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> verfügbareÄrzte { get; set; }
    }
}
