# newshore-project
Prueba tecnica NewShore, Pagina de busqueda y reserva de vuelos.

## Arquitectura oriantada a servicios
Se plantea la solución del problema con una arquitectura dividida en 4 capas orientada a servicios y una de presentación.
Cada una de las capas tiene su proposito especifico las cuales son:
#### Domain (Clases, Estructuras de datos, Objetos de Transferencia DTO, Funcionalidad de mapeo)
#### Persistence (Estructura de acceso a datos, Migraciones, Configuraciones iniciales, Data de ejemplo)
#### Service (Servicios de acceso a datos, Logica del negocio)
#### API (Proyecto que expone los servicios web API)
#### UI (Proyecto MVC que consume las apis para el flujo final de usuario)

## Configuracion
Actualice la cadena de conexión ubicada en el proyecto NewShore.API appsettings.Development.json con su maquina local
```
"ConnectionStrings": {
    "DefaultConnection": "Data Source=<SERVER>;Initial Catalog=ns_project;Integrated Security=True"
  }
```
Una vez actualizada la cadena de conexión ejecute las migraciones que tiene el proyecto.
Esto se realiza abriendo la consola de paquetes y ejecutando el comando: (Tenga en cuenta que se debe aplicar este comando sobre el proyecto NewShore.Persistence)
```
Update-Database
```
Las migraciones tienen ya configurada la data inicial para correr satisfactoriamente el aplicativo, no es necesario correr otros scripts para los datos.

## API
Los puertos utilizados para el proyecto ya están configurados si realiza algún cambio puede actualizarlos en la configuración del proyecto API y UI.
```
http://localhost:40000 API
http://localhost:60000 UI - AppMVC
```
La siguiente es la lista de servicios expuestos en el aplicativo.
```
http://localhost:40000/api/Flight [POST] // Realiza la busqueda de vuelos
Entrada:
{
  "Origin": "BOG",
  "Destination": "CTG",
  "From": "2020-11-02"
}

http://localhost:40000/api/Ticket/CODIGO [GET] // Realiza la búsqueda de reserva

http://localhost:40000/api/Ticket [POST] // Guarda la reserva
Entrada:
{
  "namePasanger": "Fernanda Gomez",
  "phoneNumber": "57688554665",
  "emailContact": "fer@hotmail.com",
  "flightId": 11
}
```
## Funcionalidades
El proyecto final cumple con las funcionalidades de:
### Búsqueda de tiquetes
![funcion 1](https://github.com/mariobot/newshore-project/blob/main/p1.png?raw=true)
### Realizar reserva
![funcion 2](https://github.com/mariobot/newshore-project/blob/main/p2.png?raw=true)
### Busqueda de reserva
![funcion 3](https://github.com/mariobot/newshore-project/blob/main/p3.png?raw=true)
### Descarga PDF de reserva
![funcion 4](https://github.com/mariobot/newshore-project/blob/main/p4.png?raw=true)

Con esta prueba técnica espero cumplir con todas las habilidades a evaluar de antemano gracias por su tiempo y revision del mismo. 
Mario Botero
