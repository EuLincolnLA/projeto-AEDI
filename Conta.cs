using System.Diagnostics.Contracts;

class Conta{
    private string name;
    private int numeroConta;
    private int password;
    private float saldo;
    private float salario;


public Conta(string name, int numeroConta, int password, float saldo){
    this.name = name;
    this.numeroConta = numeroConta;
    this.password = password;
    this.saldo = saldo;
    this.salario = salario;
    
}

public float Getsalario(){
    return salario;
}

public void Setsalario(float salario){
    saldo = salario;
}
public string Getname(){
    return name;
}

public void Setname(string name){
    name = name.ToUpper();
}

public int GetNumeroConta(){
    return numeroConta;
}

public void SetnumeroConta(int numeroConta){
    numeroConta = numeroConta;
}

public int Getpassword(){
    return password;
}

public void Setpassword(int password){
    password = password;
}

public float Getsaldo(){
    return saldo;
}

public void Setsaldo(float saldo){
    saldo = saldo;
}

public float Sacar() {
        Console.WriteLine("Digite o quanto quer sacar:");
        float valor = float.Parse(Console.ReadLine()); 
        if (valor <= 0) {
            Console.WriteLine("Valor para saque deve ser positivo.");
            return saldo;
        }

        if (valor > saldo) {
            Console.WriteLine("Saldo insuficiente.");
            return saldo;
        }

        saldo -= valor; 
        Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {saldo}");
        return saldo; 
}

public float Depositar(){
    Console.WriteLine("Quanto quer depositar?");
    float valor = float.Parse(Console.ReadLine());
    
    saldo = saldo + valor;
    Console.WriteLine($"Deposito realizado com sucesso! Novo saldo: {saldo}");
        return saldo;
}
}