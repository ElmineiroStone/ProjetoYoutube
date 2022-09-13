namespace ProjetoYoutube
{
    public class Gafanhoto:Pessoa
    {
        public Gafanhoto(string nome, int idade, string sexo, string login):base(nome, idade, sexo)
        {
            Login = login;
            TotalAssistido = 0;
        }
        public void ViuMaisUm()
        {
            this.TotalAssistido++;
        }
        

        public override string ToString()
        {
            Console.WriteLine("\n=============== Dados do Pessoa/Gafanhoto ===============\n");
            return "Gafanhoto\n" + base.ToString() +
                   "\n* Login: " + Login +
                   "\n* Total Assistido: " + TotalAssistido;
        }

        public string Login { get; private set; }
        public int TotalAssistido { get; private set; }
    }
}
