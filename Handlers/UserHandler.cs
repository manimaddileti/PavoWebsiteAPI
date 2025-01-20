using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;


namespace PavoWebsiteDatabase.Handlers
{
    public class UserHandler
    {
        private readonly UserRepository _userRepository;

        public UserHandler(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> HandleGetUsersAsync()
        {
            return await _userRepository.GetUser();
        }
    }
}
