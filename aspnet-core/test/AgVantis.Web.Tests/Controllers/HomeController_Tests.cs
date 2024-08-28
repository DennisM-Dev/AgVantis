using System.Threading.Tasks;
using AgVantis.Models.TokenAuth;
using AgVantis.Web.Controllers;
using Shouldly;
using Xunit;

namespace AgVantis.Web.Tests.Controllers
{
    public class HomeController_Tests: AgVantisWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}