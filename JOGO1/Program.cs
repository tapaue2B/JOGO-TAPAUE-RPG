//BOLA OFF THE GOLD

//-------------------------------------------------

//Bibliotecas usadas
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using Microsoft.VisualBasic.FileIO;

//-------------------------------------------------

//Classe principal
class Program
{
    //Criação de variaveis

    //-------------------------------------------------

    static string? nome, classe; // Variaveis de nome e classe do jogador

    static string? local, l1, l2, l3; // Variaveis de local do jogo

    static int atk, def, spe, atkB, atkB1, defB, speB; // Variaveis dos atributos do jogador

    static int itemBC = 0, dicaC = 0, pontos = 0; // Varaiavel de controle para itens

    static string itemb = ""; // Variavel de item de bataha

    static string? inimigo1 = "vivo", inimigo2 = "vivo", inimigo3 = "vivo", nomeI; // Variaveis de nome e estado dos inimigos

    static int atkI1, defI1, speI1, atkBI, xpI, xpJ = 0, finalBF2; // Variaveis dos atributos dos inimigos

    static string? confirma6 = "sim", confirma7 = "sim", confirma8 = "sim", confirma9 = "sim", itemDI = "", resultado = ""; // Variaveis de controle de estado dos inimigos

    static string[] itensbatalha = { "", "", "", "", "" }; // Vetor de itens de batalha
    static string[] itensDica = { "", "", "", "", "" }; // Vetor de itens de dicas

    //-------------------------------------------------

    //Inicio, menu e atribuições principais

    //-------------------------------------------------

    // Função main que inicia o codigo
    static void Main()
    {
        menu(); // Inicia a função menu
    }

    // Função menu
    static void menu() // Função inicial do jogo
    {
        Console.Clear(); // Limpa o console
        int resp; // Variavel local de resposta
        Console.WriteLine("O melhor jogo de uma bola que você vai jogar");
        Console.WriteLine("BOLA OF THE GOLD");
        Console.WriteLine("");
        Console.WriteLine("MENU");
        Console.WriteLine("1-jogar");
        Console.WriteLine("2-Instruções");
        Console.WriteLine("3-Desenvolvedores");
        Console.WriteLine("4-Sair do jogo");
        int.TryParse(Console.ReadLine(), out resp); // Recebe o valor da variavel e garante que é um valor inteiro

        switch (resp) // Segue um caminho dependendo do valor da variavel
        {
            case 1:
                novoJogo(); // Inicia a função novoJogo
                break;
            case 2:
                introducao(); // Inicia a função introduão
                break;
            case 3:
                equipe(); // Inicia a função equipe
                break;
            case 4:
                // Finaliza o jogo
                break;
            default:
                menu(); // Retorna para o inicio da função
                break;
        }
    }

    //Função novoJogo
    static void novoJogo()
    {
        Console.Clear(); // Limpa o console
        do
        {
            Console.Write("Qual seu nome:");
            nome = Console.ReadLine(); // Recebe o valor do console e atribui a variavel nome
            Console.Clear(); // Limpa o console
        } while (nome == "");
        personagem(); // Inicia o a função personagem
    }

    //Função personagem
    static void personagem()
    {
        int resp;
        Console.Clear(); // Limpa o console
        Console.WriteLine("Escolha sua classe:");
        Console.WriteLine("");
        Console.WriteLine("1-Caça sapo = ATK:225 DEF:150 SPE:75 ");
        Console.WriteLine("2-Azetorto = ATK:180 DEF:135 SPE:135 ");
        Console.WriteLine("3-Anão = ATK:250 DEF:135 SPE:65 ");
        Console.WriteLine("4-Livia = ATK:180 DEF:180 SPE:90 ");
        Console.WriteLine("5-Amapeido = ATK:225 DEF:75 SPE:150 ");
        Console.WriteLine("6-Executor = ATK:75 DEF:150 SPE:225 ");
        int.TryParse(Console.ReadLine(), out resp); // Recebe o valor da variavel e garante que é um valor inteiro

        switch (resp) // Segue um caminho dependendo do valor da variavel
        {
            case 1:
                classe = "Caça-sapo"; // Atribui o nome da classe á variavel classe
                atk = 225; // Atribui o numero de ataque á variavel atk
                def = 150; // Atribui o numero de defesa á variavel def
                spe = 75; // Atribui o numero de velocidade á variavel spe
                confirmar(); // inicia a função confirma
                break;
            case 2:
                classe = "Azetorto"; // Atribui o nome da classe á variavel classe
                atk = 180; // Atribui o numero de ataque á variavel atk
                def = 135; // Atribui o numero de defesa á variavel def
                spe = 75; // Atribui o numero de velocidade á variavel spe
                confirmar(); // inicia a função confirma
                break;
            case 3:
                classe = "Anão"; // Atribui o nome da classe á variavel classe
                atk = 250; // Atribui o numero de ataque á variavel atk
                def = 135; // Atribui o numero de defesa á variavel def
                spe = 65; // Atribui o numero de velocidade á variavel spe
                confirmar(); // inicia a função confirma
                break;
            case 4:
                classe = "Livia"; // Atribui o nome da classe á variavel classe
                atk = 180; // Atribui o numero de ataque á variavel atk
                def = 180; // Atribui o numero de defesa á variavel def
                spe = 90; // Atribui o numero de velocidade á variavel spe
                confirmar(); // inicia a função confirma
                break;
            case 5:
                classe = "Amapeido"; // Atribui o nome da classe á variavel classe
                atk = 225; // Atribui o numero de ataque á variavel atk
                def = 75; // Atribui o numero de defesa á variavel def
                spe = 150; // Atribui o numero de velocidade á variavel spe
                confirmar(); // inicia a função confirma
                break;
            case 6:
                classe = "Executor"; // Atribui o nome da classe á variavel classe
                atk = 75; // Atribui o numero de ataque á variavel atk
                def = 150; // Atribui o numero de defesa á variavel def
                spe = 225; // Atribui o numero de velocidade á variavel spe
                confirmar(); // inicia a função confirma
                break;
            default:
                personagem(); // Inicia a função confirma
                break;
        }
    }

    // Função confirmar
    static void confirmar()
    {
        Console.Clear(); // Limpa o console
        int resp;
        Console.WriteLine("Você confirma a classe escolhida?");
        Console.WriteLine("");
        Console.WriteLine("1-Sim");
        Console.WriteLine("2-Não");
        int.TryParse(Console.ReadLine(), out resp); // Recebe o valor da variavel e garante que é um valor inteiro

        switch (resp) // Segue um caminho dependendo do valor da variave
        {
            case 1:
                edin(); // Inicia função edin
                break;
            case 2:
                personagem(); // Retorna a função personagem
                break;
            default:
                confirmar(); // Retorna para o inicio da função
                break;
        }
    }

    //-------------------------------------------------

    //Criação de contexto

    //-------------------------------------------------

    // Função edin
    static void edin() // Função que inicia a historia 
    {
        Console.Clear(); // Limpa o console
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("09:00");
        Console.WriteLine("Budega do edin salgados");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine(nome + " chega no edin super empolgado pois hoje ele");
        Console.WriteLine("trouxe sua linda e brilhante bola de futmesa");
        Console.WriteLine("pra ficar até umas hora jogando.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine(nome + ": Eai edin, bom dia.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine($"Edin: Eai {nome}, tudo beleza?");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine(nome + ": Man, tem oq ai hoje?");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine($"Edin: Pae, tem mistão, refri e café.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        escolha(); // Inicia a função escolha
    }

    // Função escolha
    static void escolha() // Função para escolher o item da loja
    {
        int resp; // Variavel de resposta local
        Console.Clear();
        Console.WriteLine($"Edin: Então vai querer o que?");
        Console.WriteLine("");
        Console.WriteLine("1-Mistão -> aumento de 15% do ATK na batalha");
        Console.WriteLine("2-Refri -> aumento de 15% do DEF na batalha");
        Console.WriteLine("3-Café -> aumento de 15% do SPE na batalha");
        Console.WriteLine("4-Nada");
        int.TryParse(Console.ReadLine(), out resp);
        Console.Clear();

        switch (resp) // Segue um caminho dependendo do valor da variavel
        {
            case 1:
                itensbatalha[itemBC] = "Mistão"; // Atribui valor ao inventario
                Console.Clear(); // Limpa o console
                Console.WriteLine(nome + ": Ei vou querer um mistão oh pra dar uma reforçada no café da manhã.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine("Edin: Claro, um mistão saindo...");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + $": Valeu edin pelo {itensbatalha[itemBC]}.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + $" abre a mochila e coloca {itensbatalha[itemBC]} no bolso de itens de batalha");
                itemBC++; // Incrementa valor a variavel
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine("Edin: Ei pae vai pagar não?");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + ": Vou sim jajá kkkkkkk.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.Clear(); // Limpa o console
                babarosa(); // Inicia a função babarosa
                break;
            case 2:
                itensbatalha[itemBC] = "Refri"; // Atribui valor ao inventario
                Console.Clear(); // Limpa o console
                Console.WriteLine(nome + ": Ei vou querer um refri, até porque 9:00 da manhã nada melhor que um refri gelado.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine("Edin: Verdade viu, medicos dizem que isso ai melhora em 10 anos a vida util do teu figado...");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + $": Valeu edin pelo {itensbatalha[itemBC]}.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + $" abre a mochila e coloca {itensbatalha[itemBC]} no bolso de itens de batalha");
                itemBC++; // Incrementa valor a variavel
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine("Edin: Ei pae vai pagar não?");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + ": Vou sim jajá kkkkkkk.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.Clear(); // Limpa o console
                babarosa();
                break;
            case 3:
                itensbatalha[itemBC] = "Café"; // Atribui valor ao inventario
                Console.Clear(); // Limpa o console
                Console.WriteLine(nome + ": Ei vou querer um café bem quente oh pra dar uma acordada.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine("Edin: Beleza pae, cafézin bem quente pra você...");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + $": Valeu edin pelo {itensbatalha[itemBC]}");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + $" abre a mochila e coloca {itensbatalha[itemBC]} no bolso de itens de batalha");
                itemBC++; // Incrementa valor a variavel
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine("Edin: Ei pae vai pagar não?");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.WriteLine(nome + ": Vou sim jajá kkkkkkk.");
                Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
                Console.Clear(); // Limpa o console
                babarosa(); // Inicia a função babarosa
                break;
            case 4:
                Console.Clear(); // Limpa o console
                Console.WriteLine(nome + ": Ei vou querer porcaria nenhuma dessa tua budega fedida ai não.");
                Console.ReadLine();
                Console.WriteLine(nome + $": Valeu edin por nada...");
                Console.ReadLine();
                Console.WriteLine(nome + " abre a mochila");
                Console.ReadLine();
                Console.WriteLine(nome + $"Abri a mochila pra quê comprei nada, tô ficando é doido...");
                babarosa(); // Inicia a função babarosa
                break;
            default:
                escolha(); // Retorna ao inicio da função
                break;
        }
    }

    // Função babarosa
    static void babarosa()// Função que inicia o problema da historia
    {
        Console.Clear();
        Console.WriteLine("Barbarosa passa pela budega do edin...");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine($"Barbarosa: Ei {nome} passa pro pátio aí que vai ter o momento de cantar o hino de tápaue.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine(nome + ": Beleza Barbarosa já to indo.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine("Barbarosa: Ei man oh a bola aí pra não esquecer.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine(nome + ": Vixe verdade valeu aí.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine($"{nome} seguiu para a entrada da escola");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine($"Jorgin: Fala {nome} bom dia, partiu aula né?");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine(nome + ": Infezlimente né jorgin, mas pelo menos o futmesa vai gerar hoje.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine("Jorgin: Tô vendo, com essa bola bonita e brilhante ai vai gerar mesmo...");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine(nome + ": OHHHHHHHH...");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine("Paulo Tiragua chega na portaria");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        Console.WriteLine("Paulo Tiragua: Bom dia amigo.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine($"Paulo Tiragua: Ei {nome} essa bola ai vai ter que ser guardada em algum local, não pode levar para o hino.");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.WriteLine(nome + ": Claro patrão, vou guardar bem ali...");
        Console.ReadLine(); // Controla a quantidade de texto e mantem a tela mais organizada
        Console.Clear(); // Limpa o console
        guardar(); // Inicia a função guardar
    }

    // Função guardar
    static void guardar()// Função de escolha para continuidade da historia
    {
        int resp; // Variavel de resposta local
        Console.Clear();
        Console.WriteLine(nome + ": Aonde vou guardar a bola btl?");
        Console.WriteLine("");
        Console.WriteLine("1- Vaso de planta");
        Console.WriteLine("2- Estacionamento das bike");
        Console.WriteLine("3- Boca do Igor (ESTATUA)");
        Console.WriteLine("4- Cesto de Lixo do Banheiro");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp) // Segue um caminho dependendo do valor da variavel
        {
            case 1:
                local = "vaso de planta"; // Atribui valor a variavel local
                l1 = "terra do vaso"; // Atribui valor a variavel local
                l2 = "mesas ao redor"; // Atribui valor a variavel local
                l3 = "armarios"; // Atribui valor a variavel local
                hino(); // Inicia a função hino
                break;
            case 2:
                local = "estacionamento das bike"; // Atribui valor a variavel local
                l1 = "de trás das bicicletas"; // Atribui valor a variavel local
                l2 = "grama ao redor"; // Atribui valor a variavel local
                l3 = "Atras da arvore"; // Atribui valor a variavel local
                hino(); // Inicia a função hino
                break;
            case 3:
                local = "boca do Igor"; // Atribui valor a variavel local
                l1 = "estatua"; // Atribui valor a variavel local
                l2 = "futmesa"; // Atribui valor a variavel local
                l3 = "escada"; // Atribui valor a variavel local
                hino(); // Inicia a função hino
                break;
            case 4:
                local = "cesto de Lixo do banheiro"; // Atribui valor a variavel local
                l1 = "pia"; // Atribui valor a variavel local
                l2 = "mictorio"; // Atribui valor a variavel local
                l3 = "box pichado"; // Atribui valor a variavel local
                hino(); // Inicia a função hino
                break;
            default:
                guardar(); // Retorna ao inicio da função
                break;
        }
    }

    static void hino()
    {
        Console.Clear();
        Console.WriteLine("A bola foi guardada em " + local);
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("Pátio");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Paulo Tiragua: Agora vamos catar o hino tapauense.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("HINO:");
        Console.WriteLine("Tapaue, oh tapaue, brilho no olhar,  ");
        Console.ReadLine();
        Console.WriteLine("Com coragem e amor, vamos nos erguer,  ");
        Console.ReadLine();
        Console.WriteLine("No ritmo do tambor, vamos celebrar,  ");
        Console.ReadLine();
        Console.WriteLine("O espírito do povo que não vai se esquecer...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(nome + ": Finalmente rapaziada,partiu futmesa agora...");
        Console.ReadLine();
        Console.WriteLine(nome + ": Ué cade bola eu juro que tinha deixado aqui em " + local + ".");
        Console.ReadLine();
        perda();
    }

    //-------------------------------------------------

    static void perda()// nessa função dependendo de onde o jogador escolher ele irá para o combate ou para as dicas
    {
        int resp;
        Console.Clear();
        Console.WriteLine(nome + ": E agora oq eu faço?");
        Console.WriteLine("1- Ir para coordenação");
        Console.WriteLine("2- Procurar pistas no local que foi escondido");
        Console.WriteLine("3- Falar com as pessoas em volta");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp)
        {
            case 1:
                coordenacao();// aqui introduzirá a primeira batalha do jogo
                break;
            case 2:
                procura1();//seguindo essa escolha ele irá achar a primeira dica
                break;
            case 3:
                falar();// despistar o jogador do objetivo central
                break;
            default:
                perda();
                break;
        }
    }

    static void coordenacao()
    {
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("Coordenação ensino fundamental II");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(nome + $": Ei cassiano mah, eu tava lá hino se liga e eu tinha deixado a bola ali em {local}.");
        Console.ReadLine();
        Console.WriteLine(nome + ": Ai quando eu fui pegar a bola não tava mais lá, se liga.");
        Console.ReadLine();
        Console.WriteLine("Cassiano: Mah eu não posso fazer muita coisa não oh.");
        Console.ReadLine();
        Console.WriteLine("Cassiano: Mas tem alguem que pode ajudar...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Savio aparece misteriosamente...");
        Console.ReadLine();
        Console.WriteLine("Sávio: O que está acontecendo aqui, posso saber?");
        Console.ReadLine();
        Console.WriteLine(nome + $": Eu perdi minha bola em {local}.");
        Console.ReadLine();
        Console.WriteLine(nome + ": Quero saber se você pode me ajudar.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Sávio: Depois de ouvir esses relatos, eu estou decidido...");
        Console.ReadLine();
        Console.WriteLine("Sávio: EU VOU AJUDAR VOCÊ!!");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("SÁVIO AGORA É SEU GUIA");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Sávio seguirá com você na sua jornada!! ");
        Console.ReadLine();
        Console.Clear();
        continua();
    }

    static void continua()
    {
        Console.Clear();
        Console.WriteLine("Savio:nossa jornada vai começar pelas salas da masmorra do fundamental 2");
        Console.ReadLine();
        continuafund2();
    }
    static void continuafund2()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Savio: qual sala você quer ir?");
        Console.WriteLine("");
        Console.WriteLine("1 - 6° ANO");
        Console.WriteLine("2 - 7° ANO");
        Console.WriteLine("3 - 8° ANO");
        if (inimigo1 == "morto" & inimigo2 == "vivo")
        {
            Console.WriteLine("4 - 9° ANO");
            Console.WriteLine("5 - Mochila");
            Console.WriteLine("6 - Atributos");
        }
        else if (inimigo2 == "morto")
        {
            Console.WriteLine("4 - 9° ANO");
            Console.WriteLine("5 - Ensino Médio");
            Console.WriteLine("6 - Mochila");
            Console.WriteLine("7 - Atributos");
        }
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                if (confirma6 == "sim")
                {
                    atkI1 = 50;
                    defI1 = 250;
                    speI1 = 100;
                    nomeI = "João Lucas com dengue";
                    xpI = 100;
                    anof1();
                }
                else
                {
                    Console.WriteLine("Sávio: Nois já foi nessa sala ai animal");
                    Console.ReadLine();
                    continuafund2();
                }
                break;
            case 2:
                if (confirma7 == "sim")
                {
                    atkI1 = 100;
                    defI1 = 250;
                    speI1 = 50;
                    nomeI = "Pikinha";
                    xpI = 100;
                    anof1();
                }
                else
                {
                    Console.WriteLine("Sávio: Nois já foi nessa sala ai bicho burro");
                    Console.ReadLine();
                    continuafund2();
                }
                break;
            case 3:
                if (confirma8 == "sim")
                {
                    atkI1 = 250;
                    defI1 = 100;
                    speI1 = 50;
                    nomeI = "Gola alta";
                    xpI = 100;
                    anof1();
                }
                else
                {
                    Console.WriteLine("Sávio: Nois já foi nessa sala ai meu amigo");
                    Console.ReadLine();
                    continuafund2();
                }
                break;
            case 4:
                if (inimigo1 == "vivo")
                {
                    continuafund2();
                }
                else
                {
                    if (confirma9 == "sim")
                    {
                        atkI1 = 250;
                        defI1 = 300;
                        speI1 = 150;
                        nomeI = "Das Loira";
                        xpI = 150;
                        ano9();
                    }
                    else
                    {
                        Console.WriteLine("Sávio: Nois já foi nessa sala ai doido");
                        Console.ReadLine();
                        continuafund2();
                    }

                }
                break;
            case 5:
                if (inimigo1 == "vivo")
                {
                    continuafund2();
                }
                else if (inimigo1 == "morto" & inimigo2 == "vivo")
                {
                    mochila();
                }
                else if (inimigo2 == "morto")
                {
                    atkI1 = 350;
                    defI1 = 350;
                    speI1 = 200;
                    nomeI = "Chefão Arbusto";
                    ensinoMedio();
                }
                break;
            case 6:
                if (inimigo1 == "vivo")
                {
                    continuafund2();
                }
                else if (inimigo1 == "morto" & inimigo2 == "vivo")
                {
                    xp();
                }
                else if (inimigo2 == "morto")
                {
                    mochila();
                }
                break;
            case 7:
                if (inimigo1 == "vivo")
                {
                    continuafund2();
                }
                else if (inimigo1 == "morto" & inimigo2 == "vivo")
                {
                    continuafund2();
                }
                else if (inimigo2 == "morto")
                {
                    mochila();
                }
                break;
            default:
                continuafund2();
                break;
        }
    }

    static void anof1()
    {
        if (nomeI == "João Lucas com dengue")
        {
            confirma6 = "";
            itemDI = "Tampa de lixo";
            finalBF2 = 1;
            Console.Clear();
            Console.WriteLine("Savio: Chegamos, vou perguntar se alguem viu algo.");
            Console.ReadLine();
            Console.WriteLine("Savio: Ola gente alguem aqui viu uma linda e brilhante bola?");
            Console.ReadLine();
            Console.WriteLine("Sala: OHHHHHHH...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + $": Olha ali Savio o {nomeI} ta panguando.");
            Console.ReadLine();
            Console.WriteLine($"Savio: Ei {nomeI} se faz de doido é cade a bola?");
            Console.ReadLine();
            Console.WriteLine(nomeI + ": Oia sei lá...");
            Console.ReadLine();
            Console.WriteLine(nomeI + ": Mas agora eu vou descer a porrada nesse doidinho ai oh.");
            Console.ReadLine();
            Console.WriteLine(nome + ": Em mim, pois cai dentro pai vai passar mal.");
            Console.ReadLine();
        }
        else if (nomeI == "Pikinha")
        {
            confirma7 = "";
            itemDI = "Carrinho da volvo";
            finalBF2 = 2;
            Console.Clear();
            Console.WriteLine("Savio: Chegamos, vou analisar se alguém aqui viu alguma coisa.");
            Console.ReadLine();
            Console.WriteLine("Savio: Ola gente alguem aqui viu uma linda e brilhante bola?");
            Console.ReadLine();
            Console.WriteLine("Sala: hummmmmmmm....");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + $": O que é isso ali savio, o {nomeI} parecendo suspeito!!");
            Console.ReadLine();
            Console.WriteLine($"Savio: Ei {nomeI} tu ta com a bola bixão?");
            Console.ReadLine();
            Console.WriteLine(nomeI + ": Claro que não né...");
            Console.ReadLine();
            Console.WriteLine(nomeI + ": Mas agora eu vou descer a porrada nesse doidinho ai que ta me acusando.");
            Console.ReadLine();
            Console.WriteLine(nome + ": Em mim? Pois vem pra cima.");
            Console.ReadLine();
        }
        else if (nomeI == "Gola alta")
        {
            confirma8 = "";
            itemDI = "Conexão veloz";
            finalBF2 = 3;
            Console.Clear();
            Console.WriteLine("Savio: Chegamos, vou perguntar se alguem percebeu alguma coisa.");
            Console.ReadLine();
            Console.WriteLine("Savio: Ola gente alguem aqui viu uma linda e brilhante bola?");
            Console.ReadLine();
            Console.WriteLine("Sala: hammmmmm...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + $": Olha ali Savio o {nomeI} ta tentando esconder alguma coisa.");
            Console.ReadLine();
            Console.WriteLine($"Savio: Ei {nomeI} ta escondendo alguma coisa?");
            Console.ReadLine();
            Console.WriteLine(nomeI + ": claro que não sávio...");
            Console.ReadLine();
            Console.WriteLine(nomeI + ": Mas agora eu vou quebrar esses cara que me acusou ai, se faz de doido.");
            Console.ReadLine();
            Console.WriteLine(nome + ": Comigo? Pois eu duvido tu ganhar de mim.");
            Console.ReadLine();
        }
        escolhaItem();
    }

    static void escolhaItem()
    {
        int resp;
        Console.Clear();
        Console.WriteLine($"Escolha o item que você quer usar em batalha");
        for (int i = 0; i < itensbatalha.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {itensbatalha[i]}");
        }
        System.Console.WriteLine("6 - Nenhum");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                if (itensbatalha[0] == "")
                {
                    Console.WriteLine("Escolha invalida");
                    Console.ReadLine();
                    escolhaItem();
                }
                else
                {
                    atkB = atk;
                    defB = def;
                    speB = spe;
                    itemb = itensbatalha[0];
                    Console.WriteLine($"Savio: Você escolheu o {itemb} para batalha");
                    Console.ReadLine();
                    inicioBatalha();
                }
                break;
            case 2:
                if (itensbatalha[1] == "")
                {
                    Console.WriteLine("Escolha invalida");
                    Console.ReadLine();
                    escolhaItem();
                }
                else
                {
                    atkB = atk;
                    defB = def;
                    speB = spe;
                    itemb = itensbatalha[1];
                    Console.WriteLine($"Savio: Você escolheu o {itensbatalha[1]} para batalha");
                    Console.ReadLine();
                    inicioBatalha();
                }
                break;
            case 3:
                if (itensbatalha[2] == "")
                {
                    Console.WriteLine("Escolha invalida");
                    Console.ReadLine();
                    escolhaItem();
                }
                else
                {
                    atkB = atk;
                    defB = def;
                    speB = spe;
                    itemb = itensbatalha[2];
                    Console.WriteLine($"Savio: Você escolheu o {itensbatalha[2]} para batalha");
                    Console.ReadLine();
                    inicioBatalha();
                }
                break;
            case 4:
                if (itensbatalha[3] == "")
                {
                    Console.WriteLine("Escolha invalida");
                    Console.ReadLine();
                    escolhaItem();
                }
                else
                {
                    atkB = atk;
                    defB = def;
                    speB = spe;
                    itemb = itensbatalha[3];
                    Console.WriteLine($"Savio: Você escolheu o {itensbatalha[3]} para batalha");
                    Console.ReadLine();
                    inicioBatalha();
                }
                break;
            case 5:
                if (itensbatalha[4] == "")
                {
                    Console.WriteLine("Escolha invalida");
                    Console.ReadLine();
                    escolhaItem();
                }
                else
                {
                    atkB = atk;
                    defB = def;
                    speB = spe;
                    itemb = itensbatalha[4];
                    Console.WriteLine($"Savio: Você escolheu o {itensbatalha[4]} para batalha");
                    Console.ReadLine();
                    inicioBatalha();
                }
                break;
            case 6:
                atkB = atk;
                defB = def;
                speB = spe;
                itemb = "nada";
                Console.WriteLine("Savio: você não escolheu nenhum item para batalha(burro)");
                Console.ReadLine();
                inicioBatalha();
                break;
            default:
                escolhaItem();
                break;
        }
    }

    static void ano9()
    {
        if (nomeI == "Das Loira")
        {
            confirma9 = "";
            itemDI = "Biscoito";
            finalBF2 = 4;
        }
        Console.Clear();
        Console.WriteLine("Savio: É aqui, 9° ano...");
        Console.ReadLine();
        Console.WriteLine($"Savio: Olha ali {nome} tá vendo, o {nomeI} ta com alguma coisa na mão");
        Console.ReadLine();
        Console.WriteLine(nome + $": olha ai man, achamos a bola finalmente");
        Console.ReadLine();
        Console.WriteLine(nome + ": EI DAS LOIRA SE FAZ DE DOIDO É");
        Console.ReadLine();
        Console.WriteLine(nomeI + ": Que é man, que vocês já tão aqui");
        Console.ReadLine();
        Console.WriteLine(nome + ": Nois veio te encher de porrada");
        Console.ReadLine();
        Console.WriteLine(nomeI + ": hahaha como se você conseguisse");
        Console.ReadLine();
        escolhaItem();
    }

    static void ensinoMedio()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Savio: Ensino médio, pra onde vamos agora?");
        Console.WriteLine("");
        Console.WriteLine("1 - 1° ANO");
        Console.WriteLine("2 - 2° ANO");
        Console.WriteLine("3 - 3° ANO");
        Console.WriteLine("4 - Voltar");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                ano1M();
                break;
            case 2:
                ano2M();
                break;
            case 3:
                ano3M();
                break;
            case 4:
                continuafund2();
                break;
            default:
                break;
        }

    }

    static void ano1M()
    {
        Console.Clear();
        Console.WriteLine("Savio: Oia tem nada aqui, só esses mongol do 1° ano ai...");
        Console.ReadLine();
        ensinoMedio();
    }

    static void ano2M()
    {
        if (inimigo3 == "vivo")
        {
            Console.Clear();
            Console.WriteLine($"Savio: CUIDADO {nome} É A AULA DO CARLÃO");
            Console.ReadLine();
            Console.WriteLine(nome + ": NÃOOOO...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Você ficou na aula do carlão, e ele chamou sua atenção 667 vezes");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(nome + ": Vhish quero ficar nessa aula não, vou gazear");
            Console.ReadLine();
            Console.WriteLine("Carlão: O queee? voce so poderá sair com uma condição");
            Console.ReadLine();
            Console.WriteLine("Carlão: VOCÊ TERÁ QUE ACERTAR NO MÍNIMO 3/5 QUESTÕES SOBRE MINHA MATÉRIA");
            Console.ReadLine();
            Console.Clear();
            carlaoProva();
        }
    }

    static void carlaoProva()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Em que ano começou a Segunda Guerra Mundial?");
        Console.WriteLine("");
        Console.WriteLine("1 - 1937");
        Console.WriteLine("2 - 1939");
        Console.WriteLine("3 - 1941");
        Console.WriteLine("4 - nenhuma opção está correta");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Resposta correta");
                Console.ReadLine();
                pontos++;
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            default:
                carlaoProva();
                break;
        }
        carlaoProva2();
    }

    static void carlaoProva2()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Qual foi o principal país do Eixo na Europa");
        Console.WriteLine("");
        Console.WriteLine("1 - a) Reino Unido");
        Console.WriteLine("2 - b) Alemanha");
        Console.WriteLine("3 - c) França");
        Console.WriteLine("4 - nenhuma opção está correta");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Resposta correta");
                Console.ReadLine();
                pontos++;
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            default:
                carlaoProva2();
                break;

        }
        carlaoProva2();
    }
    static void carlaoProva3()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Quem era o líder da União Soviética durante a guerra?");
        Console.WriteLine("");
        Console.WriteLine("1 - Vladimir Putin");
        Console.WriteLine("2 - Mussolini");
        Console.WriteLine("3 - Adolf Hitler");
        Console.WriteLine("4 - Joseph Stalin");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();

                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Resposta Correta");
                Console.ReadLine();
                pontos++;
                break;
            default:
                carlaoProva3();
                break;
        }
    }

    static void carlaoProva4()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Qual evento é considerado o ponto de partida da guerra?");
        Console.WriteLine("");
        Console.WriteLine("1 - a) Invasão da Polônia");
        Console.WriteLine("2 - b) Bombardeio de Pearl Harbor");
        Console.WriteLine("3 - c) Batalha de Stalingrado");
        Console.WriteLine("4 - d) Morte de Francisco Ferdinando");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Resposta correta");
                Console.ReadLine();
                pontos++;
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();

                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            default:
                carlaoProva4();
                break;
        }
    }

    static void carlaoProva5()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Qual foi o nome da operação que levou ao desembarque da Normandia?");
        Console.WriteLine("");
        Console.WriteLine("1 - a) Operação Barbarrosa");
        Console.WriteLine("2 - b) Operação Overlord");
        Console.WriteLine("3 - c) Operação Torch");
        Console.WriteLine("4 - d) Operação Varsity");
        int.TryParse(Console.ReadLine(), out resp);
        switch (resp)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();

                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Resposta correta");
                Console.ReadLine();
                pontos++;

                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Resposta errada");
                Console.ReadLine();
                break;
            default:
                carlaoProva5();
                break;
        }
        carlaovitoria();
    }

    static void carlaovitoria()
    {
        Console.Clear();
        if (pontos >= 3)
        {
            Console.Clear();
            Console.WriteLine("VOCÊ VENCEU");
            Console.ReadLine();
            Console.WriteLine("Carlão: Parabéns, você agora pode continuar pela sua gradiosa busca jovem");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("VOCÊ GANHOU 100 DE XP");
            xpJ = 100;
            Console.ReadLine();
            Console.Clear();
            xp();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("VOCÊ PERDEU HAHAHAHA");
            Console.ReadLine();
            System.Console.WriteLine("Carlão: Você agora vai ficar fazendo portifólio comigo hahahahahaha");
            Console.ReadLine();
            Console.Clear();
            finalR2();
        }
    }

    static void ano3M()
    {
        finalBF2 = 5;
        Console.Clear();
        Console.WriteLine($"Savio: OLHAA {nome}, aquele brilho... ");
        Console.ReadLine();
        Console.WriteLine($"Savio: Aquela beleza... ");
        Console.ReadLine();
        Console.WriteLine(nome + " NÃOOOO..., ARBUSTO meu amigo...");
        Console.ReadLine();
        Console.WriteLine(nome + " Quer dizer ex-amigo");
        Console.ReadLine();
        Console.WriteLine("Arbusto: Roubei sua bola pra você nunca mais me empurra no hino...");
        Console.ReadLine();
        Console.WriteLine(nome + ": Oia ai man, se faz de doido é, foi sem querer");
        Console.WriteLine("Arbusto: Sem querer o caramba, vamo lutar...");
        Console.ReadLine();
        escolhaItem();
    }

    static void inicioBatalha()
    {
        Console.Clear();
        Console.WriteLine($"Batalha contra {nomeI}");
        Console.ReadLine();
        if (itemb == "Mistão" || itemb == "Refri" || itemb == "Café")
        {
            if (itemb == "Mistão")
            {
                atkB = atk + ((atk / 100) * 15);
                Console.Clear();
                Console.WriteLine(nome + " comeu um mistão de cruel e teve seu ataque revigorado");
                Console.ReadLine();
                Console.WriteLine($"O ataque de {nome} aumentou em 15% na batalha");
                Console.ReadLine();
            }
            else if (itemb == "Refri")
            {
                defB = def + ((def / 100) * 15);
                Console.Clear();
                Console.WriteLine(nome + " tomou um refri geladasso e teve sua defesa revigorada");
                Console.ReadLine();
                Console.WriteLine($"A defesa de {nome} aumentou em 15% na batalha");
                Console.ReadLine();

            }
            else if (itemb == "Café")
            {
                speB = spe + ((spe / 100) * 15);
                Console.Clear();
                Console.WriteLine(nome + " tomou um café pra dar uma acordada e teve sua velocidade revigorada");
                Console.ReadLine();
                Console.WriteLine($"A velocidade de {nome} aumentou em 15% na batalha");
                Console.ReadLine();
            }
        }
        else if (itemb == "Carrinho da volvo")
        {
            atkB = atk + ((atkI1 / 100) * 10);
            atkI1 = atkI1 - ((atkI1 / 100) * 10);
            Console.Clear();
            Console.WriteLine(nome + $" lançou o carrinho da volvo no {nomeI} que papocou e fez com que {nome} absorvesse 10% do ataque de {nomeI}");
            Console.ReadLine();
            Console.WriteLine($"O ataque de {nome} aumentou em 10% e o ataque de {nomeI} diminuiu em 10%");
            Console.ReadLine();
        }
        else if (itemb == "Tampa de lixo")
        {
            defB = def + ((defI1 / 100) * 10);
            defI1 = defI1 - ((defI1 / 100) * 10);
            Console.Clear();
            Console.WriteLine(nome + $" usou a tampa de lixo como escudo que fez com que {nome} absorvesse 10% da defesa de {nomeI}");
            Console.ReadLine();
            Console.WriteLine($"A defesa de {nome} aumentou em 10% e a defesa de {nomeI} diminuiu em 10%");
            Console.ReadLine();
        }
        else if (itemb == "Conexão veloz")
        {
            speB = spe + ((speI1 / 100) * 10);
            speI1 = speI1 - ((speI1 / 100) * 10);
            Console.Clear();
            Console.WriteLine(nome + $" acerta bem na conexão do {nomeI} que fez com que {nome} absorvesse 10% da velocidade de {nomeI}");
            Console.ReadLine();
            Console.WriteLine($"A velocidade de {nome} aumentou em 10% e a velocidade de {nomeI} diminui em 10%");
            Console.ReadLine();
        }
        else if (itemb == "Biscoito")
        {
            atkB = atk + ((atk / 100) * 10); ;
            defB = def + ((def / 100) * 10); ;
            speB = spe + ((spe / 100) * 10); ;
            Console.Clear();
            Console.WriteLine(nome + $" come um pacote de bsicoito com saco e tudo e se revigora por completo");
            Console.ReadLine();
            Console.WriteLine($"Todos os atributos de {nome} foram aumentados em 10%");
            Console.ReadLine();
        }
        batalha();
    }

    static void batalha()
    {
        int resultadodadoJ;
        int resultadodadoI;
        int round = 0;
        if (speB >= speI1)
        {
            Console.Clear();
            Console.WriteLine(nome + " é mais rapido e vai começar 1°");
            Console.WriteLine("");
            Console.ReadLine();
            while (defI1 > 0 & defB > 0)
            {
                round++;
                if (defI1 > 0 & defB > 0)
                {
                    Console.WriteLine($"{round}° Rodada");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $": ATK:{atkB} DEF:{defB}");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $": ATK:{atkI1} DEF:{defI1}");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para você rolar o dado");
                    Console.ReadLine();
                    Console.Clear();
                    resultadodadoJ = dadoJ();
                    Console.WriteLine($"Você rolou o dado e tirou {resultadodadoJ}");
                    Console.ReadLine();
                    Console.WriteLine($"Você deu {atkB1} de dano");
                    Console.ReadLine();
                    defI1 = defI1 - atkB1;
                    Console.WriteLine(nomeI + $" perdeu {atkB1} de vida");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (defB < 0)
                {
                    Console.WriteLine("VOCÊ PERDEU :(");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $" ficou sem forças e tomou um pau do {nomeI}");
                    Console.ReadLine();
                    resultado = "perdeu";
                }
                else if (defI1 < 0)
                {
                    Console.WriteLine("VOCÊ VENCEU :)");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $" ficou sem forças e tomou um pau de {nome}");
                    Console.ReadLine();
                    resultado = "venceu";
                }
                if (defI1 > 0 & defB > 0)
                {
                    Console.WriteLine($"{round}° Rodada");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $": ATK:{atkB} DEF:{defB}");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $": ATK:{atkI1} DEF:{defI1}");
                    Console.WriteLine("");
                    Console.WriteLine($"Aperte ENTER para o {nomeI} rolar o dado");
                    Console.ReadLine();
                    resultadodadoI = dadoI();
                    Console.WriteLine($"{nomeI} rolou o dado e tirou {resultadodadoI}");
                    Console.ReadLine();
                    Console.WriteLine($"{nomeI} deu {atkBI} de dano");
                    Console.ReadLine();
                    defB = defB - atkBI;
                    Console.WriteLine(nome + $" perdeu {atkBI} de vida");
                    Console.ReadLine();
                    Console.Clear();
                    if (defB < 0)
                    {
                        Console.WriteLine("VOCÊ PERDEU :(");
                        Console.WriteLine("");
                        Console.WriteLine(nome + $" ficou sem forças e tomou um pau do {nomeI}");
                        Console.ReadLine();
                        resultado = "perdeu";
                    }
                    else if (defI1 < 0)
                    {
                        Console.WriteLine("VOCÊ VENCEU :)");
                        Console.WriteLine("");
                        Console.WriteLine(nomeI + $" ficou sem forças e tomou um pau de {nome}");
                        Console.ReadLine();
                        resultado = "venceu";
                    }
                }
                else if (defB < 0)
                {
                    Console.WriteLine("VOCÊ PERDEU :(");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $" ficou sem forças e tomou um pau do {nomeI}");
                    Console.ReadLine();
                }
                else if (defI1 < 0)
                {
                    Console.WriteLine("VOCÊ VENCEU :)");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $" ficou sem forças e tomou um pau de {nome}");
                    Console.ReadLine();
                    resultado = "venceu";
                }
            }
            round = 0;
            inimigoDerrotado();
        }

        else if (speB < speI1)
        {
            Console.Clear();
            Console.WriteLine(nomeI + " é mais rapido e vai começar 1°");
            Console.WriteLine("");
            Console.ReadLine();
            while (defI1 > 0 & defB > 0)
            {
                round++;
                if (defI1 > 0 & defB > 0)
                {
                    Console.WriteLine($"{round}° Rodada");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $": ATK:{atkB} DEF:{defB}");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $": ATK:{atkI1} DEF:{defI1}");
                    Console.WriteLine("");
                    Console.WriteLine($"Aperte ENTER para o {nomeI} rolar o dado");
                    Console.ReadLine();
                    resultadodadoI = dadoI();
                    Console.WriteLine($"{nomeI} rolou o dado e tirou {resultadodadoI}");
                    Console.ReadLine();
                    Console.WriteLine($"{nomeI} deu {atkBI} de dano");
                    Console.ReadLine();
                    defB = defB - atkBI;
                    Console.WriteLine(nome + $" perdeu {atkBI} de vida");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (defB <= 0)
                {
                    Console.WriteLine("VOCÊ PERDEU :(");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $" ficou sem forças e tomou um pau do {nomeI}");
                    Console.ReadLine();
                    resultado = "perdeu";
                }
                else if (defI1 <= 0)
                {
                    Console.WriteLine("VOCÊ VENCEU :)");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $" ficou sem forças e tomou um pau de {nome}");
                    Console.ReadLine();
                    resultado = "venceu";

                }
                if (defI1 > 0 & defB > 0)
                {
                    Console.WriteLine($"{round}° Rodada");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $": ATK:{atkB} DEF:{defB}");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $": ATK:{atkI1} DEF:{defI1}");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para você rolar o dado");
                    Console.ReadLine();
                    Console.Clear();
                    resultadodadoJ = dadoJ();
                    Console.WriteLine($"Você rolou o dado e tirou {resultadodadoJ}");
                    Console.ReadLine();
                    Console.WriteLine($"Você deu {atkB1} de dano");
                    Console.ReadLine();
                    defI1 = defI1 - atkB1;
                    Console.WriteLine(nomeI + $" perdeu {atkB1} de vida");
                    Console.ReadLine();
                    Console.Clear();
                    if (defB <= 0)
                    {
                        Console.WriteLine("VOCÊ PERDEU :(");
                        Console.WriteLine("");
                        Console.WriteLine(nome + $" ficou sem forças e tomou um pau do {nomeI}");
                        Console.ReadLine();
                        resultado = "perdeu";
                    }
                    else if (defI1 <= 0)
                    {
                        Console.WriteLine("VOCÊ VENCEU :)");
                        Console.WriteLine("");
                        Console.WriteLine(nomeI + $" ficou sem forças e tomou um pau de {nome}");
                        Console.ReadLine();
                        resultado = "venceu";
                    }
                }
                else if (defB <= 0)
                {
                    Console.WriteLine("VOCÊ PERDEU :(");
                    Console.WriteLine("");
                    Console.WriteLine(nome + $" ficou sem forças e tomou um pau do {nomeI}");
                    Console.ReadLine();
                    resultado = "perdeu";
                }
                else if (defI1 <= 0)
                {
                    Console.WriteLine("VOCÊ VENCEU :)");
                    Console.WriteLine("");
                    Console.WriteLine(nomeI + $" ficou sem forças e tomou um pau de {nome}");
                    Console.ReadLine();
                    resultado = "venceu";
                }
            }
            round = 0;
            inimigoDerrotado();
        }
    }

    static void inimigoDerrotado()
    {
        if (resultado == "venceu")
        {
            Console.Clear();
            System.Console.WriteLine(nome + $" ganhou {xpI} de XP");
            Console.ReadLine();
            xpJ = xpJ + xpI;
            Console.Clear();
            switch (finalBF2)
            {
                case 1:
                    Console.WriteLine(nomeI + ": Eita pae tu é forte viu...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Mas agora falando serio eu juro que vi o Das Loira com essa bola");
                    Console.ReadLine();
                    if (inimigo2 == "vivo")
                    {
                        Console.WriteLine(nome + ": Das Loira...");
                        Console.ReadLine();
                        Console.WriteLine(nome + ": Valeu pae ajudou demais já...");
                        Console.ReadLine();
                        Console.WriteLine($"Dica: Das Loira, elemento suspeito");
                        Console.ReadLine();
                        Console.WriteLine(nome + $" colocou Dica na mochila");
                        itensDica[dicaC] = "Das Loira suspeito";
                        dicaC++;
                    }
                    else if (inimigo2 == "morto")
                    {
                        Console.WriteLine(nome + ": Pior que nem foi ele já perguntei");
                        Console.ReadLine();
                        Console.WriteLine(nome + ": Mas valeu pae ajudou demais já...");
                        Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine(nomeI + ": Espera tenho uma coisa para você...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Pegue isso vai ajudar você, é um escudo magico que eu ganhei de um mago");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $" recebeu o item tampa de lixo de {nomeI}");
                    Console.ReadLine();
                    itensbatalha[itemBC] = "Tampa de lixo";
                    itemBC++;
                    Console.WriteLine(nome + $" colocou a porr* de uma tampa de lixo na mochila");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $": Valeu {nomeI} representou");
                    Console.ReadLine();
                    inimigo1 = "morto";
                    break;
                case 2:
                    Console.WriteLine(nomeI + ": Meu deus eu perdi feio, sou um merda ...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Eu vou falar tudo que sei, vi um pivete com a camisa do 3° ano com uma brilhante bola");
                    Console.ReadLine();
                    Console.WriteLine(nome + ": Putz, tem muita gente do 3° ano aqui na escola");
                    Console.ReadLine();
                    Console.WriteLine(nome + ": Mas valeu pae ajudou demais já...");
                    Console.ReadLine();
                    Console.WriteLine($"Dica: Pessoa do 3° ano suspeita");
                    Console.ReadLine();
                    Console.WriteLine(nome + $" colocou Dica na mochila");
                    itensDica[dicaC] = "Camisa do 3° ano";
                    dicaC++;
                    Console.Clear();
                    Console.WriteLine(nomeI + ": Espera tenho uma coisa para você...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": é um carrinho volvo, quando voce usa ele explode no inimigo e dá um baita dano");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $" recebeu o item carrinho da volvo de {nomeI}");
                    Console.ReadLine();
                    itensbatalha[itemBC] = "Carrinho da volvo";
                    itemBC++;
                    Console.WriteLine(nome + $" colocou o Carrinho da volvo na mochila");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $": Valeu {nomeI} representou");
                    Console.ReadLine();
                    inimigo1 = "morto";
                    break;
                case 3:
                    Console.WriteLine(nomeI + ": Eita man acertou bem na minha conexão oh...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Mas agora falando serio eu não vi absolutamente nada só queria brigar mesmo");
                    Console.ReadLine();
                    Console.WriteLine(nome + $": Beleza, foi mal ai valeu...");
                    Console.Clear();
                    Console.WriteLine(nomeI + ": Espera tenho uma coisa para você...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Pegue isso vai ajudar você, é um item que sempre acerta a conexão da pessoa...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $" recebeu o item conexao veloz de {nomeI}");
                    Console.ReadLine();
                    itensbatalha[itemBC] = "Conexao veloz";
                    itemBC++;
                    Console.WriteLine(nome + $" colocou a conexao veloz na mochila");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $": Valeu {nomeI} representou");
                    Console.ReadLine();
                    inimigo1 = "morto";
                    break;
                case 4:
                    Console.WriteLine(nomeI + ": Aii minha barrigona gigantamente grande..");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Mas agora falando serio eu não vi absolutamente nada só queria brigar mesmo");
                    Console.ReadLine();
                    Console.WriteLine(nome + $": Beleza, foi mal ai valeu...");
                    Console.Clear();
                    Console.WriteLine(nomeI + ": Espera tenho uma coisa para você meu gostoso...");
                    Console.ReadLine();
                    Console.WriteLine(nomeI + ": Aqui oh é um bisoito amori de chocolate");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $" recebeu o item biscoito de {nomeI}");
                    Console.ReadLine();
                    itensbatalha[itemBC] = "Biscoito";
                    itemBC++;
                    Console.WriteLine(nome + $" colocou o biscoito ruim na mochila");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(nome + $": Po**a Das Loira esse biscoito é uma merda");
                    Console.ReadLine();
                    inimigo2 = "morto";
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Arbusto: Parabens... ,você venceu...");
                    Console.ReadLine();
                    finalB();
                    break;
            }
            xp();
        }
        else if (resultado == "perdeu")
        {
            Console.Clear();
            Console.WriteLine($"Você morreu pro {nomeI}, mds kk");
            Console.ReadLine();
            finalR1();
        }
    }

    static void xp()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Qual atributo você deseja evoluir");
        Console.WriteLine("Cada ponto de XP aumenta diretamente o atributo esolhido");
        Console.WriteLine($"Seus atributos:Atk:{atk},Def:{def},Spe:{spe}");
        Console.WriteLine($"Você tem {xpJ} pontos de XP");
        Console.WriteLine("");
        Console.WriteLine("1- Ataque");
        Console.WriteLine("2- Defesa");
        Console.WriteLine("3- Velocidade");
        Console.WriteLine("4- Voltar");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp)
        {
            case 1:
                int resp1;
                Console.Clear();
                Console.WriteLine("Quantos pontos de XP você deseja usar no atributo de ataque");
                Console.WriteLine($"Você tem {xpJ} pontos de XP");
                Console.WriteLine("");
                Console.Write("Resposta: ");
                int.TryParse(Console.ReadLine(), out resp1);
                if (resp1 > xpJ)
                {
                    Console.Clear();
                    Console.WriteLine("Você não tem pontos de experiencia suficientes");
                    Console.ReadLine();
                    xp();
                }
                else if (resp1 <= xpJ)
                {
                    Console.Clear();
                    atk = atk + resp1;
                    xpJ = xpJ - resp1;
                    Console.WriteLine($"Voce aumentou seu ataque em {resp1} pontos");
                    Console.WriteLine($"Agora seu ataque atual é de {atk}");
                    Console.ReadLine();
                    xp();
                }
                break;
            case 2:
                int resp2;
                Console.Clear();
                Console.WriteLine("Quantos pontos de XP você deseja usar no atributo de defesa");
                Console.WriteLine($"Você tem {xpJ} pontos de XP");
                Console.WriteLine("");
                Console.Write("Resposta: ");
                int.TryParse(Console.ReadLine(), out resp2);
                if (resp2 > xpJ)
                {
                    Console.Clear();
                    Console.WriteLine("Você não tem pontos de experiencia suficientes");
                    Console.ReadLine();
                    xp();
                }
                else if (resp2 <= xpJ)
                {
                    Console.Clear();
                    def = def + resp2;
                    xpJ = xpJ - resp2;
                    Console.WriteLine($"Voce aumentou sua defesa em {resp2} pontos");
                    Console.WriteLine($"Agora seu defesa atual é de {def}");
                    Console.ReadLine();
                    xp();
                }
                break;
            case 3:
                int resp3;
                Console.Clear();
                Console.WriteLine("Quantos pontos de XP você deseja usar no atributo de velocidade");
                Console.WriteLine($"Você tem {xpJ} pontos de XP");
                Console.WriteLine("");
                Console.Write("Resposta: ");
                int.TryParse(Console.ReadLine(), out resp3);
                if (resp3 > xpJ)
                {
                    Console.Clear();
                    Console.WriteLine("Você não tem pontos de experiencia suficientes");
                    Console.ReadLine();
                    xp();
                }
                else if (resp3 <= xpJ)
                {
                    Console.Clear();
                    spe = spe + resp3;
                    xpJ = xpJ - resp3;
                    Console.WriteLine($"Voce aumentou sua velocidade em {resp3} pontos");
                    Console.WriteLine($"Agora sua velocidade atual é de {spe}");
                    Console.ReadLine();
                    xp();
                }
                break;
            case 4:
                continuafund2();
                break;
            default:
                xp();
                break;
        }
    }

    static void mochila()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Qual bolso da mochila você deseja abrir");
        Console.WriteLine("");
        Console.WriteLine("1 - Itens de batata");
        Console.WriteLine("2 - Itens de dica");
        Console.WriteLine("3 - Voltar");
        int.TryParse(Console.ReadLine(), out resp);

        switch (resp)
        {
            case 1:
                itensBatalha();
                break;
            case 2:
                itenDica();
                break;
            case 3:
                continuafund2();
                break;
            default:
                mochila();
                break;
        }
    }

    static void itensBatalha()
    {
        Console.Clear();
        Console.WriteLine("Bolso de itens de batalha");
        for (int i = 0; i < itensbatalha.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {itensbatalha[i]}");
        }
        Console.WriteLine("Aperte ENTER para voltar");
        Console.ReadLine();
        mochila();
    }

    static void itenDica()
    {
        Console.Clear();
        Console.WriteLine("Bolso de dicas");
        for (int i = 0; i < itensbatalha.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {itensDica[i]}");
        }
        Console.WriteLine("Aperte ENTER para voltar");
        Console.ReadLine();
        mochila();
    }

    static int dadoJ()
    {
        Random random = new Random();
        int dadoJ = random.Next(1, 7); // Gera um número de 1 a 6
        switch (dadoJ)
        {
            case 1:
                atkB1 = atkB / 6;
                break;
            case 2:
                atkB1 = atkB / 5;
                break;
            case 3:
                atkB1 = atkB / 4;
                break;
            case 4:
                atkB1 = atkB / 3;
                break;
            case 5:
                atkB1 = atkB / 2;
                break;
            case 6:
                atkB1 = atkB;
                break;
        }
        return dadoJ;
    }

    static int dadoI()
    {
        Random random = new Random();
        int dadoI = random.Next(1, 7); // Gera um número de 1 a 6
        switch (dadoI)
        {
            case 1:
                atkBI = atkI1 / 6;
                break;
            case 2:
                atkBI = atkI1 / 5;
                break;
            case 3:
                atkBI = atkI1 / 4;
                break;
            case 4:
                atkBI = atkI1 / 3;
                break;
            case 5:
                atkBI = atkI1 / 2;
                break;
            case 6:
                atkBI = atkI1;
                break;
        }
        return dadoI;
    }

    static void procura1()
    {
        Console.Clear();
        Console.WriteLine(nome + ": Já sei, agora vou atrás de pistas");
        Console.ReadLine();
        Console.Clear();
        procuralocal();
    }

    static void procuralocal()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Aonde você deseja procurar? ");
        Console.WriteLine("");
        Console.WriteLine($"1- {l1}");
        Console.WriteLine($"2- {l2}");
        Console.WriteLine($"3- {l3}");
        Console.WriteLine("4- Voltar para o pátio");
        int.TryParse(Console.ReadLine(), out resp);
        Console.Clear();

        switch (resp)
        {
            case 1:
                dicaFalsa1();
                break;
            case 2:
                dicaFalsa2();
                break;
            case 3:
                DicaVerdadeira();
                break;
            case 4:
                perda();
                break;
            default:
                procuralocal();
                break;
        }
    }

    static void dicaFalsa1()
    {
        Console.Clear();
        Console.WriteLine($"Não foi encontrado nada em {l1}.");
        Console.ReadLine();
        procuralocal();
    }

    static void dicaFalsa2()
    {
        Console.Clear();
        Console.WriteLine($"Não foi encontrado nada em {l2}");
        Console.ReadLine();
        procuralocal();
    }

    static void DicaVerdadeira()

    {
        string? dica = "";
        if (dica == "dica")
        {
            Console.WriteLine($"Não foi encontrado nada em {l3}.");
            Console.ReadLine();
            procuralocal();
        }
        else
        {
            itensDica[dicaC] = "Fio de cabelo ruivo";
            dicaC++;
            dica = "dica";
            Console.WriteLine(nome + ": Olha!!!, oq é isso?");
            Console.ReadLine();
            Console.WriteLine(nome + ": Uma dica!!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Dica {dicaC}: Um fio de cabelo ruivo");
            Console.ReadLine();
            Console.WriteLine(nome + ": Interessante");
            Console.ReadLine();
            Console.WriteLine(nome + $" botou a dica {dicaC} na mochila");
            Console.ReadLine();
            procuralocal();
        }

    }
    static void falar()
    {
        Console.Clear();
        Console.WriteLine(nome + ": Já sei, vou falar com a galera por ai!");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("04/09/2024");
        Console.WriteLine("Quarta-feira");
        Console.WriteLine("Portão de entrada da escola tapaue");
        Console.ReadLine();
        fala1();
    }

    static void fala1()
    {
        int resp;
        Console.Clear();
        Console.WriteLine("Com quem você deseja falar?");
        Console.WriteLine("");
        Console.WriteLine("1- Sergio (Insepetor)");
        Console.WriteLine("2- Mariana (amiga)");
        Console.WriteLine("3- Carlão (Professor)");
        Console.WriteLine("4- Voltar para o pátio");
        int.TryParse(Console.ReadLine(), out resp);
        Console.Clear();

        switch (resp)
        {
            case 1:
                sergio();
                break;
            case 2:
                mariana();
                break;
            case 3:
                carlao();
                break;
            case 4:
                perda();
                break;
            default:
                fala1();
                break;
        }
    }

    static void sergio()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Ei Sérgio, a gente perdeu a nossa bola em {local}, você viu alguma coisa?");
        Console.ReadLine();
        Console.WriteLine($"Sérgio: Eu vi quando vocês colocaram a bola em {local}, e vi dois vultos passando pelo {l3} mas não vi quem era ao certo...");
        Console.ReadLine();
        Console.WriteLine(nome + ": Obrigado pela informação Sérgio, valeu.");
        Console.ReadLine();
        Console.Clear();
        fala1();
    }

    static void mariana()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Mariana doida, a gente perdeu a nossa bola em {local}, tu viu alguém com a bola?");
        Console.ReadLine();
        Console.WriteLine($"Mariana: Não vi nada mas, vi uns meninos falando sobre a bola em {l2} mas não sei quem são os eles.");
        Console.ReadLine();
        Console.WriteLine(nome + ": Valeu, vou ver se consigo saber mais quem são esses caras...");
        Console.ReadLine();
        Console.WriteLine();
        Console.Clear();
        fala1();
    }

    static void carlao()
    {
        Console.Clear();
        Console.WriteLine(nome + $": Ei Carlão, a gente perdeu a nossa bola em {local}, você viu se alguem pegou?");
        Console.ReadLine();
        Console.WriteLine($"Carlão: Eu estava meditando no {local}, e vi umas pessoas em {l1} mas eles se locomoveram de forma exageradamente acelerada, que resultou em uma identificação cognitiva pífia...");
        Console.ReadLine();
        Console.WriteLine(nome + ": Tá certo Carlota, valeu ");
        Console.ReadLine();
        Console.Clear();
        fala1();
    }

    static void finalR1()
    {
        Console.Clear();
        Console.WriteLine("FINAL RUIM VOCÊ PERDEU VERGONHOSAMENTE");
        Console.WriteLine("FECHE O COMPUTADOR E VÁ CHORAR SEU RUIM");
        Console.ReadLine();
        Console.WriteLine("CAMELOW");
        Console.ReadLine();
    }

    static void finalR2()
    {
        Console.Clear();
        Console.WriteLine("FINAL RUIM VOCÊ MORREU DE TEDIO");
        Console.WriteLine("FECHE O COMPUTADOR E VÁ FAZER O PORTIFOLIO");
        Console.ReadLine();
        Console.WriteLine("CAMELOW");
        Console.ReadLine();
    }

    static void finalB()
    {
        Console.Clear();
        Console.WriteLine("FINAL BOM VOCÊ MATOU O ARBUSTO E RECUPEROU SUA LINDA E BRILAHNTE BOLA");
        Console.WriteLine("PARTIU FUTMESA ATE UMAS HORA");
        Console.ReadLine();
        Console.WriteLine("CAMELOW");
        Console.ReadLine();
    }

    static void introducao()
    {
        Console.Clear();
        Console.WriteLine("A seguir as instruções para você ter uma experiencia mais divertida do nosso jogo.");
        Console.WriteLine("");
        Console.WriteLine("Aperte ENTER para continuar");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("1°: Quando a fala de um personagem acabar e não houver nenhuma pergunta direta aperte enter para continuar.");
        Console.WriteLine("(tipo agora)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("2°: Quando um personagem fizer uma pergunta e houver opções com numeros na frente,escolha o numero que corresponde a escolha desejada.");
        Console.WriteLine("(igual o exemplo abaixo)");
        Console.WriteLine("");
        Console.WriteLine("1-Opção 1 ");
        Console.WriteLine("2-Opção 2 ");
        Console.WriteLine("3-Opção 3 ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("3°: Seja cuidadoso com suas escolhas...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("4° (e ultimo): Se divirtam.");
        Console.WriteLine("");
        Console.WriteLine("Aperte ENTER para voltar");
        Console.ReadLine();
        Console.Clear();
        menu();
    }

    static void equipe()
    {
        Console.Clear();
        Console.WriteLine("EQUIPE TAPAUÉ - A BOLA OF THE GOLD");
        Console.WriteLine("");
        Console.WriteLine("MEMBROS (e o Gustavo): ");
        Console.WriteLine("");
        Console.WriteLine("LUCAS AMARAL - @Sacul_amaralg");
        Console.WriteLine("NIORD MANEIRO -@AnãoCLT");
        Console.WriteLine("EDUARDO GOMES -@Pikinha_da_volvo");
        Console.WriteLine("SAMUEL BRADÃO -@Caça-Sapo_OfLagamar  ");
        Console.WriteLine("LUÍS GUSTAVO -@Feznada085 ");
        Console.WriteLine("LUCAS AZEVEDO -@Azeash.tortin");
        Console.WriteLine("MARIANA VITÓRIA -*******");
        Console.WriteLine("");
        Console.WriteLine("Aperte ENTER para voltar");
        Console.ReadLine();
        Console.Clear();
        menu();
    }
}