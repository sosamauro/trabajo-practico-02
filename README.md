# Trabajo Práctico N° 2

## Ejercicio 1

Se recibe un requerimiento de un cliente el cual quiere una aplicación de consola con la cual pueda obtener de una forma fácil los valores de área y perímetro de figuras
geométricas. Las figuras requeridas son punto, círculo y triángulo. El cliente quiere que se presente un menú para seleccionar la figura y que después se pueda ingresar los valores de los ejes X e Y que definen el tamaño de las mismas sin importar la unidad de medida. 

Las funcionalidades que debe poseer la aplicación son las siguientes:
- Distancia entre dos puntos.
- Área y perímetro de un círculo.
- Área y perímetro de un triángulo.

También se recibe un diagrama de clases del diseñador de su equipo de desarrollo el cual define objetos de dominio que se deben crear para satisfacer los requerimientos. Además se indica que se debe utilizar el patrón de diseño GRASP Controlador de Fachada para desacoplar la lógica del dominio de la interfaz.

Desarrolle una aplicación que satisfaga el requerimiento de basándose en el diseño y a las indicaciones realizadas. Implemente casos de prueba unitarios para las clases que considere adecuadas.

## Ejercicio 2

Se recibe un requerimiento para que se desarrolle una aplicación de consola que permita mostrar información y realizar operaciones sobre cuentas bancarias en forma interactiva por consola.

- El cliente puede crear una cuenta unificada, con una cuenta en pesos y una en dólares, informándole al sistema el número unificado de cuenta (para el cual tomaremos el DNI) y el nombre del titular. Las cuentas creadas tendrán saldo cero en el momento de la creación.
- El cliente puede operar con las dos cuentas en cualquier momento, para ello debe seleccionar una de ellas y generar movimientos de débito y crédito con la posibilidad de mostrar el saldo cuando se requiera.
- Se podrán hacer transferencias entre ambas cuentas, tomando el valor del dólar de manera prefijada. En el caso de que al momento de debitar saldo de una cuenta este no sea suficiente entonces se debe informar al usuario de esta situación.

Por parte del diseñador se recibe el diagrama de clases del dominio y las siguientes indicaciones:
- La clase _Banca_ representa la cuenta unificada del cliente.
- La clase _RepositorioBanca_ implementa el patrón Repository de Domain-Driven Design. Revisar en internet el concepto y aplicarlo. Dado que no disponemos de un gestor de base de datos, implemente el patrón repositorio en memoria mediante un arreglo.
- La clase _Cuenta_ representa una cuenta bancaria, la cual posee un saldo en pesos de la cuenta y responde a los siguientes mensajes:
  - _Saldo:_ obtiene el saldo actual de la cuenta.
  - _AcreditarSaldo:_ suma a la cuenta el saldo indicado.
  - _DebitarSaldo:_ debita el saldo indicado de la cuenta, siempre y cuando se cuente con saldo suficiente en cuyo caso devuelve true. Si el saldo de la cuenta no es suficiente entonces el saldo no es debitado y devuelve false.
- La clase _Cuenta_ posee dos constructores, donde uno de ellos solo permite establecer la moneda inicializando el saldo inicial de la cuenta en cero, y el otro constructor permite establecer tanto la moneda como el saldo inicial.

Utilizar el patrón de diseño GRASP _Controlador de Fachada_ para desacoplar la lógica de negocio de la interfaz de usuario. Implemente casos de prueba unitarios para las clases que considere adecuadas.
