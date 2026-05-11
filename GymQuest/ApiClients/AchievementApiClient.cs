using GymQuest.Models.Dtos;
using System.Net.Http.Json;

namespace GymQuest.ApiClients;

public class AchievementApiClient
{
    private readonly HttpClient _http;

    public AchievementApiClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<AchievementDto>> GetAchievementsAsync()
    {
        return await _http.GetFromJsonAsync<List<AchievementDto>>("api/achievements") ?? new();
    }

    public async Task<AchievementDto?> GetAchievementAsync(int id)
    {
        return await _http.GetFromJsonAsync<AchievementDto>($"api/achievements/{id}");
    }
}