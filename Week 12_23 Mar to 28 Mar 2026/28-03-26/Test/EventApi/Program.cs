var builder = WebApplication.CreateBuilder(args);

// ✅ Add Controllers
builder.Services.AddControllers();

// ✅ Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ ADD CORS (VERY IMPORTANT)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var app = builder.Build();

// ❗ ENABLE CORS (MUST BE BEFORE MapControllers)
app.UseCors("AllowAll");

// ❗ ALWAYS enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Optional
app.UseHttpsRedirection();

// ✅ Map Controllers
app.MapControllers();

app.Run();