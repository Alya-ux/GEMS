using GEMS.Models;
using System.ComponentModel.DataAnnotations;

//using static GEMS.Pages.Dahsboard.DashboardAdmin2;

namespace GEMS.Services
{
    // UserService.cs
    public class UserServices
    {
        private List<UserModel> _users = new()
        {
            new UserModel { Id = 1, Username = "EMP1001", Fullname = "Ali Bin Ahmad", Email = "ali@example.com", Role = UserRolesModel.Admin1, Password = "admin123", IsActive = true, IsApproved = true },
            new UserModel { Id = 2, Username = "EMP1002", Fullname = "Sarah Tan", Email = "sarah@example.com", Role = UserRolesModel.Admin2, Password = "admin456", IsActive = true, IsApproved = true },
            new UserModel { Id = 3, Username = "EMP1003", Fullname = "John Lee", Email = "johnlee@example.com", Role = UserRolesModel.VaultAuditor, Password = "user123", IsActive = true, IsApproved = true },
            new UserModel { Id = 6, Username = "EMP1006", Fullname = "David Wilson", Email = "david.wilson@example.com", Role = UserRolesModel.Custodian, Password = "david@789", IsActive = true, IsApproved = true, Branch = "Kuala Lumpur", ContactNumber = "+6012-3456789", LastLogin = DateTime.Now.AddHours(-2)},
            new UserModel { Id = 7, Username = "EMP1007", Fullname = "Jessica Lim", Email = "jessica.lim@example.com", Role = UserRolesModel.Custodian, Password = "jessica#123", IsActive = false, IsApproved = null },
            new UserModel { Id = 8, Username = "EMP1008", Fullname = "Robert Garcia", Email = "robert.g@example.com", Role = UserRolesModel.VaultAuditor, Password = "robert$456", IsActive = false, IsApproved = false, /*Status = UserStatus.Pending,*/ RegisteredDate = DateTime.Now.AddDays(-1) },
            new UserModel { Id = 9, Username = "EMP1009", Fullname = "Sophia Martinez", Email = "sophia.m@example.com", Role = UserRolesModel.Custodian, Password = "sophia@2023", IsActive = false, IsApproved = null, /*Status = UserStatus.Pending,*/ RegisteredDate = DateTime.Now.AddDays(-2) },
            new UserModel { Id = 10, Username = "EMP1010", Fullname = "Daniel Kim", Email = "daniel.kim@example.com", Role = UserRolesModel.Custodian, Password = "daniel!789", IsActive = false, IsApproved = false, /*Status = UserStatus.Approved,*/ RegisteredDate = DateTime.Now.AddDays(-10) },
            new UserModel { Id = 11, Username = "EMP1011", Fullname = "Nora Binti Yusof", Email = "nora.y@example.com", Role = UserRolesModel.Custodian, Password = "nora123!", IsActive = true, IsApproved = true },
            new UserModel { Id = 12, Username = "EMP1012", Fullname = "Liam Chan", Email = "liam.chan@example.com", Role = UserRolesModel.Custodian, Password = "liamPass@1", IsActive = true, IsApproved = true },
            new UserModel { Id = 13, Username = "EMP1013", Fullname = "Aida Rahman", Email = "aida.r@example.com", Role = UserRolesModel.VaultAuditor, Password = "aida456$", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-3) },
            new UserModel { Id = 14, Username = "EMP1014", Fullname = "Noah Lim", Email = "noah.lim@example.com", Role = UserRolesModel.Custodian, Password = "noah1234", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-4) },
            new UserModel { Id = 15, Username = "EMP1015", Fullname = "Emily Wong", Email = "emily.wong@example.com", Role = UserRolesModel.VaultAuditor, Password = "emily@123", IsActive = true, IsApproved = true },
            new UserModel { Id = 16, Username = "EMP1016", Fullname = "Hafiz Salleh", Email = "hafiz.salleh@example.com", Role = UserRolesModel.VaultAuditor, Password = "hafiz@pass", IsActive = true, IsApproved = true },
            new UserModel { Id = 17, Username = "EMP1017", Fullname = "Grace Teo", Email = "grace.teo@example.com", Role = UserRolesModel.Custodian, Password = "grace#456", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-5) },
            new UserModel { Id = 18, Username = "EMP1018", Fullname = "Adam Ibrahim", Email = "adam.ibrahim@example.com", Role = UserRolesModel.Custodian, Password = "adam!789", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-6) },
            new UserModel { Id = 19, Username = "EMP1019", Fullname = "Tania Lim", Email = "tania.lim@example.com", Role = UserRolesModel.VaultAuditor, Password = "taniaPass", IsActive = true, IsApproved = true },
            new UserModel { Id = 20, Username = "EMP1020", Fullname = "Ben Tan", Email = "ben.tan@example.com", Role = UserRolesModel.Custodian, Password = "ben@admin", IsActive = true, IsApproved = true },
            new UserModel { Id = 21, Username = "EMP1021", Fullname = "Nurul Aina", Email = "nurul.aina@example.com", Role = UserRolesModel.Custodian, Password = "nurul#2023", IsActive = true, IsApproved = true },
            new UserModel { Id = 22, Username = "EMP1022", Fullname = "Zaki Rahman", Email = "zaki.r@example.com", Role = UserRolesModel.VaultAuditor, Password = "zaki!456", IsActive = true, IsApproved = true },
            new UserModel { Id = 23, Username = "EMP1023", Fullname = "Rachel Tan", Email = "rachel.t@example.com", Role = UserRolesModel.VaultAuditor, Password = "rachel$789", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-7) },
            new UserModel { Id = 24, Username = "EMP1024", Fullname = "Harith Iskandar", Email = "harith.i@example.com", Role = UserRolesModel.Custodian, Password = "harith@pass", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-8) },
            new UserModel { Id = 25, Username = "EMP1025", Fullname = "Amirul Hakim", Email = "amirul.h@example.com", Role = UserRolesModel.Custodian, Password = "amirul456", IsActive = true, IsApproved = true },
            new UserModel { Id = 26, Username = "EMP1026", Fullname = "Chloe Ng", Email = "chloe.ng@example.com", Role = UserRolesModel.VaultAuditor, Password = "chloe123", IsActive = true, IsApproved = true },
            new UserModel { Id = 27, Username = "EMP1027", Fullname = "Irfan Aziz", Email = "irfan.aziz@example.com", Role = UserRolesModel.Custodian, Password = "irfan@123", IsActive = true, IsApproved = true },
            new UserModel { Id = 28, Username = "EMP1028", Fullname = "Siti Khadijah", Email = "siti.k@example.com", Role = UserRolesModel.VaultAuditor, Password = "sitiPass!", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-9) },
            new UserModel { Id = 29, Username = "EMP1029", Fullname = "Marcus Lee", Email = "marcus.lee@example.com", Role = UserRolesModel.Custodian, Password = "marcus789", IsActive = true, IsApproved = true },
            new UserModel { Id = 30, Username = "EMP1030", Fullname = "Alia Farhana", Email = "alia.f@example.com", Role = UserRolesModel.Custodian, Password = "alia456", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-10) },
            new UserModel { Id = 31, Username = "EMP1031", Fullname = "Jason Foo", Email = "jason.foo@example.com", Role = UserRolesModel.Custodian, Password = "jason#admin", IsActive = true, IsApproved = true },
            new UserModel { Id = 32, Username = "EMP1032", Fullname = "Aishah Jalil", Email = "aishah.j@example.com", Role = UserRolesModel.VaultAuditor, Password = "aishahPass!", IsActive = true, IsApproved = true },
            new UserModel { Id = 33, Username = "EMP1033", Fullname = "Yasmin Hani", Email = "yasmin.h@example.com", Role = UserRolesModel.Custodian, Password = "yasmin123", IsActive = true, IsApproved = true },
            new UserModel { Id = 34, Username = "EMP1034", Fullname = "Khairol Anuar", Email = "khairol.a@example.com", Role = UserRolesModel.VaultAuditor, Password = "khairol@456", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-11) },
            new UserModel { Id = 35, Username = "EMP1035", Fullname = "Mei Yee", Email = "mei.yee@example.com", Role = UserRolesModel.Custodian, Password = "mei123!", IsActive = true, IsApproved = true },
            new UserModel { Id = 36, Username = "EMP1036", Fullname = "Daniel Raj", Email = "daniel.raj@example.com", Role = UserRolesModel.VaultAuditor, Password = "daniel$pass", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-12) },
            new UserModel { Id = 37, Username = "EMP1037", Fullname = "Arif Nazmi", Email = "arif.n@example.com", Role = UserRolesModel.Custodian, Password = "arif@pass", IsActive = true, IsApproved = true },
            new UserModel { Id = 38, Username = "EMP1038", Fullname = "Wani Idris", Email = "wani.idris@example.com", Role = UserRolesModel.Custodian, Password = "wani#pass", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-13) },
            new UserModel { Id = 39, Username = "EMP1039", Fullname = "Leon Chong", Email = "leon.c@example.com", Role = UserRolesModel.Custodian, Password = "leon789!", IsActive = true, IsApproved = true },
            new UserModel { Id = 40, Username = "EMP1040", Fullname = "Farid Zulkifli", Email = "farid.z@example.com", Role = UserRolesModel.VaultAuditor, Password = "farid@2024", IsActive = true, IsApproved = true },
            new UserModel { Id = 41, Username = "EMP1041", Fullname = "Wong Jia Yi", Email = "jia.yi@example.com", Role = UserRolesModel.Custodian, Password = "jiaPass!", IsActive = true, IsApproved = true },
            new UserModel { Id = 42, Username = "EMP1042", Fullname = "Aiman Syahmi", Email = "aiman.s@example.com", Role = UserRolesModel.VaultAuditor, Password = "aiman123", IsActive = true, IsApproved = true },
            new UserModel { Id = 43, Username = "EMP1043", Fullname = "Tan Siew Lin", Email = "siew.lin@example.com", Role = UserRolesModel.Custodian, Password = "siewlin!", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-14) },
            new UserModel { Id = 44, Username = "EMP1044", Fullname = "Rashid Omar", Email = "rashid.o@example.com", Role = UserRolesModel.Custodian, Password = "rashid@admin", IsActive = true, IsApproved = true },
            new UserModel { Id = 45, Username = "EMP1045", Fullname = "Yvonne Tan", Email = "yvonne.t@example.com", Role = UserRolesModel.Custodian, Password = "yvonnePass", IsActive = false, IsApproved = null, RegisteredDate = DateTime.Now.AddDays(-15) },
            new UserModel { Id = 46, Username = "EMP1046", Fullname = "Faisal Rahim", Email = "faisal.r@example.com", Role = UserRolesModel.VaultAuditor, Password = "faisal456", IsActive = true, IsApproved = true },
            new UserModel { Id = 47, Username = "EMP1047", Fullname = "Melissa Chan", Email = "melissa.c@example.com", Role = UserRolesModel.Custodian, Password = "melissa@123", IsActive = true, IsApproved = true },
            new UserModel { Id = 48, Username = "EMP1048", Fullname = "Nabilah Huda", Email = "nabilah.h@example.com", Role = UserRolesModel.VaultAuditor, Password = "nabilah789", IsActive = false, IsApproved = false, RegisteredDate = DateTime.Now.AddDays(-16) },
            new UserModel { Id = 49, Username = "EMP1049", Fullname = "Syafiq Zainal", Email = "syafiq.z@example.com", Role = UserRolesModel.Custodian, Password = "syafiq@admin", IsActive = true, IsApproved = true },
            new UserModel { Id = 50, Username = "EMP1050", Fullname = "Evelyn Low", Email = "evelyn.low@example.com", Role = UserRolesModel.Custodian, Password = "evelyn456!", IsActive = true, IsApproved = true },

        };

        private List<ActivityLog> _activityLogs = new()
        {
            new ActivityLog { Id = 1, ActivityType = ActivityType.Registration, Message = "New user registered: Ali Bin Ahmad", Timestamp = DateTime.Now.AddDays(-30), Username = "EMP1001" },
            new ActivityLog { Id = 2, ActivityType = ActivityType.Approval, Message = "User approved: Sarah Tan", Timestamp = DateTime.Now.AddDays(-20), Username = "EMP1002" },
            new ActivityLog { Id = 3, ActivityType = ActivityType.Approval, Message = "User approved: John Lee", Timestamp = DateTime.Now.AddDays(-10), Username = "EMP1003" }
        };

        // Add this new method to filter users for Admin1
        /*public List<User> GetRegularUsers()
        {
            return _users.Where(u => u.Status != UserStatus.Pending &&
                                   u.Status != UserStatus.Approved)
                       .ToList();
        }*/

        public List<UserModel> GetAllUsers() => _users;

        public UserModel? GetUserByEmail(string email) =>
            _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        public void AddUser(UserModel user)
        {
            user.Id = _users.Max(u => u.Id) + 1;
            user.IsActive = false;
            user.IsApproved = null; // Set as pending by default
            user.RegisteredDate = DateTime.Now;
            _users.Add(user);
        }

        public void UpdateUser(UserModel updatedUser)
        {
            var index = _users.FindIndex(u => u.Id == updatedUser.Id);
            if (index >= 0)
            {
                _users[index] = updatedUser;
            }
        }

        public void DeleteUser(int userId)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public void ToggleUserStatus(int userId)
        {
            var user = _users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                user.IsActive = !user.IsActive;
            }
        }

        // In UserService.cs
        public void UpdatePassword(string email, string newPassword)
        {
            var user = GetUserByEmail(email);
            if (user != null)
            {
                user.Password = newPassword; // In real app, hash the password
            }
        }
    

    // New methods for Admin2 dashboard
        public int GetTotalUserCount() => _users.Count;

        // public int GetPendingUserCount() => _users.Count(u => u.Status == UserStatus.Pending);
        public int GetPendingUserCount() =>
     _users.Count(u => u.IsApproved == null);

        public int GetTodayApprovedCount() => _users.Count(u =>
        u.IsApproved == true && // Use IsApproved instead of Status
        u.ApprovalDate?.Date == DateTime.Today);

        public List<PendingUser> GetPendingUsers() => _users
        .Where(u => u.IsApproved == null)
        .Select(u => new PendingUser
        {
            Id = u.Id,
            FullName = u.Fullname,
            Email = u.Email,
            RegisteredDate = u.RegisteredDate
        })
        .ToList();

        /*public List<PendingUser> GetPendingUsers() => _users
            .Where(u => u.Status == UserStatus.Pending)
            .Select(u => new PendingUser
            {
                Id = u.Id,
                FullName = u.Fullname,
                Email = u.Email,
                RegisteredDate = u.RegisteredDate
            })
            .ToList();*/

        public List<ActivityLog> GetRecentApprovalActivities(int count = 5) => _activityLogs
            .Where(a => a.ActivityType == ActivityType.Approval)
            .OrderByDescending(a => a.Timestamp)
            .Take(count)
            .ToList();

        /*public bool ApproveUser(int Id)
        {
            var user = _users.FirstOrDefault(u => u.Id == Id);
            if (user == null) return false;

            user.Status = UserStatus.Approved;
            user.IsActive = true;
            user.ApprovalDate = DateTime.Now;

            _activityLogs.Add(new ActivityLog
            {
                Id = _activityLogs.Max(a => a.Id) + 1,
                ActivityType = ActivityType.Approval,
                Message = $"User approved: {user.Fullname}",
                Timestamp = DateTime.Now,
                Username = user.Username
            });

            return true;
        }

        public bool RejectUser(int Id)
        {
            var user = _users.FirstOrDefault(u => u.Id == Id);
            if (user == null) return false;

            user.Status = UserStatus.Rejected;
            user.IsActive = false;

            _activityLogs.Add(new ActivityLog
            {
                Id = _activityLogs.Max(a => a.Id) + 1,
                ActivityType = ActivityType.Rejection,
                Message = $"User rejected: {user.Fullname}",
                Timestamp = DateTime.Now,
                Username = user.Username
            });

            return true;
        }*/
        /*public bool ApproveUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;

            user.IsApproved = true;
            user.IsActive = true;
            user.ApprovalDate = DateTime.Now;

            _activityLogs.Add(new ActivityLog
            {
                Id = _activityLogs.Max(a => a.Id) + 1,
                ActivityType = ActivityType.Approval,
                Message = $"User approved: {user.Fullname}",
                Timestamp = DateTime.Now,
                Username = user.Username
            });

            return true;
        }

        public bool RejectUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;

            user.IsApproved = false;
            user.IsActive = false;

            _activityLogs.Add(new ActivityLog
            {
                Id = _activityLogs.Max(a => a.Id) + 1,
                ActivityType = ActivityType.Rejection,
                Message = $"User rejected: {user.Fullname}",
                Timestamp = DateTime.Now,
                Username = user.Username
            });

            return true;
        }*/

        public async Task<bool> ApproveUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;

            user.IsApproved = true;
            user.IsActive = true;
            user.ApprovalDate = DateTime.Now;

            _activityLogs.Add(new ActivityLog
            {
                Id = _activityLogs.Max(a => a.Id) + 1,
                ActivityType = ActivityType.Approval,
                Message = $"User approved: {user.Fullname}",
                Timestamp = DateTime.Now,
                Username = user.Username
            });

            return await Task.FromResult(true);
        }

        public async Task<bool> RejectUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;

            user.IsApproved = false;
            user.IsActive = false;

            _activityLogs.Add(new ActivityLog
            {
                Id = _activityLogs.Max(a => a.Id) + 1,
                ActivityType = ActivityType.Rejection,
                Message = $"User rejected: {user.Fullname}",
                Timestamp = DateTime.Now,
                Username = user.Username
            });

            return await Task.FromResult(true);
        }

        // In UserServices.cs
        public async Task<UserModel?> GetUserByIdAsync(int id)
        {
            return await Task.FromResult(_users.FirstOrDefault(u => u.Id == id));
        }
       
    }

    // Model classes
    /*public class User
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
    }*/

    /*public enum UserStatus
    {
        Pending,
        Approved,
        Rejected
    }*/

   /* public enum ActivityType
    {
        Approval,
        Rejection,
        Registration
    }*/


}
