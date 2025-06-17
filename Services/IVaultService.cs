using GEMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GEMS.Services
{
    // Services/IVaultService.cs
    public interface IVaultService
    {
        Task<List<VaultModel>> GetAllVaults();
        Task<VaultModel?> GetVaultById(int id);
        Task AddVault(VaultModel vault);
        Task UpdateVault(VaultModel vault);
        Task DeleteVault(int id);
        Task<List<VaultModel>> GetAvailableVaultsAsync(string? userRegion = null);
        Task<List<AssignmentModel>> GetAssignedUsersAsync(int vaultId);
        Task AssignUserToVaultAsync(AssignmentModel assignment);
        Task RemoveAssignmentAsync(int assignmentId);
    }
}
