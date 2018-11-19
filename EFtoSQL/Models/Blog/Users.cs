using System;
using System.Collections.Generic;

namespace EFtoSQL.Models.Blog
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
