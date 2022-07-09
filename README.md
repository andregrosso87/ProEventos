# Comandos Dotnet
1- Dotnet --version = Mostra a versão usada;
2- dotnet -h = Relação de tudo o que pode fazer com o dotnet;
3- dotnet --info = Mostra todas as versoes instaladas e tudo relacionada ;
4- dotnet --list-sdks = Mostra todas as versoes instaladas.

Global.json = cria o arquivo da versão do dotnet que voce irá usar.
dotnet new globaljson --sdk-version 5.0.408 --force = cria automaticamente

dotnet new webapi -n ProEventos.API = cria um projeto e o -n é o nome que voce quer colocar

Entra na pasta do projeto criado e dá um dotnet run.

dotnet run = roda o projeto;

dotnet watch run = roda o projeto e restarta qualquer alteração automaticamente;

dotnet tool list --global - Mostra quais ferramentas estão instaladas;

dotnet ef migrations add inicial -o Data/Migrations - Adiciona uma migrations ao Banco de Dados

Controler vai se basear na rota que vai retornar o endpoint que vai ser usado.

# HTTP

## Exemplos de Request (quando o usuario faz uma requisição para o servidor)
Verbos - Post
Header - Content length: 9
Content - Ola Mundo

## Exemplos de Response ( quando o servidor responde o usuario)

Status code - 201
Header - Content Type: Text
Content - Ola Mundo
## Request

### verbos
Ações a serem execultadas no Servidor:
* Get: Requisitar recursos;
* Post: Criar recursos;
* Put: Atualizar recursos;
* Patch: Atualizar recursos parcial;
* Delete: Deletar recursos:

e mais!

### Headers
Metadados sobre a Requisição
* Content Type: Formato do conteudo;
* Content Length: Tamanho do Conteudo;
* Authorization: Quem faz a chamada;
* Accept: Quais tipos são aceitaveis;
* Cookies: Passagens de dados por requisição;

e mais!

### Content
Conteúdo referente à Requisição
* HTML, CSS, JS, XML, JSON...
* Informações para ajudar a entender a requisição;
* Onde passar tipos Binarios e Blobs comuns;

## Response

### StatusCode
Situação de Operação
* 100-199: Informação;
* 200-299: Sucesso;
* 300-399: Redirecionamento;
* 400-499: Erro do Cliente:
* 500-599: Erro do Servidor;

### Headers
Metadados sobre a Resposta
* Content Type: Formato do conteudo;
* Content Length: Tamanho do Conteudo;
* Expires: Quando considerar obsoleto;
* Accept: Quais tipos são aceitaveis;
* Cookies: Passagens de dados pela resposta;

### Content
Conteúdo referente à Resposta
* HTML, CSS, JS, XML, JSON...
* Onde passar tipos Binarios e Blobs comuns;
* API´s frequentemente tem seus proprios tipos (JSON são os mais comuns)

## JSON

* Formato mais leve;

## EntityFramework core 5.0.2
 
Abre a extenção NuGet Gallery e instala o EntityFramework, EntityFramework Tools, EntityFramework Design, EntityFramework Sqlite 

dotnet ef migrations add inicial -o Data/Migrations