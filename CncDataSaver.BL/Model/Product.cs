using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaver.BL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public virtual ICollection<Offset> Offsets { get; set; }
        public int Diameter { get; set; }
        public int ThreadType { get; set; }

        public override string ToString()
        {
            return $"{ProductId} Диаметр: {Diameter}, Тип резьбы: {ThreadType}";
        }
    }
}
