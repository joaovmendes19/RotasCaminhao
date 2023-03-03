// contrroller de caminhão com idconvert
namespace Controller;

    public class Caminhao
    {
          public static void CadastrarCaminhao(string id, string placa, string motorista)

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

               Model.Caminhao caminhao = new Model.Caminhao(ConverteId, placa, motorista);
          }  

          public static void AlterarCaminhao(string id, string placa, string motorista)
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

               Model.Caminhao.AlterarCaminhao(ConverteId, placa, motorista);
          }

          public static void ExcluirCaminhao(string id)
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

               Model.Caminhao.ExcluirCaminhao(ConverteId);
          }  

          public static List<Model.Caminhao> ListarCaminhao()
          {
               return Model.Caminhao.Caminhoes;

          }

          public static Model.Caminhao BuscarCaminhao(string id)
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

               return Model.Caminhao.BuscarCaminhao(ConverteId);
               
          }
     

     
     }
    



