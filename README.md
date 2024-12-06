# Task Management App

Este é um projeto de gerenciamento de tarefas (Task Management App) desenvolvido com ASP.NET Core. O objetivo é fornecer uma plataforma simples e eficiente para a gestão de tarefas, permitindo a criação, visualização e exclusão de tarefas.

## Tecnologias Utilizadas
- **ASP.NET Core**: Framework para desenvolvimento de aplicações web.
- **Entity Framework Core**: ORM para interagir com o banco de dados.
- **SQL Server** (ou outro banco de dados configurado): Banco de dados relacional.

### Passos para Execução

## 🚀 Como Configurar e Executar o Projeto

### Pré-requisitos

1. **Instale o .NET SDK 6.0 ou superior**: [Baixar aqui](https://dotnet.microsoft.com/download).
2. **Instale o SQL Server**: Configure um banco de dados local ou remoto.
3. **Git**: Para clonar o repositório.

### Passos para Configurar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/TaskManagementApp.git
   cd TaskManagementApp


Atualize o banco de dados: Utilize o Entity Framework para aplicar as migrações ao banco de dados:
dotnet ef database update

Compile o projeto:
dotnet build

Execute a aplicação:
dotnet run

Acesse a aplicação:
Interface Web: http://localhost:5216/Tasks

🛠 Funcionalidades Implementadas

CRUD de Tarefas:
Criar, editar, excluir e listar tarefas.

Integração com Banco de Dados:
Uso do SQL Server para persistência de dados.

Validações:
Validação no backend usando Data Annotations.

Interface Amigável:
Tabela com suporte a paginação, busca e ordenação usando DataTables.

Exportação para CSV:
Exportação de tarefas para arquivo CSV diretamente da interface.

Modais Dinâmicos:
Criação e edição de tarefas utilizando modais carregados via AJAX.

Documentação da API:
Endpoints documentados com Swagger.

📂 Estrutura do Projeto
- Controllers: Gerencia as requisições e respostas do backend.
- Models: Contém as classes que representam as entidades do sistema.
- Views: Páginas renderizadas dinamicamente usando Razor.
- Data: Configuração do banco de dados e migrações.
- wwwroot: Arquivos estáticos, como CSS e JS.

📋 Endpoints da API
- GET /api/tasks: Retorna todas as tarefas.
- POST /api/tasks: Cria uma nova tarefa.
- PUT /api/tasks/{id}: Atualiza uma tarefa existente.
- DELETE /api/tasks/{id}: Exclui uma tarefa.

🌟 Contribuições
Contribuições são bem-vindas! Para contribuir:

Faça um fork do repositório.
Crie uma nova branch:
git checkout -b minha-feature

Faça suas alterações e commit:
git commit -m "Descrição da alteração"

Suba a branch:
git push origin minha-feature
Abra um Pull Request.

🔗 Links Importantes
Repositório no GitHub: https://github.com/seu-usuario/TaskManagementApp
Aplicação Web: http://localhost:5216/Tasks

## 📁 Estrutura do Projeto

```plaintext
TaskManagementApp/                     # Pasta principal do projeto
├── Controllers/                       # Controladores para gerenciamento da lógica
│   ├── TasksController.cs             # Controlador para o frontend (Razor Pages)
│   ├── TasksApiController.cs          # Controlador para a API RESTful
│
├── Data/                              # Configurações relacionadas ao banco de dados
│   ├── ApplicationDbContext.cs        # Contexto do banco de dados do Entity Framework Core
│
├── Models/                            # Modelos de dados
│   ├── TaskItem.cs                    # Modelo de entidade para tarefas
│
├── Services/                          # Camada de serviço para lógica de negócios
│   ├── ITaskService.cs                # Interface do serviço de tarefas
│   ├── TaskService.cs                 # Implementação do serviço de tarefas
│
├── Views/                             # Views para o frontend (Razor Pages)
│   ├── Tasks/
│   │   ├── Index.cshtml               # Página principal com a lista de tarefas
│   │   ├── Create.cshtml              # Página para criação de novas tarefas
│   │   ├── Edit.cshtml                # Página para edição de tarefas
│   │   ├── Delete.cshtml              # Página para confirmação de exclusão de tarefas
│   │
│   ├── Shared/                        # Componentes de views compartilhados
│       ├── _Layout.cshtml             # Layout principal compartilhado
│       ├── _ValidationScriptsPartial.cshtml  # Scripts de validação para Razor Pages
│
├── wwwroot/                           # Arquivos estáticos do projeto
│   ├── css/                           # Arquivos de estilo (CSS)
│   ├── js/                            # Arquivos JavaScript
│   ├── lib/                           # Bibliotecas externas (Bootstrap, DataTables, etc.)
│
├── appsettings.json                   # Configurações gerais do projeto
├── Program.cs                         # Ponto de entrada da aplicação ASP.NET Core
├── launchSettings.json                # Configurações de execução (portas e ambiente)
├── TaskManagementApp.csproj           # Arquivo de configuração do projeto
├── README.md                          # Documentação do projeto



