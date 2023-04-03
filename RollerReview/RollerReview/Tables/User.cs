using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerReview.Tables
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserImage { get; set; }
        public byte[] Drawing { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<RoleUser> RoleUsers { get; set; }

    }
}
