using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaverBL.Model
{
    class Macro
    {
        public int MacroId { get; set; }
        public virtual ICollection<Offset> Offsets { get; set; }
        public double Offset { get; set; }
        public double Conicity { get; set; }
        public double Zajust { get; set; }
        public double ThreadPass { get; set; }
        public double OdSeal { get; set; }
        public double Standoff { get; set; }
    }
}
