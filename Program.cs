using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections.Generic;

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
    }

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

