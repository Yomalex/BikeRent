# BikeRent

```
## Context
A company rents bikes under following options:
1. Rental by hour, charging $5 per hour
2. Rental by day, charging $20 a day
3. Rental by week, changing $60 a week
4. Family Rental, is a promotion that can include from 3 to 5 Rentals (of any type) with a discount of 30% of the total price
```

Debido a que el contexto da solo indicaciones de como es el funcionamiento de la compañia mas no de las necesidades del cliente se asumen ciertas caracteristicas del desarrollo como tales que lo que se debe desarrollar es un sistema de administracion para el alquiler
La clase 'Bill' se encarga de la agrupacion de las rentas individuales representadas por la clase 'Rent', 'Bill' tambien se encarga de la aplicacion de la promocion 'Family Rental'.
Por motivos de indole fiscal se asume que es de caracter minimo y obligatorio suministrar 'Nombre', 'Dirección' y 'Número de contacto', de igual forma al rentar el operador debe indicar una identificación del vehículo por motivos de seguridad.

Para tener un respaldo de los alquileres, a quien se realizaron y en que momento se propone la realizacion de una base de datos estructurada de la siguiente forma.
Pensada para tener un control de las Bikes, a quien fueron rentadas, quien fue el encargado y por cuanto tiempo. 
BikeRental.dbo

Bikes
ID (Primary Key)
plate 
mark
model
color
year
free

Bills
ID (Primary Key)
Cashier [Users.ID]
Client [Clients.ID]
Date
SubTotal
Discount
Iva
Total

Rents
ID (Primary Key)
Bill [Bills.ID]
Bike [Bikes.ID]
amount
type
date

Clients
ID (Primary Key)
DNI
Name
Last_Name
Address
Phone
Date

Users
ID
DNI
Name
Last_Name
Address
Phone
Data


## Runing Tests
