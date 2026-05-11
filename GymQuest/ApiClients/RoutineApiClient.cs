using GymQuest.Models.Dtos;
using System.Net.Http.Json;

namespace GymQuest.ApiClients;

public class RoutineApiClient
{
    private readonly HttpClient _http;

    public RoutineApiClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<RoutineSummaryDto>> GetRoutinesAsync()
    {
        return await _http.GetFromJsonAsync<List<RoutineSummaryDto>>("api/routines") ?? new();
    }

    public async Task<RoutineSummaryDto?> GetRoutineAsync(int id)
    {
        return await _http.GetFromJsonAsync<RoutineSummaryDto>($"api/routines/{id}");
    }
}