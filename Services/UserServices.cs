namespace GEMS.Services
{
    // UserService.cs
    public class UserServices
    {
        private List<User> _users = new()
    {
        new User { Id = 1, UserId = "EMP1001", Name = "Ali Bin Ahmad", Email = "ali@example.com", Role = "1stAdmin", Password = "admin123", IsActive = true },
        new User { Id = 2, UserId = "EMP1002", Name = "Sarah Tan", Email = "sarah@example.com", Role = "2ndAdmin", Password = "admin456", IsActive = true },
        new User { Id = 3, UserId = "EMP1003", Name = "John Lee", Email = "johnlee@example.com", Role = "User", Password = "user123", IsActive = true },
        new User { Id = 6, UserId = "EMP1006", Name = "David Wilson", Email = "david.wilson@example.com", Role = "User", Password = "david@789", IsActive = true },
        new User { Id = 7, UserId = "EMP1007", Name = "Jessica Lim", Email = "jessica.lim@example.com", Role = "User", Password = "jessica#123", IsActive = true },
        new User { Id = 8, UserId = "EMP1008", Name = "Robert Garcia", Email = "robert.g@example.com", Role = "User", Password = "robert$456", IsActive = true },
        new User { Id = 9, UserId = "EMP1009", Name = "Sophia Martinez", Email = "sophia.m@example.com", Role = "User", Password = "sophia@2023", IsActive = false },
        new User { Id = 10, UserId = "EMP1010", Name = "Daniel Kim", Email = "daniel.kim@example.com", Role = "User", Password = "daniel!789", IsActive = false }
    };

        public List<User> GetAllUsers() => _users;

        public User? GetUserByEmail(string email) =>
            _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        public void AddUser(User user)
        {
            user.Id = _users.Max(u => u.Id) + 1;
            _users.Add(user);
        }

        public void UpdateUser(User updatedUser)
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
    }

    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }

}
