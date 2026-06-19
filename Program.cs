using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeiroProjeto;

class Program {
    static void Main(String[] args) {
        // Tipos de dados para número inteiros
        sbyte tipoSbyte = 10;
        short tipoShort = 10;
        int tipoInt = 10;
        long tipoLong = 10L;

        Console.WriteLine("SByte: " + tipoSbyte);
        Console.WriteLine("Short: " + tipoShort);
        Console.WriteLine("Int: " + tipoInt);
        Console.WriteLine("Long: " + tipoLong);

        // Tipos de dados para números decimais
        double tipoDouble = 10.0;
        float tipoFloat = 10.0F;
        decimal tipoDecimal = 10;

        Console.WriteLine("Double: " + tipoDouble);
        Console.WriteLine("Float: " + tipoFloat);
        Console.WriteLine("Decimal: " + tipoDecimal);

        // Tipo de dados para caracteres
        char tipoChar = 'A';

        Console.WriteLine("Char: " + tipoChar);

        // Tipo de dados booleano
        bool tipoBool = false;

        Console.WriteLine("Bool: " + tipoBool);

        // Tipo de dados para cadeia de caracteres
        string tipoString = "Olá";

        Console.WriteLine("String: " + tipoString);

        // Tipo de dados para objetos de qualquer tipo
        object tipoObject = "Objeto";

        Console.WriteLine("Object: " + tipoObject);

        // Saida de dados

        Console.WriteLine("Hello World!"); // Com quebra de linha no final
        Console.Write("Hello World!");     // Sem quebra de linha no final

        float numero = 5.234F;
        Console.WriteLine("\n" + numero.ToString("F2", CultureInfo.InvariantCulture)); // Imprimindo com 2 casas decimais


        // Placeholder (espaço para variaveis)
        string nome = "Matheus";
        int idade = 24;

        Console.WriteLine("Olá, {0}! Você tem {1} anos", nome, idade); // Tem como formatar casas tbm: {2:F2}

        // Interpolar variaveis diretamente
        Console.WriteLine($"Olá, {nome}! Você tem {idade} anos"); // Tambem é possivel formatar decimais: {valor:F2}



        // Exercicio 01

        string produto1 = "Computador";
        string produto2 = "Mesa de escritorio";

        byte age = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos: ");
        Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
        Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
        Console.WriteLine($"\nRegistro: {age} de idade, código {codigo} e gênero: {genero}");
        Console.WriteLine($"Médida com oito casas decimais {medida:F8}");
        Console.WriteLine($"Arredondado (três casas decimais) {medida:F3}");
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        // Operadores de atribuição

        // =  - Atribuição
        // += - Adiciona ao valor atual
        // -= - Diminuiu do valor atual
        // *= - Multiplica o valor
        // /= - Divide o valor atual
        // %= - Atribuição

        // Operadores aritmeticos / de atribuição
        // ++ - Incrementar 1 ao valor de uma variavel
        // -- - Descrementa 1 ao valor de uma variavel

        // Conversão

        // Implicita quando o compilador converte de um tipo para outro
        float x = 4.3F;
        double y = x;

        Console.WriteLine(y);

        // Casting quando há conversão explicita entre tipos compativeis. (Pode haver perda de dados)
        double a = 5.1;
        float b = (float)a;

        Console.WriteLine(b);

        // Entrada de dados

        string numeroString = Console.ReadLine();

        // Conversão de entrada de dados;
        int numeroInt = int.Parse(numeroString);
        double numeroDouble = double.Parse(numeroString);

        // Regras:
        // 1. Nome de atributos de classe começam com letra maiuscula
        // 2. Nome de métodos de classe começam com letra maiscula
        // 3. Nome de argumentos de métodos começam com letra minuscula

        // IF-ELSE
        int idadePessoa = 18;

        if (idade >= 18) {
            Console.WriteLine("Maior de idade");
        }
        else {
            Console.WriteLine("Menor de idade");
        }

        // While
        int numeroPontos = 5;

        while (numeroPontos > 0) {
            Console.WriteLine("Pontos: " + numeroPontos);
            numeroPontos--;
        }

        // Do-while
        int number = 10;
        do {
            Console.WriteLine(number);
            number--;
        } while (number > 0);

        // FOR
        int total = 10;

        for (int i = 0; i <= total; i++) {
            Console.WriteLine(i);
        }

        // Switch-case
        string cor = "Azul";

        switch (cor) {
            case "Azul":
                Console.WriteLine("Azul");
                break;
            case "Amarelo":
                Console.WriteLine("Amarelo");
                break;
            case "Vermelho":
                Console.WriteLine("Vermelho");
                break;
            default:
                Console.WriteLine("Cor invalida");
                break;
        }

        // foreach
        string[] alimentos = ["Banana", "Maça", "Pera", "Melão"];
        foreach (var item in alimentos) {
            Console.WriteLine("Alimento: " + item);
        }

        // Classe Math

        // Maior dentre dois números
        Math.Max(x, y);

        // Menor dentre dois números
        Math.Min(5, 10);

        // Raiz quadrada de um número
        Math.Sqrt(x);

        // Valor absoluto
        Math.Abs(x);

        // Arrendoda para o inteiro mais próximo
        Math.Round(9.99);


        // Classe string
        string nomeCompleto = "Matheus Henrique";

        // Quantidade de elementos
        int value = nomeCompleto.Length;

        // Maiusculas
        nomeCompleto.ToUpper();

        // Minusculas
        nomeCompleto.ToLower();

        // concatenação
        nomeCompleto.Concat("Teste");

        // Comparação e compração ignorando case
        string nomeCompleto2 = "MATHEUS HENRIQUE";

        string.Equals(nomeCompleto, nomeCompleto2);
        string.Equals(nomeCompleto, nomeCompleto2, StringComparison.OrdinalIgnoreCase);

        // Substituindo e removendo caracteres

        string frase = "Eu amo programação em C#.";

        // Substituir
        string atualizado = frase.Replace("C#", "JavaScript");
        Console.WriteLine(atualizado); // Saída: Eu amo programação em JavaScript.

        // Remover
        string encurtado = frase.Remove(7, 3);
        Console.WriteLine(encurtado); // Saída: Eu amo programação.

        // Dividindo e unindo Strings
        string dados = "maçã,banana,laranja";

        // Dividir
        string[] frutas = dados.Split(',');
        foreach (var fruta in frutas) {
            Console.WriteLine(fruta);
        }

        // Unir
        string unido = string.Join(" | ", frutas);
        Console.WriteLine(unido); // Saída: maçã | banana | laranja

        // StringBuilder para manipulação eficiente
        StringBuilder sb = new StringBuilder();
        sb.Append("Olá");
        sb.Append(", ");
        sb.Append("Mundo!");
        Console.WriteLine(sb.ToString()); // Saída: Olá, Mundo!

        // Substrings e Pesquisa
        string texto = "C# é incrível!";

        // Extrair substring
        string substring = texto.Substring(3, 2);
        Console.WriteLine(substring); // Saída: é

        // Procurar uma substring
        bool contem = texto.Contains("incrível");
        Console.WriteLine(contem); // Saída: True

        int posicao = texto.IndexOf("incrível");
        Console.WriteLine(posicao); // Saída: 5

        // Arrays

        // Criando array
        string[] nomes = { "Matheus", "Davi" };

        // Acessando elementos
        Console.WriteLine(nomes[0]);

        // Mudando valor
        nomes[0] = "Opel";

        // Array Length
        Console.WriteLine(nomes.Length);

        // Sort an Array
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Array.Sort(cars);
        foreach (string i in cars) {
            Console.WriteLine(i);
        }

        // Matriz

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        // Acessar
        Console.WriteLine(numbers[0, 2]);  // Outputs 2

        //Change Elements

        int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
        numbers2[0, 0] = 5;  // Change value to 5
        Console.WriteLine(numbers2[0, 0]); // Outputs 5 instead of 1


        // Membros estaticos

        // Palavra this
        //
        // Diferenciar atributos de variaveis locais
        // Referênciar outro construtor em um construtor
        // Passar o proprio objeto como argumento na chamada de um método ou construtor

        // Ordem de implementação da classe sugerida
        //
        // Atributos privados
        // Propriedade autoimplementadas
        // Construtores
        // Propriedade customizadas (get/set)
        // Outros métodos da classe


        // - Modificadores de acesso -
        //
        // public = propria classe, subclasses no assembly(projeto), classes do assembly(projeto), subclasses e classes fora do assembly(projeto)
        // protected internal = propria classe, subclasses no assembly(projeto), classes do assembly(projeto), subclasses fora do assembly(projeto)
        // internal = propria classe, subclasses no assembly(projeto), classes do assembly(projeto)
        // protected = propria classe, subclasses no assembly(projeto), subclasses fora do assembly(projeto)
        // private protected = propria classe, subclasses no assembly(projeto)
        // private = propria classe


        // Tipos referência vs Tipos valor
        //
        // Classe -> Tipo referência que ao ser criada armazena um espaço na memoria stack e após instanciada aponta para um objeto na memoria heap
        // - Armazenam valor null que não aponta para nada;
        // - Se criarmos dois objetos p1 e p2, instanciarmos e dissermos que p2 = p1, o p2 passa a apontar para o mesmo objeto na memoria heap que p1
        //
        // Structs -> Tipo valor que são armazenados em "caixas" ou "espaço na memoria stack" e não funcionam como ponteiros.
        // - Estão presentes todos os tipos primitivos da linguagem.
        // - Se criarmos duas variaveis p1 e p2, e dissermos que p2 = p1, o p2 faz uma copia do valor de p1.
        // - É possivel criar structs (semelhante a tipos basicos) usando struct nome {} semelhante a criação de uma classe.

        // Nullable
        //
        // Tipos valor não recebem null, pórem é possivel utilizar indicando um nullable
        // Nullable<double> x; ou double? x;
        //
        // Operador de coalescência nula "??" ->  serve para quando se quer atribuir a um tipo valor um valor de outro tipo valor que pode ser nulo
        // Exemplo:
        double? f = null;
        double g = f ?? 0.0; // Se F for null, g recebe 0.0;


        // Vetores
        //
        // Estrutura de dados de mesmo tipo, ordenada (acesso por posição), alocada de uma vez só em bloco contiguo de memoria
        // Tamanho fixo
        //
        int[] numbers3 = { 1, 2, 3, 4 };
        string[] names3 = ["Matheus", "Davi"];
        Funcionario[] funcionarios = new Funcionario[4];

        // Matriz
        //
        // Estrutura de dados de mesmo tipo, ordenada (acesso por posição), alocada de uma vez só em bloco contiguo de memoria
        // Tamanho fixo
        //
        double[,] mat = new double[1, 2];
        // Funções para matriz
        Console.WriteLine(mat.Length); // Mostra a quantidade de elementos
        Console.WriteLine(mat.Rank); // Mostra a quantidade de dimensões desse tipo de array
        Console.WriteLine(mat.GetLength(0)); // Numero de elementos de uma dimensão especifica do array.

        // Teste params
        int result = Program.Sum(1, 2, 3);

        // REF
        //
        // Permite que um método receba uma variável por referência, em vez de receber apenas uma cópia do valor.
        // O método e chamada devem usar ref
        // A variavel deve estar inicializada
        //
        int xx = 10;
        Program.Triple(ref xx);

        // OUT
        //
        // Permite que um método retorne valores através de parâmetros.
        // O método é obrigado a atribuir um valor ao parâmetro antes de terminar sua execução.
        // A variavel não precisa estar inicializada
        //
        int valor;
        ObterNumero(out valor);
        Console.WriteLine(valor);


        // Boxing e unboxing
        //
        // Boxing -> Conversão de um objeto tipo valor para um tipo referência compativel.
        int abc = 20;
        Object obj = abc;
        // Unboxing -> Conversão de um objeto de tipo referência para um de tipo valor compativel. CASTING EXPLICITO OBRIGATORIO
        int y = (int)obj;


        // Listas
        //
        // Estrutura de dados do mesmo tipo
        // Ordenadas (acesso por posição)
        // Inicia vazia, e elementos são alocados sob demanda
        // Cada elemento ocupa um nó
        //
        List<int> list = new List<int>();
        // Inserir elementos (add e insert)
        list.Add(5);
        list.Add(7);
        list.Add(9);
        list.Insert(2, 7); // (posição, valor) ->  Adiciona o elemento em uma posição especifica.
        // Tamanho da lista
        int numCount = list.Count;
        // Encontrar primeiro e ultimo elemento de acordo com um predicado
        list.Find(x => x == 5);
        list.FindLast(x => x == 7);
        // Encontrar primeira ou ultima posição de elemento da lista por predicado
        list.FindIndex(x => x == 9);
        list.FindLastIndex(x => x == 9);
        // Filtrar a lista com base em um predicado OBS: Gera outra lista
        List<int> lista = list.FindAll(x => x >= 10);
        // Remover elementos da lista
        list.Remove(7); //  Remove por elemento;
        list.RemoveAll(x => x < 10); // Remove por função
        list.RemoveAt(2); // Remove por posição
        list.RemoveRange(2, 2); // Remove por grupo -> (A partir de qual posição, remover quantos elementos)

        // Inferência de Tipo(var)
        //
        // Permite declarar uma variável sem informar explicitamente seu tipo. O compilador determina o tipo com base no valor atribuído.
        //
        // Regras:
        //
        // Deve ser inicializada na declaração.
        // Após inferido, o tipo não pode ser alterado.
        // var não significa tipo dinâmico.
        var nome3 = "Matheus";   // string
        var idade3 = 24;         // int
        var salario3 = 2500.50;  // double

        // DateTime
        //
        // Estrutura(struct) que representa uma data e hora em C#.
        //
        // Usos comuns:
        //
        // Obter a data e hora atual.
        // Armazenar datas de nascimento.
        // Calcular diferença entre datas.
        // Formatar datas para exibição.
        DateTime agora = DateTime.Now;
        DateTime hoje = DateTime.Today;
        DateTime aniversario = new DateTime(2001, 10, 15);
        //
        // Principais métodos do DateTime
        //
        // DateTime.Now (Data e hora atuais)
        // DateTime.Today (Data atual com hora zerada)
        // AddDays(n)  (Adiciona dias)
        // AddMonths(n)    Adiciona meses
        // AddYears(n) Adiciona anos
        // AddHours(n) Adiciona horas
        // ToString()  Converte para string
        // Parse() Converte string para DateTime
        // TryParse()  Tenta converter string para DateTime
        //
        // Principais propriedades do DateTime
        //
        // Year Ano
        // Month Mês
        // Day Dia
        // Hour Hora
        // Minute Minuto
        // Second Segundo
        // DayOfWeek Dia da semana
        // DayOfYear Dia do ano
        //
        // Formatação de datas
        //
        // "dd/MM/yyyy"         17 / 06 / 2026
        // "dd/MM/yyyy HH:mm"   17 / 06 / 2026 14:30
        // "yyyy-MM-dd"         2026 - 06 - 17
        // "HH:mm:ss"           14:30:45


        // TimeSpan
        //
        // Estrutura(struct) que representa um intervalo de tempo, ou seja, a diferença entre duas datas ou horários.
        //
        // Usos comuns:
        //
        // Medir duração de uma operação.
        // Calcular idade ou prazo.
        // Representar horas, minutos e segundos.
        TimeSpan tempo = new TimeSpan(1, 30, 0);    // 1 hora, 30 minutos e 0 segundos
        TimeSpan t2 = TimeSpan.FromDays(2);         // 2 dias
        TimeSpan t3 = TimeSpan.FromHours(3.5);      // 3h e meia
        TimeSpan t4 = TimeSpan.FromMinutes(90);     // 90 minutos
        //
        // Principais propriedades do TimeSpan
        // Days             Dias inteiros
        // Hours            Horas
        // Minutes          Minutos
        // Seconds          Segundos
        // TotalDays        Total em dias
        // TotalHours       Total em horas
        // TotalMinutes     Total em minutos
        // TotalSeconds     Total em segundos
        //
        // Obtendo a diferença entre duas datas
        //
        DateTime inicio = DateTime.Now;

        DateTime fim = inicio.AddHours(3);

        TimeSpan diferenca = fim - inicio;

        Console.WriteLine(diferenca.TotalHours); // 3


        // Enumeração(enum)
        // 
        // Tipo especial que representa um conjunto fixo de constantes nomeadas.
        // Classe Selada(sealed class)
        //
        // Uma classe que não pode ser herdada por outras classes.

        // Método Selado(sealed method)
        //
        // Método sobrescrito que não pode ser sobrescrito novamente nas classes filhas.

        // Herança
        //
        // Mecanismo que permite que uma classe herde atributos e métodos de outra classe, promovendo reutilização de código.
        //
        // Usa-se os dois pontos para indicar que uma classe extende de outra(:)

        // Polimorfismo
        //
        // Capacidade de tratar objetos de diferentes classes derivadas como objetos da classe base, executando comportamentos específicos de cada uma.

        // Composição
        //
        // Relacionamento em que uma classe possui objetos de outra classe como parte de sua estrutura.
        //
        // Relação: Carro tem um Motor.

        // Classes Abstratas(abstract class)
        //
        // Uma classe abstrata é uma classe que não pode ser instanciada diretamente e serve como modelo para outras classes.
        //
        // Ela pode conter:
        //
        // Métodos comuns(com implementação).
        // Métodos abstratos(sem implementação).
        // Atributos e propriedades.
        // Construtores.
        //
        // Objetivo: definir características e comportamentos comuns que as classes filhas devem compartilhar.
        //
        // Quando usar classes abstratas?
        // 
        // Quando várias classes possuem características em comum.
        // Quando deseja impedir a criação de objetos da classe base.
        // Quando quer obrigar as classes filhas a implementarem determinados métodos.
        // Quando existe uma relação clara de "é um"(Herança).
        //
        // Exemplo:
        //
        // Veiculo → classe abstrata.
        // Carro, Moto e Caminhao → classes concretas.
        //
        // Todos são veículos, mas cada um implementa seus comportamentos específicos.


        // Tratamento de Exceção
        //
        // Mecanismo utilizado para capturar e tratar erros em tempo de execução, evitando que a aplicação seja encerrada inesperadamente.
        //
        // Objetivos:
        //
        // Tratar erros de forma controlada.
        // Exibir mensagens amigáveis ao usuário.
        // Registrar informações para depuração.
        // Garantir a execução de operações de limpeza.
        //
        // Todas as exceções em .NET herdam da classe Exception.
        //
        // System.Exception
        //
        // Classe base de todas as exceções do .NET.
        //
        // Representa qualquer erro ocorrido na aplicação.
        // Pode ser usada para criar exceções personalizadas, embora não seja a abordagem mais comum.
        // É frequentemente usada no último catch para capturar erros não tratados.
        //
        // ApplicationException
        //
        // Classe criada para servir de base para exceções da aplicação.
        try {
            Console.WriteLine("Executando...");
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message); // Capturando erro
        }
        finally {
            Console.WriteLine("Finalizando operação.");
        }

        // Trabalhando com arquivos
        //
        // File → classe estática, usada para operações rápidas.
        //
        // Exists()         Verifica se o arquivo existe
        // Copy()           Copia um arquivo
        // Move()           Move um arquivo
        // Delete()         Remove um arquivo
        // ReadAllText()    Lê todo o conteúdo
        // ReadAllLines()   Lê todas as linhas
        // WriteAllText()   Escreve texto no arquivo
        // WriteAllLines()  Escreve várias linhas
        // AppendAllText()  Adiciona texto ao final
        //
        // Lendo um arquivo
        string path = @"C:\Users\Matheus\Desktop\Teste.txt";
        if (File.Exists(path)) {
            Console.WriteLine("Arquivo encontrado.");
        }
        string conteudo = File.ReadAllText(path);
        Console.WriteLine(conteudo);
        //
        // Escrevendo um arquivo
        string path2 = @"C:\temp\arquivo.txt";
        File.WriteAllText(path2, "Olá Mundo!");
        //
        // FileInfo → classe baseada em objetos, usada quando se deseja manipular e consultar informações de um arquivo específico.
        //
        // Name             Nome do arquivo
        // FullName         Caminho completo
        // Length           Tamanho em bytes
        // Extension        Extensão
        // DirectoryName    Pasta do arquivo
        // CreationTime     Data de criação
        // LastWriteTime    Última modificação
        // Exists           Verifica existência
        // CopyTo()         Copia o arquivo
        // MoveTo()         Move o arquivo
        // Delete()         Exclui o arquivo
        // Create()         Cria o arquivo
        //
        // Criando um objeto
        string path3 = @"C:\temp\arquivo.txt";
        FileInfo fileInfo = new FileInfo(path3);
        Console.WriteLine(fileInfo.Name);
        Console.WriteLine(fileInfo.Length);
        Console.WriteLine(fileInfo.Extension);
        //
        // Copiando arquivo
        FileInfo origem = new FileInfo(@"C:\temp\arquivo.txt");
        origem.CopyTo(@"C:\backup\arquivo.txt");
        //
        // FileStream
        //
        // Classe utilizada para abrir, criar, ler e escrever arquivos como um fluxo de bytes(stream).
        //
        // path Caminho do arquivo
        // FileMode    Como abrir ou criar o arquivo
        // FileAccess  Permissão de leitura / escrita
        // FileShare Compartilhamento do arquivo
        // Create Cria um novo arquivo
        // CreateNew   Cria somente se não existir
        // Open    Abre um arquivo existente
        // OpenOrCreate Abre ou cria
        // Append Adiciona conteúdo ao final
        // Truncate    Apaga o conteúdo existente
        //
        string path4 = @"C:\temp\arquivo.txt";

        using FileStream fs = new FileStream(
            path,
            FileMode.Open,
            FileAccess.Read);

        Console.WriteLine(fs.Length);
        //
        // StreamReader
        //
        // Classe utilizada para ler arquivos texto(string) de forma eficiente.
        //
        // Read()  Lê um caractere
        // ReadLine()  Lê uma linha
        // ReadToEnd() Lê todo o arquivo
        // Peek()  Visualiza o próximo caractere
        // Close() Fecha o stream
        string path5 = @"C:\temp\arquivo.txt";

        using StreamReader sr = File.OpenText(path);

        string linha;

        while ((linha = sr.ReadLine()) != null) {
            Console.WriteLine(linha);
        }
        //
        // FileStream e StreamReader
        string path6 = @"C:\temp\arquivo.txt";

        using FileStream fs2 = new FileStream(
            path,
            FileMode.Open,
            FileAccess.Read);

        using StreamReader sr2 = new StreamReader(fs);

        string line;

        while ((line = sr.ReadLine()) != null) {
            Console.WriteLine(line);
        }
        //
        // Versão reduzida
        string path7 = @"C:\temp\arquivo.txt";

        using StreamReader sr4 = File.OpenText(path);

        while (!sr4.EndOfStream) {
            string line2 = sr.ReadLine();

            Console.WriteLine(line);
        }
        //
        // using
        //
        // A palavra-chave using garante que o arquivo será fechado automaticamente, mesmo que ocorra uma exceção.
        using StreamReader sr3 =new StreamReader(@"C:\temp\arquivo.txt");

        string texto3 = sr.ReadToEnd();
        //
        // StreamWriter
        //
        // Classe utilizada para escrever texto em arquivos de forma eficiente.
        string path8 = @"C:\temp\arquivo.txt";

        using StreamWriter sw = new StreamWriter(path);

        sw.WriteLine("Olá Mundo!");
        sw.WriteLine("Segunda linha.");
        //
        // Usando FileStream
        string path9 = @"C:\temp\arquivo.txt";

        using FileStream fs3 = new FileStream(
            path,
            FileMode.Create,
            FileAccess.Write);

        using StreamWriter sw2 = new StreamWriter(fs);

        sw.WriteLine("Primeira linha");
        sw.WriteLine("Segunda linha");
        //
        // Versão reduzida usando File
        string path10 = @"C:\temp\arquivo.txt";

        using StreamWriter sw3 = File.AppendText(path);

        sw.WriteLine("Nova linha");
        //
        // Directory
        //
        // Classe estática utilizada para criar, mover, excluir e consultar diretórios(pastas).
        // Como é uma classe estática, não é necessário criar objetos.
        //
        // Principais métodos
        //
        // Exists()                 Verifica se o diretório existe
        // CreateDirectory()        Cria um diretório
        // Delete()                 Remove um diretório
        // Move()                   Move ou renomeia um diretório
        // GetFiles()               Retorna os arquivos
        // GetDirectories()         Retorna os subdiretórios
        // GetCurrentDirectory()    Retorna o diretório atual
        // EnumerateFiles()         Retorna arquivos sob demanda
        // EnumerateDirectories()   Retorna diretórios sob demanda
        //
        // Exemplo: verificar existência
        string path11 = @"C:\temp";

        if (Directory.Exists(path)) {
            Console.WriteLine("Diretório existe.");
        }
        //
        // Exemplo: criar diretório
        string path12 = @"C:\temp\novaPasta";

        Directory.CreateDirectory(path);
        //
        // Se a pasta já existir, nenhuma exceção é lançada.
        //
        // Exemplo: listar arquivos
        string path13 = @"C:\temp";

        string[] files = Directory.GetFiles(path);

        foreach (string file in files) {
            Console.WriteLine(file);
        }
        //
        // Exemplo: listar subdiretórios
        string path14 = @"C:\temp";

        string[] dirs = Directory.GetDirectories(path);

        foreach (string dire in dirs) {
            Console.WriteLine(dire);
        }
        //
        // DirectoryInfo
        //
        // Classe orientada a objetos que representa um diretório específico.
        // Ao contrário de Directory, é necessário criar um objeto.
        //
        // Criando um objeto
        string path25 = @"C:\temp";

        DirectoryInfo dirInfo = new DirectoryInfo(path);
        //
        // Principais propriedades
        //
        // Name             Nome da pasta
        // FullName         Caminho completo
        // Parent           Diretório pai
        // Exists           Verifica se existe
        // CreationTime     Data de criação
        // Root             Diretório raiz
        //
        // Exemplo
        DirectoryInfo dire2 = new DirectoryInfo(@"C:\temp");
        Console.WriteLine(dire2.Name);
        Console.WriteLine(dire2.FullName);
        Console.WriteLine(dire2.Exists);
        //
        // Principais métodos
        //
        // Create()                 Cria o diretório
        // Delete()                 Remove o diretório
        // MoveTo()                 Move ou renomeia
        // GetFiles()               Obtém arquivos
        // GetDirectories()         Obtém subdiretórios
        // CreateSubdirectory()     Cria subdiretório
        //    
        // Exemplo: listar arquivos
        DirectoryInfo dir =
        new DirectoryInfo(@"C:\temp");

        FileInfo[] files2 = dir.GetFiles();

        foreach (FileInfo file in files2) {
            Console.WriteLine(file.Name);

            Console.WriteLine(file.Length);
        }
        //
        // Observe que:
        //
        // Directory.GetFiles() // retorna string[].
        // DirectoryInfo.GetFiles() // retorna FileInfo[].
        //
        // Exemplo: listar subdiretórios
        DirectoryInfo dire3 = new DirectoryInfo(@"C:\temp");

        DirectoryInfo[] dirs2 = dir.GetDirectories();

        foreach (DirectoryInfo d in dirs2) {
            Console.WriteLine(d.Name);
        }
        //
        // Path
        //
        // Classe estática utilizada para manipular caminhos de arquivos e diretórios.
        //
        // Ela não cria, move ou exclui arquivos. Seu objetivo é apenas trabalhar com strings que representam caminhos.
        //
        // Principais métodos
        //
        // Combine()                        Combina partes de um caminho
        // GetFileName()                    Obtém o nome do arquivo
        // GetFileNameWithoutExtension()    Obtém o nome sem extensão
        // GetExtension()                   Obtém a extensão
        // GetDirectoryName()               Obtém a pasta do arquivo
        // GetFullPath()                    Obtém o caminho absoluto
        // GetTempPath()                    Obtém a pasta temporária do sistema
        // GetTempFileName()                Cria um nome de arquivo temporário
        // HasExtension()                   Verifica se o arquivo possui extensão
        // ChangeExtension()                Altera a extensão
        //
        // Combina partes de um caminho, inserindo os separadores corretamente.
        string path16 = Path.Combine(@"C:\temp", "arquivos", "dados.txt");
        Console.WriteLine(path);
        // Saída: C:\temp\arquivos\dados.txt
        //
        // Obtém apenas o nome do arquivo.
        //
        string path17 = @"C:\temp\arquivo.txt";
        string nome10 = Path.GetFileName(path);
        Console.WriteLine(nome);
        // Saída: arquivo.txt
        // 
        // Obtém o nome sem a extensão.
        //
        string nome11 = Path.GetFileNameWithoutExtension(@"C:\temp\arquivo.txt");
        Console.WriteLine(nome);
        //
        //Saída: arquivo
        //
        // Obtém a extensão do arquivo.
        //
        string ext = Path.GetExtension(@"C:\temp\arquivo.txt");
        Console.WriteLine(ext);
        //
        // Saída:.txt
        //
        // Obtém apenas o diretório do arquivo.
        //
        string dir5 = Path.GetDirectoryName(@"C:\temp\arquivo.txt");
        Console.WriteLine(dir);
        // Saída: C:\temp
        //
        // Converte um caminho relativo em absoluto.
        //
        string path18 = Path.GetFullPath("arquivo.txt");
        Console.WriteLine(path);
        //
        // Saída: C: \Users\Matheus\Projeto\arquivo.txt
        //
        // Obtém a pasta temporária do sistema operacional.
        string temp = Path.GetTempPath();
        Console.WriteLine(temp);
        //
        // Saída: C: \Users\Matheus\AppData\Local\Temp\
        //
        // Cria e retorna um arquivo temporário.
        string file = Path.GetTempFileName();
        Console.WriteLine(file);
        //
        // Saída: C: \Users\Matheus\AppData\Local\Temp\tmp1234.tmp
        //
        // Verifica se o caminho possui extensão.
        //
        bool possuiExt = Path.HasExtension(@"C:\temp\arquivo.txt");
        Console.WriteLine(possuiExt);
        //
        // Saída: True
        //
        // Altera a extensão do arquivo.
        //
        string novoNome = Path.ChangeExtension(@"C:\temp\arquivo.txt", ".pdf");
        Console.WriteLine(novoNome);
        //
        // Saída: C:\temp\arquivo.pdf
    }
}
    // Exceção personalizada
    public class SaldoInsuficienteException : ApplicationException { // Microsoft recomenda herdar de Exception
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem) {
        }
    }

    // Classe abstrata e método abstrato
    public abstract class Forma {
        public abstract double CalcularArea();
    }
    // O método CalcularArea() não possui implementação.
    // Toda classe que herdar Forma deve implementar esse método.
    //
    // Classe derivada
    public class Circulo : Forma {
        public double Raio { get; set; }

        public override double CalcularArea() {
            return Math.PI * Raio * Raio;
        }
    }
    // Método abstrato (abstract)
    //
    // É um método sem corpo, declarado em uma classe abstrata, que obriga as classes derivadas a fornecerem sua implementação.
    //
    public abstract class Animal {
        public abstract void EmitirSom();
    }

    public class Cachorro : Animal {
        public override void EmitirSom() {
            Console.WriteLine("Au au");
        }
    }

    // Composição
    public class Motor { }

    public class Carro {
        public Motor Motor { get; set; }
    }

    // Classe selada
    public sealed class Cliente 
    {
    }

    // Método selado
    public class A {
        public virtual void Metodo() { }
    }

    public class B : A {
        public sealed override void Metodo() { }
    }

    // Herança
    public class Animal { }

    public class Cachorro : Animal { }

    // Polimorfismo
    // Animal animal = new Cachorro();
    // animal.EmitirSom();

    // Enum
    enum StatusPedido : int {
        Pendente = 0,
        Pago = 1,
        Cancelado = 2
    }

    // Composição
    //
    // Relacionamento em que uma classe possui objetos de outra classe como parte de sua estrutura.

    // Params
    //
    // Usado como argumento de métodos para indicar que o método pode receber diversos parametros
    public static int Sum(params int[] numbers) {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++) {
            sum += numbers[i];
        }
        return sum;
    }

    // Teste ref
    public static void Triple(ref int xx) {
        xx *= 3;
    }

    // Teste out
    public static void ObterNumero(out int numero) {
        numero = 10;
    }

    // Classe, atributos e métodos
    class Funcionario {
        public string Nome;
        public int Idade;
        public bool Ativo;

        // Construtor
        public Funcionario() {
            Ativo = true;
        }

        // Sobrecarga
        public Funcionario(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        // Sobrecarga + uso do this para usar construtor dentro de construtor
        public Funcionario(string nome) : this() {
            Nome = nome;
        }

        public string ImprimirFuncionario() {
            return "Funcionario: " + Nome + " - Idade: " + Idade;
        }

        // tostring
        public override string ToString() {
            return "Nome: " + Nome + " - Idade: " + Idade;
        }
    }

    class FuncionarEncapsulado {
        private string _nome;
        private int _idade;
        private bool _ativo;

        public FuncionarEncapsulado(string nome, int idade, bool ativo) {
            _nome = nome;
            _idade = idade;
            _ativo = ativo;
        }

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            _nome = nome;
        }

        public int GetIdade() {
            return _idade;
        }

        public void SetIdade(int idade) {
            _idade = idade;
        }

        public bool GetAtivo() {
            return _ativo;
        }

        public void SetAtivo(bool ativo) {
            _ativo = ativo;
        }

        class FuncionarEncapsuladoProperties {
            private string _nome;
            private int _idade;
            private bool _ativo;

            public FuncionarEncapsuladoProperties(string nome, int idade, bool ativo) {
                _nome = nome;
                _idade = idade;
                _ativo = ativo;
            }

            //properties OBS: sem ()
            public string Nome {
                get { return _nome; }
                set { _nome = value; }
            }

            public int Idade {
                get => _idade;
                set => _idade = value;
            }

            public bool Ativo {
                get { return _ativo; }
                set { _ativo = value; }
            }
        }

        class FuncionarEncapsuladoAutoProperties {
            // Autoproperties
            public string Nome { get; set; }
            public int Idade { get; set; }
            public bool Ativo { get; private set; }

            public FuncionarEncapsuladoAutoProperties(string nome, int idade, bool ativo) {
                Nome = nome;
                Idade = idade;
                Ativo = ativo;
            }
        }
    }
}

