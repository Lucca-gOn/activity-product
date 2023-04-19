// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

using System.Globalization;

string escolherOpcao;
string resposta;

string [] nome = new string[3];
float [] preco = new float[3];
bool [] promocao = new bool[3];

  while (true)
{
  Console.WriteLine(@$"
  █████████
  █▄█████▄█
  █▼▼▼▼▼
  █   Bem vindo, vamos cadastrar os seus produtos?
    Selecione uma das seguintes opções: 
    1 - Cadastrar produtos             
    2 - Listar produtos               
    0 - Sair      
  █▲▲▲▲▲
  █████████
  ██ ██
");

  
  escolherOpcao = (Console.ReadLine());
  switch (escolherOpcao)
  {
  
  case "1":
  for (int i = 0; i < 3; i++)
  {
  
    Console.WriteLine(@$"──────────────────────────────────────────");
    
    Console.WriteLine($"Cadastro de produtos:");
    Console.WriteLine($"Produto {i + 1}º");
    
    Console.WriteLine($"Informe o nome do produto:");
    nome[i] = Console.ReadLine();

    Console.WriteLine("Informe o preço do produto em (R$):");
    preco[i] = float.Parse(Console.ReadLine());

    Console.WriteLine("O produto está em promoção ? (s/n)");
    string oferta = Console.ReadLine().ToLower();
    
    Console.WriteLine(@$"──────────────────────────────────────────");
  
  if (oferta == "s")
  {
    promocao[i] = true;
  }
  else
  {
    promocao[i] = false;
  }

    Console.WriteLine("Produto cadastrado!");

    Console.WriteLine("Desejaria cadastrar um novo produto? (s/n)");
    resposta = Console.ReadLine().ToLower();

    Console.WriteLine($"Pressione qualquer tecla para continuar...");
    Console.ReadKey();
  if (resposta != "s")
  {
    break;
  }
  }
  break;
  
  case "2": 
  if (string.IsNullOrEmpty(nome[0]))
  {
    Console.WriteLine("Nenhum produto foi cadastrado.");
  }
  else
  {

  for (var i = 0; i < 3; i++)
  {
    if (!string.IsNullOrEmpty(nome[i]))
  {
  Console.WriteLine(@$"
  ──────────────────────────────────
        PRODUTOS CADASTRADOS
  Produto: {nome[i]}   
  Preço: {Math.Round(preco[i], 2).ToString("C", new CultureInfo("pt-BR"))} 
  Desconto: {(promocao[i] == true ? "sim" : "não")}
  ──────────────────────────────────
");
  }
  }
  }
  break;

  case "0":
    Console.WriteLine("Obrigado! volte sempre.");
  return;

  default:
    Console.WriteLine("Opção inválida, tente novamente");
  break;
  }
  }