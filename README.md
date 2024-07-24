## DevFreela is a manager of projects, freelancers and owners.

### 1. About the project

DevFreela API is a project developed as part of training. The project aims to manage projects, freelancers and owners. Users can be freelancers or owners of projects (clients). Clients can post a project containing details such as title, description and value that it will pay. On the other hand, freelancers can find these projects, send a message to the client, and if their skills are compatible with what the owner is looking for. When the freelancer and owner agree with the conditions then the project starts.

### 2. Functionalities

- Users Login and register them.
- CRUD projects
- Adding Project's comment

### 3. Technologies used

- .NET 6
- Entity Framework Core
- SQL Server
- Dapper
- Authentication e Authorization with JWT Bearer

### 4. Architecture and patterns applied

- Clean Architecture
- CQRS
- Repository
- Fluent Validation

### 5. How do you get started?

**5.1. Prerequisites\*\***

- .NET 6
- Visual Studio Community 2022 or VS Code
- SQL Server Management Studio 20
- Entity Framework Core installed

**5.2. Running**

- Downloading this repository using git
  - git clone https://github.com/ThiagoBoccalon/DevFreela.git
- Open project/solution on Visual Studio
- Make sure SQL Server is opened
- Applying migrations - `cd DevFreela\DevFreela.Infrastructure>` - `DevFreela\DevFreela.Infrastructure>dotnet ef database update -s ../DevFreela.API/DevFreela.API.csproj`
- F5 for running

### 6. Sreem shoots

To do
