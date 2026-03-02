var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona o suporte aos Controllers (Os ouvintes de IPC)
builder.Services.AddControllers();

// 2. Libera o CORS para o seu React (Renderer) conseguir falar com o C#
builder.Services.AddCors();

var app = builder.Build();

// 3. Configura o CORS
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.MapOpenApi();


// 4. Mapeia os Controllers para as rotas
app.MapControllers();
app.Run();