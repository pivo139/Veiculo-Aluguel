### Repositório criado para fazer um teste

using System;

public abstract class Veículo{
    protected double TaxaDiaria{get;set;}
    public abstract double CalcularValorTotal(int numDiarias);
}

class Carro: Veículo{
    public Carro(double TaxaDiaria){
        this.TaxaDiaria = TaxaDiaria;
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return numDiarias * TaxaDiaria;
    }
}

class Moto: Veículo{
    public Moto(double TaxaDiaria){
        this.TaxaDiaria = TaxaDiaria;
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return numDiarias * TaxaDiaria;
    }
}

class Program{
    public static void Main(string[] args){

        double taxaCarro = 50;
        double taxaMoto = 25;
        int numDiarias = 10;

    Carro carro = new Carro(taxaCarro);
    Moto moto = new Moto(taxaMoto);

    double ValorTotalCarro = carro.CalcularValorTotal(numDiarias);
    double ValorTotalMoto = moto.CalcularValorTotal(numDiarias);

    Console.WriteLine("O valor total do aluguel do carro por 10 dias é: " + ValorTotalCarro);
    Console.WriteLine("O valor total do aluguel da moto por 10 dias é: " + ValorTotalMoto);

    }
}


