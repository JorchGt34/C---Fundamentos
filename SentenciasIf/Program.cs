//Blackjack
int totalJugador = 22;
int totalDealer = 16;
string mensaje = "";

//Blackjack
//El jugador debe tener un total de 21 o menos para poder seguir jugando

if ((totalJugador <= 21 && totalJugador > totalDealer) || (totalDealer > 21 && totalJugador <= 21)) {
    mensaje = "El jugador gana";
} else {
    mensaje = "El dealer gana";
}

Console.WriteLine(mensaje);