using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForYp2.Model
{
    class User
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string? LastName { get; set; }

        [Column(TypeName = "decimal(11,0)")]
        public decimal Phone { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Login { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; } = null!;
        public Types Type { get; set; } = null!;
    }
}
