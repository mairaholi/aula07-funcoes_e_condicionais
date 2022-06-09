/*
Resultado do cálculo do IMC
Abaixo de 18.5
Entre 18.5 e 24.9
Entre 25 e 29.9
Acima de 30
Maior que 40
Diagnóstico
Anêmico
Normal
Sobrepeso
Obesidade
Obesidade grave
*/

double IMC, peso, altura;

Console.WriteLine("Informe o seu peso: ");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a sua altura: ");
altura = double.Parse(Console.ReadLine());



string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario) {
    IMC = pesoDoUsuario / (alturaDoUsuario* alturaDoUsuario);
}

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu diagnóstico é XXXXXX.
Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(peso, altura)}");

