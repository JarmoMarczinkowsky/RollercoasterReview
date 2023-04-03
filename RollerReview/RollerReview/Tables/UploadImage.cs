using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerReview.Tables
{
    public class UploadImage
    {
        public int UploadImageId { get; set; }
        public string ImageName { get; set; }
        public byte[] Image { get; set; }
    }
}
