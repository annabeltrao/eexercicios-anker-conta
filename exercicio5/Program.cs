class Program
{
    static void Main(string[] args)
    {
        ContaNormal contaNormal = new ContaNormal(123, "Anna", 500);

        contaNormal.Depositar(200);
        contaNormal.Sacar(300);
        contaNormal.Sacar(1000);

        Console.WriteLine("Conta Normal");
        Console.WriteLine("Saldo: R$ " + contaNormal.saldo);

        Console.WriteLine("\nExtrato:");

        foreach (string movimento in contaNormal.extratoBancario)
        {
            Console.WriteLine(movimento);
        }

        Console.ReadLine();
    }
}