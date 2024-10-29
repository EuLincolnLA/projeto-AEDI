using System;
using System.Collections.Generic;
using System.IO;

namespace projeto_AEDI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco de Horas - Sistema de RH");
    }
}
class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Departamento { get; set; }

    public Funcionario(int id, string nome, string departamento)
    {
        Id = id;
        Nome = nome;
        Departamento = departamento;
    }

    // Outros métodos, como AdicionarHoras
}

class BancoDeHoras
{
    public int FuncionarioId { get; set; }
    public DateTime Data { get; set; }
    public int Horas { get; set; }

    public BancoDeHoras(int funcionarioId, DateTime data, int horas)
    {
        FuncionarioId = funcionarioId;
        Data = data;
        Horas = horas;
    }

    // Método para salvar no arquivo TXT
    public void RegistrarHoras(Funcionario funcionario, int horas, DateTime data)
    {
        // Implementação de registro de horas
    }
}

class Departamento
{
    public string Nome { get; set; }
    public List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario>();

    public Departamento(string nome)
    {
        Nome = nome;
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        ListaFuncionarios.Add(funcionario);
    }
}