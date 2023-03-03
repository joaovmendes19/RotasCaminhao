using System;

namespace Program {

      public class Program
      {
          public static void Main(string[] args)
          {
              Console.WriteLine("Menu de Rotas");
              do{
                    Console.WriteLine("1 - Cadastrar Rota");
                    Console.WriteLine("2 - Alterar Rota");
                    Console.WriteLine("3 - Excluir Rota");
                    Console.WriteLine("4 - Listar Rotas");
                    Console.WriteLine("5 - Cadastrar Cidade");
                    Console.WriteLine("6 - Alterar Cidade");
                    Console.WriteLine("7 - Excluir Cidade");
                    Console.WriteLine("8 - Listar Cidades");
                    Console.WriteLine("9 - Cadastrar Caminhão");
                    Console.WriteLine("10 - Alterar Caminhão");
                    Console.WriteLine("11 - Excluir Caminhão");
                    Console.WriteLine("12 - Listar Caminhões");
                    Console.WriteLine("13 - Mostrar média de valor das rotas");
                    Console.WriteLine("14 - Sair");
                    Console.WriteLine("Digite a opção desejada:");
                    string opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            View.Rota.CadastrarRota();
                            break;
                        case "2":
                            View.Rota.AlterarRota();
                            break;
                        case "3":
                            View.Rota.ExcluirRota();
                            break;
                        case "4":
                            View.Rota.ListarRotas();
                            break;
                        case "5":
                            View.Cidade.CadastrarCidade();
                            break;
                        case "6":
                            View.Cidade.AlterarCidade();
                            break;
                        case "7":
                            View.Cidade.ExcluirCidade();
                            break;
                        case "8":
                            View.Cidade.ListarCidades();
                            break;
                        case "9":   
                            View.Caminhao.CadastrarCaminhao();
                            break;
                        case "10":
                            View.Caminhao.AlterarCaminhao();
                            break;
                        case "11":
                            View.Caminhao.ExcluirCaminhao();
                            break;
                        case "12":
                            View.Caminhao.ListarCaminhoes();
                            break;
                        case "13":
                            Console.WriteLine("A média é: " + Model.Rotas.MediaValorPorRotas());
                            break;
                            
                        case "14":
                            return;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                } while (true);
              }
          }
}