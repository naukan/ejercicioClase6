int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

Console.WriteLine("Intente adivinar el numero generado por ordenador. Solo tiene 5 intentos.");
Console.WriteLine("Ingrese un numero: ");

int numeroUsuario = int.Parse(Console.ReadLine());

int intentos = 1;

for (intentos = 0; intentos < 5; intentos++)
{
    while (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es mayor al numero generado por ordenador. Intente nuevamente");
        numeroUsuario = int.Parse(Console.ReadLine());
    }

    while (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es menor al numero generado por ordenador. Intente nuevamente");
        numeroUsuario = int.Parse(Console.ReadLine());
    }
}

if (numeroUsuario == numeroSecreto)
{
    Console.WriteLine($"Feliciaciones! Encontraste el numero secreto que era {numeroSecreto}!");
    Console.WriteLine($"Lo ha logrado en {intentos} intentos.");
}


