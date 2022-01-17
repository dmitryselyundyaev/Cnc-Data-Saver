using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaver.BL.Model
{
    public class Channel2
    {
        public int Channel2Id { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }
        public decimal? X1 { get; set; }
        public decimal? Z1 { get; set; }
        public decimal? X2 { get; set; }
        public decimal? Z2 { get; set; }
        public decimal? X3 { get; set; }
        public decimal? Z3 { get; set; }
        public decimal? X4 { get; set; }
        public decimal? Z4 { get; set; }
        public decimal? X5 { get; set; }
        public decimal? Z5 { get; set; }
        public decimal? X6 { get; set; }
        public decimal? Z6 { get; set; }
        public decimal? X7 { get; set; }
        public decimal? Z7 { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}

