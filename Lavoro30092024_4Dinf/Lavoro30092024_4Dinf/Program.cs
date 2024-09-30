using Lavoro30092024_4Dinf;

Console.WriteLine("gestione bliblioteca");

Console.WriteLine("inserimento libri");



bool continua= true;
while (continua)
{
    Libro oggettolibro = new Libro();

    Console.WriteLine("inserisci titolo:");
    oggettolibro.Titolo = Console.ReadLine();

    Console.WriteLine("inserisci autore:");
    oggettolibro.Autore = Console.ReadLine();

    Console.WriteLine("inserisci numero pagine:");
    oggettolibro.Pagine = int.Parse(Console.ReadLine());

    Console.WriteLine("inserisci prezzo:");
    oggettolibro.Costo = decimal.Parse(Console.ReadLine());


    Console.WriteLine("inserisci se vuole continuare(S/N):");
        string risposta = Console.ReadLine();
    if (risposta == "n") continua= false ;
}


