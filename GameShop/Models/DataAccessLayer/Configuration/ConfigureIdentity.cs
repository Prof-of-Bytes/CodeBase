using Microsoft.AspNetCore.Identity;

namespace GameShop.Models
{
    public class ConfigureIdentity
    {
        

        public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider)
    
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<GameShopUser>>();

            string roleName = null!;
            string password = null!;
            string username = null!;

            if (await roleManager.FindByIdAsync(roleName)==null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
            if (await userManager.FindByIdAsync(username)==null)
            {
                GameShopUser user = new GameShopUser { UserName = username};
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
