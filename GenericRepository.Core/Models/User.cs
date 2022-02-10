using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.Core.Models
{
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
    }
}
