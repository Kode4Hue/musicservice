using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Artist: BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Album> Albums { get; set; } = new List<Album>(); 
    }
}
