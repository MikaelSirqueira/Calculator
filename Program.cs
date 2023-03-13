// See https://aka.ms/new-console-template for more information

Menu();


static void Menu(){
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("---------------------");
    Console.WriteLine("Selecione uma opção: ");
    short numSelecionado = Convert.ToInt16(Console.ReadLine());

    switch(numSelecionado) {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.ESoma);

    Console.WriteLine("Segundo valor: ");
    double v2 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.ESoma);

    double resultado = v1 + v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da soma é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao() {
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    double v1 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.ESubtracao);

    Console.WriteLine("Segundo valor: ");
    double v2 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.ESubtracao);

    double resultado = v1 - v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.EDivisao);

    Console.WriteLine("Segundo valor: ");
    double v2 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.EDivisao);

    double resultado = v1 / v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da divisão é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.EMultiplicacao);

    Console.WriteLine("Segundo valor: ");
    double v2 = ValidarEntradaNumerica(Console.ReadLine(), Operadores.EMultiplicacao);

    double resultado = v1 * v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da multiplicação é: {resultado}");
    Console.ReadKey();
    Menu();
}

static double ValidarEntradaNumerica(string? valor, Operadores origem){
    double valorResultado;
    if (!double.TryParse(valor, out valorResultado)){

        switch(origem) {
            case Operadores.ESoma: 
                Soma(); break;
            case Operadores.ESubtracao: 
                Subtracao(); break;
            case Operadores.EDivisao: 
                Divisao(); break;
            case Operadores.EMultiplicacao: 
                Multiplicacao(); break;
            default: Menu(); break;
        }

    }    
    return valorResultado;
}

enum Operadores{
    ESoma=1,
    ESubtracao=2,
    EMultiplicacao=3,
    EDivisao=4
}