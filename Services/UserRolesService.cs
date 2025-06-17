using GEMS.Models;

namespace GEMS.Services
{
    public class UserRolesService
    {
        public bool IsAdmin1(string role) => role == UserRolesModel.Admin1;
        public bool IsAdmin2(string role) => role == UserRolesModel.Admin2;
        public bool IsVaultAuditor(string role) => role == UserRolesModel.VaultAuditor;
        public bool IsCustodian(string role) => role == UserRolesModel.Custodian;

        public string GetDashboardRoute(string role)
        {
            return role switch
            {
                UserRolesModel.Admin1 => "/dashboard/firstadmin",
                UserRolesModel.Admin2 => "/dashboard/secondadmin",
                UserRolesModel.VaultAuditor => "/dashboard/vaultauditor",
                UserRolesModel.Custodian => "/dashboard/custodian",
                _ => throw new UnauthorizedAccessException($"Invalid role: {role}")
            };
        }
    }
}
