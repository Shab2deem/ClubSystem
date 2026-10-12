using ClubSystemAPI.Context;
using ClubSystemAPI.Models;
using ClubSystemAPI.Repos.Custom.Implementation;
using ClubSystemAPI.Repos.Custom.Interface;
using ClubSystemAPI.Repos.General.Implementation;
using ClubSystemAPI.Repos.General.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(op=>op.UseSqlServer("Data Source=(localdb)\\mylocaldatabase;Initial Catalog=ClubDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
builder.Services.AddScoped<IBookingRepo,BookingRepo>();
builder.Services.AddScoped<IMemberRepo,MemberRepo>();
builder.Services.AddScoped<IFacilityRepo,FacilityRepo>();
builder.Services.AddScoped<IPaymentRepo,PaymentRepo>();

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
