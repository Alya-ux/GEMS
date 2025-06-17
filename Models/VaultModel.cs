namespace GEMS.Models
{
    // Models/Vault.cs
    public class VaultModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ControllerID { get; set; } = string.Empty;
        public string ControllerIP { get; set; } = string.Empty;
        public VaultStatus Status { get; set; }
        public string TimeWindow { get; set; }
        public int RequiredCustodians { get; set; }
    }


    public enum VaultStatus
    {
        Approved,
        Pending,
        Inactive,
        Rejected
    }
}
