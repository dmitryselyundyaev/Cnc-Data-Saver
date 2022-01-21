using System.Collections.Generic;

namespace CncDataSaver.BL.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<OffsetData> Offsets { get; set; }

        public string UserPassword { get; set; }
        public override string ToString()
        {
            return $"{UserName} ";
        }
    }
}
