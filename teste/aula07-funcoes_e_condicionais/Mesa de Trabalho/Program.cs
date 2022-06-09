//1. Com base no código a seguir, calcule a conversão do real para dólar, estabeleça um valor mínimo e máximo para compra na transação.
// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
Console.WriteLine("Insira o valor da compra em reais: ");
double valorDaCompraEmReais = double.Parse(Console.ReadLine());


string converterRealParaDolar(double valorDaCompraEmReais)
{
    double valorDaCompraEmDolar = valorDaCompraEmReais / cotacaoDoDolarHoje;
    if(valorDaCompraEmDolar < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
    {
        return $"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}" ;
    }else if (valorDaCompraEmDolar > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
    {
        return $"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
    }
    else
    {
        return $"Você pode comprar $ {valorDaCompraEmDolar}";
    }
}




// Utilize as mensagens a seguir como base do retorno esperado:
// A compra mínima permitida é de $ XXX,XX.
// A compra máxima permitida é de $ XXXX,XX.
// Você pode comprar $ XXX,XX.
Console.WriteLine(converterRealParaDolar(valorDaCompraEmReais));

