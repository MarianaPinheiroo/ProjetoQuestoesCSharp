using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ProjetoQuestoesCSharp
{
    public class Questoes
    {
        public void ExecutarQuestao(int numeroQuestao)
        {
            switch (numeroQuestao)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Questao3();
                    break;
                case 4:
                    Questao4();
                    break;
                case 5:
                    Questao5();
                    break;
                case 6:
                    Questao6();
                    break;
                case 7:
                    Questao7();
                    break;
                case 8:
                    Questao8();
                    break;
                case 9:
                    Questao9();
                    break;
                case 10:
                    Questao10();
                    break;
                case 11:
                    Questao11();
                    break;
                case 12:
                    Questao12();
                    break;
                case 13:
                    Questao13();
                    break;
                case 14:
                    Questao14();
                    break;
                case 15:
                    Questao15();
                    break;
                case 16:
                    Questao16();
                    break;
                case 17:
                    Questao17();
                    break;
                case 18:
                    Questao18();
                    break;
                case 19:
                    Questao19();
                    break;
                case 20:
                    Questao20();
                    break;
                case 21:
                    Questao21();
                    break;
                case 22:
                    Questao22();
                    break;
                case 23:
                    Questao23();
                    break;
                case 24:
                    Questao24();
                    break;
                case 25:
                    Questao25();
                    break;
                case 26:
                    Questao26();
                    break;
                case 27:
                    Questao27();
                    break;
                case 28:
                    Questao28();
                    break;
                case 29:
                    Questao29();
                    break;
                case 30:
                    Questao30();
                    break;
                case 31:
                    Questao31();
                    break;
                case 32:
                    Questao32();
                    break;
                case 33:
                    Questao33();
                    break;
                case 34:
                    Questao34();
                    break;
                case 35:
                    Questao35();
                    break;
                case 36:
                    Questao36();
                    break;
                case 37:
                    Questao37();
                    break;
                case 38:
                    Questao38();
                    break;
                case 39:
                    Questao39();
                    break;
                case 40:
                    Questao40();
                    break;
                case 41:
                    Questao41();
                    break;
                case 42:
                    Questao42();
                    break;
                case 43:
                    Questao43();
                    break;
                case 44:
                    Questao44();
                    break;
                case 45:
                    Questao45();
                    break;
                case 46:
                    Questao46();
                    break;
                case 47:
                    Questao47();
                    break;
                case 48:
                    Questao48();
                    break;
                case 49:
                    Questao49();
                    break;
                case 50:
                    Questao50();
                    break;
                case 51:
                    Questao51();
                    break;
                case 52:
                    Questao52();
                    break;
                case 53:
                    Questao53();
                    break;
                case 54:
                    Questao54();
                    break;
                case 55:
                    Questao55();
                    break;
                case 56:
                    Questao56();
                    break;
                case 57:
                    Questao57();
                    break;
                case 58:
                    Questao58();
                    break;
                case 59:
                    Questao59();
                    break;
                case 60:
                    Questao60();
                    break;
                case 61:
                    Questao61();
                    break;
                case 62:
                    Questao62();
                    break;
                case 63:
                    Questao63();
                    break;
                case 64:
                    Questao64();
                    break;
                case 65:
                    Questao65();
                    break;
                case 66:
                    Questao66();
                    break;
                case 67:
                    Questao67();
                    break;
                case 68:
                    Questao68();
                    break;
                case 69:
                    Questao69();
                    break;
                case 70:
                    Questao70();
                    break;
                case 71:
                    Questao71();
                    break;
                case 72:
                    Questao72();
                    break;
                case 73:
                    Questao73();
                    break;
                case 74:
                    Questao74();
                    break;
                case 75:
                    Questao75();
                    break;
                case 76:
                    Questao76();
                    break;
                case 77:
                    Questao77();
                    break;
                case 78:
                    Questao78();
                    break;
                case 79:
                    Questao79();
                    break;
                case 80:
                    Questao80();
                    break;
                case 81:
                    Questao81();
                    break;
                case 82:
                    Questao82();
                    break;
                case 83:
                    Questao83();
                    break;
                case 84:
                    Questao84();
                    break;
                case 85:
                    Questao85();
                    break;
                case 86:
                    Questao86();
                    break;
                case 87:
                    Questao87();
                    break;
                case 88:
                    Questao88();
                    break;
                case 89:
                    Questao89();
                    break;
                case 90:
                    Questao90();
                    break;
                case 91:
                    Questao91();
                    break;
                case 92:
                    Questao92();
                    break;
                case 93:
                    Questao93();
                    break;
                case 94:
                    Questao94();
                    break;
                case 95:
                    Questao95();
                    break;
                case 96:
                    Questao96();
                    break;
                case 97:
                    Questao97();
                    break;
                case 98:
                    Questao98();
                    break;
                case 99:
                    Questao99();
                    break;
                case 100:
                    Questao100();
                    break;
                default:
                    Console.WriteLine("Questão não encontrada.");
                    break;
            }
        }

        private void ExibirQuestao(int numero)
        {
            Console.WriteLine($"=== Questão {numero} ===");
        }

        private string LerString(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        private double LerDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }

        private int LerInt(string mensagem)
        {
            Console.Write(mensagem);
            return int.Parse(Console.ReadLine());
        }

        private void Questao1()
        {
            ExibirQuestao(1);
            string nome = LerString("Por favor, digite o nome do produto: ");
            double preco = LerDouble("Agora, digite o preço do produto: ");
            Console.WriteLine($"Produto: {nome}, Preço: {preco}");
        }

        private void Questao2()
        {
            ExibirQuestao(2);
            string nome = LerString("Digite o nome do produto: ");
            double preco = LerDouble("Digite o preço do produto: ");
            Console.WriteLine($"Nome: {nome}, Preço: {preco}");
        }

        private void Questao3()
        {
            ExibirQuestao(3);
            int num1 = LerInt("Digite o primeiro número: ");
            int num2 = LerInt("Digite o segundo número: ");
            int soma = num1 + num2;
            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
        }

        private void Questao4()
        {
            ExibirQuestao(4);
            int numero = LerInt("Digite um número: ");
            string resultado = numero % 2 == 0 ? "par" : "ímpar";
            Console.WriteLine($"O número {numero} é {resultado}.");
        }

        private void Questao5()
        {
            ExibirQuestao(5);
            double metros = LerDouble("Digite o valor em metros: ");
            double centimetros = metros * 100;
            Console.WriteLine($"{metros} metros são {centimetros} centímetros.");
        }

        private void Questao6()
        {
            ExibirQuestao(6);
            int idade = LerInt("Digite a idade: ");
            Console.WriteLine(idade >= 18 ? "A pessoa é maior de idade." : "A pessoa é menor de idade.");
        }

        private void Questao7()
        {
            ExibirQuestao(7);
            double raio = LerDouble("Digite o raio do círculo: ");
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do círculo é: {area:F2}");
        }

        private void Questao8()
        {
            ExibirQuestao(8);
            int numero = LerInt("Digite um número para exibir sua tabuada: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        private void Questao9()
        {
            ExibirQuestao(9);
            int n = LerInt("Digite um número para calcular a soma de 1 até ele: ");
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma de 1 até {n} é: {soma}");
        }

        private void Questao10()
        {
            ExibirQuestao(10);
            double celsius = LerDouble("Digite a temperatura em Celsius: ");
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C em Fahrenheit é: {fahrenheit}°F");
        }

        private void Questao11()
        {
            ExibirQuestao(11);
            string texto = LerString("Digite uma string: ");
            Console.WriteLine(string.IsNullOrEmpty(texto) ? "A string é vazia ou nula." : "A string contém texto.");
        }

        private void Questao12()
        {
            ExibirQuestao(12);
            Console.WriteLine("Números pares entre 1 e 50:");
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        private void Questao13()
        {
            ExibirQuestao(13);
            int num1 = LerInt("Digite o primeiro número: ");
            int num2 = LerInt("Digite o segundo número: ");
            int num3 = LerInt("Digite o terceiro número: ");
            int maior = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"O maior número é: {maior}");
        }

        private void Questao14()
        {
            ExibirQuestao(14);
            string texto = LerString("Digite uma string: ");
            char[] charArray = texto.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("String invertida: " + new string(charArray));
        }

        private void Questao15()
        {
            ExibirQuestao(15);
            int anoNascimento = LerInt("Digite o ano de nascimento: ");
            int idade = DateTime.Now.Year - anoNascimento;
            Console.WriteLine(idade >= 18 ? "A pessoa pode votar." : "A pessoa não pode votar.");
        }

        private void Questao16()
        {
            ExibirQuestao(16);
            int numero = LerInt("Digite um número: ");
            Console.WriteLine(numero >= 0 ? "O número é positivo." : "O número é negativo.");
        }

        private void Questao17()
        {
            ExibirQuestao(17);
            double nota1 = LerDouble("Digite a primeira nota: ");
            double nota2 = LerDouble("Digite a segunda nota: ");
            double nota3 = LerDouble("Digite a terceira nota: ");
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine(media >= 7.0 ? "Aprovado" : "Reprovado");
        }

        private void Questao18()
        {
            ExibirQuestao(18);
            string texto = LerString("Digite uma string: ");
            int count = texto.Count(c => c == 'a' || c == 'A');
            Console.WriteLine($"A letra 'a' aparece {count} vezes.");
        }

        private void Questao19()
        {
            ExibirQuestao(19);
            Console.WriteLine("Números de 10 a 1:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        private void Questao20()
        {
            ExibirQuestao(20);
            int n = LerInt("Digite um número: ");
            int somaQuadrados = 0;
            for (int i = 1; i <= n; i++)
            {
                somaQuadrados += i * i;
            }
            Console.WriteLine($"A soma dos quadrados de 1 até {n} é: {somaQuadrados}");
        }

        private void Questao21()
        {
            ExibirQuestao(21);
            string nome = LerString("Digite seu nome: ");
            int idade = LerInt("Digite sua idade: ");
            Console.WriteLine($"Bem-vindo, {nome}, você tem {idade} anos!");
        }

        private void Questao22()
        {
            ExibirQuestao(22);
            int numero = LerInt("Digite um número: ");
            Console.WriteLine($"Dobro: {numero * 2}");
            Console.WriteLine($"Triplo: {numero * 3}");
        }

        private void Questao23()
        {
            ExibirQuestao(23);
            string texto = LerString("Digite uma string: ");
            Console.WriteLine(!string.IsNullOrEmpty(texto) ? $"Último caractere: {texto[^1]}" : "A string está vazia.");
        }

        private void Questao24()
        {
            ExibirQuestao(24);
            int horas = LerInt("Digite o número de horas: ");
            int segundos = horas * 3600;
            Console.WriteLine($"{horas} horas são {segundos} segundos.");
        }

        private void Questao25()
        {
            ExibirQuestao(25);
            int numero = LerInt("Digite um número: ");
            Console.WriteLine(numero % 3 == 0 && numero % 5 == 0 ? "O número é divisível por 3 e por 5." : "O número não é divisível por 3 e por 5.");
        }

        private void Questao26()
        {
            ExibirQuestao(26);
            int num1 = LerInt("Digite o primeiro número: ");
            int num2 = LerInt("Digite o segundo número: ");
            int num3 = LerInt("Digite o terceiro número: ");

            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);
            Console.WriteLine($"Números ordenados: {string.Join(", ", numeros)}");
        }

        private void Questao27()
        {
            ExibirQuestao(27);
            int numero = LerInt("Digite um número para calcular o fatorial: ");
            int fatorial = 1;
            for (int i = 2; i <= numero; i++)
                fatorial *= i;
            Console.WriteLine($"Fatorial de {numero} é: {fatorial}");
        }

        public class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            public void Exibir()
            {
                Console.WriteLine($"Nome do Aluno: {Nome}, Nota: {Nota}");
            }
        }

        private void Questao28()
        {
            ExibirQuestao(28);
            string nome = LerString("Digite o nome do aluno: ");
            double nota = LerDouble("Digite a nota do aluno: ");

            Aluno aluno = new Aluno { Nome = nome, Nota = nota };
            aluno.Exibir();
        }

        private void Questao29()
        {
            ExibirQuestao(29);
            int quantidade = LerInt("Digite a quantidade de números na lista: ");
            List<double> numeros = new List<double>();
            for (int i = 0; i < quantidade; i++)
            {
                double numero = LerDouble($"Digite o número {i + 1}: ");
                numeros.Add(numero);
            }
            double media = numeros.Average();
            Console.WriteLine($"A média dos números é: {media}");
        }

        private void Questao30()
        {
            ExibirQuestao(30);
            string palavra = LerString("Digite uma palavra: ");
            string inversa = new string(palavra.Reverse().ToArray());
            Console.WriteLine(palavra.Equals(inversa, StringComparison.OrdinalIgnoreCase) ? "É um palíndromo." : "Não é um palíndromo.");
        }

        private void Questao31()
        {
            ExibirQuestao(31);
            int quantidade = LerInt("Digite a quantidade de números no array: ");
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                numeros[i] = LerInt($"Digite o número {i + 1}: ");
            }

            int menor = numeros.Min();
            Console.WriteLine($"O menor número do array é: {menor}");
        }

        private void Questao32()
        {
            ExibirQuestao(32);
            int[] array = { 2, 4, 6, 8 };
            int multiplicador = LerInt("Digite um valor para multiplicar os elementos: ");
            for (int i = 0; i < array.Length; i++)
                array[i] *= multiplicador;
            Console.WriteLine("Array multiplicado: " + string.Join(", ", array));
        }

        private void Questao33()
        {
            ExibirQuestao(33);
            int quantidade = LerInt("Digite a quantidade de números no array: ");
            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                array[i] = LerInt($"Digite o número {i + 1}: ");
            }

            int somaImpares = array.Where(num => num % 2 != 0).Sum();
            Console.WriteLine($"A soma dos números ímpares no array é: {somaImpares}");
        }

        public class Carro
        {
            public string Marca { get; set; }
            public int Ano { get; set; }
        }

        private void Questao34()
        {
            ExibirQuestao(34);
            string marca = LerString("Digite a marca do carro: ");
            int ano = LerInt("Digite o ano do carro: ");

            Carro carro = new Carro { Marca = marca, Ano = ano };
            Console.WriteLine($"Carro: {carro.Marca}, Ano: {carro.Ano}");
        }

        private void Questao35()
        {
            ExibirQuestao(35);
            int ano = LerInt("Digite um ano: ");
            bool isBissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
            Console.WriteLine(isBissexto ? "Ano bissexto." : "Ano não é bissexto.");
        }

        private void Questao36()
        {
            ExibirQuestao(36);
            int a = 0, b = 1, c;
            Console.Write("Sequência de Fibonacci: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        private void Questao37()
        {
            ExibirQuestao(37);
            string texto = LerString("Digite uma string: ");
            string substituida = texto.Replace(" ", "_");
            Console.WriteLine("Texto com espaços substituídos: " + substituida);
        }

        private void Questao38()
        {
            ExibirQuestao(38);
            int quantidade = LerInt("Digite a quantidade de números no array: ");
            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                array[i] = LerInt($"Digite o número {i + 1}: ");
            }

            int indiceMaior = Array.IndexOf(array, array.Max());
            Console.WriteLine($"O índice do maior elemento é: {indiceMaior}");
        }

        private void Questao39()
        {
            ExibirQuestao(39);
            int num1 = LerInt("Digite o primeiro número: ");
            int num2 = LerInt("Digite o segundo número: ");

            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            Console.WriteLine($"MDC é: {num1}");
        }

        private void Questao40()
        {
            ExibirQuestao(40);
            string texto = LerString("Digite uma string: ");
            int numVogais = texto.Count(c => "aeiouAEIOU".Contains(c));
            Console.WriteLine($"Número de vogais na string: {numVogais}");
        }

        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome)
            {
                Nome = nome;
            }

            public void Falar()
            {
                Console.WriteLine($"Olá, meu nome é {Nome}!");
            }
        }
        private void Questao41()
        {
            Console.WriteLine("=== Questão 41 ===");
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine($"Representação binária: {binario}");
        }

        private void Questao42()
        {
            Console.WriteLine("=== Questão 42 ===");
            Console.Write("Digite um número entre 0 e 9: ");
            int numero = int.Parse(Console.ReadLine());
            string[] palavras = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            Console.WriteLine(numero >= 0 && numero <= 9 ? palavras[numero] : "Número fora do intervalo.");
        }

        private void Questao43()
        {
            Console.WriteLine("=== Questão 43 ===");
            Random random = new Random();
            int[] frequencia = new int[6];

            for (int i = 0; i < 100; i++)
                frequencia[random.Next(1, 7) - 1]++;

            Console.WriteLine("O dado foi girado 100 vezes:");
            for (int i = 0; i < frequencia.Length; i++)
                Console.WriteLine($"Número {i + 1} apareceu {frequencia[i]} vezes");
        }

        private void Questao44()
        {
            Console.WriteLine("=== Questão 44 ===");
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            string categoria = imc < 18.5 ? "Baixo peso" :
                               imc < 24.9 ? "Peso normal" :
                               imc < 29.9 ? "Sobrepeso" :
                               "Obesidade";
            Console.WriteLine($"IMC: {imc:F2} - Categoria: {categoria}");
        }

        private void Questao45()
        {
            Console.WriteLine("=== Questão 45 ===");
            Console.Write("Digite a quantidade de números no array: ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array.Max();
            int segundoMaior = array.Where(num => num != max).Max();
            Console.WriteLine($"O segundo maior número é: {segundoMaior}");
        }

        private void Questao46()
        {
            Console.WriteLine("=== Questão 46 ===");
            Console.Write("Digite a quantidade de elementos no array: ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] array = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(array);
            Console.WriteLine("Array invertido: " + string.Join(", ", array));
        }

        private void Questao47()
        {
            Console.WriteLine("=== Questão 47 ===");
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] soma = new int[2, 2];

            Console.WriteLine("Digite os valores da primeira matriz 2x2:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    matrizA[i, j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores da segunda matriz 2x2:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    matrizB[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    soma[i, j] = matrizA[i, j] + matrizB[i, j];

            Console.WriteLine("Soma das matrizes:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(soma[i, j] + " ");
                Console.WriteLine();
            }
        }

        private void Questao48()
        {
            Console.WriteLine("=== Questão 48 ===");
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Dia da semana: {data.DayOfWeek}");
        }

        private void Questao49()
        {
            Console.WriteLine("=== Questão 49 ===");
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
            bool somenteLetrasNumeros = input.All(char.IsLetterOrDigit);
            Console.WriteLine(somenteLetrasNumeros ? "A string contém apenas letras e números." : "A string contém outros caracteres.");
        }

        private void Questao50()
        {
            Console.WriteLine("=== Questão 50 ===");
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 0; i < expoente; i++)
                resultado *= baseNum;

            Console.WriteLine($"Resultado: {resultado}");
        }

        private void Questao51()
        {
            Console.WriteLine("=== Questão 51 ===");
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Digite os valores da matriz 3x3:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matriz[i, j] = int.Parse(Console.ReadLine());

            bool simetrica = true;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] != matriz[j, i]) simetrica = false;

            Console.WriteLine(simetrica ? "A matriz é simétrica" : "A matriz não é simétrica");
        }

        private void Questao52()
        {
            Console.WriteLine("=== Questão 52 ===");
            Console.WriteLine("Digite uma lista de nomes separados por vírgula:");
            List<string> nomes = Console.ReadLine().Split(',').Select(n => n.Trim()).ToList();
            nomes.Sort();
            Console.WriteLine("Nomes ordenados: " + string.Join(", ", nomes));
        }

        private void Questao53()
        {
            Console.WriteLine("=== Questão 53 ===");
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int frequente = array.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine("Elemento mais frequente: " + frequente);
        }

        private void Questao54()
        {
            Console.WriteLine("=== Questão 54 ===");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int valorAbsoluto = numero < 0 ? -numero : numero;
            Console.WriteLine("Valor absoluto: " + valorAbsoluto);
        }

        private void Questao55()
        {
            Console.WriteLine("=== Questão 55 ===");
            Console.WriteLine("Digite uma lista de números separados por vírgula:");
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write("Digite o número a ser encontrado: ");
            int valor = int.Parse(Console.ReadLine());
            int indice = Array.IndexOf(array, valor);
            Console.WriteLine(indice >= 0 ? $"Valor encontrado no índice {indice}" : "Valor não encontrado");
        }

        private void Questao56()
        {
            Console.WriteLine("=== Questão 56 ===");
            Console.WriteLine("Cronômetro iniciado...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + " segundo(s)");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Cronômetro encerrado.");
        }

        private void Questao57()
        {
            Console.WriteLine("=== Questão 57 ===");
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int palavras = frase.Split(' ').Length;
            Console.WriteLine("Número de palavras: " + palavras);
        }

        private void Questao58()
        {
            Console.WriteLine("=== Questão 58 ===");
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Pessoa pessoa = new Pessoa(nome);
            pessoa.Falar();
        }

        private void Questao59()
        {
            Console.WriteLine("=== Questão 59 ===");
            Console.WriteLine("Digite os elementos do primeiro array separados por vírgula:");
            int[] array1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine("Digite os elementos do segundo array separados por vírgula:");
            int[] array2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            int[] intersecao = array1.Intersect(array2).ToArray();
            Console.WriteLine("Elementos em comum: " + string.Join(", ", intersecao));
        }

        private void Questao60()
        {
            Console.WriteLine("=== Questão 60 ===");
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();
            Console.WriteLine("String invertida: " + new string(input.Reverse().ToArray()));
        }



        private void Questao61()
        {
            Console.WriteLine("=== Questão 61 ===");
            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine();
            int unicos = texto.Distinct().Count();
            Console.WriteLine("Caracteres únicos: " + unicos);
        }

        private void Questao62()
        {
            Console.WriteLine("=== Questão 62 ===");
            Console.Write("Digite o limite para exibir números primos: ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("Números primos até " + limite + ":");
            for (int i = 2; i <= limite; i++)
            {
                bool primo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0) primo = false;
                if (primo) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private void Questao63()
        {
            Console.WriteLine("=== Questão 63 ===");
            Console.Write("Digite um número para verificar se é perfeito: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i < numero; i++)
                if (numero % i == 0) soma += i;
            Console.WriteLine(soma == numero ? "Número perfeito" : "Não é perfeito");
        }

        private void Questao64()
        {
            Console.WriteLine("=== Questão 64 ===");
            Console.Write("Digite um número para exibir seus divisores: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisores de " + numero + ":");
            for (int i = 1; i <= numero; i++)
                if (numero % i == 0) Console.Write(i + " ");
            Console.WriteLine();
        }

        private void Questao65()
        {
            Console.WriteLine("=== Questão 65 ===");
            int[,] matriz = new int[2, 3];
            Console.WriteLine("Digite os valores da matriz 2x3:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    matriz[i, j] = int.Parse(Console.ReadLine());

            int[,] transposta = new int[3, 2];
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    transposta[j, i] = matriz[i, j];

            Console.WriteLine("Matriz transposta:");
            for (int i = 0; i < transposta.GetLength(0); i++)
            {
                for (int j = 0; j < transposta.GetLength(1); j++)
                    Console.Write(transposta[i, j] + " ");
                Console.WriteLine();
            }
        }

        private void Questao66()
        {
            Console.WriteLine("=== Questão 66 ===");
            Console.WriteLine("Horário atual: " + DateTime.Now);
            Thread.Sleep(1000);
        }

        private void Questao67()
        {
            Console.WriteLine("=== Questão 67 ===");
            Console.Write("Digite uma operação (+, -, *, /): ");
            char operacao = Console.ReadLine()[0];
            Console.Write("Digite o primeiro número: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double resultado = operacao switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                _ => 0
            };
            Console.WriteLine("Resultado: " + resultado);
        }

        private void Questao68()
        {
            Console.WriteLine("=== Questão 68 ===");
            Console.Write("Digite um valor em reais: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor em extenso: " + valor.ToString("C"));
        }

        private void Questao69()
        {
            Console.WriteLine("=== Questão 69 ===");
            Console.Write("Digite as notas separadas por vírgula: ");
            int[] notas = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.Write("Digite os pesos das notas separados por vírgula: ");
            int[] pesos = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            double soma = 0, totalPesos = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i] * pesos[i];
                totalPesos += pesos[i];
            }
            Console.WriteLine("Média ponderada: " + (soma / totalPesos));
        }

        private void Questao70()
        {
            Console.WriteLine("=== Questão 70 ===");
            Console.Write("Digite o valor do saque: ");
            int valor = int.Parse(Console.ReadLine());
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            foreach (int nota in notas)
            {
                int qtdNotas = valor / nota;
                if (qtdNotas > 0)
                {
                    Console.WriteLine($"{qtdNotas} nota(s) de {nota}");
                    valor %= nota;
                }
            }
        }

        private void Questao71()
        {
            Console.WriteLine("=== Questão 71 ===");
            Console.WriteLine("Digite os elementos do primeiro array separados por vírgula:");
            int[] array1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine("Digite os elementos do segundo array separados por vírgula:");
            int[] array2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            bool iguais = array1.SequenceEqual(array2);
            Console.WriteLine(iguais ? "Arrays iguais" : "Arrays diferentes");
        }

        private void Questao72()
        {
            Console.WriteLine("=== Questão 72 ===");
            Console.Write("Digite o comprimento desejado para a senha: ");
            int comprimento = int.Parse(Console.ReadLine());

            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < comprimento; i++)
            {
                int indiceAleatorio = random.Next(caracteres.Length);
                senha.Append(caracteres[indiceAleatorio]);
            }

            Console.WriteLine("Senha gerada: " + senha.ToString());
        }

        private void Questao73()
        {
            Console.WriteLine("=== Questão 73 ===");
            Console.Write("Digite o número para a tabela de multiplicação: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tabela de multiplicação de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        private void Questao74()
        {
            Console.WriteLine("=== Questão 74 ===");
            Console.Write("Digite o lado A do triângulo: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado B do triângulo: ");
            double ladoB = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado C do triângulo: ");
            double ladoC = double.Parse(Console.ReadLine());

            double semiPerimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
            Console.WriteLine("Área do triângulo: " + area);
        }

        private void Questao75()
        {
            Console.WriteLine("=== Questão 75 ===");
            Console.Write("Digite o valor máximo para os números únicos gerados: ");
            int max = int.Parse(Console.ReadLine());
            HashSet<int> numeros = new HashSet<int>();
            Random random = new Random();

            while (numeros.Count < max)
            {
                numeros.Add(random.Next(1, max + 1));
            }

            Console.WriteLine("Números gerados: " + string.Join(", ", numeros));
        }

        private void Questao76()
        {
            Console.WriteLine("=== Questão 76 ===");
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 0;
            Console.WriteLine("Jogo de Adivinhação: Tente adivinhar o número entre 1 e 100.");

            while (tentativa != numeroSecreto)
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa < numeroSecreto)
                    Console.WriteLine("O número secreto é maior.");
                else if (tentativa > numeroSecreto)
                    Console.WriteLine("O número secreto é menor.");
                else
                    Console.WriteLine("Parabéns! Você acertou o número.");
            }
        }

        private void Questao77()
        {
            Console.WriteLine("=== Questão 77 ===");
            Console.WriteLine("Verifique se dois arrays possuem os mesmos elementos (independente da ordem).");

            Console.WriteLine("Digite os elementos do primeiro array separados por espaço:");
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Digite os elementos do segundo array separados por espaço:");
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool iguais = array1.Length == array2.Length && !array1.Except(array2).Any();

            Console.WriteLine(iguais ? "Os arrays possuem os mesmos elementos." : "Os arrays não possuem os mesmos elementos.");
        }

        private void Questao78()
        {
            Console.WriteLine("=== Questão 78 ===");
            Console.Write("Digite a string a ser invertida: ");
            string original = Console.ReadLine();
            char[] caracteres = original.ToCharArray();
            Array.Reverse(caracteres);
            string invertida = new string(caracteres);
            Console.WriteLine("String invertida: " + invertida);
        }

        private void Questao79()
        {
            Console.WriteLine("=== Questão 79 ===");
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split(' ');
            Console.WriteLine("Número de palavras: " + palavras.Length);
        }

        private void Questao80()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            while (numero > 0)
            {
                soma += numero % 10;
                numero /= 10;
            }

            Console.WriteLine("Soma dos dígitos: " + soma);
        }
        private void Questao81()
        {
            List<int> lista = new List<int>();
            Console.WriteLine("Digite 10 números inteiros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    lista.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    i--; 
                }
            }

            Console.WriteLine("Números pares na lista:");
            foreach (int numero in lista)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }


        private void Questao82()
        {
            List<double> valores = new List<double>();
            Console.WriteLine("Digite valores (ou 'sair' para encerrar):");

            string entrada;
            while ((entrada = Console.ReadLine()) != "sair")
            {
                valores.Add(double.Parse(entrada));
            }

            if (valores.Count > 0)
            {
                double media = valores.Average();
                double maior = valores.Max();
                Console.WriteLine($"Média: {media}, Maior valor: {maior}");
            }
        }

        private void Questao83()
        {
            List<string> nomes = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o nome {i}: ");
                nomes.Add(Console.ReadLine());
            }

            nomes.Sort();
            Console.WriteLine("Nomes em ordem alfabética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        private void Questao84()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            string invertida = new string(palavra.Reverse().ToArray());

            Console.WriteLine(palavra.Equals(invertida, StringComparison.OrdinalIgnoreCase)
                ? "A palavra é um palíndromo."
                : "A palavra não é um palíndromo.");
        }

        private void Questao85()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(random.Next(1, 51));
            }

            int menor = numeros.Min();
            int maior = numeros.Max();
            Console.WriteLine("Números gerados: " + string.Join(", ", numeros));
            Console.WriteLine($"Menor: {menor}, Maior: {maior}");
        }

        public class ContaBancaria
        {
            private decimal saldo;

            public ContaBancaria(decimal saldoInicial)
            {
                saldo = saldoInicial;
            }

            public void Depositar(decimal valor)
            {
                saldo += valor;
                Console.WriteLine("Saldo atual: " + saldo);
            }

            public void Sacar(decimal valor)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine("Saldo atual: " + saldo);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
        }

        private void Questao86()
        {
            ContaBancaria conta = new ContaBancaria(1000);
            Console.WriteLine("Digite o valor para depósito:");
            decimal deposito = decimal.Parse(Console.ReadLine());
            conta.Depositar(deposito);

            Console.WriteLine("Digite o valor para saque:");
            decimal saque = decimal.Parse(Console.ReadLine());
            conta.Sacar(saque);
        }

        private void Questao87()
        {
            Console.Write("Digite o salário bruto: ");
            decimal salarioBruto = decimal.Parse(Console.ReadLine());
            decimal salarioLiquido = salarioBruto * 0.90m;
            Console.WriteLine("Salário líquido: " + salarioLiquido);
        }

        private void Questao88()
        {
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine("Representação binária: " + binario);
        }

        private void Questao89()
        {
            Console.WriteLine("Digite três notas:");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Média: " + media + (media >= 7 ? " - Aprovado" : " - Reprovado"));
        }

        private void Questao90()
        {
            int[,] matriz = new int[2, 2];
            Console.WriteLine("Digite os elementos da matriz 2x2:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;
            foreach (int elemento in matriz)
            {
                soma += elemento;
            }

            Console.WriteLine("Soma dos elementos da matriz: " + soma);
        }

        private void Questao91()
        {
            int[] votos = new int[3];
            string entrada;

            Console.WriteLine("Digite o número do candidato (1, 2 ou 3) para votar ou 'fim' para encerrar:");
            while ((entrada = Console.ReadLine().ToLower()) != "fim")
            {
                if (int.TryParse(entrada, out int candidato) && candidato >= 1 && candidato <= 3)
                {
                    votos[candidato - 1]++;
                }
                else
                {
                    Console.WriteLine("Voto inválido.");
                }
            }

            int vencedor = Array.IndexOf(votos, votos.Max()) + 1;
            Console.WriteLine($"Candidato vencedor: {vencedor} com {votos.Max()} votos.");
        }

        private void Questao92()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(numero % 3 == 0 && numero % 7 == 0
                ? "O número é múltiplo de 3 e 7."
                : "O número não é múltiplo de 3 e 7.");
        }

        private void Questao93()
        {
            Console.Write("Digite a coordenada X do primeiro ponto: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y do primeiro ponto: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a coordenada X do segundo ponto: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y do segundo ponto: ");
            double y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Distância entre os pontos: " + distancia);
        }

        private void Questao94()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numeros.Add(random.Next(1, 101));
            }

            numeros.Sort();
            Console.WriteLine("Números em ordem crescente: " + string.Join(", ", numeros));
        }

        private void Questao95()
        {
            Dictionary<string, string> agenda = new Dictionary<string, string>();
            string opcao;

            do
            {
                Console.WriteLine("Digite 1 para adicionar contato, 2 para listar contatos, 3 para sair:");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Número: ");
                    string numero = Console.ReadLine();
                    agenda[nome] = numero;
                }
                else if (opcao == "2")
                {
                    foreach (var contato in agenda)
                    {
                        Console.WriteLine($"Nome: {contato.Key}, Número: {contato.Value}");
                    }
                }
            } while (opcao != "3");
        }

        private void Questao96()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool primo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private void Questao97()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        private void Questao98()
        {
            int[,] matriz = new int[3, 3];
            Console.WriteLine("Digite os elementos da matriz 3x3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maior = matriz[0, 0];
            foreach (int elemento in matriz)
            {
                if (elemento > maior)
                {
                    maior = elemento;
                }
            }

            Console.WriteLine("Maior número na matriz: " + maior);
        }

        private void Questao99()
        {
            Console.Write("Digite um número N: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                soma += i * i;
            }

            Console.WriteLine("Soma dos quadrados de 1 a N: " + soma);
        }

        private void Questao100()
        {
            string palavraSecreta = "programacao";
            string letra;
            int tentativas = 5;
            string tentativa = new string('_', palavraSecreta.Length);

            while (tentativas > 0 && tentativa.Contains('_'))
            {
                Console.WriteLine($"Palavra: {tentativa}");
                Console.Write("Digite uma letra: ");
                letra = Console.ReadLine();

                if (palavraSecreta.Contains(letra))
                {
                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        if (palavraSecreta[i].ToString() == letra)
                        {
                            tentativa = tentativa.Remove(i, 1).Insert(i, letra);
                        }
                    }
                }
                else
                {
                    tentativas--;
                    Console.WriteLine($"Letra não encontrada! Tentativas restantes: {tentativas}");
                }
            }

            if (!tentativa.Contains('_'))
            {
                Console.WriteLine($"Parabéns! Você adivinhou a palavra: {palavraSecreta}");
            }
            else
            {
                Console.WriteLine($"Você perdeu! A palavra era: {palavraSecreta}");
            }
        }
    }
}

