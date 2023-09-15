using Infrastructure.Configuration.Configuration;
using Infrastructure.IOC.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Configure Log
var logger = LoggingConfiguration.CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);
builder.Services.AddSingleton(logger);

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddHealthChecks();
builder.Services.AddBaseServices(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureRequestLocation();
builder.Services.AddCustomServices(builder.Configuration);

//var secretService = new SecretService(builder.Configuration);
//string jwtSecretKey = await secretService.GetJwtSecretKeyAsync("jwt_token", AwsConfiguration.Current.Region);

if (EnvironmentConfiguration.NotProd())
    builder.Services.ConfigureSwagger();

builder.Services.AddAuthentication(_ =>
{
    _.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    _.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("teste"/*jwtSecretKey*/)),
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});

builder.Services.AddAuthorization(options =>
{
    var defaultAuthorizationPolicyBuilder = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme);
    defaultAuthorizationPolicyBuilder = defaultAuthorizationPolicyBuilder.RequireAuthenticatedUser();
    options.DefaultPolicy = defaultAuthorizationPolicyBuilder.Build();
});

//services
//builder.Services.AddScoped<IKiprevService, KiprevService>();

//Application
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
//app.ConfigureHealthCheck();

app.Run();
