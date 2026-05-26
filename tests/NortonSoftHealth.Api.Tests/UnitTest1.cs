using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace NortonSoftHealth.Api.Tests;

//For some reason, error thrown when reying on the using statement - using full qualified name instead.
public class UnitTest1 : IClassFixture<Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public UnitTest1(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task VersionEndpoint_Returns_200_And_Valid_Version()
    {
        // Act
        var response = await _client.GetAsync("/api/version");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var content = await response.Content.ReadFromJsonAsync<VersionDto>();
        Assert.NotNull(content);
        Assert.Matches(@"^\d+\.\d+\.\d+", content.Version);
    }

    [Fact]
    public async Task HealthEndpoint_Returns_Healthy()
    {
        var response = await _client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}

record VersionDto(string Version, string BuildDate, string Description);
