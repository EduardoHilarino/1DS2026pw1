using System;
using System.Threading;
using static System.Console;
using static System.Convert;

namespace Projeto_Menu_AMS
{
    internal class Program
    {
        static int colunaCaixa;
        static int linhaCaixa;
        static int larguraCaixa;
        static int alturaCaixa;
        static void Main(string[] args)
        {
            string nome;
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;

            CriarCaixa(1, true, 3, 46, " ", 'd');
            EscreverCentralizado("Digite o nome do usúario: ", 2, 2);
            nome = LerTexto();
            CriarCaixa(3, true, 4, 46, " ", 'R');
            EscreverCentralizado($"Seja bem vindo(a) {nome}!", 4, 4);
            EscreverCentralizado($"Pressione ESPAÇO para pular a animação", 5, 4);
            ReadKey();

            int opcao;
            do
            {
                Clear();

                int coluna = (WindowWidth - "███╗   ███╗███████╗███╗   ██╗██╗   ██╗".Length) / 2;

                CriarCaixa(1, true, 9, 46, "Versão 2", 'd');
                SetCursorPosition(coluna, 3); WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗");
                SetCursorPosition(coluna, 4); WriteLine("████╗ ████║██╔════╝████╗  ██║██║   ██║");
                SetCursorPosition(coluna, 5); WriteLine("██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║");
                SetCursorPosition(coluna, 6); WriteLine("██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║");
                SetCursorPosition(coluna, 7); WriteLine("██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝");
                SetCursorPosition(coluna, 8); WriteLine("╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ");

                CriarCaixa(9, true, 10, 46, "Opções:", 'R');
                EscreverCentralizado("[1] Menu Vetores", 12, 5);
                EscreverCentralizado("[2] Tabuada", 13, 5);
                EscreverCentralizado("[3] Bhaskara", 14, 5);
                EscreverCentralizado("[4] Compara números", 15, 5);
                EscreverCentralizado("[5] Média", 16, 5);
                EscreverCentralizado("[6] Encerrar", 17, 5);

                CriarCaixa(18, true, 3, 46, "", 'R');
                EscreverCentralizado("Digite sua opção: ", 19, 2);
                int.TryParse(LerTexto(1), out opcao);

                switch (opcao)
                {
                    case 1:
                        Menu_Vetores();
                        break;
                    case 2:
                        Tabuada();
                        break;
                    case 3:
                        Bhakara();
                        break;
                    case 4:
                        Compara_Números();
                        break;
                    case 5:
                        Média();
                        break;
                    case 6:
                        Encerrar();
                        break;
                    default:
                        Clear();
                        CriarCaixa(1, true, 3, 118, "", 'd');
                        SetCursorPosition(45, 2); Write("=== Opção Ínvalida ===");
                        ReadKey();
                        break;
                }
            } while (opcao != 6);



        }

        static void Menu_Vetores()
        {

        }

        static void Tabuada()
        {

        }

        static void Compara_Números()
        {
            do
            {
                Clear();

                CriarCaixa(1, false, 3, 50, "", 'd');
                EscreverCentralizado("Lista de números", 2, 4);
                CriarCaixa(3, false, 3, 50, "", 'R');
                EscreverCentralizado("quantos números você deseja analizar? ", 4, 4);
                int qtd = int.Parse(LerTexto());

                double soma = 0;

                int qtdPar = 0;
                int qtdImpar = 0;

                double Menor = double.MaxValue; //Começa com o maior valor do C#
                double Maior = double.MinValue; //começa com o menor valor do C#

                int posMaior = 0;
                int posMenor = 0;

                CriarCaixa(5, true, qtd + 2, 50, "", 'R');
                for (int i = 0; i < qtd; i++)
                {
                    EscreverCentralizado($"Digite o {i + 1}º número: ", i + 6, 4);
                    double num = double.Parse(LerTexto());


                    //acomula para média
                    soma += num;

                    //verifica se é par o impar
                    if (num % 2 == 0)
                    {
                        qtdPar++;
                    }
                    else
                    {
                        qtdImpar++;
                    }
                    //Descobre qual o maior número até agora
                    if (num > Maior)
                    {
                        Maior = num;
                        posMaior = i + 1; //guarda a posiçao
                    }
                    if (num < Menor)
                    {
                        Menor = num;
                        posMenor = i + 1;
                    }
                }
                //calcula a média final
                double media = soma / qtd;
                //exibe o relatório na tela
                Clear();
                CriarCaixa(1, true, 3, 70, "", 'd');
                EscreverCentralizado(" Relatório da analize ", 2, 6);
                CriarCaixa(3, true, 7, 70, "", 'R');
                EscreverCentralizado($"O maior número é {Maior} na {posMaior}º posição.", 4, 6);
                EscreverCentralizado($"O menor número é {Menor} na {posMenor}º posição.", 5, 6);
                EscreverCentralizado($"Quantidade de números pares: {qtdPar}", 6, 6);
                EscreverCentralizado($"Quantidade de números ímpares: {qtdImpar}", 7, 6);
                EscreverCentralizado($"A média de todos os números é: {media:F2}", 8, 6);
                ReadKey();

            } while (Continuar());
        }

        static void Média()
        {

        }

        static void Bhakara()
        {
            do
            {
                Clear();
                int a, b, c;
                double delta;

                CriarCaixa(1, true, 5, 50, "", 'd');
                EscreverCentralizado("Insira o valor de \"a\": ", 2, 3);
                a = ToInt32(LerTexto(5));
                EscreverCentralizado("Insira o valor de \"b\": ", 3, 3);
                b = ToInt32(LerTexto(5));
                EscreverCentralizado("Insira o valor de \"c\": ", 4, 3);
                c = ToInt32(LerTexto(5));


                delta = Math.Pow(b, 2) - 4 * a * c;

                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                CriarCaixa(5, true, 3, 50, "", 'R');
                EscreverCentralizado($"O seu valor de \"x\" é: {x1} e {x2}.", 6, 3);
                ReadKey();
            } while (Continuar());
        }

        static void Encerrar()
        {
            Clear();
            EscreverCentralizado("Encerrando", 3, 1);
            for (int i = 0; i < 3; i++)
            {
                Clear();
                SetCursorPosition(55, 3); WriteLine("Encerrando.");
                Thread.Sleep(333);
                SetCursorPosition(55, 3); WriteLine("Encerrando..");
                Thread.Sleep(333);
                SetCursorPosition(55, 3); WriteLine("Encerrando...");
                Thread.Sleep(333);
            }
        }

        static bool Continuar()
        {
            bool escolha;
            string resp;

            Clear();
            CriarCaixa(1, true, 3, 50, "",'d');
            EscreverCentralizado("Deseja fazer novamente? (s/n): ", 2, 3);
            resp = LerTexto(1);

            escolha = resp.ToLower() == "s" || resp.ToLower() == "sim";

            return escolha;
        }

        static void Escrever(string texto, int vel)
        {
            int num_char = texto.Length;

            for (int i = 0; i < num_char; i++)
            {
                string Sub_texto = texto.Substring(i, 1);
                Write(Sub_texto);

                if (KeyAvailable)
                {
                    ConsoleKeyInfo tecla = ReadKey(true);
                    if (tecla.Key == ConsoleKey.Spacebar)
                    {
                        if (i < num_char)
                        {
                            vel = 100000;
                        }
                    }
                }
                Thread.Sleep(100 / vel);
            }
        }

        static void EscreverCentralizado(string texto, int linha, int vel)
        {
            int coluna = (WindowWidth - texto.Length) / 2;

            if (coluna < 0)
                coluna = 0;

            SetCursorPosition(coluna, linha);
            Escrever(texto, vel);
        }

        static void CriarCaixa(int linha, bool til, int altura, int largura, string titulo, char borda = '\0')
        {
            // Centraliza somente horizontalmente
            int coluna = (Console.WindowWidth - largura) / 2;

            // Guarda as informações da caixa atual
            colunaCaixa = coluna;
            linhaCaixa = linha;
            larguraCaixa = largura;
            alturaCaixa = altura;

            // Salva cores atuais
            var corFundoAnterior = BackgroundColor;
            var corLetraAnterior = ForegroundColor;

            // SOMBRA
            BackgroundColor = ConsoleColor.DarkGray;
            ForegroundColor = ConsoleColor.Black;

            for (int i = 1; i <= altura; i++)
            {
                SetCursorPosition(coluna + 1, linha + i);
                Write(new string(' ', largura));
            }

            // CAIXA PRINCIPAL
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < altura; i++)
            {
                SetCursorPosition(coluna, linha + i);
                Write(new string(' ', largura));
            }


            // Desenha borda se solicitada
            if (borda != '\0' && largura >= 2 && altura >= 2)
            {
                char cse, csd, cid, cie, lh, lv;

                if (borda == 'd')
                {
                    cse = '╔'; csd = '╗'; cid = '╝'; cie = '╚';
                    lh = '═'; lv = '║';
                }
                else if (borda == 's')
                {
                    cse = '┌'; csd = '┐'; cid = '┘'; cie = '└';
                    lh = '─'; lv = '|';
                }
                else if (borda == 'b')
                {
                    cse = '█'; csd = '█'; cid = '█'; cie = '█';
                    lh = '█'; lv = '█';
                }
                else if (borda == 'R')
                {
                    cse = '╠'; csd = '╣'; cid = '╝'; cie = '╚';
                    lh = '═'; lv = '║';
                }
                else
                {
                    // caractere qualquer: usa ele como linha/coluna
                    cse = csd = cid = cie = borda;
                    lh = lv = borda;
                }

                // Topo e fundo
                SetCursorPosition(coluna, linha);
                Write(new string(lh, largura));
                SetCursorPosition(coluna, linha + altura - 1);
                Write(new string(lh, largura));

                // Laterais
                for (int y = linha; y < linha + altura; y++)
                {
                    SetCursorPosition(coluna, y);
                    Write(y == linha ? cse : (y == linha + altura - 1 ? cie : lv));
                    SetCursorPosition(coluna + largura - 1, y);
                    Write(y == linha ? csd : (y == linha + altura - 1 ? cid : lv));
                }
            }

            // BARRA DE TÍTULO (área interna)
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;

            int innerOffset = (borda != '\0' && largura >= 2) ? 1 : 0;
            int innerWidth = Math.Max(0, largura - innerOffset * 2);
            SetCursorPosition(coluna + innerOffset, linha + innerOffset);
            Write(new string(' ', innerWidth));

            string txt = (titulo ?? "").Trim();
            if (txt.Length > innerWidth) txt = txt.Substring(0, innerWidth);

            int posicaoTitulo = coluna + innerOffset + Math.Max(0, (innerWidth - txt.Length) / 2);

            SetCursorPosition(posicaoTitulo, linha + innerOffset);
            Write(txt);

            // Restaura cores anteriores
            BackgroundColor = corFundoAnterior;
            ForegroundColor = corLetraAnterior;
        }

        static string LerTexto(int limite = 0)
        {
            int colunaInicial = Console.CursorLeft;
            int linhaInicial = Console.CursorTop;

            // Se não foi informado limite,
            // calcula automaticamente pelo tamanho da caixa.
            if (limite <= 0)
            {
                // Limite da parte interna da caixa
                int limiteDireito;

                if (larguraCaixa > 0)
                {
                    // Se tiver borda, deixa 1 espaço antes dela
                    limiteDireito = colunaCaixa + larguraCaixa - 2;

                    // Quantidade de caracteres que cabem
                    limite = limiteDireito - colunaInicial;
                }
                else
                {
                    // Segurança caso nenhuma caixa tenha sido criada
                    limite = Console.WindowWidth - colunaInicial - 1;
                }
            }

            if (limite < 0)
                limite = 0;

            string texto = "";

            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                // ENTER
                if (tecla.Key == ConsoleKey.Enter)
                {
                    break;
                }

                // BACKSPACE
                if (tecla.Key == ConsoleKey.Backspace)
                {
                    if (texto.Length > 0)
                    {
                        texto = texto.Substring(0, texto.Length - 1);

                        Console.SetCursorPosition(
                            colunaInicial + texto.Length,
                            linhaInicial
                        );

                        Console.Write(' ');

                        Console.SetCursorPosition(
                            colunaInicial + texto.Length,
                            linhaInicial
                        );
                    }

                    continue;
                }

                // Caracteres normais
                if (!char.IsControl(tecla.KeyChar))
                {
                    if (texto.Length < limite)
                    {
                        texto += tecla.KeyChar;
                        Console.Write(tecla.KeyChar);
                    }
                }
            }

            return texto;
        }

    }
}