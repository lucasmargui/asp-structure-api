<H1 align="center">JSON WEB API</H1>
<p align="center">🚀 Projeto de criação de uma estrutura de Json Web Api para referências futuras</p>

## Controller

<details>
  <summary>Clique para mostrar conteúdo</summary>
  
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

</details>




## Index

<details>
  <summary>Clique para mostrar conteúdo</summary>

### Lista Clientes
```
ListagemClientes.html
```

Caminho referente á ControllerCliente.cs onde fará a requisição dos dados
```
var uri = 'api/Cliente';
```


Quando o documento estiver carregado acionará a função getJSON, onde receberá os dados em data e fará um looping passando por cada dado adicionando na tabela
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


</details>



## Resultado


<div align="center">
<img src="https://github.com/lucasmargui/ASP_JSON_WEB_API/assets/157809964/a615c14f-4526-4c88-8df5-d2c36601efb4" style="width:90%">
</div>



