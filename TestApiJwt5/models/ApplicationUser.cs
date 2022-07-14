using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestApiJwt5.models
{
    public class ApplicationUser:IdentityUser
    {
        [Required,MaxLength(20)]
        public string FirstName { get; set; }
        [Required,MaxLength(20)]
        public string LastName { get; set; }

    }
}
