// See https://aka.ms/new-console-template for more information
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
