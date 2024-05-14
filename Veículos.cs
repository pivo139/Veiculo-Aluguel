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