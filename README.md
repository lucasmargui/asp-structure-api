<H1 align="center">JSON WEB API</H1>
<p align="center">🚀 Projeto de criação de uma estrutura de Json Web Api para referências futuras</p>

## Controller

### ClienteController 

```
Controller/ClienteController.cs
```

Responsável por retornar os dados solicitados através da requisição pelo Json

```
Cliente[] clientes = new Cliente[]
{
new Cliente() { ID = 1, Nome = "Guinther", EMail = "guintherpauli@gmail.com" },
new Cliente() { ID = 2, Nome = "Rudolfo", EMail = "rudolfo@teste.com" },
new Cliente() { ID = 3, Nome = "Wesley", EMail = "Wesley@teste.com" }
};

 public IEnumerable<Cliente> getClientes()
        {
            return clientes;
        }
```

## Index

### Lista Clientes
```
ListagemClientes.html
```

Caminho referente á ControllerCliente.cs onde fará a requisição dos dados
```
var uri = 'api/Cliente';
```


Quando o documento estiver carregado acionará a função getJSON, onde receberá os dados em data e fará um looping passando por cada dado e adicionando na tabela
```
$(document).ready(function () {
			$.getJSON(uri)
				.done(function (data) {
					$.each(data, function (key, item) {
						$('<li>', { text: formatar(item) }).appendTo($('#clientes'));
					});
				});
		});

```

## Resultado

<img src="https://cdn.discordapp.com/attachments/1046824853015113789/1205199668808646676/image.png?ex=65d780a8&is=65c50ba8&hm=70894506ee4435c219e36d06b5b0c6aadb5f23a9e2a5f23ef5c4a3a07094cdb6&" alt="">

