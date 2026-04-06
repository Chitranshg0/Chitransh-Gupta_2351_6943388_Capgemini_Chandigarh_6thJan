using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class AccountController : Controller
{
    private readonly IApiService _apiService;
    private readonly ILogger<AccountController> _logger;

    public AccountController(IApiService apiService, ILogger<AccountController> logger)
    {
        _apiService = apiService;
        _logger = logger;
    }

    // ================= LOGIN GET =================
    [HttpGet]
    public IActionResult Login()
    {
        if (HttpContext.Session.GetString("Token") != null)
        {
            return RedirectToAction("Index", "Dashboard");
        }

        return View();
    }

    // ================= LOGIN POST =================
    [HttpPost]
    public async Task<IActionResult> Login(LoginDTO loginDto)
    {
        if (!ModelState.IsValid)
        {
            return View(loginDto);
        }

        // ✅ FIXED ENDPOINT
        var result = await _apiService.PostAsync<TokenDTO>("api/auth/login", loginDto);

        if (result == null)
        {
            ModelState.AddModelError(string.Empty,
                "Login failed. Check credentials or API connection.");
            return View(loginDto);
        }

        HttpContext.Session.SetString("Token", result.AccessToken);
        HttpContext.Session.SetString("RefreshToken", result.RefreshToken);
        HttpContext.Session.SetString("Role", result.Role);
        HttpContext.Session.SetString("FullName", result.FullName);
        HttpContext.Session.SetInt32("UserId", result.UserId);

        _logger.LogInformation("User logged in: {Email}", loginDto.Email);

        return RedirectToAction("Index", "Dashboard");
    }

    // ================= REGISTER GET =================
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    // ================= REGISTER POST =================
    [HttpPost]
    public async Task<IActionResult> Register(RegisterDTO registerDto)
    {
        if (!ModelState.IsValid)
        {
            return View(registerDto);
        }

        // ✅ FIXED ENDPOINT
        var result = await _apiService.PostAsync<TokenDTO>("api/auth/register", registerDto);

        if (result == null)
        {
            ModelState.AddModelError(string.Empty,
                "Registration failed. Email may already exist or API error.");
            return View(registerDto);
        }

        HttpContext.Session.SetString("Token", result.AccessToken);
        HttpContext.Session.SetString("RefreshToken", result.RefreshToken);
        HttpContext.Session.SetString("Role", result.Role);
        HttpContext.Session.SetString("FullName", result.FullName);
        HttpContext.Session.SetInt32("UserId", result.UserId);

        _logger.LogInformation("User registered: {Email}, Role: {Role}",
            registerDto.Email, registerDto.Role);

        return RedirectToAction("Index", "Dashboard");
    }

    // ================= LOGOUT =================
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        _logger.LogInformation("User logged out");
        return RedirectToAction(nameof(Login));
    }
}