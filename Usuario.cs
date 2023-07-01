using System;
using System.Xml;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public bool Admin { get; set; }

    public void RealizarCadastro()
    {
        Console.WriteLine("Digite o ID do usuário:");
        Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do usuário:");
        Nome = Console.ReadLine();

        Console.WriteLine("Digite a senha do usuário:");
        Senha = Console.ReadLine();

        Console.WriteLine("O usuário é um administrador? (S/N):");
        string adminInput = Console.ReadLine();
        Admin = (adminInput.ToLower() == "s");
    }

    public void EntrarSistema()
    {
        // Carregar o arquivo XML existente ou criar um novo, se necessário
        XmlDocument xmlDoc = new XmlDocument();
        string xmlFilePath = "usuarios.xml";

        try
        {
            xmlDoc.Load(xmlFilePath);
        }
        catch (Exception)
        {
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xmlDoc.CreateElement("Usuarios");
            xmlDoc.AppendChild(xmlDeclaration);
            xmlDoc.AppendChild(root);
        }

        // Verificar se já existe um usuário com o mesmo nome
        XmlNodeList usuarios = xmlDoc.SelectNodes("/Usuarios/Usuario[Nome='" + Nome + "']");
        if (usuarios.Count > 0)
        {
            Console.WriteLine("Já existe um usuário com o mesmo nome. Acesso negado.");
        }
        else
        {
            // Lógica para entrar no sistema
            Console.WriteLine("Usuário " + Nome + " entrou no sistema.");
        }
    }
}