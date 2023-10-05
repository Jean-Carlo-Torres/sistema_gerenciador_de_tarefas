# Sistema de Gerenciamento de Tarefas com Entity Framework

<p>Sistema gerenciador de tarefas, onde permite cadastrar uma lista de tarefas. Utilizando o método CRUD que permite obter os registros, criar, salvar e deletar esses registros. Com integração ao banco de dados do MySQL.

## Diagrama da classe principal

<img src="Imagens/diagrama.png">

## Métodos do sistema

**Swagger**

<img src="Imagens/swagger.png">

</br>

**Endpoints**


| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

Esse é o schema (model) de Tarefa, utilizado para passar para os métodos que exigirem

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```

## Tópicos abordados durante esse projeto:
* Entity Framework
* CRUDs.
* Integração ao Banco de dados



## Tecnologias utilizadas no projeto
* .NET
* C#
* MySQL

<hr>
</br>

[![Linkedin Badge](https://img.shields.io/badge/-JeanCarlo-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/jeancarlotorre619b/)](https://www.linkedin.com/in/jeancarlotorre619b/)

<h3>Contribuindo</h3>

⭐️ Star o projeto

🐛 Encontrar e relatar issues