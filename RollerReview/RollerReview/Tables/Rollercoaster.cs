using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerReview.Tables
{
    public class Rollercoaster
    {
        public int RollercoasterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RollercoasterImage { get; set; }
        public DateTime Build { get; set; }

        public int ParkId { get; set; }
        public Park Park { get; set; }
    }
}
