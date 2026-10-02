

int dia = 0;
int total = 0;

while (dia < 10 )
{
    dia++;
    total = total + 5;
    Console.WriteLine($"Dia: {dia}: R${total}");
    Thread.Sleep(1000);
}
Console.WriteLine("Economia total concluída com sucesso!"); 








