Console.WriteLine("---Bem-vindo a calculadora---");

Console.WriteLine("Digite o primeiro número: ");
int nmr1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int nmr2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Selecione a operação: ");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");

int operacao = Convert.ToInt32(Console.ReadLine());
int resultado = 0;

switch (operacao)
{
    case 1:
        resultado = nmr1 + nmr2;
        break;
    case 2:
        resultado = nmr1 - nmr2;
        break;
    case 3:
        resultado = nmr1 * nmr2;
        break;
    case 4:
        resultado = nmr1 / nmr2;
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}

Console.WriteLine($"O Resultado é {resultado}");



