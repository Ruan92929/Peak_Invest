PeakInvest

Este repositório contém duas aplicações: um backend desenvolvido com Azure Functions em .NET e um frontend desenvolvido com Angular.

Requisitos

Node.js (para rodar o frontend)

Angular CLI

Azure Functions Core Tools (para rodar o backend)

.NET SDK (para compilar e rodar a Azure Function)

Como rodar o Frontend (Angular)

Navegue até a pasta do frontend:

cd PeakInvestFrontend

Instale as dependências:

npm install

Inicie o servidor de desenvolvimento:

ng serve

Acesse a aplicação no navegador: http://localhost:4200/

Como rodar o Backend (Azure Functions)

Navegue até a pasta do backend:

cd PeakInvestBackend

Inicie a Azure Function localmente:

func start

As funções estarão disponíveis em http://localhost:7071/
