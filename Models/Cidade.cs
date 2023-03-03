using System;
using System.Collections.Generic;

namespace Model
{
    public  class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        

        public static List<Cidade> Cidades {get; set;} = new List<Cidade>();

        public Cidade(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Cidades.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }

        public static Cidade BuscarCidade(int id)
        {
            foreach (var cidade in Cidades)
            {
                if (cidade.Id == id)
                {
                    return cidade;
                }
            }

            throw new Exception("Cidade não encontrada");
        }

        public static void AlterarCidade(int id, string nome)
        {
            Cidade cidade = BuscarCidade(id);
            cidade.Nome = nome;
        }
        public static void ExcluirCidade(int id)
        {
            Cidade cidade = BuscarCidade(id);
            Cidades.Remove(cidade);
        }
        
    }

    


}