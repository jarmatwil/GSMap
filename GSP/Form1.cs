using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSP
{
    public partial class Form1 : Form
    {
        List<Waygate> waygates = new List<Waygate>();
        public Form1()
        {
            InitializeComponent();
            loadWaygates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GSCalc calc = new GSCalc();
            Waygate entry;
            foreach(Waygate wg in waygates)
            {
                if(wg.getLocation.Equals(input))
                {
                    entry = wg;
                }
            }
            calc.calculatePath(waygates);
        }

        public void loadWaygates()
        {
            waygates.Add(new Waygate("Mining Town", "Knoxmoor", "Tenebris", "Cave of the Dead Lady", "Fort Saward"));
            waygates.Add(new Waygate("Outpost Adera", "Forest", "Fort Saward", "Quarry", "Exolesco"));
            waygates.Add(new Waygate("Fort Saward", "Cave of the Dead Lady", "Forest", "Outpost Adera", "Quarry"));
            waygates.Add(new Waygate("Cave of the Dead Lady", "Knoxmoor", "Tenebris", "Mining Town", "Fort Saward"));
            waygates.Add(new Waygate("Sanctuary of Peace", "Forest", "Fort Saward", "Quarry", "Fort Erie"));
            waygates.Add(new Waygate("Tenebris", "Knoxmoor", "Mining Town", "Cave of the Dead Lady", "Kauri"));
            waygates.Add(new Waygate("Quarry", "Mining Town", "Fort Saward", "Outpost Adera", "Exolesco"));
            waygates.Add(new Waygate("Kauri", "Tenebris", "Mining Town", "Anvalia", "Desert Canyon Sanctuary"));
            waygates.Add(new Waygate("Clarce", "Cave of the Dead Lady", "Forest", "Outpost Adera", "Snow Mountain"));
            waygates.Add(new Waygate("Desert Canyon Sanctuary", "Tenebris", "Patchwork", "Anvalia", "Kauri"));
            waygates.Add(new Waygate("Knoxmoor", "Tenebris", "Mining Town", "Fort Erie", "Clarce"));
            waygates.Add(new Waygate("Forest", "Desert Castle", "Grimdale Farm", "Sanctuary of Peace", "Fort Saward"));
            waygates.Add(new Waygate("Fort Erie", "Secret Stash", "Forest", "Clarce", "Snow Mountain"));
            waygates.Add(new Waygate("Exolesco", "Desert Castle", "Grimdale Farm", "Sanctuary of Peace", "Sanctuary of Peace"));
            waygates.Add(new Waygate("Snow Mountain", "Secret Stash", "Patchwork", "Clarce", "Fort Erie"));
            waygates.Add(new Waygate("Patchwork", "Secret Stash", "Anvalia", "Forest", "Snow Mountain"));
            waygates.Add(new Waygate("Anvalia", "Patchwork", "Desert Canyon Sanctuary", "Exolesco", "Snow Mountain"));
            waygates.Add(new Waygate("Grimdale Farm", "Desert Castle", "Forest", "Exolesco", "Snow Mountain"));
            waygates.Add(new Waygate("Desert Castle", "Secret Stash", "Grimdale Farm", "Forest", "Exolesco"));
            waygates.Add(new Waygate("Secret Stash", "Desert Castle", "Patchwork", "Anvalia", "Fort Erie"));
        }
    }
}
