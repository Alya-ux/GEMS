namespace GEMS.Models
{
    public static class UserRolesModel
    {
        public const string Admin1 = "1stAdmin";
        public const string Admin2 = "2ndAdmin";
        public const string VaultAuditor = "VaultAuditor";
        public const string Custodian = "Custodian";

        public static readonly List<string> AllRoles = new()
        {
            Admin1,
            Admin2,
            VaultAuditor,
            Custodian
        };
    }
}
