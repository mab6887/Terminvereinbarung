using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminvereinbarungLib
{
    public partial class Zeitslot
    {
        public Zeitslot(DateTime Startzeitpunkt, TimeSpan Dauer)
        {
            this.Startzeitpunkt = Startzeitpunkt;
            this.Dauer = Dauer;
        }
    }
}