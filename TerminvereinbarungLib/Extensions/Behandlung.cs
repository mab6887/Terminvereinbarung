using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminvereinbarungLib
{
    public partial class Behandlung
    {
        public Behandlung(string Behandlungart, TimeSpan Behandlungsdauer)
        {
          this.Behandlungart = Behandlungart;
            this.Behandlungsdauer = Behandlungsdauer;
        }
    }
}
