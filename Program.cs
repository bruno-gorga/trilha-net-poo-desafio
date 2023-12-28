using DesafioPOO.Models;
using System.Threading;

// Menu de navegação do usuário
static string MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("BEM VINDO À LOJA DE CELULARES!");
    Console.WriteLine("1 - Comprar Novo Celular");
    Console.WriteLine("2 - Acessar Celular");
    Console.WriteLine("3 - Sair da loja");
    Console.WriteLine("Por favor, digite a opção desejada: ");
    string opcaoMenu = Console.ReadLine();
    return opcaoMenu;
}

// Função que irá gerar os números de celular disponíveis para a linha, sem o DDD de cada estado
static string GeradorDeNumerosDeCelular()
{
    string numeroDeCelular = "";
    int i = 0;
    Random geradorDeNumeros = new Random();

    while (i <= 10)
    {
        numeroDeCelular = Convert.ToString(geradorDeNumeros.Next());
        i++;
    }
    return numeroDeCelular;
            
}


// Declarando as variáveis e inicializando o gerador de números para o IMEI
Random geradorDeNumerosImei = new Random();
string ddd;
string numeroDeCelular = "";
string numeroImei = "";
string numero = "";
string estado = "";
string fabricante = "";
var dataDaCompra = DateTime.Now;
int memoriaDoCelular = 0;
string memoriaDoCelularEntrada = "";
string opcaoCelular = "";
string opcaoIphone = "";
string opcaoNokia = "";
bool temCelularDisponivelNokia = false;
bool temCelularDisponivelIphone = false;

string opcaoMenu = MenuPrincipal();
while(opcaoMenu != "3")
{
    switch (opcaoMenu)
    {
        case "1":
                Console.Clear();
                Console.WriteLine("Digite o fabricante do celular que deseja (Nokia/iPhone):");
                fabricante = Console.ReadLine();
                while (fabricante != "Nokia" && fabricante != "iPhone")
                {   
                    Console.Clear();
                    Console.WriteLine("Erro. Modelo não disponível. Escolha novamente: ");
                    fabricante = Console.ReadLine();
                }

                Console.WriteLine("Digite seu estado: ");
                estado = Console.ReadLine();
                
                // Fazendo validação do estado digitado
                string [] estados = { "DF", "SP", "RJ", "ES", "MG", "RS", "SC", "PR", "MS", "MT", "GO", 
                "AM", "PA", "TO", "RO", "RR", "AP", "AC",
                "BA", "AL", "CE", "PE", "PI", "RN", "SE", "PB", "MA" };
                
                while(estados.Contains(estado) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Erro! Estado inválido. Digite novamente: ");
                    estado = Console.ReadLine();
                }


                // Cada estado tem o seu próprio DDD. Minha intenção foi simular uma compra de celular em uma loja, 
                // na qual o cliente precisa escolher os números disponíveis de uma operadora.
                if (estado == "DF")
                {
                    ddd = "+55 (61) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                    
                }
                else if (estado == "GO")
                {
                    ddd = "+55 (62) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "MT")
                {
                    ddd = "+55 (65) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "MS")
                {
                    ddd = "+55 (67) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "AL")
                {
                    ddd = "+55 (82) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "BA")
                {
                    ddd = "+55 (71) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "CE")
                {
                    ddd = "+55 (85) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "MA")
                {
                    ddd = "+55 (98) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "PB")
                {
                    ddd = "+55 (82) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "PE")
                {
                    ddd = "+55 (81) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "PI")
                {
                    ddd = "+55 (86) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "RN")
                {
                    ddd = "+55 (84) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "SE")
                {
                    ddd = "+55 (79) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "AC")
                {
                    ddd = "+55 (68) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "AP")
                {
                    ddd = "+55 (96) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "AM")
                {
                    ddd = "+55 (92) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "PA")
                {
                    ddd = "+55 (91) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "RO")
                {
                    ddd = "+55 (69) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "RR")
                {
                    ddd = "+55 (95) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "TO")
                {
                    ddd = "+55 (63) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "ES")
                {
                    ddd = "+55 (27) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "MG")
                {
                    ddd = "+55 (31) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "RJ")
                {
                    ddd = "+55 (21) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "SP")
                {
                    ddd = "+55 (11) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "PR")
                {
                    ddd = "+55 (41) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "RS")
                {
                    ddd = "+55 (51) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else if (estado == "SC")
                {
                    ddd = "+55 (47) 9";
                    numero = GeradorDeNumerosDeCelular();
                    numeroDeCelular = ddd + numero.Substring(0, 8);
                    Console.WriteLine("Seu número é: " + numeroDeCelular);
                }
                else 
                {
                    Console.WriteLine("Estado inválido. Digite novamente: ");
                    estado = Console.ReadLine();
                }
            
                // Quantidade de memória que o celular terá. Assim como na vida real, os celulares podem ter 4, 8 ou 16 GB 
                // de memória RAM
                
                Console.WriteLine("Digite a memória que você deseja (4, 8, 16): ");
                memoriaDoCelularEntrada = Console.ReadLine();
                
                // Verificação da entrada de dados
                while (memoriaDoCelularEntrada != "4" && memoriaDoCelularEntrada != "8" && memoriaDoCelularEntrada != "16")
                {
                    Console.Clear();
                    Console.WriteLine("Erro. Não há aparelhos com a memória selecionada. Digite novamente: ");
                    memoriaDoCelularEntrada = Console.ReadLine();
                }
                Console.WriteLine($"Memória selecionada: {memoriaDoCelularEntrada} GB");

                memoriaDoCelular = Convert.ToInt32(memoriaDoCelularEntrada);
                
                // Gerando número IMEI para o celular
                for (int i = 0; i <= 17; i++)
                {
                    numeroImei = Convert.ToString(geradorDeNumerosImei.Next());
                }
                Console.WriteLine("IMEI: " + numeroImei);
                
                // Instanciando o objeto celularNokia e imprimindo nota fiscal
                if (fabricante == "Nokia")
                {
                    Nokia celularNokia = new Nokia(numeroDeCelular, fabricante, numeroImei, memoriaDoCelular);
                    temCelularDisponivelNokia = true;
                    Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine("Celular Nokia comprado!");
                    Console.WriteLine("Nota fiscal");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Hora da compra: " + dataDaCompra);
                    Console.WriteLine("Número da linha: " + numeroDeCelular);
                    Console.WriteLine("Fabricante: " + fabricante);
                    Console.WriteLine("IMEI: " + numeroImei);
                    Console.WriteLine($"Memória: {memoriaDoCelular} GB");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    opcaoMenu = MenuPrincipal();
                }

                // Instanciando o objeto celularIphone e imprimindo nota fiscal
                else if (fabricante == "iPhone")
                {
                    Iphone celularIphone = new Iphone(numero, fabricante, numeroImei, memoriaDoCelular);
                    temCelularDisponivelIphone = true;
                    Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine("Celular iPhone comprado!");
                    Console.WriteLine("Nota fiscal");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Hora da compra: " + dataDaCompra);
                    Console.WriteLine("Número da linha: " + numeroDeCelular);
                    Console.WriteLine("Fabricante: " + fabricante);
                    Console.WriteLine("IMEI: " + numeroImei);
                    Console.WriteLine($"Memória: {memoriaDoCelular} GB");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    opcaoMenu = MenuPrincipal();
                }
                break;

        // Acessando os celulares
        case "2":
                Console.Clear();
                Console.WriteLine("Digite o celular que gostaria de acessar: ");
                Console.WriteLine("1 - Nokia\n2 - iPhone\n3 - Voltar ao menu inicial");
                opcaoCelular = Console.ReadLine();

                // Validando as entradas
                while(opcaoCelular != "1" && opcaoCelular != "2" && opcaoCelular != "3")
                {
                    Console.Clear();
                    Console.WriteLine("Erro. Opção inválida. Tente novamente.");
                    Console.WriteLine("Digite o celular que gostaria de acessar: ");
                    Console.WriteLine("1 - Nokia\n2 - iPhone\n3 - Voltar");
                    opcaoCelular = Console.ReadLine();
                }
                // Acessando o celular Nokia
                if (opcaoCelular == "1")
                {
                    // Caso o usuário não tenha criado um celular Nokia anteriormente
                    if (temCelularDisponivelNokia == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Não há nenhum celular Nokia disponível.");
                        Thread.Sleep(500); // O método Thread.Sleep foi colocado para que o usuário possa ler o motivo pelo qual a operação selecionada não pode ser executada
                        Console.WriteLine("1 - Nokia\n2 - iPhone\n3 - Voltar ao menu inicial");
                        string opcaoCelulariPhone = Console.ReadLine();
                        opcaoCelular = opcaoCelulariPhone;
                    }
                    else
                    {
                        Console.Clear();
                        Nokia celularNokia = new Nokia(numeroDeCelular, fabricante, numeroImei, memoriaDoCelular);
                        Console.WriteLine("Opção selecionada: Nokia");
                        Console.WriteLine("1 - Ligar\n2 - Receber uma ligação\n3 - Instalar um Aplicativo\n4 - Voltar ao menu anterior");
                        Console.WriteLine("Digite sua opção: ");
                        opcaoNokia = Console.ReadLine();
                        // Validando a opção de uso do celular
                        while (opcaoNokia != "1" && opcaoNokia != "2" && opcaoNokia != "3" && opcaoNokia != "4")
                        {
                            Console.Clear();
                            Console.WriteLine("Erro. Opção inválida. Digite novamente.");
                            Console.WriteLine("1 - Ligar\n2 - Receber uma ligação\n3 - Instalar um Aplicativo\n4 - Voltar ao menu anterior");
                            Console.WriteLine("Digite sua opção: ");
                            opcaoNokia = Console.ReadLine();
                        }
                        switch (opcaoNokia)
                        {
                            case "1":
                                Console.Clear();
                                celularNokia.Ligar();
                                Thread.Sleep(300);
                                Console.WriteLine("Ligação concluída.");
                                Console.WriteLine();
                                Console.WriteLine("Aperte qualquer tecla para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "2":
                                Console.Clear();
                                celularNokia.ReceberLigacao();
                                Thread.Sleep(80);
                                Console.WriteLine("Ligação concluída.");
                                Console.WriteLine();
                                Console.WriteLine("Aperte qualquer tecla para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Digite o nome do aplicativo que deseja instalar: ");
                                celularNokia.InstalarAplicativo(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Aperte qualquer tecla para continuar.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Digite o celular que gostaria de acessar: ");
                                Console.WriteLine("1 - Nokia\n2 - iPhone\n3 - Voltar ao menu inicial");
                                opcaoCelular = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Opção inválida! Tente novamente!");
                                break;
                        }
                    }
                }
                else if (opcaoCelular == "2")
                {
                    // Caso o usuário não tenha criado um telefone iPhone anteriormente
                    if (temCelularDisponivelIphone == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Não há nenhum celular iPhone disponível.");
                        Thread.Sleep(500);
                        Console.WriteLine("1 - Nokia\n2 - iPhone\n3 - Voltar ao menu inicial");
                        string opcaoCelulariPhone = Console.ReadLine();
                        opcaoCelular = opcaoCelulariPhone;
                    }
                    else{
                        Console.Clear();
                        Iphone celularIphone = new Iphone(numero, fabricante, numeroImei, memoriaDoCelular);
                        Console.WriteLine("Opção selecionada: iPhone");
                        Console.WriteLine("1 - Ligar\n2 - Receber uma ligação\n3 - Instalar um Aplicativo\n4 - Voltar ao menu anterior");
                        Console.WriteLine("Digite sua opção: ");
                        opcaoIphone = Console.ReadLine();
                        while (opcaoIphone != "1" && opcaoIphone != "2" && opcaoIphone != "3" && opcaoIphone != "4")
                        {
                            Console.Clear();
                            Console.WriteLine("Erro. Opção inválida. Digite novamente.");
                            Console.WriteLine("1 - Ligar\n2 - Receber uma ligação\n3 - Instalar um Aplicativo\n4 - Voltar ao menu anterior");
                            Console.WriteLine("Digite sua opção: ");
                            opcaoIphone = Console.ReadLine();
                        }
                        switch (opcaoIphone)
                        {
                            case "1":
                                Console.Clear();
                                celularIphone.Ligar();
                                Thread.Sleep(80);
                                Console.WriteLine("Ligação concluída.");
                                Console.WriteLine();
                                Console.WriteLine("Aperte qualquer tecla para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "2":
                                Console.Clear();
                                celularIphone.ReceberLigacao();
                                Thread.Sleep(80);
                                Console.WriteLine("Ligação concluída.");
                                Console.WriteLine();
                                Console.WriteLine("Aperte qualquer tecla para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Digite o nome do aplicativo que deseja instalar: ");
                                celularIphone.InstalarAplicativo(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Aperte qualquer tecla para continuar.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Digite o celular que gostaria de acessar: ");
                                Console.WriteLine("1 - Nokia\n2 - iPhone\n3 - Voltar ao menu inicial");
                                opcaoCelular = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Opção inválida! Tente novamente!");
                                break;
                        }
                    }
                }
                else if (opcaoCelular == "3")
                {   
                    Console.Clear();
                    opcaoMenu = MenuPrincipal();
                }  
                break;  
        default:
                Console.WriteLine("Erro! Opção inválida. Tente novamente.");
                opcaoMenu = MenuPrincipal();
                break;

    }
}