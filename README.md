# Hospital-Management-System
# Ramakrishna Sarada Mission Hospital Software

This is a comprehensive hospital management software system developed for **Ramakrishna Sarada Mission Hospital**. The system is designed to streamline the hospital's operations, improve efficiency, and manage patient data, billing, inventory, pathology reports, and more. It is developed using modern technologies such as C#, ASP.NET Core MVC, SQL Server, HTML, CSS, and JavaScript.

## Features

### 1. **IPD & OPD Management**
- Streamlined management of inpatient (IPD) and outpatient (OPD) operations.
- Track patient visits, admission details, treatment history, and discharge summaries.

### 2. **Pharmacy Module**
- Full pharmacy functionality including inventory management, drug dispensation, and billing.
- Integration with patient data for seamless medication tracking.

### 3. **Pathology Section**
- Management of test reports, patient records, and diagnostic data.
- Easy access to patient test results and histories for healthcare professionals.

### 4. **Patient Information System**
- A centralized database for storing and retrieving patient details, medical history, and treatment plans.
- Secure and reliable patient data storage with easy-to-use interfaces.

### 5. **Accounting Integration**
- Facilitates hospital billing, expense tracking, and generating financial reports.
- Simplifies the management of hospital finances and provides clear financial insights.

### 6. **Admin Reports**
- Comprehensive reporting system for hospital administration.
- Generate reports for various departments to track performance and improve operations.

## Technologies Used

- **C#**: The core programming language for backend development.
- **ASP.NET Core MVC**: Framework for building the web application with a Model-View-Controller architecture.
- **HTML**: For structuring the web pages.
- **CSS**: For styling the web pages and improving user experience.
- **JavaScript**: For dynamic content and client-side functionality.
- **SQL Server**: Relational database management system for storing all hospital data securely.

  # Program.cs
  using DataAccessLibrary.Common;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews()
        .AddJsonOptions(js => js.JsonSerializerOptions.PropertyNamingPolicy = null)
        .AddNToastNotifyToastr(new NToastNotify.ToastrOptions()
        {
            ProgressBar = true
        });

    builder.Services.AddRazorPages();
    builder.Services.AddHttpContextAccessor();
    builder.Services.AddDistributedMemoryCache();

    builder.Services.InjectDependency(builder.Configuration);
}

var app = builder.Build();
{
    app.UseNToastNotify();
    // Configure the HTTP request pipeline.
    app.UseDeveloperExceptionPage();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
    }

    app.UseFileServer();
    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseSession();

    app.MapAreaControllerRoute(
        name: "default",
        areaName: "Login",
        pattern: "{area=Login}/{controller=Login}/{action=Start}/{id?}");

    app.Run();
}

