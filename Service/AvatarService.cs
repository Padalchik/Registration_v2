using Registration_v2.Entity;

namespace Registration_v2.Service
{
    public class AvatarService
    {
        private readonly IConfiguration _config;

        public AvatarService(IConfiguration config)
        {
            _config = config;
        }

        public string GetAvatarUrl(CustomUser user)
        {
            return user?.Avatar != null
                ? $"data:image/jpeg;base64,{Convert.ToBase64String(user.Avatar)}"
                : _config["DefaultAvatarPath"];
        }
    }
}
