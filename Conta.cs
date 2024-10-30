using System;

class Conta {
    private string name;
    private int numeroConta;
    private int password;
    private float saldo;
    private float salario;

    public Conta(string name, int numeroConta, int password, float saldo) {
        this.name = name;
        this.numeroConta = numeroConta;
        this.password = password;
        this.saldo = saldo;
        this.salario = 0; // Inicializa o salário como zero
    }

    public float Getsalario() {
        return salario;
    }

    public void Setsalario(float salario) {
        this.salario += salario; // Adiciona o salário ao saldo
        saldo += salario; // Atualiza o saldo
        Console.WriteLine($"Salário adicionado com sucesso! Novo saldo: {saldo:C}");
    }

    public string Getname() {
        return name;
    }

    public void Setname(string name) {
        this.name = name.ToUpper();
    }

    public int GetNumeroConta() {
        return numeroConta;
    }

    public void SetnumeroConta(int numeroConta) {
        this.numeroConta = numeroConta;
    }

    public int Getpassword() {
        return password;
    }

    public void Setpassword(int password) {
        this.password = password;
    }

    public float Getsaldo() {
        return saldo;
    }

    public float Depositar(float valor) {
        saldo += valor; // Adiciona o valor ao saldo
        Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {saldo:C}");
        return saldo;
    }

    public float Sacar() {
        Console.Write("Digite o quanto quer sacar (ou '0' para cancelar): ");
        float valor = float.Parse(Console.ReadLine());
        
        if (valor == 0) {
            Console.WriteLine("Operação de saque cancelada.");
            return saldo; // Cancela o saque e retorna o saldo atual
        }

        if (valor <= 0) {
            Console.WriteLine("Valor para saque deve ser positivo.");
            return saldo;
        }

        if (valor > saldo) {
            Console.WriteLine("Saldo insuficiente.");
            return saldo;
        }

        saldo -= valor; 
        Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {saldo:C}");
        return saldo; 
    }

    public void MenuConta() {
        string opcao = "";

        while (opcao != "0") {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===                 Conta                         ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("1 - Depositar.");
            Console.WriteLine("2 - Sacar.");
            Console.WriteLine("3 - Ver Saldo.");
            Console.WriteLine("4 - Adicionar Salário.");
            Console.WriteLine("0 - Voltar.");
            opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    Console.Write("Digite o valor a ser depositado (ou '0' para cancelar): ");
                    float valorDeposito = float.Parse(Console.ReadLine());

                    if (valorDeposito == 0) {
                        Console.WriteLine("Operação de depósito cancelada.");
                    } else {
                        Depositar(valorDeposito);
                    }
                    break;
                case "2":
                    Sacar();
                    break;
                case "3":
                    Console.WriteLine($"Saldo atual: {saldo:C}");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Write("Digite o salário a ser adicionado (ou '0' para cancelar): ");
                    float valorSalario = float.Parse(Console.ReadLine());
                    Setsalario(valorSalario);
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
}
