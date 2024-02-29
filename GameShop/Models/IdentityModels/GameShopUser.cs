using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GameShop.Models
{
    public class GameShopUser: IdentityUser
    {
        public int? CustomerId { get; set; }

        [ValidateNever]
        public Customer Customer { get; set; } = null!;
    }
}
