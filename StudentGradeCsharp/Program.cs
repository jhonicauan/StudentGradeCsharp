using Microsoft.EntityFrameworkCore;
using StudentGradeCsharp.Database;
using StudentGradeCsharp.Repository;
using StudentGradeCsharp.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepositoryStudent, StudentRepository>();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<IRepositorySchoolTest, SchoolTestRepository>();
builder.Services.AddScoped<SchoolTestService>();
builder.Services.AddScoped<IRepositoryGrade, GradeRepository>();
builder.Services.AddScoped<GradeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Student Grade Csharp v1"));
}

app.MapControllers();



app.Run();

