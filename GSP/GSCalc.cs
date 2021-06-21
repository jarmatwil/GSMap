using System;
using System.Collections.Generic;
using System.Text;

namespace GSP
{
    class GSCalc
    {
        List<Waygate> waygates;
        List<String> ignore = new List<string>();
        List<String> toCheck = new List<string>();

        public List<Dictionary<String, String>> CalculatePath(List<Waygate> waygates, Waygate entry, String exit)
        {
            this.waygates = waygates;
            int travels = 0;
            bool calculated = false;
            List<Dictionary<String,String>> finalPath = new List<Dictionary<String, String>>();

            Dictionary<String, String> path = new Dictionary<string, string>();

            ignore.Add(entry.getLocation());

            while (!calculated)
            {
                
                foreach(Waygate wg in waygates)
                {

                    if(toCheck.Contains(wg.getLocation)
                    {

                    }

                }
            }
            return null;
        }

        public void checkSection()
        {
            for
        }
        public void editIgnore()
        {

        }

        

    }
    
    
}
