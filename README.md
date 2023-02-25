Abra o Visual Studio 2022 e selecione "Criar um novo projeto".
Selecione ".NET" no menu à esquerda e, em seguida, "ASP.NET Core Web Application" no menu central.
Selecione "API" na tela de seleção de tipo de projeto e clique em "Avançar".
Insira um nome para o projeto e escolha um diretório para salvá-lo.
Selecione ".NET 6.0" como versão do framework e clique em "Criar".
Selecione o esquema de autenticação a ser utilizado (opcional) e clique em "Criar".
Espere alguns instantes enquanto o Visual Studio cria a estrutura básica do projeto

Nesse código, estamos definindo um controller com a rota "api/produtos" e injetando a dependência do repositório de produtos. As ações disponíveis são:

"GetAll": retorna todos os produtos da loja.
"GetById": retorna um produto específico pelo seu ID.
"Add": adiciona um novo produto à loja.
"Update": atualiza um produto existente pelo seu ID.
"Delete": remove um produto existente pelo seu ID.
Essas ações são executadas ao receber as requisições HTTP correspondentes, que são mapeadas através dos atributos 
[HttpGet], [HttpPost], [HttpPut] e [HttpDelete] no código acima.

Agora, a API está pronta para ser executada e testada. 
Para executá-la, Depois, você pode testar as rotas usando ferramentas como o Postman ou o Insomnia.
