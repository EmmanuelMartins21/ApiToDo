# ApiToDo

API REST em desenvolvimento utilizando .NET que gerencia uma lista de tarefas. A mesma ainda não possui mecanismo de autenticação mas,
possui persistência em um banco de dados MySQL.

## A CONSTRUÇÃO
- A API e possui 5 operações:
  1) Registrar tarefa: Recebe os dados da tarefa e registra com status "Não concluida";
  2) Buscar todas as tarefas;
  3) Buscar tarefa: Busca pelo Id da tarefa;
  4) Atualizar a tarefa pelo Id;
  5) Atualizar todas as tarefas;
  
## ENDPOINTS 
- [HttpPost] </br>
     Request URL = `https://localhost:7205/Tarefa`
Grava um JSON da venda no formato: </br>
    ```
    {
      "idTarefa": 0,
      "tituloTarefa": "string",
      "conteudoTarefa": "string",
      "concluido": true
    }
    ```
- [HttpGet] </br>
   Retorna todas as tarefas registradas. Request URL = `https://localhost:7205/Tarefa` </br>

- [HttpGet("{id}")] </br>
   Necessita apenas do ID da venda que deseja consultar. Request URL = `'https://localhost:7205/Tarefa/idTarefa` </br>
 

## TECNOLOGIAS ENVOLVIDAS
- C#.NET
- API REST 
- MySQL

## CONTATOS
[![Linkedin Badge](https://img.shields.io/badge/-LinkedIn-0072b1?style=for-the-badge&logo=Linkedin&logoColor=white)](https://www.linkedin.com/in/emmanuel-cosme-martins-bento-3963bb1b9/ 'Contato pelo LinkedIn')
[![Gmail Badge](https://img.shields.io/badge/-gmail-c14438?style=for-the-badge&logo=Gmail&logoColor=white)](mailto:emmanuelbento6@gmail.com 'Contato via Email')