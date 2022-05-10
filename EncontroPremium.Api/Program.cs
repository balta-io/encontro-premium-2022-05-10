using EncontroPremium.Api.Models;
using EncontroPremium.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("v1/passwords", (short? len, bool? specialChars, bool? uppercase)
    => Results.Ok(new PasswordResponse(PasswordGenerator.Generate(len ?? 16, specialChars ?? true, uppercase ?? false))))
    .Produces<PasswordResponse>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();