namespace GEMS.Models
{
    public class AssignmentModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VaultId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
       // public TimeSpan StartTime { get; set; } = new TimeSpan(8, 0, 0); // Default 08:00
        //public TimeSpan EndTime { get; set; } = new TimeSpan(17, 0, 0); // Default 17:00
        //public string TimeWindow { get; set; } = "08:00-17:00"; // Default time window
        public int RequiredCustodians { get; set; } = 2;
        public DateTime AssignmentDate { get; set; } = DateTime.Now;

        // Navigation properties (for display)
        public string UserName { get; set; } = string.Empty;
        public string UserRole { get; set; } = string.Empty;
        public string VaultName { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;

        // Helper property to maintain backward compatibility
        public string TimeWindow
        {
            get => $"{StartTime:hh\\:mm}-{EndTime:hh\\:mm}";
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var parts = value.Split('-');
                    if (parts.Length == 2 && TimeSpan.TryParse(parts[0], out var start) &&
                        TimeSpan.TryParse(parts[1], out var end))
                    {
                        StartTime = start;
                        EndTime = end;
                    }
                }
            }
        }
    }
}
