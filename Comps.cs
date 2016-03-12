using System.Collections.Generic;

namespace Ss.RealEstate.Model
{
    public class Comp
    {
        public decimal CompScore { get; set; }
        public PropertyInfo PropertyData { get; set; }            
    }

    public class Comps
    {
        public PropertyInfo Principal { get; set; } 
        public List<Comp> Comparables { get; set; }
    }
}
