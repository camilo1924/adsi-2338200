Proceso sin_titulo 
	//Hacer un algoritmo que lea el nombre de un artículo, el valor unitario, la cantidad a comprar y muestre
	//el nombre y el total a pagar.
	//Proceso 
	Definir articulo como cadena;
	Definir valor_uni Como Entero;
	Definir cantidad Como Entero;
	Definir total_pagar Como Entero;
	//Proceso 
	Escribir "ingrese nombre del articulo" ;
	Leer articulo;
	Escribir "ingrese el costo del articulo" ;
	Leer valor_uni;
	Escribir "ingrese la cantidad de la compra" ;
	Leer cantidad;
	
	//proseso
	total_pagar = (valor_uni * cantidad);
	
	//salida
	Escribir "articulo:", articulo;
	Escribir "total a pagar:", total_pagar;
FinProceso
