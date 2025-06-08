using Pessoa.Data;
using Pessoa.Rotas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer(); // Adiciona suporte ao API Explorer
builder.Services.AddSwaggerGen();           // Adiciona o Swagger
builder.Services.AddScoped<PessoaContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();               
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = "swagger";
    });        

}
app.PessoaRotas();



app.UseHttpsRedirection();
app.Run();

