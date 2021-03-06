# Tarea 7
Este equipo está conformado por Brahiam Castillo, Iván Gómez y Félix Ramírez.

## Pasos para tener lo necesario en el proyecto.
En primer lugar deben ejecutar el comando `dotnet restore` , este se encarga de restaurar las dependencias del proyecto.

A continuación, se debe agregar el connection string de MYSQL al appsettings.json del proyecto, esto se hace con la línea de comandos:

Antes que todo, deben activar el user-secret del proyecto, esto se logra usando el siguiente comando:

```bash
dotnet user-secrets init
```
<hr>

Lo siguiente es introducir el connection string con el siguiente comando:

```bash
dotnet user-secrets set ConnectionStrings:vacunas "server=localhost;uid=root;pwd=tupassword;database=vacunas"
```
En la parte de "uid" y "pwd", deben reemplazarlo con su respectivo usuario y contraseña de MYSQL, ya deben saber acerca de hacer como es el asunto del connection string.

<hr>

Una vez hecho lo anterior, ejecutan `dotnet ef database update` , de esta manera la base de datos y su estructura se introducirá en su servidor de MYSQL por medio de las migraciones programadas, todo sin necesidad de ejecutar algún script, solo lo anterior, pero por las dudas, dejaré el script MYSQL en el repositorio.

## Ya con estos pasos realizados, el proyecto les correrá sin problemas y podrán programar en el mismo sin errores.
