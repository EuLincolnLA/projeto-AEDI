using System;
using System.Text;

class Investimento {
    private float cdb;
    private float tesouroSelic;
    private float tesouroDireto;

    private float saldoCdb = 0;
    private float saldoTesouroSelic = 0;
    private float saldoTesouroDireto = 0;
    private float saldoConta = 0;

    public Investimento(float cdb, float tesouroSelic, float tesouroDireto) {
        this.cdb = cdb;
        this.tesouroSelic = tesouroSelic;
        this.tesouroDireto = tesouroDireto;
    }

    public void MenuInvestimento() {
        string opcao = "";

        while (opcao != "0") {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===              Investimentos                    ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - Investir.");
            Console.WriteLine("2 - Sacar Investimento.");
            Console.WriteLine("3 - Ver Saldo da Conta.");
            Console.WriteLine("0 - Voltar.");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    MenuInvestir();
                    break;
                case "2":
                    SacarInvestimento();
                    break;
                case "3":
                    VerSaldoConta();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    public void MenuInvestir() {
        string opcao = "";

        while (opcao != "0") {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===                   Investir                    ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - CDB.");
            Console.WriteLine("2 - Tesouro Direto.");
            Console.WriteLine("3 - Tesouro Selic.");
            Console.WriteLine("0 - Voltar.");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    RealizarInvestimento("CDB", cdb, ref saldoCdb);
                    break;
                case "2":
                    RealizarInvestimento("Tesouro Direto", tesouroDireto, ref saldoTesouroDireto);
                    break;
                case "3":
                    RealizarInvestimento("Tesouro Selic", tesouroSelic, ref saldoTesouroSelic);
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu anterior...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void RealizarInvestimento(string tipo, float rendimentoMensal, ref float saldoInvestimento) {
        Console.Clear();
        Console.WriteLine($"Você escolheu: {tipo}");
        Console.Write("Digite a quantia que deseja investir: ");
        float quantia = float.Parse(Console.ReadLine());

        float rendimento = quantia * (rendimentoMensal / 100);
        Console.WriteLine($"Com base na taxa de {rendimentoMensal}%, o rendimento mensal será: {rendimento:C}");

        string confirmar = "";
        while (confirmar.ToLower() != "s" && confirmar.ToLower() != "n") {
            Console.Write("Deseja confirmar o investimento? (s/n): ");
            confirmar = Console.ReadLine();

            if (confirmar.ToLower() == "s") {
                saldoInvestimento += quantia + rendimento;
                Console.WriteLine("Investimento confirmado!");
            } else if (confirmar.ToLower() == "n") {
                Console.WriteLine("Investimento cancelado.");
            } else {
                Console.Clear();
                Console.WriteLine("Opção inválida! Digite 's' para confirmar ou 'n' para cancelar.");
            }
        }

        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }

    private void SacarInvestimento() {
        string opcao = "";

        while (opcao != "0") {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===                Sacar Investimento             ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - CDB.");
            Console.WriteLine("2 - Tesouro Direto.");
            Console.WriteLine("3 - Tesouro Selic.");
            Console.WriteLine("0 - Voltar.");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    Sacar("CDB", ref saldoCdb);
                    break;
                case "2":
                    Sacar("Tesouro Direto", ref saldoTesouroDireto);
                    break;
                case "3":
                    Sacar("Tesouro Selic", ref saldoTesouroSelic);
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu anterior...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void Sacar(string tipo, ref float saldoInvestimento) {
        Console.Clear();
        Console.WriteLine($"Você escolheu sacar do: {tipo}");

        if (saldoInvestimento > 0) {
            Console.WriteLine($"Saldo disponível: {saldoInvestimento:C}");
            Console.Write("Digite a quantia que deseja sacar: ");
            float quantia = float.Parse(Console.ReadLine());

            if (quantia <= saldoInvestimento) {
                saldoInvestimento -= quantia;
                saldoConta += quantia;
                Console.WriteLine($"Saque realizado com sucesso! {quantia:C} foi adicionado à sua conta.");
            } else {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        } else {
            Console.WriteLine("Você não tem saldo suficiente neste investimento.");
        }

        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }

    private void VerSaldoConta() {
        Console.Clear();
        Console.WriteLine($"Saldo atual da conta: {saldoConta:C}");
        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }
}
