namespace GEMS.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<int> FunctionalityGroupIds { get; set; } = new();
        public List<string> FunctionalityGroupNames { get; set; } = new();
        public List<string> Permissions { get; set; } = new();
        public bool IsActive { get; set; } = true;
        public bool? IsApproved { get; set; } = null;

        //public UserStatus Status { get; set; } = UserStatus.Pending;
        public DateTime RegisteredDate { get; set; } = DateTime.Now;
        public DateTime? ApprovalDate { get; set; }

        // Add these new properties to fix the errors
        public string? Branch { get; set; }
        public string? ContactNumber { get; set; }
        public DateTime? LastLogin { get; set; }

        // Optional: Add profile picture property
        public string? ProfilePictureUrl { get; set; }
    }
    public class PendingUser
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime RegisteredDate { get; set; }
    }

    public class ActivityLog
    {
        public int Id { get; set; }
        public ActivityType ActivityType { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public string Username { get; set; } = string.Empty;
    }

    /*public enum UserStatus
    {
        Pending,
        Approved,
        Rejected
    }*/

    public enum ActivityType
    {
        Approval,
        Rejection,
        Registration
    }

}
