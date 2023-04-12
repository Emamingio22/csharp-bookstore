Console.WriteLine("------ LIBRO DI OGGI -----");
Console.WriteLine();


string title = "Clean Code: A Handbook of Agile Software Craftsmanship";
string author = "Robert C. Martin";
Console.WriteLine();
Console.WriteLine("informazioni generiche: ");
Console.WriteLine();
long ISBN10 = 9780132350884;
int numeroPagine = 431;
float pesoLibro = 0.800f;
float larghezza = 17.78f;
float lunghezza = 23.37f;
float profondità = 2.79f;


Console.WriteLine("TITOLO: " + title);
Console.WriteLine("AUTORE: " + author);
Console.WriteLine("ISBN-10: " + ISBN10);
Console.WriteLine("NUMERO PAGINE: " + numeroPagine + " pagine");
Console.WriteLine("PESO ARTICOLO: " + pesoLibro + " kg");
Console.WriteLine("DIMENSIONI: " + larghezza + " x " + profondità + " x " + lunghezza + " cm");







Console.WriteLine();
Console.WriteLine("informazioni amazon: ");
Console.WriteLine();
int recensioni = 5413;
float valutazioneMedia = 4.7f;
bool isKindle = true;
bool isFlessibile = true;
string kindle = "";
string flessibile = "";


if (isKindle)
{
    kindle = "SI";
} else
{
    kindle = "NO";
}


if (isFlessibile)
{
    flessibile = "SI";
}
else
{
    flessibile = "NO";
}

Console.WriteLine("NUMERO DI RECENSIONI: " + recensioni + " recensioni");
Console.WriteLine("VALUTAZIONE MEDIA: " + valutazioneMedia + " su 5");
Console.WriteLine("FORMATO KINDLE: " + isKindle + " (15,28 euro)");
Console.WriteLine("COPERTINA FLESSIBILE: " + isFlessibile + " (28,27 euro)");


