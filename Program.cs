
bool continuar = true;

do
{
    Console.WriteLine("Calculadora de IMC e Faixa Etária");
    Console.WriteLine("----------------------------------");

    // Solicitar nome da pessoa
    Console.Write("Digite o nome da pessoa: ");
    string nome = Console.ReadLine();

    // Solicitar idade
    Console.Write("Digite a idade da pessoa: ");
    int idade = int.Parse(Console.ReadLine());

    // Solicitar altura em centímetros e converter para metros
    Console.Write("Digite a altura da pessoa em centímetros: ");
    double alturaCentimetros = double.Parse(Console.ReadLine());
    double alturaMetros = alturaCentimetros / 100.0;

    // Solicitar peso em quilogramas
    Console.Write("Digite o peso da pessoa em quilogramas: ");
    double peso = double.Parse(Console.ReadLine());

    // Calcular o IMC
    double imc = peso / (alturaMetros * alturaMetros);

    // Determinar a categoria de IMC
    string categoriaIMC = "";
    if (imc < 18.5)
        categoriaIMC = "Abaixo do peso";
    else if (imc < 24.9)
        categoriaIMC = "Normal";
    else if (imc < 29.9)
        categoriaIMC = "Sobrepeso";
    else
        categoriaIMC = "Obeso";

    // Determinar a faixa etária
    string faixaEtaria = "";
    if (idade < 12)
        faixaEtaria = "Criança";
    else if (idade < 20)
        faixaEtaria = "Adolescente";
    else if (idade < 60)
        faixaEtaria = "Adulto";
    else
        faixaEtaria = "Idoso";

    // Gerar relatório
    Console.WriteLine("\nRelatório:");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade: " + idade + " anos");
    Console.WriteLine("Altura: " + alturaCentimetros + " cm");
    Console.WriteLine("Peso: " + peso + " kg");
    Console.WriteLine("IMC: " + imc.ToString("0.00"));
    Console.WriteLine("Categoria de IMC: " + categoriaIMC);
    Console.WriteLine("Faixa Etária: " + faixaEtaria);

    // Perguntar ao usuário se deseja continuar
    Console.Write("\nDeseja gerar um novo relatório? (S/N): ");
    string resposta = Console.ReadLine().ToUpper();
    continuar = (resposta == "S");

} while (continuar);

Console.WriteLine("Programa encerrado. Obrigado!");
