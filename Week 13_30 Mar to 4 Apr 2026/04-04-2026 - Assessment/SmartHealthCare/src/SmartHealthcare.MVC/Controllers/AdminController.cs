using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class AdminController : Controller
{
    private readonly IApiService _apiService;

    public AdminController(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<IActionResult> Users(int page = 1)
    {
        var token = HttpContext.Session.GetString("Token");

        var result = await _apiService.GetAsync<PagedResult<UserDTO>>(
            $"api/admin/users?pageNumber={page}&pageSize=10", token);

        return View(result ?? new PagedResult<UserDTO>());
    }

    // ✅ DELETE USER
    [HttpPost]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var token = HttpContext.Session.GetString("Token");

        await _apiService.DeleteAsync($"api/admin/users/{id}", token);

        return RedirectToAction("Users");
    }
}