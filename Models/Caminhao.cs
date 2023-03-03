using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Caminhao
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }

        public decimal ValorFat { get; set; }

        public int quantidade { get; set;}

        public decimal media { get; set; }
        public static List<Caminhao> Caminhoes = new List<Caminhao>();

        public Caminhao(int id, string placa, string motorista)
        {
            Id = id;
            Placa = placa;
            Motorista = motorista;
            ValorFat=0;
            quantidade=0;
            media=0;

            Caminhoes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Placa: {Placa}, Motorista: {Motorista}, Valor Faturado: {ValorFat}, Quantidade de Rotas: {quantidade}";
        }

        public static Caminhao BuscarCaminhao(int id)
        {
            foreach (var caminhao in Caminhoes)
            {
                if (caminhao.Id == id)
                {
                    return caminhao;
                }
            }

            throw new Exception("Caminhão não encontrado");
        }

        public static void AlterarCaminhao(int id, string placa, string motorista)
        {
            Caminhao caminhao = BuscarCaminhao(id);
            caminhao.Placa = placa;
            caminhao.Motorista = motorista;
        }
        public static void ExcluirCaminhao(int id)
        {
            Caminhao caminhao = BuscarCaminhao(id);
            Caminhoes.Remove(caminhao);
        }


    
        public List<Rotas> Rotas { get; set; }     // método para obter a quantidade de rotas do caminhão
        public static int ObterQuantidadeDeRotas()
        {
            int quantidade = 0;
            foreach(var rota in Model.Rotas.RotasSistem) {
                foreach(var caminhao in Caminhoes) {
                    if(rota.IdCaminhao == caminhao.Id) {
                        quantidade++;
                    }
                }
              
            }
            return quantidade;
        }     
        // método para obter o valor total das rotas do caminhão
        public static decimal ObterValorTotalDeCadaRotaDoCaminhao()
        {
            decimal valorTotal = 0;
            foreach(var rota in Model.Rotas.RotasSistem) {
                foreach(var caminhao in Caminhoes) {
                    if(rota.IdCaminhao == caminhao.Id) {
                        valorTotal += rota.Valor;
                    }
                }
            }
            return valorTotal;
            
        }

        





    }

}