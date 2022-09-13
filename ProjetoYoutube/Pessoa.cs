namespace ProjetoYoutube
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Experiencia = 0;
        }

        public override string ToString()
        {
            
            return "Pessoa\n" +
                   "* Nome: " + Nome +
                   "\n* Idade: " + Idade +
                   "\n* Sexo: " + Sexo +
                   "\n* Experiencia: " + Experiencia;
        }
        
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }
        public string Sexo { get; protected set; }
        public float Experiencia { get; }
    }
}
