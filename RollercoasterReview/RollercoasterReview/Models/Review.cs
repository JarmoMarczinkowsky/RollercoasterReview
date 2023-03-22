using Microsoft.AspNetCore.Identity;

namespace RollercoasterReview.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? Partner { get; set; }
        public int RollercoasterId { get; set; }
        public virtual Rollercoaster? Rollercoaster { get; set; }
        public int UserId { get; set; }
        public virtual IdentityUser? User { get; set; }
    }
}
