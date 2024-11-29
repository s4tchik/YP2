using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForYp2.Model
{
    class Requests
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateOnly StartDate { get; set; }
        public OrgTechType Id_OrgTechType { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string OrgTechManufacture { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string OrgTechModel { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        public string? OrgTechNumber { get; set; } = null!;

        public Statys Id_Statys { get; set; } = null!;

        [Column(TypeName = "date")]
        public DateOnly? CompletionDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? RepairParts { get; set; } = null!;
 


        [ForeignKey("MasterId")]
        public User? Master { get; set; }
        
        [ForeignKey("ClientId")]
        public User Client { get; set; } = null!;


    }
}
