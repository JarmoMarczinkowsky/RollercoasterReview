using Microsoft.AspNetCore.Identity;

namespace RollercoasterReview.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int RollercoasterId { get; set; }
        public virtual Rollercoaster Rollercoaster { get; set; }
        public int UserId { get; set; }
        public virtual IdentityUser User { get; set; }
        public int RatingValue { get; set; }
    }
}
