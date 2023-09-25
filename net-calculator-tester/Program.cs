
using net_calculator_tester;

double a = 5;
double b = 5;

while (true)
{
    Console.WriteLine("Quale operazione vuoi fare?");
    Console.WriteLine();
    Console.WriteLine("1 - SOMMA");
    Console.WriteLine("2 - SOTTRAZIONE");
    Console.WriteLine("3 - MOLTIPLICAZIONE");
    Console.WriteLine("4 - DIVISIONE");
    Console.WriteLine("5 - ESCI");

    string scelta = Console.ReadLine();

    if (string.IsNullOrEmpty(scelta))
    {
        Console.WriteLine("Seleziona un opzione valida");
        continue;
    }

    if (scelta == "1")
    {
        double risultato = Calcolatrice.Somma(a, b);
        Console.WriteLine($"La somma di {a} e {b} e' : {risultato}");
    }

    if (scelta == "2")
    {
        double risultato = Calcolatrice.Sottrazione(a, b);
        Console.WriteLine($"La sottrazione di {a} e {b} e' : {risultato}");
    }

    if (scelta == "3")
    {
        double risultato = Calcolatrice.Moltiplicazione(a, b);
        Console.WriteLine($"La moltiplicazione di {a} e {b} e' : {risultato}");
    }

    if (scelta == "4")
    {
        double risultato = Calcolatrice.Divisione(a, b);
        Console.WriteLine($"La divisione di {a} e {b} e' : {risultato}");
    }

    if (scelta == "5")
    {
        break;
    }


}



