using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using System.Net;

namespace Hr.WebApi.Tests.Features.Employee;

public class PromoteEmployeeTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public PromoteEmployeeTest(WebApplicationFactory<Program> webApplicationFactory)
    {
        this.webApplicationFactory = webApplicationFactory;
    }

    [Fact]
    public async Task TestSuccessGetPerson()
    {
        // Arrange
        string url = "/Person/list";
        HttpMethod method = HttpMethod.Get;
        HttpClient httpClient = webApplicationFactory.CreateClient();
        HttpRequestMessage request = new HttpRequestMessage(method, url);

        // Action
        HttpResponseMessage response = await httpClient.SendAsync(request);
        string jsonContent = await response.Content.ReadAsStringAsync();

        // Asserts
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.NotEmpty(jsonContent);
    }
}