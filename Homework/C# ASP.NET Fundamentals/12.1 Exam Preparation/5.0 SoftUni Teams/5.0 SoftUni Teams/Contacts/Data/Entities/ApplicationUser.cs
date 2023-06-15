using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.ApplicationUsersContacts = new HashSet<ApplicationUserContact>();
        }
    

        public ICollection<ApplicationUserContact> ApplicationUsersContacts { get; set; }
    }
}
