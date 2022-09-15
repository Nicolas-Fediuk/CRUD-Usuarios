# CRUD de usuarios
Proyecto realizado con el proposito adquirir conocimientos en:
- Formuarios de windows en .NET 
- Libreria Krypton para una mejor interfaz
- Entity Framework database first 

### Habilidades 
- C#
- .NET 6
- Libreria Krypton
- Programación en capas
- Entity Framework database first 
- SQL Server

# 

###Login

![](https://github.com/Nicolas-Fediuk/CRUD-Usuarios-EF-DatabaseFirst/blob/master/ImgReadme/login.png?raw=true)
Al ejecutar el programa cárga el form con el login donde el usuario debe ingresar sus credenciales 

Correo:  **nf@gmail.com**
Contraseña: **12345**

En caso de ingresar un correo o contraseña que no este registrado en la base de datos aparecera un mensaje de error y cada textbox se va a colorear de rojo cuando el dato ingresado este mal y en verde cuando sea el correcto.

###Registro

![](https://github.com/Nicolas-Fediuk/CRUD-Usuarios-EF-DatabaseFirst/blob/master/ImgReadme/registro.png?raw=true)

Al hacer click en el boton "Regístrese" en el login lleva se carga este formulario para que el usuario se registre para ingresar a la app ingresando sus datos personales

Restricciones:
- Nombre y Apellido solo se pueden ingresar más de 2 caracteres de tipo letra 
- DNI y celular solo se pueden ingresar caracteres de tipo numericos. El dni tiene que ser mayor a 1.000.000 y distinto a uno ya cargado, sino el programa le mostrara un mensaje de error, y el celular tiene que contener más de 9 caracteres
- Correo electronico: solo admite un correo valido 

En caso de ingresar un dato invalido aparecera un mensaje de error y cada textbox se va a colorear de rojo cuando el dato ingresado este mal y en verde cuando sea el correcto.

###Control de usuarios

![](https://github.com/Nicolas-Fediuk/CRUD-Usuarios-EF-DatabaseFirst/blob/master/ImgReadme/control.png?raw=true)

Al loguearse correctamente se muestra el formulario para editar los datos del usuario o eliminarlo.
Al hacer click en la fila de la tabla automaticamente se llena los textbox con los datos del usuarios para editarlos y al terminar la edición el usuario debe oprimir en el boton "Editar". **Al editar un DNI este debe ser distinto a uno cargado** sino el programa le indicara con un mensaje de error.
Para eliminar un usuario se debe seleccionar a mismo en la tabla y  hacer click en el boton "Eliminar".
