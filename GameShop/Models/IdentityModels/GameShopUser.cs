using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GameShop.Models
{
    public class GameShopUser: IdentityUser
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
