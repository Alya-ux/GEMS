// Services/FunctionalityGroupService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using GEMS.Models;  // Make sure this is using the correct namespace
using static GEMS.Models.FunctionalityGroupModel;

namespace GEMS.Services
{
    public class FunctionalityGroupService
    {
        private List<FunctionalityGroupModel> _groups = new()
        {
            new FunctionalityGroupModel {
                Id = 1,
                GroupName = "1st Admin",
                Permissions = new List<string> { 
                    Permission.AddUsers, 
                    Permission.UpdateUsers, 
                    Permission.DeleteUsers },
                Status = "Approved"
            },
            new FunctionalityGroupModel {
                Id = 2,
                GroupName = "2nd Admin",
                Permissions = new List<string> {
                    Permission.ApproveRegistrations,
                    Permission.ApproveVaultAssignments
                },
                Status = "Approved"
            },
            new FunctionalityGroupModel {
                Id = 3,
                GroupName = "Vault Auditor",
                Permissions = new List<string> {
                    Permission.AddVaults,
                    Permission.UpdateVaults,
                    Permission.DeleteVaults,
                    Permission.AssignCustodians
                },
                Status = "Approved"
            },
            new FunctionalityGroupModel {
                Id = 4,
                GroupName = "Custodian",
                Permissions = new List<string>(),
                Status = "Approved"
            },
            /*new FunctionalityGroupModel {
                Id = 5,
                GroupName = "User Management",
                Permissions = new List<string>{
                    Permission.AddUsers,
                    Permission.UpdateUsers,
                    Permission.DeleteUsers
                },
                Status = "Approved"
            }*/
        };
        
        public Task<List<FunctionalityGroupModel>> GetAllGroupsAsync()
        {
            return Task.FromResult(_groups.ToList());
        }

        public Task<FunctionalityGroupModel?> GetGroupByIdAsync(int id)
        {
            return Task.FromResult(_groups.FirstOrDefault(g => g.Id == id));
        }
        
        public Task AddGroupAsync(FunctionalityGroupModel group)
        {
            group.Id = _groups.Count > 0 ? _groups.Max(g => g.Id) + 1 : 1;
            _groups.Add(group);
            return Task.CompletedTask;
        }
        
        public Task UpdateGroupAsync(FunctionalityGroupModel group)
        {
            var index = _groups.FindIndex(g => g.Id == group.Id);
            if (index >= 0)
            {
                _groups[index] = group;
            }
            return Task.CompletedTask;
        }
        public Task DeleteGroupAsync(int id)
        {
            _groups.RemoveAll(g => g.Id == id);
            return Task.CompletedTask;
        }
        public Task SubmitForApprovalAsync(int id)
        {
            var group = _groups.FirstOrDefault(g => g.Id == id);
            if (group != null)
            {
                group.Status = GroupStatuses.PendingApproval;
            }
            return Task.CompletedTask;
        }
     
        
    }
}

/*private List<FunctionalityGroupModel> _functionalityGroups = new();
        private int _nextId = 1;

        public Task<List<FunctionalityGroupModel>> GetAllGroupsAsync()
        {
            return Task.FromResult(new List<FunctionalityGroupModel>(_functionalityGroups));
        }

        public Task<FunctionalityGroupModel?> GetGroupByIdAsync(int id)
        {
            return Task.FromResult(_functionalityGroups.FirstOrDefault(g => g.Id == id));
        }

        public Task AddGroupAsync(FunctionalityGroupModel group)
        {
            group.Id = _nextId++;
            _functionalityGroups.Add(group);
            return Task.CompletedTask;
        }

        public Task UpdateGroupAsync(FunctionalityGroupModel updatedGroup)
        {
            var index = _functionalityGroups.FindIndex(g => g.Id == updatedGroup.Id);
            if (index >= 0)
            {
                _functionalityGroups[index] = updatedGroup;
            }
            return Task.CompletedTask;
        }

        public Task DeleteGroupAsync(int id)
        {
            _functionalityGroups.RemoveAll(g => g.Id == id);
            return Task.CompletedTask;
        }*/