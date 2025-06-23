namespace GEMS.Models
{
        public class Notification
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Message { get; set; } = string.Empty;
            public NotificationType Type { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;
            public bool IsRead { get; set; } = false;
            public string? ActionLink { get; set; }
            public int? RelatedUserId { get; set; }
            public int? RelatedVaultId { get; set; }
        }

        public enum NotificationType
        {
            UserApproval,
            VaultAssignment,
            SystemAlert,
            VaultRegistration
    }
    
}
