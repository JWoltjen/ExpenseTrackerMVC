using ExpenseTrackerMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependency Injection

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzMTQyMkAzMjMxMmUzMDJlMzBEckxrdmpKUlJrM003am1zZ2JGSTNzbmtiRWpXRm9GL3hVaWppSlBRK2xFPQ==;Mgo+DSMBaFt+QHJqVk1mQ1NGaV1CX2BZfFl0RmlbeE4QCV5EYF5SRHBeR1xnS31RcUBhXH8=;Mgo+DSMBMAY9C3t2VFhiQlJPcEBAX3xLflF1VWFTfV16dlJWACFaRnZdQV1lSHtSckdgW3hbdHVV;Mgo+DSMBPh8sVXJ1S0R+X1pCaV1AQmFJfFBmR2lbfFRyc0UmHVdTRHRcQltiTH9XdEZhXnpbd3Q=;MjQzMTQyNkAzMjMxMmUzMDJlMzBYRWdwazFZSUd4TWlsVk9jWHpXVXlsVFlsWUxSN2hPdCtOa0szbGR0dmQ4PQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldX2FWfFN0RnNbdVxzfldBcDwsT3RfQF5jT39Wd0FhWn1ZdnVQRg==;ORg4AjUWIQA/Gnt2VFhiQlJPcEBAX3xLflF1VWFTfV16dlJWACFaRnZdQV1lSHtSckdgW3hYc3RV;MjQzMTQyOUAzMjMxMmUzMDJlMzBjc3Q2UDFRKzFIVUxxUXB1OU50aGFUVVJPRkhsUlBLeFBLRWQ2NTZMZlVRPQ==;MjQzMTQzMEAzMjMxMmUzMDJlMzBZd1JWb3F1Y1J4TDZvR1FiSTNVUUE3Wjc5VEtvVzlpTXBSMi9pWlJuL05vPQ==;MjQzMTQzMUAzMjMxMmUzMDJlMzBmbWg0dDlNSkRGRjJwL2dNL1I3ZGplRitHODNETTJXQUxtNHJISEdHc21rPQ==;MjQzMTQzMkAzMjMxMmUzMDJlMzBOMkMwa0VvQVZSMjRMY28rWjRQMzMybnpFZVRRTGZCTUxPQ0hPSFE1NWlFPQ==;MjQzMTQzM0AzMjMxMmUzMDJlMzBEckxrdmpKUlJrM003am1zZ2JGSTNzbmtiRWpXRm9GL3hVaWppSlBRK2xFPQ==\r\n");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
