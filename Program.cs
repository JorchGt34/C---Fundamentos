//Programa que calcula el área de un rectangulo
double ladoA;
double ladoB;
double resultado;

Console.WriteLine("Calcula el área de un rectangulo");
Console.WriteLine("Ingresa el valor de lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa el valor de lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;
Console.WriteLine("El lado A es de " + ladoA + " mientras que el lado B es de " + ladoB + " por lo que el área del rectangulo es de: " + resultado);