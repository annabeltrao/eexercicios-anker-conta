class Program
{
    static void Main(string[] args)
    {
        ContaNormal contaNormal = new ContaNormal(123, "Anna", 500);

        contaNormal.Depositar(200);
        contaNormal.Sacar(300);

        Console.WriteLine("Conta Normal");
        Console.WriteLine("Saldo: R$ " + contaNormal.saldo);

        foreach (string movimento in contaNormal.extratoBancario)
        {
            Console.WriteLine(movimento);
        }

        Console.WriteLine();

        ContaEspecial contaEspecial = new ContaEspecial(456, "Anna", 500, 1000);

        contaEspecial.Depositar(200);
        contaEspecial.Sacar(1200);

        Console.WriteLine("Conta Especial");
        Console.WriteLine("Saldo: R$ " + contaEspecial.saldo);

        foreach (string movimento in contaEspecial.extratoBancario)
        {
            Console.WriteLine(movimento);
        }
    }
}