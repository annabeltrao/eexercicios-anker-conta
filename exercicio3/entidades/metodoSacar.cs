using System;
using System.Collections.Generic;

class Conta
{
    public int numeroConta;
    public string nomeTitular;
    public double saldo;
    public List<string> extratoBancario;

    public Conta(int numeroConta, string nomeTitular, double saldo)
    {
        this.numeroConta = numeroConta;
        this.nomeTitular = nomeTitular;
        this.saldo = saldo;
        extratoBancario = new List<string>();
    }

    public void Depositar(double valor)
    {
        saldo += valor;
        extratoBancario.Add("Depósito: R$ " + valor);
    }

    public void Sacar(double valor)
    {
        saldo -= valor;
        extratoBancario.Add("Saque: R$ " + valor);
    }
}

class ContaNormal : Conta
{
    public ContaNormal(int numeroConta, string nomeTitular, double saldo)
        : base(numeroConta, nomeTitular, saldo)
    {
    }
}

class ContaEspecial : Conta
{
    public double limite;

    public ContaEspecial(int numeroConta, string nomeTitular, double saldo, double limite)
        : base(numeroConta, nomeTitular, saldo)
    {
        this.limite = limite;
    }
}
