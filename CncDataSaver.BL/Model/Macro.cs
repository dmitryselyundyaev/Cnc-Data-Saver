using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaver.BL.Model
{
    public class Macro
    {
        public int MacroId { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }
        public double? Offset { get; set; }
        public decimal? Conicity { get; set; }
        public decimal? Zajust { get; set; }
        public decimal? ThreadPass { get; set; } 
        public decimal? OdSeal { get; set; }
        public decimal? Standoff { get; set; }


        public override string ToString()
        {
            return $"";
        }
    }
}
