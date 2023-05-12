using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Hr.WebApi.Tests.Features.WeatherForecast;

public class WeatherForecastTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public WeatherForecastTest(WebApplicationFactory<Program> webApplicationFactory)
    {
        this.webApplicationFactory = webApplicationFactory;
    }

    [Fact]
    public async Task TestSuccessGetWeatherForcast()
    {
        // Arrange
        string url = "/weatherforecast";
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