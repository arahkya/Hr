using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Hr.WebApi;

namespace Hr.WebApi.Tests.Features.Employee;

public class RegisterPersonTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> webApp;

    public RegisterPersonTest(WebApplicationFactory<Program> webApp)
    {
        this.webApp = webApp;
    }

    [Fact]
    public async Task TestSuccessRegistraterPerson()
    {
        // Arrange

        // Action
        await Task.CompletedTask;

        // Asserts
        Assert.True(true);
    }
}