Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Decomposição Decimal\n");
Console.ResetColor();

Console.Write("DIGITE UM NÚMERO INTEIRO:...");
int numero = Convert.ToInt32(Console.ReadLine());

int restante = numero;

int unidades = restante % 10;
restante /= 10;

int dezenas = restante % 10;
restante /= 10;

int centenas = restante;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"\nO número {numero} possui:");
Console.ResetColor(); 

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"{unidades,10} unidade(s)");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{dezenas,10} dezenas(s)");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{centenas,10} centena(s).");
Console.ResetColor();
