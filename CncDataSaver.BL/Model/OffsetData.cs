using System;

namespace CncDataSaver.BL.Model
{
    public class OffsetData
    {
        public int OffsetDataId { get; set; }
        public string Machine { get; set; }
        public int Channel1Id { get; set; }
        public virtual Channel1 Channel1 { get; set; }
        public int Channel2Id { get; set; }
        public virtual Channel2 Channel2 { get; set; }
        public int MacroId { get; set; }
        public virtual Macro Macro { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string Comment { get; set; }
        public override string ToString()
        {
            return $"Станок:{Machine}           Сортамент:{Product.ThreadType}/{Product.Diameter}          От:{Created}";
        }
    }
}
