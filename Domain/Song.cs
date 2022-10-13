using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Song: BaseModel
    {
        public int Track { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
