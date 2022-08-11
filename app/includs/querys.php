<?php

$nameQuery = $conn->query("SELECT nombre1 FROM clientes WHERE idCliente = 1;");
$name = $nameQuery->fetch_array();

$lastNameQuery = $conn->query("SELECT apellido1 FROM clientes WHERE idCliente = 1;");
$lastName = $lastNameQuery->fetch_array();

// query consultado productos

$resultadoProductos = $conn->query("SELECT * FROM productos;");

// query consultado clientes

$resultadoClientes = $conn->query("SELECT idCliente, nombre1, mail, celular FROM clientes;");

// query consultado compras

$resultadoCompras = $conn->query("SELECT compras.idCompra,clientes.nombre1,clientes.apellido1,cursos.descripcionDelProducto FROM compras JOIN clientes on compras.idCliente = clientes.idCliente JOIN productos on compras.iProducto = productos.idproducto;");
?>
