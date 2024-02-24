## Tarea: Gestión productos

Las modificación de la base de datos se da através de la conexión que se da entre el lenguaje de programación

y la base de datos. La arquitectura de la conexión a base de datos es cliente - servidor, lo que nos permite 

realizar las modificaciones en una misma máquina.

<img src="https://github.com/Mike37Jet/PantallasBD/assets/71087557/3ea6f12b-8615-4393-8c21-ce9ebaf04a23" width="500" height="200">


> Las herramientas para la tarea son:
> 
>       - SQLserver
>       - Visual Studio
>       - C#: .net, forms


## Menu: Actividades en Productos

La pantalla principal denota el acceso hacia las diferentes actividades que se pueden realizar en la tabla

de productos. 


<img src="https://github.com/Mike37Jet/PantallasBD/assets/71087557/12a474dd-695a-4eb5-8a63-84b47176ff6b" width="500" height="400">


## Insertar productos
La pantalla insertar permitirá agregar un nuevo producto a la base de datos mediante la siguiente información:

> Datos de Entrada
>    - código: int 
>    - nombre: string
>    - precio: double
>    - unidad: int
>    - id tipo: int
>    - id proveedor: int


<img src="https://github.com/Mike37Jet/PantallasBD/assets/71087557/7bb1fee1-61e1-4387-a67e-d600a30d55a2" width="500" height="400">


## Eliminar productos

La pantalla eliminar permitirá eliminar un producto mediante el ingreso del código de un producto. Además, presenta el campo N

que denota el numero de tuplas que se eliminaron.

<img src="https://github.com/Mike37Jet/PantallasBD/assets/71087557/283c39cf-8377-45dd-855c-2334f2893f6a" width="500" height="400">

## Actualizar productos

La pantalla actualizar permitirá actualizar las datos de los parámetros precio, cantidad stock, mediante el

el ingreso del código de un producto ó nombre del producto. Además, la actualización se denota por el campo N que mostrará 1 si 

se realizo con exito la actualización en una tupla ó 0 si hubo un fallo y no se realizo cambios en la tupla.

<img src="https://github.com/Mike37Jet/PantallasBD/assets/71087557/2f021c06-5f61-4431-b07b-d5db99f25c2c" width="500" height="400">

## Consultar productos

La pantalla consultar permitirá consultar los parámtros que presenta la tabla productos mediante el ingreso del id del producto

ó nombre del producto.

<img src="https://github.com/Mike37Jet/PantallasBD/assets/71087557/ccf76959-0234-4400-90a9-5974c1e73d6c" width="500" height="400">

## Descarga del programa

> 1. abrir visual code
> 2. selecciónar del menú de git, la opción clonar repositorio
>
>    ![image](https://github.com/Mike37Jet/PantallasBD/assets/71087557/510fee4c-b9cc-44a5-9f9d-0e647a90c7a2)
>    
> 3. se le mostrara la siguiente pantalla
>
>    ![image](https://github.com/Mike37Jet/PantallasBD/assets/71087557/fb83c32a-6f1d-418b-a5cf-55dd73b3a5ac)
>    
> 4. en el campo de localización de repositorio ingresar el siguiente link:
>    
>     --- https://github.com/Mike37Jet/PantallasBD.git
> 5. dar click en clonar. Y obtendrá el proyecto
>  #### Nota: en la conexión a la base de datos se deberá cambiar el nombre actual por su nombre del servidor de sqlserver
