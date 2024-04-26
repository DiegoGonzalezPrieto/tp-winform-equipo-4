<H1 align=center>
  Aplicación de Gestión De Artículos 
</H1>

La aplicación es para la gestión de artículos de un catálogo de un comercio. La aplicación es del tipo genérica, es decir, aplica para cualquier tipo de comercio.

Es un programa de escritorio que contempla la administración de artículos. 

## Funcionalidades 

Las funcionalidades que tiene la aplicación son:

- Listado de artículos.
- Búsqueda de artículos por distintos criterios.
- Agregar artículos.
- Modificar artículos.
- Eliminar artículos.
- Ver detalle de un artículo.

Toda ésta información es persistida en una base de datos. El programa permite administrar las Marcas y Categorías disponibles en el programa. Además, un producto podría llegar a tener una o más imágenes, sin un límite establecido. Esto está contemplado en la gestión del artículo.

## La aplicación

La aplicación cuenta con una ventana principal donde se visualiza una lista de artículos, que están conformadas por las columnas Codigo de Articulo, Nombre Articulo, Descripcion, Marca Articulo, Categoria y Precio, así mismo tiene las diferentes filas donde se registran los artículos cargados a la misma. Al costado de la grilla de artículos tenemos una caja de imagen donde se visualizan los artículos cargados, si es que los tienen, sino muestra una imagen por defecto, indicando que ese artículo no tiene imágenes. 

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/l4zuah4ifl07ysn43qclb/Captura-de-pantalla-2024-04-26-165233.png?rlkey=c4p16l9oof6q583uvl4koa8py&st=r994q190&raw=1" alt="Pantalla Principal">
</p>
En la parte superior de la ventana principal de se puede visualizar un menú con diferentes opciones que indican Articulo, Marca, Categoría, Ver Artículo.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/b0bwydplkgm2j8f0h34r8/Captura-de-pantalla-2024-04-26-165438.png?rlkey=rvowc4zmx9r6v7qf6ye4tf3g9&st=mjium05u&raw=1" alt="Menu de navegacion">
</p>

## Administración de los artículos

En la primera de las opciones tenemos lo referido a la administración de los artículos, con las tres funcionalidades del sistema en la gestión de artículos: Nuevo Artículo, Modificar Artículo y Eliminar Artículo. 

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/ytb8upv685fg6m91lwfq6/Captura-de-pantalla-2024-04-26-165816.png?rlkey=w7jyhhss2g5fbwisldy4ibsd4&st=cypxmg21&raw=1" alt="Funcionalidades de articulo">
</p>

### Nuevo Artículo

Si seleccionamos la funcionalidad del Nuevo Artículo, este nos abre una ventana donde nos indica los campos que se deben completar para cargar el nuevo artículo al sistema, comenzando por el código del artículo, nombre, descripción del artículo, la marca el cual se encuentra en un desplegable de opciones precargadas con anterioridad y del cual debemos elegir la marca que corresponda al artículo que se está cargando. 

<div style="display: flex; justify-content: center; gap: 20px;">
  <p align="center">
  <img src="https://www.dropbox.com/scl/fi/n2uwiuzjzs12bt0bcqd9b/Captura-de-pantalla-2024-04-26-170317.png?rlkey=35pgltyrdraass36d0scci67h&st=06jpwjym&raw=1" alt="Seleccion de marca" style="width: 45%;">
  <img src="https://www.dropbox.com/scl/fi/ka0fry6rgy9qi62x8vzpd/Captura-de-pantalla-2024-04-26-170332.png?rlkey=h1u1lpfkb973hj619teyxlkkd&st=uerik1lv&raw=1" alt="Seleccion de categoria" style="width: 45%;">
  </p>
</div>

#### Carga de imágenes

A continuación tenemos la carga de imágenes que consta de su propia ventana, debido a que los artículos pueden tener varias imágenes. 

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/kz2lh21wgtcyotuwjjov2/Captura-de-pantalla-2024-04-26-170701.png?rlkey=60iv8fgabghsftuocmbw82a0h&st=k74tg169&raw=1" alt="Carga de imagenes">
</p>

En la parte inferior de la ventana de carga de imágenes, debajo de la grilla, se encuentran tres botones con la funcionalidad de eliminar un link de imagen que no corresponda o bien deba ser actualizada, un botón para confirmar y terminar la carga de imágenes y por último un botón para salir de la ventana, si es que se ingresó por error.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/u1siiwu43uuycoqz886hg/Captura-de-pantalla-2024-04-26-170813.png?rlkey=rcdcd132cvyqpkf087pjr51nw&st=ddqov2z5&raw=1" alt="Botones de funcionalidades de la carga de imagenes">
</p>

### Modificar Artículo

La opción de funcionalidad de modificar artículos abre una ventana similar a la de nuevo artículo con la diferencia que todos los campos están cargados con los datos del artículo seleccionado con anterioridad, aquí se puede modificar el campo que desee, o bien ir a la ventana de imágenes a cambiar los link de las imágenes, el procedimiento es el mismo que se mencionó anteriormente.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/aumwjsx24ig9g9woegjzf/Captura-de-pantalla-2024-04-26-172331.png?rlkey=5e6umwzdfve3cfzjpndu9svwj&st=2fvizlvq&raw=1" alt="Ventana de modificar articulo">
</p>

### Eliminar Artículo

Por último la funcionalidad de eliminar, realiza la acción de mostrarnos una ventana para confirmar si realmente queremos eliminar el artículo que seleccionamos de la tabla, de la ventana principal, mostrándonos la marca y nombre del artículo que vamos a eliminar, dándonos dos opciones, SI o NO.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/cnd66yavraap1ffza6iet/Captura-de-pantalla-2024-04-26-172722.png?rlkey=xw62ns9josbveogiqig60ye64&st=ahd4of85&raw=1" alt="Eliminar articulo">
</p>

## Marca y Categoría

Siguiendo con las opciones del menú de la aplicación, tenemos lo que refiere a Marca y Categoría, que tiene el mismo sistema de funcionamiento, por lo cual vamos a explicar solo el del tipo Marca.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/ngkowo8ehbsu5s3xovqq3/Captura-de-pantalla-2024-04-26-172853.png?rlkey=lydhp0nnrsfqmy0pg2v2f5b63&st=hvw1wl2i&raw=1" alt="Funcionalidades de Marca">
</p>

### Nueva Marca

Si se selecciona Nueva Marca, nos abre una pequeña ventana titulada con “Nueva Marca”, donde tenemos un campo de texto el cual nos permite ingresar el nombre de la marca que deseamos cargar (lo mismo ocurre en categoría) y los botones de guardar y cancelar, el cual nos deja en claro el tipo de acción que realiza cada botón, si se cancela automáticamente se cierra la ventana sin cambios en la aplicación, ahora bien si se oprime guardar, nos sale una nueva ventana de aviso que la marca ha sido guardada con éxito, y todas las ventas se cierran luego de aceptar el aviso.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/mwnwh2dcz3bfxkv5jaicc/Captura-de-pantalla-2024-04-26-173053.png?rlkey=dqpmncb5ukt0bb29gi7587e36&st=389meo9j&raw=1" alt="Cargar Nueva Marca">
</p>


### Buscar Marca

Para verificar que esta marca se cargó correctamente, se puede ir a la opción de buscar marca que teníamos en mismo apartado, donde esta nos abre una nueva ventana con varias opciones, ya que en la misma se realizan tres tipos de acciones. En primer lugar vamos a visualizar una grilla con una única columna donde se listan las marcas que tenemos cargadas en el sistema, también un campo de texto que tiene un sistema de búsqueda por palabras, el cual va ir buscando la coincidencia de palabras ingresadas en el mismo, y filtrando la lista de marcas hasta encontrar coincidencia con el texto. A un costado tenemos dos botones que nos permiten editar la marca o bien eliminarla, esta última opción tiene la misma funciona que se utilizar con los artículos, y el botón de editar el mismo sistema de funcionalidad de que la ventana de modificar de artículos, mostrándonos una ventana similar a la de carga pero con el campo cargado con el nombre de la marca seleccionada.

<div style="display: flex; justify-content: center; gap: 20px;">
  <p align="center">
  <img src="https://www.dropbox.com/scl/fi/98yf8lsp9u53dhsjhxs4w/Captura-de-pantalla-2024-04-26-173123.png?rlkey=0obp7ywwzb9j78g29583emb3f&st=n1qlfb38&raw=1" alt="Seleccion de marca" style="width: 45%;">
  <img src="https://www.dropbox.com/scl/fi/ptrtnadze8k03oxcnui6s/Captura-de-pantalla-2024-04-26-173412.png?rlkey=fhoikoenozmc5528jsiwfynid&st=jhtj1jos&raw=1" alt="Seleccion de categoria" style="width: 45%;">
  </p>
</div>

## Ver Artículo

La anteúltima opción del menú de navegación es el de Ver Artículo, aquí se nos abre una ventana donde vamos a encontrar los detalles del artículo seleccionado, con su respectivo nombre, marca, descripción, categoría, precio y un cuadro de imagen con unas flechas que nos permiten ver las imágenes correspondiente a este artículo seleccionado, siempre que este tenga más de una imagen, si es que lo tiene, de lo contrario mostrar una imagen por defecto de imagen no disponible.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/xj739g19402clgvb850bx/Captura-de-pantalla-2024-04-26-174223.png?rlkey=e4kv43w0556d36grzxk9vuls0&st=as2zgr7e&raw=1" alt="Ver Articulo">
</p>

La última opción de menú de navegación es Ayuda, que nos permite acceder a dos opciones, la primera el archivo de funcionamiento de la aplicación. Por otro lado tenemos información sobre la aplicación.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/n9e33ybdl2g8zso60oc0a/Captura-de-pantalla-2024-04-26-174615.png?rlkey=arkqyylekg9wavzg99kwmlddm&st=eijiheld&raw=1" alt="Seccion de ayuda">
</p>

## Búsqueda de Artículos

### Búsqueda Rapida

Ya mencionamos que la ventana tiene una grilla de datos de artículos, y justo arriba de la misma se puede visualizar un texto que dice: Buscar, seguido de un campo de texto, el cual tiene el mismo funcionamiento que el sistema de filtrado de la ventana de buscar marca, pero con la diferencia, que aquí la búsqueda se realiza sobre todos los datos que contiene la grilla, ya sea código, nombre, descripción, etc. dando así un resultado más óptimo a la hora de la búsqueda.

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/nz1fnrrumx5bleiz41yau/Captura-de-pantalla-2024-04-26-174707.png?rlkey=32r3vt96dm05govv1b8xecwmr&st=zmfplyu8&raw=1" alt="Busqueda rapida">
</p>

### Búsqueda Avanzada

Aparte de este sistema de búsqueda rápida, debajo de la grilla, encontramos un sistema de búsqueda más avanzado, esto nos permite realizar una búsqueda más precisa, el cual nos permite realizar el filtrado indicando un campo, un criterio y un parámetro de búsqueda ya sea un carácter, una palabra o un número, esta acción se genera cuando cargamos todos los datos y se presiona sobre el botón de filtrado, realizando que en la grilla principal se muestre el artículo coincidente. El botón borrar filtro realiza un reinicio de la grilla del sistema volviendo a mostrar todos los artículos. 

<p align="center">
  <img src="https://www.dropbox.com/scl/fi/ncggbu27ix02lgdzjj30h/Captura-de-pantalla-2024-04-26-174716.png?rlkey=z12ydmqpv6ldzvrfnffxfw9qj&st=q0z049t1&raw=1" alt="Busqueda avanzada">
</p>


---
## Trabajo Práctico N2: Aplicación de Gestión de Artículo

**Materia:** Programación III  
**Profesor:** Maximiliano Sar Fernanadez  
**Ayudantes:** Regina Laurentino - Gonzalo Ligero  


**Alumnos:**  
- Diego González Prieto  
- Juan Pablo Rajoy  
- Daniel (Luciano) Santostefano  

<p align="center">
Derechos Reservados © 2024
</p>

