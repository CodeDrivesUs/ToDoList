using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ToDoList.Pages
{
    public class Index_Tests : ToDoListWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
