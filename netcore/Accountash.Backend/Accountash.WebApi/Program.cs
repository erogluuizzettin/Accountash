using Accountash.Application.Services.AppServices;
using Accountash.Application.Services.CompanyServices;
using Accountash.Domain;
using Accountash.Domain.AppEntities.Identity;
using Accountash.Domain.Repositories.UniformChartOfAccountRepository;
using Accountash.Persistance;
using Accountash.Persistance.Context;
using Accountash.Persistance.Repositories.UniformChartOfAccountRepository;
using Accountash.Persistance.Services.AppServices;
using Accountash.Persistance.Services.CompanyServices;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUniformChartOfAccountService, UniformChartOfAccountService>();
builder.Services.AddScoped<IUniformChartOfAccountCommandRepository, UniformChartOfAccountCommandRepository>();
builder.Services.AddScoped<IUniformChartOfAccountQueryRepository, UniformChartOfAccountQueryRepository>();
builder.Services.AddScoped<IContextService, ContextService>();

builder.Services.AddMediatR(typeof(Accountash.Application.AssemblyReference).Assembly);

builder.Services.AddAutoMapper(typeof(Accountash.Persistance.AssemblyReference).Assembly);

builder.Services.AddControllers().AddApplicationPart(typeof(Accountash.Presentation.AssemblyReference).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
    var jwtSecuritySheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put **_ONLY_** yourt JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecuritySheme, Array.Empty<string>() }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
