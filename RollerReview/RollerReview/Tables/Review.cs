using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerReview.Tables
{
    public class Review
    {
        public int ReviewId { get; set; }
        public DateTime ReviewDate { get; set; }

        public int RollercoasterId { get; set; }
        public Rollercoaster Rollercoaster { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
