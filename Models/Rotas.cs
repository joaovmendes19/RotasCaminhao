using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Rotas
    {
        public int Id { get; set; }
        
        public int IdOrigem;

        public int IdDestino;

        public int IdCaminhao;

        public Cidade Origem { get; set; }

        public Cidade Destino { get; set; }

        public Caminhao Caminhao { get; set; }

        public string Data { get; set; }

        public decimal Valor { get; set; }



        public static List<Rotas> RotasSistem {get; set;} = new List<Rotas>();

        public Rotas(int id, Cidade origem, Cidade destino, Caminhao caminhao, string data, decimal valor)
        {
            Id = id;
            Origem = origem;
            IdOrigem = origem.Id;
            Destino = destino;
            IdDestino = destino.Id;
            Caminhao = caminhao;
            IdCaminhao = caminhao.Id;
            Data = data;
            Valor = valor;


            RotasSistem.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Origem: {Origem}, Destino: {Destino}, Caminhão: {Caminhao}, Data: {Data}, Valor: {Valor}";
        }

        public static Rotas BuscarRota(int id)
        {
            foreach (var rota in RotasSistem)
            {
                if (rota.Id == id)
                {
                    return rota;
                }
            }

            throw new Exception("Rota não encontrada");
        }

        public static void AlterarRota(int id, Cidade origem, Cidade destino, Caminhao caminhao, string data, decimal valor)
        {
            Rotas rota = BuscarRota(id);
            rota.Origem = origem;
            rota.Destino = destino;
            rota.Caminhao = caminhao;
            rota.Data = data;
            rota.Valor = valor;
        }

        public static void ExcluirRota(int id)
        {
            Rotas rota = BuscarRota(id);
            RotasSistem.Remove(rota);
        }

        public static decimal MediaValorPorRotas()
        {
            decimal media = 0;
            foreach(var rota in Model.Rotas.RotasSistem) {
                foreach(var caminhao in Model.Caminhao.Caminhoes) {
                    if(rota.IdCaminhao == caminhao.Id) {
                        media += rota.Valor;
                    }
                }
            }
            return media / Model.Caminhao.ObterQuantidadeDeRotas();
        }




    }
    
    

}
