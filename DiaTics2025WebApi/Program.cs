using Business;
using DiaTics2025WebApi;

var builder = WebApplication.CreateBuilder(args);

// Habilita CORS para aceptar TODO
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


// Add services to the container.
//GRR: IOC Repository
builder.Services.AddRepositoryViProduce(builder.Configuration.GetConnectionString("DiaTics2025DB") ?? "");

// GRR: IOC Business
builder.Services.AddBusiness();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirTodo");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
