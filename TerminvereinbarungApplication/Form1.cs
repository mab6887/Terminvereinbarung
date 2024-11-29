using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminvereinbarungLib;

namespace TerminvereinbarungApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataStore Data = new DataStore();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Behandlung newBehandlung = new Behandlung();
                {
                    newBehandlung.Behandlungart = "Ultraschall";
                    if (newBehandlung == null) return;
                    Data.BehandlungSet.Add(newBehandlung);
                    Data.SaveChanges();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
