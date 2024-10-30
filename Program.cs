using System;

namespace projeto_AEDI;

class Program {
    static void Main(string[] args) {
        string opcao = "";
        Investimento investir = new Investimento(11.2f, 6.8f, 10.5f);

        while (opcao != "0") {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===              Banco - BIG BANK                 ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - Investimento");
            Console.WriteLine("0 - Sair.");
            opcao = Console.ReadLine();

            if (opcao == "1") {
                investir.MenuInvestimento();
            } else if (opcao != "0") {
                Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Encerrando o programa...");
    }
}
