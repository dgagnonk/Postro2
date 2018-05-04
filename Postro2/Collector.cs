using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postro2
{

    /*
     * A collector is a customer or client who buys posters.
     * They can have holds.
     */
    
    public class Collector
    {
        public string Name;
        public List<Hold> Holds = new List<Hold>();
    }

    public class Hold
    {
        public string PosterTitle;
        public int HoldsOnThisTitle;
    }
}
