using System;
using System.Collections.Generic;
using System.Text;

namespace GSP
{
    class Waygate
    {
        private string location;
        private Dictionary<String,String> exits;

        public Waygate(string loc, string a, string b, string t, string o)
        {
            this.location = loc;
            this.exits.Add("Alpha", a);
            this.exits.Add("Beta", b);
            this.exits.Add("Theta", t);
            this.exits.Add("Omega", o);
        }

        public string getLocation()
        {
            return location;
        }

        public String getExit(String exitName)
        {
            string result;
            exits.TryGetValue(exitName, out result);
            return result;
        }


    }
}
