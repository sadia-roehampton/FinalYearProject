using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FYP_Appointment_ManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FYP_Appointment_ManagementContext") ?? throw new InvalidOperationException("Connection string 'FYP_Appointment_ManagementContext' not found.")));

builder.Services.AddDbContext<DepartmentContext>(options =>
    options.UseSqlServer("Server=DESKTOP-4B4U572;Database=DepartmentContext;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddDbContext<Patient_appointmentsContext>(options =>
    options.UseSqlServer("Server=DESKTOP-4B4U572;Database=Patient_appointmentstContext;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddDbContext<PatientContext>(options =>
    options.UseSqlServer("Server=DESKTOP-4B4U572;Database=PatientContext;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddDbContext<Staff_appointmentsContext>(options =>
    options.UseSqlServer("Server=DESKTOP-4B4U572;Database=Staff_appointmentsContext;Trusted_Connection=True;TrustServerCertificate=True"));

builder.Services.AddDbContext<StaffContext>(options =>
    options.UseSqlServer("Server=DESKTOP-4B4U572;Database=StaffContext;Trusted_Connection=True;TrustServerCertificate=True"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
