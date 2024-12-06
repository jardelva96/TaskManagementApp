# TaskManagementApp

### Aplicação de Gestão de Tarefas com ASP.NET Core

---

## 📝 Descrição
O **TaskManagementApp** é uma aplicação web desenvolvida em **ASP.NET Core MVC**, com suporte a Razor Pages e uma API RESTful para o gerenciamento de tarefas. Ele permite criar, editar, excluir e visualizar tarefas de forma eficiente. A aplicação é acompanhada de funcionalidades dinâmicas no frontend, como a utilização do **DataTables** para exibição e manipulação das tarefas.

---

## ⚙️ Funcionalidades Implementadas

### API RESTful:
- **GET /api/tasks**: Retorna todas as tarefas com suporte a filtros.
- **POST /api/tasks**: Cria uma nova tarefa.
- **PUT /api/tasks/{id}**: Atualiza uma tarefa existente.
- **DELETE /api/tasks/{id}**: Exclui uma tarefa.

### Frontend:
- **DataTables**: Exibição de tarefas com paginação, ordenação e busca dinâmica.
- **Modais Dinâmicos**: Adição e edição de tarefas por meio de modais com carregamento via AJAX.
- **Validação Dinâmica**: Feedback para o usuário sobre erros no formulário.
- **Exportação para CSV**: Exportação das tarefas exibidas na tabela.

### Backend:
- **Logs**: Registro das operações de criação, edição e exclusão no backend.
- **Validação no Servidor**: Garantia de dados consistentes.
- **Persistência de Dados**: Integração com banco de dados **SQL Server** via **Entity Framework Core**.

---

## 🚀 Como Configurar e Executar o Projeto

### Pré-requisitos
- **.NET 6 ou superior**
- **SQL Server** (local ou remoto)
- **Node.js** (para gerenciar pacotes JS, como o DataTables)

### Configuração do Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/jardelva96/TaskManagementApp.git
   cd TaskManagementApp
Configure o Banco de Dados:

Abra o arquivo appsettings.json e edite a string de conexão:
"ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=TaskManagementDb;Trusted_Connection=True;"
}
Aplique as Migrações:
dotnet ef database update

Execute o Projeto:
dotnet run

Acesse a aplicação no navegador:
http://localhost:5000
🛠️ Tecnologias Utilizadas
ASP.NET Core MVC
Entity Framework Core (migrations e persistência)
SQL Server (armazenamento de dados)
JavaScript e jQuery
DataTables (frontend dinâmico)
Bootstrap 5 (estilização)
📂 Estrutura do Projeto
Controllers: Lógica para gerenciamento das tarefas.
Views: Renderização do frontend com suporte ao DataTables.
Services: Camada para encapsular a lógica de negócios e comunicação com o banco de dados.
Models: Definição das entidades do sistema.
Migrations: Configurações de versão do banco de dados.
🔗 Link da Aplicação (opcional)
A aplicação pode ser acessada localmente em: http://localhost:5000

📜 Licença
Este projeto é licenciado sob a MIT License.

👨‍💻 Autor
Desenvolvido por Jardelva96.

### Como Usar
- Salve este conteúdo em um arquivo chamado `README.md` no diretório principal do seu projeto.
- Certifique-se de incluir as instruções detalhadas sobre a configuração do banco de dados e as dependências necessárias. 
- Depois, execute os comandos do Git para garantir que o arquivo seja enviado ao repositório:
  ```bash
  git add README.md
  git commit -m "Adicionado README.md"
  git push origin main
