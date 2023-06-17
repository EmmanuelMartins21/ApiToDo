# ApiToDo

API REST em desenvolvimento utilizando .NET que gerencia uma lista de tarefas. A mesma ainda não possui mecanismo de autenticação mas,
possui persistência em um banco de dados MySQL.

## A CONSTRUÇÃO
- A API e possui 6 operações:
  1) Registrar tarefa: Recebe os dados da tarefa e registra com status "Não concluida";
  2) Buscar todas as tarefas;
  3) Buscar tarefa: Busca pelo Id da tarefa;
  4) Atualizar a tarefa pelo Id;
  5) Atualizar todas as tarefas;
  6) Excluir uma tarefa pelo ID;

## ENDPOINTS 
- [HttpPost] </br>
     Request URL = `https://localhost:7205/controller/task`
Grava um JSON da venda no formato: </br>
    ```
    {
      "id": 0,
      "tituloTarefa": "string",
      "conteudoTarefa": "string",
      "dataCriacao": "2023-05-29T23:32:42.220Z",
      "concluido": true,
      "nivelUrgencia": "string"
    }
    ```
- [HttpGet] </br>
   Retorna todas as tarefas registradas. Request URL = `https://localhost:7205/controller/task` </br>

- [HttpGet("{id}")] </br>
   Necessita apenas do ID da venda que deseja consultar. Request URL = `https://localhost:7205/controller/task/idTarefa` </br>
 

## TECNOLOGIAS ENVOLVIDAS
- C#.NET
- API REST 
- MySQL

## CONTATOS
[![Linkedin Badge](https://img.shields.io/badge/-LinkedIn-0072b1?style=for-the-badge&logo=Linkedin&logoColor=white)](https://www.linkedin.com/in/emmanuel-cosme-martins-bento-3963bb1b9/ 'Contato pelo LinkedIn')
[![Gmail Badge](https://img.shields.io/badge/-gmail-c14438?style=for-the-badge&logo=Gmail&logoColor=white)](mailto:emmanuelbento6@gmail.com 'Contato via Email')