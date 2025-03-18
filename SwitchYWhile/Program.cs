using System;

int totalJugador, totalDealer, num;
string mensaje, controlSwitch = "menu",endGame = "si", controlOtraCarta;
System.Random random = new System.Random();

while(endGame == "si"){
    totalJugador = 0; totalDealer = 0;
    switch (controlSwitch) {
    case "menu":
        Console.WriteLine("Bienvenido al juego de Blackjack \n Escriba 21 para comenzar");
        controlSwitch = Console.ReadLine();
        break;
    case "21":
    //El jugador toma cartas
        do {
            num = random.Next(1,12);
            totalJugador += num;
            Console.WriteLine($"Nueva carta del jugador: {num}");
            Console.WriteLine($"Total del jugador: {totalJugador}");
            Console.WriteLine("¿Desea otra carta?");
            controlOtraCarta = Console.ReadLine();
        } while (controlOtraCarta == "Otra carta" || controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "yes");
    //El dealer toma cartas
        do {
            num = random.Next(1,12);
            totalDealer += num;
            Console.WriteLine($"Nueva carta del dealer: {num}");
            Console.WriteLine($"Total del dealer: {totalDealer}");
        } while (totalDealer < 17);

    //Determinar ganador
        if (totalJugador > totalDealer && totalJugador <= 21 || totalDealer > 21 && totalJugador <= 21){
        mensaje = "¡Felicidades! Has ganado";
        } else {
            mensaje = "¡Lo siento! Has perdido";
        }
        Console.WriteLine(mensaje);
        Console.WriteLine("¿Desea jugar de nuevo?\n-no para terminar\n-si para continuar");
        endGame = Console.ReadLine();
        break;
    default:
        mensaje = "Opción no válida";
        break;
    }
}