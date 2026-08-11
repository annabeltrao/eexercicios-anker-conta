using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta(123, "Anna", 500);

        conta.Depositar(200);

        Console.WriteLine("Número da conta: " + conta.numeroConta);
        Console.WriteLine("Titular: " + conta.nomeTitular);
        Console.WriteLine("Saldo: R$ " + conta.saldo);

        Console.WriteLine("Extrato:");

        foreach (string movimento in conta.extratoBancario)
        {
            Console.WriteLine(movimento);
        }
    }
}
