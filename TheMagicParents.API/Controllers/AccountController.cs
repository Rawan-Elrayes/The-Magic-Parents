using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheMagicParents.Models;

namespace TheMagicParents.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Models.ServiceProvider> ServiceProviderManager;
        private readonly UserManager<Client> ClientManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<Models.ServiceProvider> ServiceProviderManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.ServiceProviderManager = ServiceProviderManager;
            this.roleManager = roleManager;
            _configuration = configuration;
        }
    }
}
