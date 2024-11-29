using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForYp2.Model
{
    class OrgTechType
    {
        public int Id { get; set; }
        [Column (TypeName = "nvarchar(50)")]
        public string Name { get; set; } = null!;
    }
}
