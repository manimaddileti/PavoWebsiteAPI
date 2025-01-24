using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class TestmonialHandler
    {
        private readonly ITestmonialRepository _testmonialRepository;

        public TestmonialHandler(ITestmonialRepository testmonialRepository)
        {
            _testmonialRepository = testmonialRepository;
        }
        public async Task<IEnumerable<Testmonial>> GetTestmonialsAsync()
        {
            var data = await _testmonialRepository.GetTestmonialsAsync();
            if (data == null || !data.Any())
            {
                throw new Exception("data not found in testmonials");
            }
            return data;
        }
    }
}
