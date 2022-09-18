using BigProje.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace BigProje.Areas.Admin.Models.DTOs
{
    public class AssignedRoleDTO
    {
        public IdentityRole Role { get; set; }
        public IList<AppUser> HasRole { get; set; }
        public IList<AppUser> HasNotRole { get; set; }

        public string RoleName { get; set; }
        public string[] AddIds { get; set; }
        public string[] DeleteIds { get; set; }


    }
}
