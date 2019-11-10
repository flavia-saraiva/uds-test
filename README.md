**UDS-TEST**

Esta aplicação foi desenvolvida de acordo com os requisitos propostos no teste.

Abaixo são apresentados os comandos para execução desta aplicação:

**1-2) Montar/Personalizar pizza**

POST /api/Pizzas

Body:
{

  "flavor": {flavor_index},
  
  "size": {size_index},
  
  "extras" {extra_index}
  
}


Sendo:

**{flavor_index}**:

1 - Calabresa

2 - Marguerita

3 - Portuguesa

**{size_index}**:

1 - Small

2 - Medium

3 - Large

**{extra_index}**:

1 - bacon

2 - no_onion

3 - stuffed_crust

**3) Montar pedido**

**Tamanho:** GET /api/Pizzas/Size/{id}

**Sabor:** GET /api/Pizzas/Flavor/{id}

**Personalizações:** GET /api/Pizzas/Extras/{id}

**Valor Total:** GET /api/Pizzas/TotalPrice/{id}

**Tempo de preparo:** GET /api/Pizzas/PreparationTime/{id}

Sendo:

**{id}**: id da pizza inserida
