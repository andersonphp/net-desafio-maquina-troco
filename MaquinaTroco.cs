using System;

class MaquinaTroco

{
    private static int[] estoqueMoedas = { 0, 20, 0, 0, 100 }; // usei privado só pra termos 20 moedas de 0,50 e 100 de 0.5.
    public static void CalcularTroco(double valorProduto, double valorPago)
    {
        
        if(valorPago < valorProduto) //condição para encerrar o programa se a pessoa der dinheiro faltando rsrs.
        {
            Console.WriteLine("Valor pago é insuficiente para adquirir o produto, favor insira um valor equivalente ao preço do produto ou maior que devolveremos seu troco.");
            return;
        }

    double troco = valorPago - valorProduto;

    double[] moedas = {1, 0.5, 0.25, 0.10, 0.5}; //moedas que temos

     for (int i = 0; i < moedas.Length; i++) //loop que vai percorrer pelo array, o [i] é a variavel que representa a posição do array
        {
            if (moedas[i] == 1 || moedas[i] == 0.5) // Condição para escolher apenas moedas de 1 real ou 50 centavos
            {
                int quantidadeDisponivel = Math.Min((int)(troco / moedas[i]), estoqueMoedas[i]); // a função math.min serve para não ultrapassarmos o estoque

                if (quantidadeDisponivel > 0) //qtda de moedas tem que ser maior que zero para executar
                {
                    Console.Write($" {quantidadeDisponivel} moeda(s) de R${moedas[i]:F2}, "); //usamos o f2 para ponto flutuante (F) com duas casas decimais (2). 
                    troco -= quantidadeDisponivel * moedas[i]; //subtrai o valor das moedas utilizadas no troco
                    estoqueMoedas[i] -= quantidadeDisponivel; //atualiza o estoque subtraindo as moedas utilizadas
                }
            }
        }

}
}