using System.Collections.Generic;

namespace CncDataSaver.BL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }
        public int Diameter { get; set; }
        public string ThreadType { get; set; }

        public override string ToString()
        {
            return $"{ProductId} Диаметр: {Diameter}, Тип резьбы: {ThreadType}";
        }
    }
}
