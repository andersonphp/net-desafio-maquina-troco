class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o valor do produto:");
        double valorProduto = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Informe o valor pago pelo cliente:");
        double valorPago = Convert.ToDouble(Console.ReadLine());

        MaquinaTroco.CalcularTroco(valorProduto, valorPago);
    }
}