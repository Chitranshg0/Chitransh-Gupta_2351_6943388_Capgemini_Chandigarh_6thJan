using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class DoctorController : Controller
{
    private readonly IApiService _apiService;

    public DoctorController(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<IActionResult> Index(string? specialization, string? name, int page = 1)
    {
        var token = HttpContext.Session.GetString("Token");

        string endpoint = $"api/doctors?pageNumber={page}&pageSize=10";

        // ✅ Search by specialization
        if (!string.IsNullOrWhiteSpace(specialization))
        {
            endpoint = $"api/doctors/search?specialization={Uri.EscapeDataString(specialization)}&pageNumber={page}&pageSize=10";
        }

        var result = await _apiService.GetAsync<PagedResult<DoctorDTO>>(endpoint, token);

        // ✅ Name filtering (frontend)
        if (!string.IsNullOrWhiteSpace(name) && result?.Items != null)
        {
            result.Items = result.Items
                .Where(d => d.FullName.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        ViewBag.Specialization = specialization;
        ViewBag.Name = name;

        // ✅ IMPORTANT: send full object
        return View(result ?? new PagedResult<DoctorDTO>());
    }
}