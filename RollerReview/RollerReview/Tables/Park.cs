﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerReview.Tables
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
