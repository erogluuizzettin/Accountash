using Accountash.Domain.AppEntities.Identity;
using Accountash.WebApi.Configurations;
using Accountash.WebApi.Middleware;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "izzettineroglu",
            Email="erogluuizzettin@gmail.com",
            Id= Guid.NewGuid().ToString(),
            FullName = "İzzettin Eroğlu"
        }, "Er1994*").Wait();
    }
}

app.Run();
