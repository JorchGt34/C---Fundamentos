# C# Fundamentos

## Introducción

C es uno de los lenguajes antiguos que fue de los más utilizados. Con el tiempo, algunas de sus características fueron quedando obsoletas y se creó C++. Aunque C++ es muy utilizado, también era necesario un lenguaje que fuera orientado a objetos, y así fue como se creó C#.

Los objetos a los que se refiere son como en la vida misma: objetos que tienen características, como un balón, una persona, etc.

C# es un lenguaje principalmente potenciado por Microsoft para ser usado en .NET, pero también tecnologías como Unity utilizan C# para la programación de aplicaciones, videojuegos, etc.

Este lenguaje cuenta con mucho soporte por parte de la comunidad, por lo que se actualiza con frecuencia y tiene soporte durante un largo tiempo.

## ¿Qué son los algoritmos?

Un algoritmo es un conjunto de instrucciones que resuelven un problema paso a paso sin ambigüedades. Los algoritmos se utilizan para definir reglas o una serie de pasos para que, en este caso, el código funcione correctamente. No debe haber ambigüedad, ya que esto lleva a resultados erróneos o a un mal funcionamiento del código.

## Entorno de programación

Se recomienda usar **Visual Studio (Community 2022)**, pero solo está disponible para Windows, así como **Xcode** solo está para macOS. Es posible instalar .NET para Mac y empezar a programar en **Visual Studio Code** o IDEs como **Rider**.

## Compilación

C# es un lenguaje compilado, por lo que primero se compila el código que se haya creado; si no hay errores en la compilación, el código se ejecutará.

## Tipos de datos primitivos

Los datos se utilizan para marcar lo que está pasando o guardar información. Algunos ejemplos de datos son:

**Ejemplo de datos en videojuegos:**
- Vidas
- Niveles
- Características de un personaje
- Mapa

**Ejemplo de datos de un inicio de sesión:**
- Nombre de usuario
- Correo
- Contraseña
- Número de teléfono
- Nombre completo

**Datos primitivos en C#:**

- `int` // 4 bytes // Del -2147483648 a 2147483647
- `bool` // 1 bit // Del 0 al 1
- `float` // 4 bytes // De 6 a 7 dígitos
- `double` // 8 bytes // Hasta 15 dígitos
- `char` // 2 bytes // Un solo carácter
- `string` // 2 bytes por carácter // sin rango
- `long` // 8 bytes // -9223372036854775808 a 9223372036854775807
- `uint` // 4 bytes // Del 0 al 4294967295

Otros archivos como imágenes, música, video, documentos, etc. son archivos binarios y se almacenan en formato de 0s y 1s.

## Rangos

Los rangos de los tipos de valores tienen un rango de almacenamiento que ocupan en la memoria RAM. Según el uso de los datos, el programa puede optimizarse o puede desperdiciarse un poco la memoria RAM.

## Datos `var`

Los datos pueden ser declarados como tipo `var`. Este tipo de dato es implícito y sirve para expresar de qué tipo será su contenido. Declarar los tipos de datos de manera implícita hace que el código sea más legible.

```csharp
var numero = 10;
var texto = "Hola mundo";
```

## Datos `const`

Estos datos se declaran con un valor que nunca va a cambiar. A pesar de eso, se puede usar para ser operado por otras variables.

```csharp
const double PI = 3.1416;
```

## Objeto `Math` en C#

**`Math.PI`**
Esta propiedad de `Math` tiene el valor de la constante PI con precisión.

**`Math.Pow()`**
Este método calcula la potencia de un número:

```csharp
double resultado = Math.Pow(2, 3); // Resultado: 8
```

## Operadores aritméticos

- `+` // Suma
- `-` // Resta
- `*` // Multiplica
- `/` // Divide
- `%` // Módulo (resto de una división)
- `++` // Incremento
- `--` // Decremento

## Operadores lógicos

- `&&` // AND (ambos deben ser true)
- `||` // OR (uno debe ser true)
- `!` // NOT (invierte el valor)
- `^` // XOR (compara si los valores son diferentes)

## Sentencia `if`

```csharp
if (condicion) {
   // Código a ejecutar
} else if (otraCondicion) {
   // Otro bloque de código
} else {
   // Código por defecto
}
```

## Sentencia `switch`

```csharp
switch (valor) {
    case 1:
        // Código para caso 1
        break;
    case 2:
        // Código para caso 2
        break;
    default:
        // Código por defecto
        break;
}
```

## Sentencia `while`

```csharp
while (condicion) {
    // Código a ejecutar mientras la condición sea verdadera
}
```

## Sentencia `do-while`

```csharp
do {
    // Código a ejecutar
} while (condicion);
```

## Ciclo `for`

```csharp
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}
```

## Optimización

La optimización consiste en buscar una mejor manera de llegar a la misma conclusión usando menos código o memoria, mejorando el rendimiento y la claridad del programa.

