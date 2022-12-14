using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp.Models.Role
{
    // The role selector authentication 
    public class AddToRoleViewModel
    {
        public SelectList Roles { get; set; }
        public SelectList Users { get; set; }
        public string Message { get; set; }
    }
}
