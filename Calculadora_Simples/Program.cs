using Calculadora_Simples;
using CalculateSimple;
using System.ComponentModel;

Calculate calc = new Calculate();

int calcular;

Console.WriteLine("1 - Somar, 2 - Subtrair, 3 - Multiplicar, 4 - Dividir, " +
    "5 - Potenciação, 6 - Seno, 7 - Coseno, 8 - Tangente, 9 - Raiz Quadrada");

Console.WriteLine("Escolha uma Opção.");

calcular = int.Parse(Console.ReadLine());

switch (calcular)
{

    case 1:
        Console.WriteLine("SOMA");
        calc.Add();
        break;
    case 2:
        Console.WriteLine("SUBTRAÇÃO");
        calc.Subtract();
        break;
    case 3:
        Console.WriteLine("MULTIPLICAÇÃO");
        calc.Multiply();
        break;
    case 4:
        Console.WriteLine("DIVISÃO");
        calc.Divide();
        break;
    case 5:
        Console.WriteLine("POTENCIAÇÃO");
        calc.Power();
        break;
    case 6:
        Console.WriteLine("SENO");
        calc.Sine();
        break;
    case 7:
        Console.WriteLine("COSENO");
        calc.Cosine();
        break;
    case 8:
        Console.WriteLine("TANGENTE");
        calc.Tangent();
        break;
    case 9:
        Console.WriteLine("RAIZ QUADRADA");
        calc.SquareRoot();
        break;
    default:
        Console.WriteLine("Opção inválida, tente novamente!");
        break;

}