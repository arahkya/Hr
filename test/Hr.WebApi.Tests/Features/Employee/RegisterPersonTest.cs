using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Headers;
using System.Net;
using Hr.Domains.Features.Employee;
using Hr.Domains.Features.Employee.Enums;
using Hr.Domains.Features.Employee.ValueObjects;
using Hr.Application.Interfaces;
using Moq;
using Hr.Domains.Common.Interfaces;

namespace Hr.WebApi.Tests.Features.Employee;

public class RegisterPersonTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public RegisterPersonTest(WebApplicationFactory<Program> webApplicationFactory)
    {
        this.webApplicationFactory = webApplicationFactory;
    }

    [Fact]
    public async Task TestSuccess()
    {
        // Arrange
        string url = "/person";
        HttpMethod method = HttpMethod.Post;
        HttpClient httpClient = webApplicationFactory.WithWebHostBuilder(cfg =>
        {
            cfg.ConfigureServices(opt =>
            {
                opt.AddScoped<IApplicationDbContext>(serv =>
                {
                    Mock<IApplicationDbContext> mockAppDbContext = new Mock<IApplicationDbContext>();
                    mockAppDbContext.Setup(p => p.AddAsync(It.IsAny<IEntity>())).ReturnsAsync(1);
                    mockAppDbContext.Setup(p => p.CommitAsync());
                    
                    return mockAppDbContext.Object;
                });
            });
        }).CreateClient();
        Person person = new Person
        {
            Firstname = "Arahk",
            Lastname = "Yambupah",
            DateOfBirth = new DateTime(1982, 2, 23, 0, 0, 0),
            Gender = Gender.Male,
            Nationality = "Thai",
            GovIdentity = new GovIdentity
            {
                CitizenId = "1234567890123"
            },
            Phones = new List<Phone>
            {
                new Phone { Number = "0816163536", Priority = Priority.First },
                new Phone { Number = "0917712328", Priority = Priority.Second }
            },
            Emails = new List<Email>
            {
                new Email { Address = "arahk@outlook.com", Priority = Priority.First },
                new Email { Address = "arrak.ya@outlook.com", Priority = Priority.Second }
            }
        };
        JsonContent content = JsonContent.Create(person, mediaType: new MediaTypeHeaderValue("application/json"));
        HttpRequestMessage request = new HttpRequestMessage(method, url);
        request.Content = content;

        // Action
        HttpResponseMessage response = await httpClient.SendAsync(request);

        // Asserts
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}