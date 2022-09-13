namespace ProjetoYoutube
{
    public class Visualizacao
    {
        public Visualizacao (Gafanhoto espectador, Video filme)
        {
            Espectador = espectador;
            Filme = filme;
            Espectador.ViuMaisUm();
            Filme.RecebeuMaisUm();
        }

        public void Avaliar()
        {
            Filme.Avaliacao = 5;
        }
        public void Avaliar(int nota)
        {
            Filme.Avaliacao = nota;
        }

        public void Avaliar(float porcentagem)
        {
            int tot;
            if (porcentagem <= 20)
            {
                tot = 3;
            }
            else if (porcentagem <= 50)
            {
                tot = 5;
            }
            else if (porcentagem <= 90)
            {
                tot = 8;
            }
            else
            {
                tot = 10;
            }
            Filme.Avaliacao = tot;
        }

        public override string ToString()
        {
            return "Visualizacao\n" +
                   "* Espectador: " + Espectador +
                   "\n* Filme: " + Filme;
        }

        public Gafanhoto Espectador { get; private set; }
        public Video Filme { get; private set; }
    }
}
