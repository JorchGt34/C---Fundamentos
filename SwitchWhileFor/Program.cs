using System;

int totalJugador, totalDealer, num, monedasJugador, partidasGanadas = 0;
string mensaje, controlSwitch = "1",endGame = "si", controlOtraCarta;
System.Random random = new System.Random();

while(endGame == "si"){
    Console.WriteLine("Bienvenido al juego de Blackjack \n ¿Cuántas fichas desea comprar? (1 ficha es 1 ronda)");
    monedasJugador = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < monedasJugador; i++){
        totalJugador = 0; totalDealer = 0;
        switch (controlSwitch) {
            case "1":
            //El jugador toma cartas
                do {
                    num = random.Next(1,12);
                    totalJugador += num;
                    Console.WriteLine($"Ronda {i+1}/{monedasJugador}");
                    Console.WriteLine($"Nueva carta del jugador: {num}");
                    Console.WriteLine($"Total del jugador: {totalJugador}");
                    Console.WriteLine("¿Desea otra carta?");
                    controlOtraCarta = Console.ReadLine();
                } while (controlOtraCarta == "Otra carta" || 
                        controlOtraCarta == "Si" || 
                        controlOtraCarta == "si" || 
                        controlOtraCarta == "yes");
                //El dealer toma cartas
                do {
                    num = random.Next(1,12);
                    totalDealer += num;
                    Console.WriteLine($"Nueva carta del dealer: {num}");
                    Console.WriteLine($"Total del dealer: {totalDealer}");
                } while (totalDealer < 17);

                //Determinar ganador
                if (totalJugador > totalDealer && totalJugador <= 21 || 
                    totalDealer > 21 && totalJugador <= 21){
                    mensaje = "¡Felicidades! Has ganado";
                    partidasGanadas++;
                    monedasJugador++;
                } else {
                    mensaje = "¡Lo siento! Has perdido";
                    monedasJugador--;
                }
                Console.WriteLine(mensaje);
                break;
                
            default:
                Console.WriteLine("Opción no válida");
                controlSwitch = "menu";
                break;
        }
    }
    Console.WriteLine($"Ganaste {partidasGanadas} de {monedasJugador} partidas");
    endGame = "no";
}