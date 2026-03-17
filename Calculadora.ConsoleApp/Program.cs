// Objetivos / Passo-a-Passo

// V1
// 1. Nossa calculadora deve ter a possibilidade de somar dois números - OK
// 2. Nossa calculadora deve ter a possibilidade de subtrair dois números - OK
// 3. Nossa calculadora deve ter a possibilidade de multiplicar dois números - OK
// 4. Nossa calculadora deve ter a possibilidade de dividir dois números - OK
// 5. Nossa calculadora deve ter a possibilidade de executador opeção em continuidade - OK

//V2
// 1. Nossa calculadora deve produzir a tabuada de um número informado. - OK
// 2. Nossa calculadora deve conter um Histórico de Operações. - OK

using System.Dynamic;

//Array
string[] historicoOperacoes = new string[100]; // 0[] 1[] 2[]...
int contadorOperacoes = 0;


while (true == true)
{
    Console.Clear();

    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de Operações");
    Console.WriteLine("S - Sair");
    Console.WriteLine("------------------------------------------------");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Escolha Uma Opção Válida!");
        Console.WriteLine("------------------------------------------------");

        Console.Write("Aperte ENTER Para Continuar...");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("------------------------------------------------");
        Console.Write("Digite Um Número Inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        Console.Write("Digite o Multiplicador Máximo da Tabuada: ");
        int multiplicadorMaximoTabuada = Convert.ToInt32(Console.ReadLine());


        for (int iterador = 1; iterador <= multiplicadorMaximoTabuada; iterador = iterador + 1)
        {
            Console.WriteLine("------------------------------------------------");
            string linhaTabuada = $"{numeroDigitado} X {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(linhaTabuada);
        }

        Console.WriteLine("------------------------------------------------");
        Console.Write("Aperte ENTER Para Continuar...");
        Console.ReadLine();
        continue;
    }

    if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Historico de Operações");
        Console.WriteLine("------------------------------------------------");

        for (int iterador = 0; iterador < historicoOperacoes.Length; iterador++)

        {
            if (historicoOperacoes[iterador] != null)
                Console.WriteLine(historicoOperacoes[iterador]);
        }

        Console.WriteLine("------------------------------------------------");
        Console.Write("Aperte ENTER Para Continuar...");
        Console.ReadLine();
        continue;
    }
    Console.Write("Digite o Primeiro Número: ");
    string strPrimeiroNumero = Console.ReadLine(); // Texto - Character String - Cadeia de Caracteres.
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero); // Número Inteiro, Não Aplicável Para Número Quebrado.

    Console.Write("Digite o Segundo Número: ");
    String strSegundoNumero = Console.ReadLine();
    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;
    string textoOperacao;

    // Estrutura de Decisão.

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }
    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }
    else
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++; // contadorOperacoes + 1
    }
    else
    {
        historicoOperacoes = new string[100];
        contadorOperacoes = 0;

        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++;
    }

    Console.WriteLine("O Resultado é: " + resultado);
    Console.WriteLine();
    Console.WriteLine("------------------------------------------------");
    Console.Write("Aperte ENTER Para Continuar...");
    Console.ReadLine();
}