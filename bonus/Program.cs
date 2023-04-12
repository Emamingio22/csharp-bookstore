Console.WriteLine("------ LIBRO DI OGGI -----");
string title = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("AUTORE: ");
string author = Console.ReadLine();

Console.WriteLine("ISBN: ");
string ISBN10 = Console.ReadLine();

Console.WriteLine("NUMERO PAGINE: ");
int numeroPagine = int.Parse(Console.ReadLine());

Console.WriteLine("PESO ARTICOLO: ");
float pesoLibro = float.Parse(Console.ReadLine());

Console.WriteLine("LARGHEZZA: ");
float larghezza = float.Parse(Console.ReadLine());

Console.WriteLine("LUNGHEZZA: ");
float lunghezza = float.Parse(Console.ReadLine());

Console.WriteLine("PROFONDITA': ");
float profondità = float.Parse(Console.ReadLine());

Console.WriteLine("NUMERO DI RECENSIONI: ");
int recensioni = int.Parse(Console.ReadLine());

Console.WriteLine("VALUTAZIONE MEDIA: ");
float valutazioneMedia = float.Parse(Console.ReadLine());

Console.WriteLine("FORMATO KINDLE: ");
string isKindle = Console.ReadLine();

Console.WriteLine("COPERTINA FLESSIBILE: ");
string isFlessibile = Console.ReadLine();

Console.WriteLine();


Console.WriteLine("IL LIBRO DI OGGI: " + title + " di " + author);

Console.WriteLine();

Console.WriteLine("Informazioni generiche: ");

Console.WriteLine();

Console.WriteLine("ISBN: " + ISBN10);
Console.WriteLine("NUMERO PAGINE: " + numeroPagine + " pagine");
