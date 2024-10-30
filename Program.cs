class Program {
    static void Main(string[] args) {
        Conta conta = new Conta("João Silva", 123456, 1234, 1000.0f);
        Investimento investimento = new Investimento(10f, 15f, 20f, conta);

        string opcao = "";
        while (opcao != "0") {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===                Banco - BIG BANK               ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - Acessar Conta.");
            Console.WriteLine("2 - Acessar Investimentos.");
            Console.WriteLine("0 - Sair.");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    conta.MenuConta();
                    break;
                case "2":
                    investimento.MenuInvestimento();
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
