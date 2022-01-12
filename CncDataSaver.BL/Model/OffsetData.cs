using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaver.BL.Model
{
    public class OffsetData
    {
        public int OffsetDataId { get; set; }
        public string Machine { get; set; }
        public int Ch1Id { get; set; }
        public virtual Ch1 Ch1 { get; set; }
        public int Ch2Id { get; set; }
        public virtual Ch2 Ch2 { get; set; }
        public int MacroId { get; set; }
        public virtual Macro Macro { get; set; }
        public DateTime Created => DateTime.Now;
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public override string ToString()
        {
            return $"Оффсет номер = {OffsetDataId} Станок = {Machine} Дата создания =  {Created}";
        }
    }
}
