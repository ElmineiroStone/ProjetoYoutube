namespace ProjetoYoutube
{
    public class Video : IAcoesVideo
    {
        private int avaliacao;

        public Video(string titulo)
        {
            Titulo = titulo;
            Avaliacao = 1;
            Views = 0;
            Curtidas = 0;
            Reproduzindo = false;
        }
        public void Play()
        {
            Reproduzindo = true;
        }
        public void Pause()
        {
            Reproduzindo = false;
        }
        public void Like()
        {
            Curtidas++;
        }
        
        public void RecebeuMaisUm()
        {
            Views++;
        }


        public override string ToString()
        {
            Console.WriteLine("=============== Dados do Video ===============\n");
            return "* Titulo: " + Titulo + 
                   "\n* Avaliação: " + Avaliacao + 
                   "\n* Views: " + Views + 
                   "\n* Curtidas: " + Curtidas + 
                   "\n* Reproduzindo: " + Reproduzindo;
        }

        public string Titulo { get; private set; }
        public int Avaliacao 
        { 
            get => avaliacao; 
            set => avaliacao = value; 
        }
        public int Views { get; private set; }
        public int Curtidas { get; private set; }
        public bool Reproduzindo { get; private set; }
        public int Soma { get; private set; }
    }
}
