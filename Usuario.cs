using System;
using System.IO;
class Usuário{
    private string login;
    private string senha;
    private string email;


    public string getLogin(){
        return login;
    }
    public void setLogin(string login){
        this.login = login;
    }

    public string getSenha(){
        return senha;
    }
    public void setSenha(string senha){
        this.senha = senha;
    }

    public string getEmail(){
        return email;
    }
    public void setEmail(string email){
        this.email = email;
    }

     public void criarUsuario()
    {
        string diretorio = @"banco_de_dados";
        string caminhoArquivo = Path.Combine(diretorio, "dados.txt");

        if (!Directory.Exists(diretorio))
        {
            Directory.CreateDirectory(diretorio);
        }

        string caminhoAbsoluto = Path.GetFullPath(caminhoArquivo);
        Console.WriteLine($"Arquivo será salvo em: {caminhoAbsoluto}");

        Console.WriteLine("Digite seu login:");
        string criarLogin = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine(criarLogin);
            }
            Console.WriteLine("Login salvo com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao gravar o arquivo: {ex.Message}");
        }
    }
}

    

