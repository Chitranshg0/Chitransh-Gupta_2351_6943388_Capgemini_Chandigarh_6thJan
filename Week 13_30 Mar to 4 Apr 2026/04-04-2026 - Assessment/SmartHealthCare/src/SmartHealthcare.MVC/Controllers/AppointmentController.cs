using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.MVC.Services;
using SmartHealthcare.Models.DTOs;

namespace SmartHealthcare.MVC.Controllers;

public class AppointmentController : Controller
{
    private readonly IApiService _apiService;
    private readonly ILogger<AppointmentController> _logger;

    public AppointmentController(IApiService apiService, ILogger<AppointmentController> logger)
    {
        _apiService = apiService;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var role = HttpContext.Session.GetString("Role");
        PagedResult<AppointmentDTO>? result = null;

        if (role == "Patient")
        {
            result = await _apiService.GetAsync<PagedResult<AppointmentDTO>>(
                "api/appointments/my-appointments?pageNumber=1&pageSize=50", token);
        }
        else if (role == "Doctor")
        {
            result = await _apiService.GetAsync<PagedResult<AppointmentDTO>>(
                "api/appointments/doctor-appointments?pageNumber=1&pageSize=50", token);
        }
        else if (role == "Admin")
        {
            result = await _apiService.GetAsync<PagedResult<AppointmentDTO>>(
                "api/appointments?pageNumber=1&pageSize=50", token);
        }

        ViewBag.Role = role;
        return View(result?.Items ?? Enumerable.Empty<AppointmentDTO>());
    }

    // ===================== CREATE GET =====================
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        // ✅ FIX: Correct API + correct type
        var doctorResult = await _apiService.GetAsync<PagedResult<DoctorDTO>>(
            "api/doctors?pageNumber=1&pageSize=100", token);

        ViewBag.Doctors = doctorResult?.Items ?? Enumerable.Empty<DoctorDTO>();

        _logger.LogInformation($"Doctors Loaded: {doctorResult?.Items?.Count()}");

        return View();
    }

    // ===================== CREATE POST =====================
    [HttpPost]
    public async Task<IActionResult> Create(CreateAppointmentDTO dto)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        if (!ModelState.IsValid)
        {
            var doctorResult = await _apiService.GetAsync<PagedResult<DoctorDTO>>(
                "api/doctors?pageNumber=1&pageSize=100", token);

            ViewBag.Doctors = doctorResult?.Items ?? Enumerable.Empty<DoctorDTO>();

            return View(dto);
        }

        var result = await _apiService.PostAsync<AppointmentDTO>(
            "api/appointments", dto, token);

        if (result == null)
        {
            ModelState.AddModelError("", "Failed to create appointment.");

            var doctorResult = await _apiService.GetAsync<PagedResult<DoctorDTO>>(
                "api/doctors?pageNumber=1&pageSize=100", token);

            ViewBag.Doctors = doctorResult?.Items ?? Enumerable.Empty<DoctorDTO>();

            return View(dto);
        }

        TempData["Success"] = "Appointment booked successfully!";
        return RedirectToAction(nameof(Index));
    }

    // ===================== DETAILS =====================
    public async Task<IActionResult> Details(int id)
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            return RedirectToAction("Login", "Account");
        }

        var appointment = await _apiService.GetAsync<AppointmentDTO>(
            $"api/appointments/{id}", token);

        if (appointment == null)
        {
            return NotFound();
        }

        ViewBag.Role = HttpContext.Session.GetString("Role");

        ViewBag.Prescription = await _apiService.GetAsync<PrescriptionDTO>(
            $"api/prescriptions/appointment/{id}", token);

        return View(appointment);
    }
}