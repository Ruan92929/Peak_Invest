```markdown
# PeakInvest

Este repositório contém duas aplicações: um backend desenvolvido com Azure Functions em .NET e um frontend desenvolvido com Angular.

## Requisitos

- [Node.js](https://nodejs.org/) (para rodar o frontend)
- [Angular CLI](https://angular.io/cli)
- [Azure Functions Core Tools](https://learn.microsoft.com/en-us/azure/azure-functions/functions-run-local) (para rodar o backend)
- .NET SDK (para compilar e rodar a Azure Function)

## Como rodar o Frontend (Angular)

1. Navegue até a pasta do frontend:

   ```sh
   cd PeakInvestFrontend
   ```

2. Instale as dependências:

   ```sh
   npm install
   ```

3. Inicie o servidor de desenvolvimento:

   ```sh
   ng serve
   ```

4. Acesse a aplicação no navegador: `http://localhost:4200/`

## Como rodar o Backend (Azure Functions)

1. Navegue até a pasta do backend:

   ```sh
   cd PeakInvestBackend
   ```

2. Inicie a Azure Function localmente:

   ```sh
   func start
   ```

3. As funções estarão disponíveis em `http://localhost:7071/`

