using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class TestmonialHandler
    {
        private readonly TestmonialRepository _testmonialRepository;

        public TestmonialHandler(TestmonialRepository testmonialRepository)
        {
            _testmonialRepository = testmonialRepository;
        }
        public async Task<IEnumerable<Testmonial>> HandleGetTestmonialsAsync()
        {
            return await _testmonialRepository.GetTestmonials();
        }
    }
}
