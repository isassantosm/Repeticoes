
Console.WriteLine("Digite seu numero: ");

int numero = Convert.ToInt32(Console.ReadLine());

for (int tabuada = 1; tabuada <= 10; tabuada++)
{
    Console.WriteLine($"{numero} X {tabuada} = {numero * tabuada}");
    Thread.Sleep(500);
}