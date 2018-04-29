using Microsoft.AspNet.Identity.EntityFramework;
using ModelLayer.MembershipModels;

namespace DataLayer.Contexts
{
    public class MembershipDbContext : IdentityDbContext<ApplicationUser>
    {
        public MembershipDbContext()
            : base("MembershipDbContext", throwIfV1Schema: false)
        {
        }

        public static MembershipDbContext Create()
        {
            return new MembershipDbContext();
        }
    }
}