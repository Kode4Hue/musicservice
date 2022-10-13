using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album: BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public int YearReleased { get; set; }
    }
}
