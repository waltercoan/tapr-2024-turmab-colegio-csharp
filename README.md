# tapr-2024-turmab-colegio-csharp

## Documentação do projeto
[Diagramas](https://univillebr-my.sharepoint.com/:u:/g/personal/walter_s_univille_br/EWtm7BQwjlJJgXsTxgdj9UIB6YYhdA9x5ufNfKxCAtlKVg?e=cl21Nh)

## Extensões do VSCode
[C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit?wt.mc_id=AZ-MVP-5003638)

[C# Extension](https://marketplace.visualstudio.com/items?itemName=kreativ-software.csharpextensions?wt.mc_id=AZ-MVP-5003638)

[Rest Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client?wt.mc_id=AZ-MVP-5003638)

## Criação do projeto
```
dotnet net webapi -o microserv<nome do seu subdominio>
dotnet dev-certs https --trust
```
1. Criar um namespace com o nome de cada Bounded Context
2. Criar um namespace chamado Entities e dentro dele criar as entidades
```
├── Secretaria
│   └── Entities
│       └── Aluno.cs
```

## Cosmos DB
[Introdução (https://learn.microsoft.com/en-us/azure/cosmos-db/introduction?wt.mc_id=AZ-MVP-5003638)](https://learn.microsoft.com/en-us/azure/cosmos-db/introduction?wt.mc_id=AZ-MVP-5003638)

[Databases, Containers e Itens (https://learn.microsoft.com/en-us/azure/cosmos-db/resource-model?wt.mc_id=AZ-MVP-5003638)](https://learn.microsoft.com/en-us/azure/cosmos-db/resource-model?wt.mc_id=AZ-MVP-5003638)