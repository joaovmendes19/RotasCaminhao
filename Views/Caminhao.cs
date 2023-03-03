namespace View
{
    public class Caminhao
    {
        public static void CadastrarCaminhao()
        {
            Console.WriteLine("Cadastrar caminhão");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite a placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digit o motorista:");
            string motorista = Console.ReadLine();
            try {
                Controller.Caminhao.CadastrarCaminhao(id, placa, motorista);
                Console.WriteLine("Caminhão cadastrado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar caminhão: {e.Message}");
            }
        }

        public static void AlterarCaminhao()
        {
            Console.WriteLine("Didigite o id do caminhão que deseja alterar:");
            Console.WriteLine("Campo de Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Nova placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Novo motorista:");
            string motorista = Console.ReadLine();
            try {
                Controller.Caminhao.AlterarCaminhao(id, placa, motorista);
                Console.WriteLine("Atualização realizada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao atualizar");
            }
        }

        public static void ExcluirCaminhao()
        {
            Console.WriteLine("digite o id do caminhão que deseja excluir:");
            Console.WriteLine("Campo de Id:");
            string id = Console.ReadLine();
            try {
                Controller.Caminhao.ExcluirCaminhao(id);
                Console.WriteLine("Exclusão sucedida");
            } catch (Exception e) {
                Console.WriteLine($"Exclusão mal sucedida");
            }
        }

        public static void ListarCaminhoes() {
            Console.WriteLine("Caminhões cadastrados no banco:");
            foreach (Model.Caminhao caminhao in Controller.Caminhao.ListarCaminhao()) {
                Console.WriteLine(caminhao);
            }
        }
    }
}