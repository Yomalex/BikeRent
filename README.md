# BikeRent

```
## Context
A company rents bikes under following options:
1. Rental by hour, charging $5 per hour
2. Rental by day, charging $20 a day
3. Rental by week, changing $60 a week
4. Family Rental, is a promotion that can include from 3 to 5 Rentals (of any type) with a discount of 30% of the total price

## Assigment:
1. Implement a set of classes to model this domain and logic
2. Add automated tests to ensure a coverage over 85%
3. Use GitHub to store and version your code
4. Apply all the recommended practices you would use in a real project
5. Add a README.md file to the root of your repository to explain: your design, the development
practices you applied and how run the tests.
Note: we don't expect any kind of application, just a set of classes with its automated tests.
```

Debido a que el contexto da solo indicaciones de como es el funcionamiento de la compañia mas no de las necesidades del cliente se asumen ciertas caracteristicas del desarrollo como tales que lo que se debe desarrollar es un sistema de administracion para el alquiler

La clase 'Bill' se encarga de la agrupacion de las rentas individuales representadas por la clase 'Rent', 'Bill' tambien se encarga de la aplicacion de la promocion 'Family Rental'.

Por motivos de indole fiscal se asume que es de caracter minimo y obligatorio suministrar 'Nombre', 'Dirección' y 'Número de contacto', de igual forma al rentar el operador debe indicar una identificación del vehículo por motivos de seguridad.

## La clase bill posee la siguente estructura:

### Constructor:
**Bill(string name, string dir, string phone)**: requiere 3 argumentos obligatorios no null, no blank y no whitespaced

### Methods:
* **int Add(float amount, string desc, RentType type)**: Amount es la cantidad de horas/dias/semanas, desc esta relacionado al vehiculo y type es el modo de renta hora/dia/semana
**Return value**: devuelve la cantidad de elementos en lista.
* **void Remove(int Index)**: index >= 1 y ademas debe ser menor o igual a la cantidad de elementos agregados a bill. Remueve el elemento en esa posicion.
**Return value**: void. 

### Properties:
* **float SubTotal** *(read-only)*: retorna el total parcial de la factura.
* **float Discount** *(read-only)*: retorna la cantidad total descontada al cliente.
* **flota Total** *(read-only)*: retorna la cantidad neta a pagar por el cliente.
* **string Name** *(read-only)*: retorna a nombre de quien se encuentra la factura.
* **string Address** *(read-only)*: retorna la direccion proporcionada por el cliente.
* **string Contact** *(read-only)*: retorna el número de contacto proprocionado.

## La clase 'Rent' posee la siguente structura:

### Constructor:
**Rent(float amount, string desc, RentType type)**: amount debe ser > 0, desc debe ser != null

### Properties:
* **string Description** *(read-only)*: Descripcion del vehiculo.
* **RentType mode** *(read-only)*: Como esta siendo rentado.
* **float Amount** *(read-only)*: Cantidad de renta.
* **float SubTotal** *(read-only)*: Costo.

## Clase RentConst
Constantes utilizadas por las clases Rent y Bill, como son los porcentajes de Family Rent, tambien los costos de los modos de renta. 


# Runing Tests
* Se han generado pruebas automatizadas de codigo para cada uno de los casos planteados en la descripcion anterior, Pruebas de validacion e invalidacion de funciones para evitar errores humanos
* La prueba se ejecuta desde el administrador de pruebas del Visual Studio.
* El codigo esta elaborado con Visual Studio 2017 Community lo cual no me brinda accesso a covertura de codigo, aun asi cosidero que la covertura esta dentro de lo requerido.