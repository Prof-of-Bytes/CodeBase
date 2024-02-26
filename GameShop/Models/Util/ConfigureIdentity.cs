using Microsoft.AspNetCore.Identity;

namespace GameShop.Models
{
    public class ConfigureIdentity
    {
        

<<<<<<< HEAD
<<<<<<< HEAD
        public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider)
=======
        public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider, )
>>>>>>> c0b109c156901a71128da7efbb856131a2a4a2e2
=======
        public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider, )
>>>>>>> c0b109c156901a71128da7efbb856131a2a4a2e2
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
