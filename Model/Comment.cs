using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForYp2.Model
{
    class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;

        [ForeignKey ("MasterId")]
        public User? Master { get; set; }

        [ForeignKey ("requestId")]
        public Requests? reqId { get; set; }
    }
}
