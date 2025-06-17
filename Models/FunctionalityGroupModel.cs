// Models/FunctionalityGroup.cs
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GEMS.Models
{
    public class FunctionalityGroupModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Group name is required")]
        [StringLength(50, ErrorMessage = "Group name is too long (max 50 chars)")]
        public string GroupName { get; set; } = string.Empty;

        public List<string> Permissions { get; set; } = new();
        public string Status { get; set; } = GroupStatuses.Draft;
        public string? AssignedRole { get; set; } // Now uses string values from UserRoles

        public static class Permission
        {
            public const string AddUsers = "AddUsers";
            public const string UpdateUsers = "UpdateUsers";
            public const string DeleteUsers = "DeleteUsers";
            public const string ApproveRegistrations = "ApproveRegistrations";
            public const string AddVaults = "AddVaults";
            public const string UpdateVaults = "UpdateVaults";
            public const string DeleteVaults = "DeleteVaults";
            public const string ApproveVaultAssignments = "ApproveVaultAssignments";
            public const string SetUnlockRules = "SetUnlockRules";
            public const string AssignCustodians = "AssignCustodians";

            public static readonly List<string> All = new()
    {
        AddUsers, UpdateUsers, DeleteUsers, ApproveRegistrations,
        AddVaults, UpdateVaults, DeleteVaults, ApproveVaultAssignments,
        SetUnlockRules, AssignCustodians
    };
        }


        public static class GroupStatuses
        {
            public const string Draft = "Draft";
            public const string PendingApproval = "Pending Approval";
            public const string Approved = "Approved";
            public const string Rejected = "Rejected";

            public static readonly List<string> All = new()
            {
                Draft,
                PendingApproval,
                Approved,
                Rejected
            };
        }


        /*public enum RoleType
        {
            [Display(Name = "Admin (Full access)")]
            Admin,
            [Display(Name = "Second Admin (Approvals only)")]
            SecondAdmin,
            [Display(Name = "Vault Auditor (Region-specific vaults)")]
            VaultAuditor,
            [Display(Name = "Custodian (Access only)")]
            Custodian
        }*/
    }
}