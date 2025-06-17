using GEMS.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GEMS.Services
{
    public class AuthorizationService
    {
        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthorizationService(AuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
        }

        public async Task<bool> CanAssignVaults()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            return authState.User.IsInRole(UserRolesModel.VaultAuditor);
        }

        public async Task<string?> GetUserRegion()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            return authState.User.FindFirst("Region")?.Value;
        }
    }
}