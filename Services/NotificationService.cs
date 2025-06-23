using GEMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GEMS.Services
{
    public class NotificationService
    {
        private List<Notification> _notifications = new()
        {
            // Mock notifications for Admin2
            new Notification
            {
                Id = 1,
                Title = "User Approval Required",
                Message = "Ali Ahmad needs approval",
                Type = NotificationType.UserApproval,
                CreatedAt = DateTime.Now.AddMinutes(-30),
                IsRead = false,
                ActionLink = "/admin2/pending-users",
                RelatedUserId = 7 // Jessica Lim
            },
            new Notification
            {
                Id = 2,
                Title = "User Approval Required",
                Message = "Siti Khadijah (Vault Auditor) needs approval",
                Type = NotificationType.UserApproval,
                CreatedAt = DateTime.Now.AddHours(-2),
                IsRead = false,
                ActionLink = "/admin2/pending-users",
                RelatedUserId = 28 // Siti Khadijah
            },
            new Notification
            {
                Id = 3,
                Title = "Vault Assignment Request",
                Message = "Vault_KL01 assignment for 2 users",
                Type = NotificationType.VaultAssignment,
                CreatedAt = DateTime.Now.AddDays(-1),
                IsRead = true,
                ActionLink = "/admin2/vault-assignments",
                RelatedVaultId = 1 // Vault_KL01
            },
            new Notification
            {
                Id = 4,
                Title = "New Vault Registration",
                Message = "Vault_JB01 requires approval",
                Type = NotificationType.VaultRegistration, // Make sure this enum value exists
                CreatedAt = DateTime.Now.AddHours(-5),
                IsRead = false,
                ActionLink = "/admin2/vault-approvals",
                RelatedVaultId = 2 // Vault_JB01
            }

        };

        public Task<List<Notification>> GetNotificationsForUserAsync(string userEmail, string userRole)
        {
            // Filter by user role/permissions
            if (userRole == UserRolesModel.Admin2)
            {
                return Task.FromResult(_notifications);
            }
            return Task.FromResult(new List<Notification>());
        }

        public Task<int> GetUnreadNotificationCountAsync(string userEmail, string userRole)
        {
            if (userRole == UserRolesModel.Admin2)
            {
                return Task.FromResult(_notifications.Count(n => !n.IsRead));
            }
            return Task.FromResult(0);
        }

        public Task MarkNotificationAsRead(int notificationId)
        {
            var notification = _notifications.FirstOrDefault(n => n.Id == notificationId);
            if (notification != null)
            {
                notification.IsRead = true;
            }
            return Task.CompletedTask;
        }

        public Task MarkAllNotificationsAsRead()
        {
            foreach (var notification in _notifications)
            {
                notification.IsRead = true;
            }
            return Task.CompletedTask;
        }

        public Task AddNotification(Notification notification)
        {
            notification.Id = _notifications.Any() ? _notifications.Max(n => n.Id) + 1 : 1;
            _notifications.Add(notification);
            return Task.CompletedTask;
        }

        public Task<Notification?> GetNotificationByIdAsync(int id)
        {
            return Task.FromResult(_notifications.FirstOrDefault(n => n.Id == id));
        }

    }
}
