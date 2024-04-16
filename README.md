<H1 align="center">Json Web Api</H1>
<p align="center">🚀 Project to create a Json Web Api framework for future references</p>



<div align="center">
<img src="https://github.com/lucasmargui/ASP_JSON_WEB_API/assets/157809964/a615c14f-4526-4c88-8df5-d2c36601efb4" style="width:70%">
</div>

## Controller

<details>
   <summary>Click to show content</summary>
  
### ClienteController

```
Controller/ClienteController.cs
```

Responsible for returning the data requested through the Json request

```
Customer[] customers = new Customer[]
{
new Cliente() { ID = 1, Name = "Guinther", EMail = "guintherpauli@gmail.com" },
new Cliente() { ID = 2, Name = "Rudolfo", EMail = "rudolfo@teste.com" },
new Cliente() { ID = 3, Name = "Wesley", EMail = "Wesley@teste.com" }
};

  public IEnumerable<Customer> getCustomers()
         {
             return customers;
         }
```

</details>




## Index

<details>
   <summary>Click to show content</summary>

### Customer List
```
ListingCustomers.html
```

Path referring to ControllerCliente.cs where the data request will be made
```
var uri = 'api/Client';
```


When the document is loaded, it will trigger the getJSON function, where it will receive the data in data and loop through each data adding it to the table
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

