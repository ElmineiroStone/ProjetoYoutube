using ProjetoYoutube;

var video = new Video[3];

video[0] = new Video("Aula 1 de POO");
video[1] = new Video("Aula 12 de Csharp");
video[2] = new Video("Aula 10 de Java");

var gafanhoto = new Gafanhoto[2];
gafanhoto[0] = new Gafanhoto("Jubileu", 22, "M", "juba");
gafanhoto[1] = new Gafanhoto("Creuza", 12, "F", "creuzita");

Console.WriteLine("VIDEOS\n--------------------");
Console.WriteLine(video[0].ToString());
Console.WriteLine(video[1].ToString());
Console.WriteLine(video[2].ToString());

Console.WriteLine("\nGAFANHOTOS\n--------------------");
Console.WriteLine(gafanhoto[0].ToString());
Console.WriteLine(gafanhoto[1].ToString());

var visualizacao = new Visualizacao[5];
visualizacao[0] = new Visualizacao(gafanhoto[0], video[2]); // Jubileu assiste Java
visualizacao[0].Avaliar();
Console.WriteLine(visualizacao[0].ToString());
visualizacao[0] = new Visualizacao(gafanhoto[0], video[1]); // Jubileu assiste Csharp
visualizacao[0].Avaliar(87.0f);
Console.WriteLine(visualizacao[0].ToString());

//visualizacao[0].Avaliar();