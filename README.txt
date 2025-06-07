 EmergenciaAPI

PITCH
https://youtu.be/Qu5Ph4sw3f4

API RESTful desenvolvida em ASP.NET Core com Entity Framework Core e PostgreSQL, voltada para o gerenciamento de situações de emergência com sensores, alertas e localização de dispositivos.

 Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core
- PostgreSQL
- Swagger
- Docker (opcional)
- Razor Pages (em outra etapa)
- TagHelpers

 Estrutura de Pastas

```
EmergenciaAPI/
├── Controllers/         # Endpoints REST
├── Models/              # Entidades (Usuario, Dispositivo, Alerta, etc.)
├── DTOs/                # Data Transfer Objects
├── Data/                # AppDbContext e configuração
├── Migrations/          # Migrations geradas com EF Core
├── Program.cs           # Startup da aplicação
├── appsettings.json     # Configurações (string de conexão)
```

 Funcionalidades

- Cadastro de usuários e dispositivos
- Geração e consulta de alertas com tipo, mensagem e prioridade
- Registro de localização (latitude, longitude, data/hora)
- Relacionamentos entre entidades (ex: Usuário 1:N Dispositivos)
- Documentação com Swagger UI


 Como Executar Localmente

1. Clone o repositório:

```bash
git clone https://github.com/Guusthy/EmergenciaAPI.git
cd EmergenciaAPI
```

2. Configure a string de conexão em `appsettings.json:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=EmergenciaDB;Username=postgres;Password=123456"
}
```

3. Aplique as Migrations:

```bash
dotnet ef database update
```

4. Execute a aplicação:

```bash
dotnet run --project EmergenciaAPI
```


 Entidades do Sistema

- Usuario: Nome, Email, etc.
- Dispositivo: Id do dispositivo, relacionado ao usuário
- Alerta: Tipo, Mensagem, DataHora, DispositivoId
- Localizacao: Latitude, Longitude, DataHora, DispositivoId


 Requisitos Atendidos

- [x] API REST com boas práticas
- [x] Persistência com PostgreSQL
- [x] Relacionamentos 1:N
- [x] Documentação Swagger
- [x] Migrations aplicadas



 Licença

MIT. Livre para uso acadêmico.
