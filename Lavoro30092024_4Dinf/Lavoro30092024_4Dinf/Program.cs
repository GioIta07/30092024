Console.WriteLine("gestione bliblioteca");

Console.WriteLine("inserimento libri");

bool continua= true;
while (continua)
{
    Console.WriteLine("inserisci titolo:");
    string titolo = Console.ReadLine();
    Console.WriteLine("inserisci autore:");
    string autore = Console.ReadLine();
    Console.WriteLine("inserisci numero pagine:");
    int pagine = int.Parse(Console.ReadLine());
    Console.WriteLine("inserisci prezzo:");
    decimal prezzo = decimal.Parse(Console.ReadLine());

    Console.WriteLine("inserisci se vuole continuare:");
        string risposta = Console.ReadLine();
    if (risposta == "n") continua= false ;
}


