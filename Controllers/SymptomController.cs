using Microsoft.AspNetCore.Mvc;
using SymptomCheckerGPT.Models;
using SymptomCheckerGPT.Services;

public class SymptomController : Controller
{
    private readonly OpenAIService _aiService;

    public SymptomController(OpenAIService aiService)
    {
        _aiService = aiService;
    }

    [HttpGet]
    public IActionResult Index() => View(new SymptomInput());

    [HttpPost]
    public async Task<IActionResult> CheckSymptoms(SymptomInput input)
    {
        input.Response = await _aiService.GetDiagnosisAsync(input.Symptoms);
        return View("Index", input);
    }
}
