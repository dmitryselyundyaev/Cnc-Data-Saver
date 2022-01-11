using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaverBL.Model
{
    class Ch2
    {
        public int Ch2Id { get; set; }
        public virtual ICollection<Offset> Offsets { get; set; }
        public double? X1 { get; set; }
        public double? Z1 { get; set; }
        public double? X2 { get; set; }
        public double? Z2 { get; set; }
        public double? X3 { get; set; }
        public double? Z3 { get; set; }
        public double? X4 { get; set; }
        public double? Z4 { get; set; }
        public double? X5 { get; set; }
        public double? Z6 { get; set; }
        public double? X7 { get; set; }
        public double? Z8 { get; set; }
        public double? X9 { get; set; }
        public double? Z9 { get; set; }
        public double? Y1 { get; set; }
        public double? Y2 { get; set; }
        public double? Y3 { get; set; }
        public double? Y4 { get; set; }
    }
}

