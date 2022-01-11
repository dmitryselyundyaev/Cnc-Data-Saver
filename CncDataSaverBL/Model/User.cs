using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CncDataSaverBL.Model
{
    class User
    {
        public int UserId { get; set; }
        public virtual ICollection<Offset> Offsets { get; set; }
        public string UserName { get; set; }

        public override string ToString()
        {
            return $"ID:{UserId} Имя пользователя: {UserName}";
        }
    }
}
