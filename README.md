# 🚀 ASP.NET Core Image Backend API

Este é o **Main Process (Backend)** de uma arquitetura resiliente, desenvolvido para gerenciar o ciclo de vida de ativos de imagem via requisições assíncronas. O projeto utiliza o ecossistema **C#** para garantir alta performance de I/O, tipagem forte e escalabilidade no lado do servidor.

## 🛠 Tech Stack & Architecture

### **Core Engine**
* **Framework:** [.NET 8/9 ASP.NET Core Web API](https://learn.microsoft.com)
* **Language:** C# 12 (Strongly Typed)
* **Pattern:** **MVC Controller-Based Architecture** para separação rigorosa entre roteamento e lógica de negócio.

### **Features & Modules**
* **Dependency Injection (DI):** Gerenciamento de caminhos de diretórios via `IHostEnvironment` para persistência segura em disco.
* **Asynchronous I/O:** Operações não-bloqueantes utilizando `Task<IActionResult>` e `FileStream` para manipulação de buffers.
* **CORS Policy:** Middleware customizado para integração segura com frontends **React** (Cross-Origin Resource Sharing).
* **Static File Handling:** Entrega de arquivos físicos diretamente do sistema de arquivos do servidor.

### **Infrastructure & Deployment**
* **Containerization:** [Docker](https://www.docker.com) com Multi-stage build para redução do overhead de runtime.
* **Hosting:** Configurado para deploy em [Render](https://render.com) ou Azure App Service.
* **Tooling:** [Swagger/OpenAPI](https://swagger.io) para documentação e testes de contratos de API.

## 📡 Endpoints (IPC Simulation)

Diferente do IPC interno do Electron, este backend comunica-se via HTTP:

* `POST /api/config/upload` -> Recebe `multipart/form-data` e persiste no `ContentRootPath`.
* `GET /api/config/foto` -> Retorna a `Promise` (Task) do stream da imagem para o Renderer.

## 🚀 Como Executar

```bash
# Restaurar dependências (NuGet)
dotnet restore

# Iniciar o servidor em modo de observação (Hot Reload)
dotnet watch run
