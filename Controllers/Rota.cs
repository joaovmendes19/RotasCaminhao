
namespace Controller;

public class Rotas
{

    public static void CadastrarRota(string id, string IdOrigem, string IdDestino, string IdCaminhao, string data, decimal Valor)
    {
       if (!int.TryParse(id, out int ConverteId) || !int.TryParse(IdOrigem, out int ConverteIdOrigem))
        {
            throw new Exception("Id inválido");
        }

        Model.Cidade origem = Model.Cidade.BuscarCidade(ConverteIdOrigem);
        Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(IdDestino));
        Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(int.Parse(IdCaminhao));
        Model.Rotas rota = new Model.Rotas(ConverteId, origem, destino, caminhao, data, Valor);
        if(Model.Caminhao.ObterValorTotalDeCadaRotaDoCaminhao()!=0)
        {
            rota.Caminhao.ValorFat = Model.Caminhao.ObterValorTotalDeCadaRotaDoCaminhao();
        }
        if(Model.Caminhao.ObterValorTotalDeCadaRotaDoCaminhao()!=0)
        {
            rota.Caminhao.quantidade = Model.Caminhao.ObterQuantidadeDeRotas();

        }
    }

    public static void AlterarRota(string id, string IdOrigem, string IdDestino, string IdCaminhao, string data, decimal valor)
    {
        if (!int.TryParse(id, out int ConverteId) || !int.TryParse(IdOrigem, out int ConverteIdOrigem))
        {
            throw new Exception("Id inválido");
        }

        Model.Cidade origem = Model.Cidade.BuscarCidade(ConverteIdOrigem);
        Model.Cidade destino = Model.Cidade.BuscarCidade(int.Parse(IdDestino));
        Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(int.Parse(IdCaminhao));

        Model.Rotas.AlterarRota(ConverteId, origem, destino, caminhao, data, valor);
    }

    public static void ExcluirRota(string id)
    {
        int ConverteId;
        try
        {
            ConverteId = Convert.ToInt32(id);
        }
        catch (Exception)
        {
            throw new Exception("Id inválido");
        }

        Model.Rotas.ExcluirRota(ConverteId);
    }

    public static List<Model.Rotas> ListarRota()
    {
        return Model.Rotas.RotasSistem;

    }

    public static Model.Rotas BuscarRota(string id)
    {
        int ConverteId;
        try
        {
            ConverteId = Convert.ToInt32(id);
        }
        catch (Exception)
        {
            throw new Exception("Id inválido");
        }

        return Model.Rotas.BuscarRota(ConverteId);
    }

}