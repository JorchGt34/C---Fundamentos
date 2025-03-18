var radio = 0d;
var resultado = 0d;

Console.WriteLine("Bienvenido, calculemos círculos");
// Pi * Radio^2

Console.WriteLine("Ingrese el redio del circulo:");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * Math.Pow(radio, 2);

Console.WriteLine("El área del círculo es: " + resultado);