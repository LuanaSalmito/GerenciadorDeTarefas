using System;



class Program {
    public static Usuario userLogado = null;

    static void Main(string[] args){
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Pink;
    Console.WriteLine("Bem-vindo ao sistema de controle de tarefas!");

    Usuario usuario = new Usuario();
    usuario.RealizarCadastro();
    usuario.EntrarSistema();


    }
    public static int menuVisitante(){
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("--------- Opções --------");
    Console.WriteLine("| 01 - Criar conta       |");
    Console.WriteLine("| 02 - Entrar no Sistema |");
    Console.WriteLine("--------------------------");
    Console.WriteLine("| 00 - Fim               |");
    Console.WriteLine("--------------------------");
    Console.Write("\nOpção: ");
    return int.Parse(Console.ReadLine());
    }
    public static void CriarConta() {
    Console.WriteLine("Nova conta no sistema");
    Console.Write("Informe o nome: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a senha: ");
    string senha = Console.ReadLine();
    Usuario u = new Usuario { Nome = nome, Senha = senha, Admin = true };
    NUsuario.Inserir(u);
    Console.WriteLine("Conta inserida com sucesso");
  }
    public static void EntrarSistema() {
    Console.WriteLine("Entrar no sistema");
    Console.Write("Informe o nome: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a senha: ");
    string senha = Console.ReadLine();
    usuarioLogado = NUsuario.EntrarSistema(nome, senha);
    if (usuarioLogado == null)
      Console.WriteLine("Usuário ou senha incorretos");
    else
      Console.WriteLine("Bem-vindo(a), " + usuarioLogado.Nome);
  }

   public static int menuAdmin(){


    }
}