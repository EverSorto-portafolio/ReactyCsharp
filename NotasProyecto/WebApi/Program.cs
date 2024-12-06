var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(
    opciones => opciones.AddPolicy("ReactApp",
    builder => builder.WithOrigins("http://localhost:5173")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    )
    );
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddCors(policyBuilder => policyBuilder.AddDefaultPolicy(
  //  policy => policy.WithOrigins("*")
   // .AllowAnyHeader().AllowAnyMethod()
   // ));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseCors("ReactApp");  
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
