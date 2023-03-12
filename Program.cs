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
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Segundo valor: ");
    double v2 = Convert.ToDouble(Console.ReadLine());

    double resultado = v1 + v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da soma é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Segundo valor: ");
    double v2 = Convert.ToDouble(Console.ReadLine());

    double resultado = v1 - v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Segundo valor: ");
    double v2 = Convert.ToDouble(Console.ReadLine());

    double resultado = v1 / v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da divisão é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    double v1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Segundo valor: ");
    double v2 = Convert.ToDouble(Console.ReadLine());

    double resultado = v1 * v2;
    Console.WriteLine(" ");
    Console.WriteLine($"Resultado da multiplicação é: {resultado}");
    Console.ReadKey();
    Menu();
}
