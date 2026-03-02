using Microsoft.AspNetCore.Mvc;

namespace MeuBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfigController : ControllerBase
{
    private readonly IHostEnvironment _env;

    // DEVE EXISTIR APENAS ESTE CONSTRUTOR ABAIXO
    public ConfigController(IHostEnvironment env)
    {
        _env = env;
    }

    [HttpGet("foto")]
    public async Task<IActionResult> ObterFoto()
    {
        // Path.Combine é o seu path.join
        var caminhoDaImagem = Path.GetFullPath(Path.Combine(_env.ContentRootPath, "images", "fotoPerfil.jpg"));
        
        if (!System.IO.File.Exists(caminhoDaImagem))
        {
            return NotFound(new { erro = "Arquivo não encontrado em: " + caminhoDaImagem });
        }
        
        var bytes = await System.IO.File.ReadAllBytesAsync(caminhoDaImagem);
        return File(bytes, "image/png");
    }
}