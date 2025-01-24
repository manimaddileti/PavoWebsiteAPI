using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;


namespace PavoWebsiteDatabase.Handlers
{
    public class UserHandler
    {
        private readonly IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var data = await _userRepository.GetUserRepositoryAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("User not found");
            }
            return data;
        }
    }
}
