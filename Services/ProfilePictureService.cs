namespace GEMS.Services
{
    public class ProfilePictureService
    {
        public string ProfilePictureUrl { get; private set; } = "/Images/profile-picture.png";

        public event Action? OnProfilePictureChanged;
        public void SetProfilePictureUrl(string url)
        {
            ProfilePictureUrl = url;
            OnProfilePictureChanged?.Invoke();
        }
    }
}
