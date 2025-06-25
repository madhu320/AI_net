using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class OpenAIService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "your-openai-api-key";

    public OpenAIService(HttpClient client)
    {
        _httpClient = client;
    }

    public async Task<string> GetDiagnosisAsync(string symptoms)
    {
        var prompt = $"Patient reports: {symptoms}. What could be the possible cause or advice?";

        var request = new
        {
            model = "gpt-3.5-turbo",
            messages = new[] {
                new { role = "user", content = prompt }
            }
        };

        var requestJson = JsonSerializer.Serialize(request);
        var httpContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);

        var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", httpContent);
        var responseJson = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(responseJson);

        return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
    }
}
