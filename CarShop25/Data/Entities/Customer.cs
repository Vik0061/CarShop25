using Microsoft.AspNetCore.Identity;

namespace CarShop25.Data.Entities
{
    public class Customer : IdentityUser
    {
        public virtual ICollection<Order>? Orders { get; set; }
    }
}