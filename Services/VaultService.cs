using GEMS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GEMS.Services
{
    public class VaultService : IVaultService
    {
        private List<VaultModel> _vaults = new List<VaultModel>
        {
            new VaultModel { Id = 1, Name = "Vault_KL01", Branch = "KL Main", State = "KL", Status = VaultStatus.Approved, ControllerID = "CTRL-KL01", ControllerIP = "192.168.1.1", RequiredCustodians = 3 },
            new VaultModel { Id = 2, Name = "Vault_PG02", Branch = "Penang", State = "Penang", Status = VaultStatus.Pending, ControllerID = "CTRL-PG02", ControllerIP = "192.168.1.2" },
            new VaultModel { Id = 3, Name = "Vault_JH03", Branch = "Johor", State = "Johor", Status = VaultStatus.Approved, ControllerID = "CTRL-JH03", ControllerIP = "192.168.1.3" },
            new VaultModel { Id = 4, Name = "Vault_KL04", Branch = "KL South", State = "KL", Status = VaultStatus.Approved, ControllerID = "CTRL-KL04", ControllerIP = "192.168.1.4" },
            new VaultModel { Id = 5, Name = "Vault_SB05", Branch = "Sabah", State = "Sabah", Status = VaultStatus.Inactive, ControllerID = "CTRL-SB05", ControllerIP = "192.168.1.5" },
            new VaultModel { Id = 6, Name = "Vault_SR06", Branch = "Sarawak", State = "Sarawak", Status = VaultStatus.Approved, ControllerID = "CTRL-SR06", ControllerIP = "192.168.1.6" },
            new VaultModel { Id = 7, Name = "Vault_ML07", Branch = "Melaka", State = "Melaka", Status = VaultStatus.Pending, ControllerID = "CTRL-ML07", ControllerIP = "192.168.1.7" },
            new VaultModel { Id = 8, Name = "Vault_PH08", Branch = "Pahang", State = "Pahang", Status = VaultStatus.Approved, ControllerID = "CTRL-PH08", ControllerIP = "192.168.1.8" },
            new VaultModel { Id = 9, Name = "Vault_NS09", Branch = "Negeri Sembilan", State = "Negeri Sembilan", Status = VaultStatus.Approved, ControllerID = "CTRL-NS09", ControllerIP = "192.168.1.9" },
            new VaultModel { Id = 10, Name = "Vault_TR10", Branch = "Terengganu", State = "Terengganu", Status = VaultStatus.Inactive, ControllerID = "CTRL-TR10", ControllerIP = "192.168.1.10" },
            new VaultModel { Id = 11, Name = "Vault_KD11", Branch = "Kedah", State = "Kedah", Status = VaultStatus.Approved, ControllerID = "CTRL-KD11", ControllerIP = "192.168.1.11" },
            new VaultModel { Id = 12, Name = "Vault_PR12", Branch = "Perak", State = "Perak", Status = VaultStatus.Pending, ControllerID = "CTRL-PR12", ControllerIP = "192.168.1.12" },
            new VaultModel { Id = 13, Name = "Vault_PL13", Branch = "Perlis", State = "Perlis", Status = VaultStatus.Approved, ControllerID = "CTRL-PL13", ControllerIP = "192.168.1.13" },
            new VaultModel { Id = 14, Name = "Vault_KL14", Branch = "KL West", State = "KL", Status = VaultStatus.Approved, ControllerID = "CTRL-KL14", ControllerIP = "192.168.1.14" },
            new VaultModel { Id = 15, Name = "Vault_PG15", Branch = "Penang North", State = "Penang", Status = VaultStatus.Inactive, ControllerID = "CTRL-PG15", ControllerIP = "192.168.1.15" }
        };

        public Task<List<VaultModel>> GetAllVaults()
        {
            return Task.FromResult(_vaults);
        }

        public Task<VaultModel?> GetVaultById(int id)
        {
            return Task.FromResult(_vaults.FirstOrDefault(v => v.Id == id));
        }

        public Task AddVault(VaultModel vault)
        {
            vault.Id = _vaults.Max(v => v.Id) + 1; // Auto-increment ID
            _vaults.Add(vault);
            return Task.CompletedTask;
        }

        public Task UpdateVault(VaultModel updatedVault)
        {
            var index = _vaults.FindIndex(v => v.Id == updatedVault.Id);
            if (index != -1)
            {
                _vaults[index] = updatedVault;
            }
            return Task.CompletedTask;
        }

        public Task DeleteVault(int id)
        {
            _vaults.RemoveAll(v => v.Id == id);
            return Task.CompletedTask;
        }

        private List<AssignmentModel> _assignments = new();

        public Task<List<VaultModel>> GetAvailableVaultsAsync(string? userRegion = null)
        {
            var vaults = _vaults.Where(v => v.Status == VaultStatus.Approved);

            if (!string.IsNullOrEmpty(userRegion))
            {
                vaults = vaults.Where(v => v.State == userRegion);
            }

            return Task.FromResult(vaults.ToList());
        }

        public Task<List<AssignmentModel>> GetAssignedUsersAsync(int vaultId)
        {
            return Task.FromResult(_assignments
                .Where(a => a.VaultId == vaultId)
                .ToList());
        }

        public Task AssignUserToVaultAsync(AssignmentModel assignment)
        {
            assignment.Id = _assignments.Any() ? _assignments.Max(a => a.Id) + 1 : 1;
            _assignments.Add(assignment);
            return Task.CompletedTask;
        }

        public Task RemoveAssignmentAsync(int assignmentId)
        {
            _assignments.RemoveAll(a => a.Id == assignmentId);
            return Task.CompletedTask;
        }

        // In VaultService.cs
        public async Task<VaultModel?> GetVaultByIdAsync(int id)
        {
            return await Task.FromResult(_vaults.FirstOrDefault(v => v.Id == id));
        }
    }
}