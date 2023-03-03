namespace View
{
    public class Rota
    {
        public static void CadastrarRota() {
            Console.WriteLine("Cadastrar Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Origem:");
            string origemId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("O valor da rota:");
            decimal valor = decimal.Parse(Console.ReadLine());
            try {
                Controller.Rotas.CadastrarRota(id, origemId, destinoId, caminhaoId, data,valor);
                Console.WriteLine("Rota cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void AlterarRota() {
            Console.WriteLine("Alterar Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Origem:");
            string origemId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("O valor da rota:");
            decimal valor = decimal.Parse(Console.ReadLine());
            try {
                Controller.Rotas.AlterarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("Rota alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExcluirRota() {
            Console.WriteLine("Excluir Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            try {
                Controller.Rotas.ExcluirRota(id);
                Console.WriteLine("Rota excluída com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListarRotas() {
            Console.WriteLine("Listar Rotas");
            foreach (Model.Rotas rota in Controller.Rotas.ListarRota()) {
                Console.WriteLine(rota);
            }
        }    
    }
}