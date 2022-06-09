using System;

using System.Globalization;

double IMC, peso, altura;

Console.WriteLine("Informe o seu peso em kilos: ");
peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Informe a sua altura em metros: ");
altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario) {
IMC = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);
    if (IMC < 18.5)
    {
        return "Abaixo do peso.";
    }
    else if (IMC <= 24.9)
    {
        return "Peso Normal.";
    }
    else if (IMC <= 30)
    {
        return "Sobrepeso";
    }
    else if(IMC <= 40)
    {
        return "Obesidade";
    }
    else
    {
        return "Obesidade grave";
    }
}

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu diagnóstico é XXXXXX.
Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(altura,peso)}");

