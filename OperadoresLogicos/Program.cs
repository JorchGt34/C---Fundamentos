//Operadores logicos
/*
&& - AND
|| - OR
! - NOT 
^ - XOR (Ou exclusivo)
*/

var (valor1, valor2, valor3) = (true, true, false);

//Operador AND
bool resultOr = valor1 && valor2 && valor3;
Console.WriteLine(resultOr);

//Operador OR
bool resultAnd = valor1 || valor2 || valor3;
Console.WriteLine(resultAnd);

//Operador AndOr
bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

bool resultNot = !valor1;
Console.WriteLine(resultNot);

bool resultXOR = valor1 ^ valor2 ^ valor3; //Primero checa los dos primeros valores y luego el resultado con el tercer valor
Console.WriteLine(resultXOR);