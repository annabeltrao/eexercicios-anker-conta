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
}

