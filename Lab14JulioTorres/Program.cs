var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
                                      <!DOCTYPE html>
                                      <html lang="es">
                                      <head>
                                          <meta charset="UTF-8">
                                          <title>Laboratorio 14</title>
                                          <style>
                                              body {
                                                  font-family: Arial, sans-serif;
                                                  background: #0f172a;
                                                  color: white;
                                                  display: flex;
                                                  justify-content: center;
                                                  align-items: center;
                                                  min-height: 100vh;
                                                  margin: 0;
                                              }
                                              .card {
                                                  background: #1e293b;
                                                  padding: 50px;
                                                  border-radius: 20px;
                                                  text-align: center;
                                                  box-shadow: 0 10px 40px #0005;
                                              }
                                              h1 { color: #38bdf8; }
                                              .status { color: #4ade80; }
                                              p { color: #cbd5e1; }
                                          </style>
                                      </head>
                                      <body>
                                          <div class="card">
                                              <h1>Laboratorio 14 - .NET 10</h1>
                                              <h2>Julio Torres</h2>
                                              <p>Desarrollo de Aplicaciones Empresariales Avanzadas</p>
                                              <p>Publicación y despliegue de aplicaciones</p>
                                              <h3 class="status">Aplicación funcionando correctamente</h3>
                                              <p>Rider | GitHub Actions | Render</p>
                                          </div>
                                      </body>
                                      </html>
                                      """, "text/html; charset=utf-8"));

app.MapGet("/api/status", () => new
{
    estudiante = "Julio Torres",
    laboratorio = 14,
    tecnologia = ".NET 10",
    estado = "Activo"
});

app.Run();