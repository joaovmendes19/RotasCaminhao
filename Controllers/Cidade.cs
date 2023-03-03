namespace Controller;

    public class Cidade
    {

        public static void CadastrarCidade(string id, string nome)
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

            Model.Cidade cidade = new Model.Cidade(ConverteId, nome);
        }

        public static void AlterarCidade(string id, string nome)
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

             Model.Cidade.AlterarCidade(ConverteId,nome);
        }

        public static void ExcluirCidade(string id)
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

            Model.Cidade.ExcluirCidade(ConverteId);
        }

        public static List<Model.Cidade> ListarCidade()
        {
            return Model.Cidade.Cidades;

        }

        public static Model.Cidade BuscarCidade(string id)
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

            return Model.Cidade.BuscarCidade(ConverteId);
        }


    }