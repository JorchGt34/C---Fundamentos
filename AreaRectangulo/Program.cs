//Programa que calcula el área de un rectangulo
var ladoA = 0d;
var ladoB = 0d;
var resultado = 0d;

Console.WriteLine("Calcula el área de un rectangulo");
Console.WriteLine("Ingresa el valor de lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa el valor de lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

//Operadores aritmeticos en C#
/*
ladoA + ladoB = Suma
ladoA - ladoB = Resta
ladoA * ladoB = Multiplicación
ladoA / ladoB = División
ladoA % ladoB = Módulo
*/

//Otros operadores
/*
ladoA++ = Incremento
ladoA-- = Decremento
ladoA += ladoB = ladoA = ladoA + ladoB
ladoA -= ladoB = ladoA = ladoA - ladoB
ladoA *= ladoB = ladoA = ladoA * ladoB
ladoA /= ladoB = ladoA = ladoA / ladoB
ladoA %= ladoB = ladoA = ladoA % ladoB
*/

resultado = ladoA * ladoB;
Console.WriteLine("El lado A es de " + ladoA + " mientras que el lado B es de " + ladoB + " por lo que el área del rectangulo es de: " + resultado);