<h1>Criar um CRUD de pessoa</h1>

* crie um novo projeto mvc com o nome **crud_people**

<h2> Model</h2>

- <h3>Aula01 - Model Person e Repositório</h3>

    - criar o model Person.cs com id e nome e construtor
    - criar o repositorio PersonRepository com os métodos de crud: *Create, Delete, Update, GetById, GetAll
    - criar uma public static list para "simular o db de people". Importar o System.Collections.Generic;
    - implementar **GetAll()* return people;
    - Criar um método fill para preencher inicialmente a lista com dados fixos

- <h3>Aula02 - Model Person e Repositório (crud)</h3>

    - Criar o método Create(Person person) e adicionar na lista people;
    - Criar o método GetById(int id) buscando um objeto na lista people;
    - Criar o método Delete(int id) buscando o objeto na lista people e passando isso ao método Remove() da lista People;
    - Criar o método Update(Person person) deletando o objeto anterior e inserindo o novo na lista people;

<br><br>

---

<h2>Controller</h2>

- <h3>Aula01 - index</h3>

    - instalar o plugin asp.net snippets
    - crie uma nova classe com o nome PersonController e digite HomeController
    - instanciar o repositorio de Person
    - implementar o GetAll para a Action Index
    - passar para a view a lista people

- <h3>Aula02 - Create e Edit</h3>

    - Criar o método do tipo IActionResult com o nome de Create();
    - o return View() fica igual;
    - criar o método do tipo IActionResult com o nome de Create do tipo do objeto Person, mas com a assinatura [HttpPost];
        - [HttpPost] Create(Person person)
    - teste a aplicação
    - Criar o método do tipo IActionResult com o nome de Edit(int id) e parametro id da pessoa;
    - chame o método GetById passando o argumento id que veio da view;
    - o return View() deve passar o objeto person que foi buscado no GetById; Ex. Return View(person);
    - criar o método do tipo IActionResult com o nome de Edit do tipo do objeto Person, mas com a assinatura [HttpPost];
        - [HttpPost] Edit(Person person);
    - chamar o método update do repostório passando o novo objeto;
    - teste a aplicação

<br><br>

---

<h2>View</h2>

- <h3>Aula01 - index</h3>

    - criar uma pasta Person (a pasta deve ter o mesmo nome do controller, e para cada Action, uma cshtml);
    - Criar a *Index.cshtml*
    - Tipar a view com IEnumerable<Person>: 
        > @model IEnumerable<crud_w_mvc_ram.Models.Person>
    - Desenvolver uma tabela para mostrar a lista de Person
    - utilizar foreach para percorrer a lista people e mostrar os dados.

- <h3>Aula02 create e edit</h3>

    - criar formulário com o nome Create.cshtml;
    - Tipar a view com Person: 
        > @model crud_w_mvc_ram.Models.Person

    - fazer o formulário html conforme campos necessários (id, name, adress);
    - o form deve apontar para o Create com o metodo de envio POST;
    - não esqueça o botão do submit. 
    - utilize as classes form-horizontal, form-group e form-control para estilizar o seu formulário :)
    - criar formulário com o nome Edit.cshtml;
    - tipar a view com Person: 
        > @model crud_w_mvc_ram.Models.Person

    - fazer o formulário html conforme campos necessários (id, name, adress);
    - o form deve apontar para o Edit com o metodo de envio POST;
    - cada input deve ter a propriedade value="@Model.nome_do_campo_no_model" ex. value="@Model.name";
    - não esqueça o botão do submit;
    - utilize as classes form-horizontal, form-group e form-control para estilizar o seu formulário :)

<h3>bibliografia</h3>

- [Documentação sobre VIEWS E RAZOR](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/razor)
- [Documentação sobre CONTROLLERS](https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/actions)
- [Documentação sobre MODELS](https://docs.microsoft.com/pt-br/aspnet/core/mvc/models)
