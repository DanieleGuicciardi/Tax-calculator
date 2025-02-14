using System;

public class Contribuente
{
    private string Nome { get; }
    private string Cognome { get; }
    private string DataNascita { get;  }
    private string CodiceFiscale { get; set; }  // key
    private string Sesso { get; }
    private string ComuneResidenza { get; }
    private double RedditoAnnuale { get; set; }

    public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, string sesso, string comuneResidenza)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = 0;
    }

    public void SetReddito(double reddito)
    {
        if (reddito >= 0)
            RedditoAnnuale = reddito;
        else
            Console.WriteLine("Errore: Il reddito non può essere negativo!");
    }

    public double CalcoloImposte()
    {
        double imposta = 0;

        if (RedditoAnnuale >= 0 && RedditoAnnuale <= 15000)
        {
            imposta = RedditoAnnuale * 0.23;
            Console.WriteLine("Rientri nella prima categoria!");
            Console.WriteLine($"Imposta da versare: ${imposta}");
            Console.WriteLine("Aliquota del 23%");
        }
        else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
        {
            imposta = 3450 + (RedditoAnnuale - 15000) * 0.27;
            Console.WriteLine("Rientri nella seconda categoria!");
            Console.WriteLine($"Imposta da versare: ${imposta}");
            Console.WriteLine("Aliquota del 27%(eccedenza dei 15k) + 3450$");
        }
        else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
        {
            imposta = 6960 + (RedditoAnnuale - 28000) * 0.38;
            Console.WriteLine("Rientri nella terza categoria!");
            Console.WriteLine($"Imposta da versare: ${imposta}");
            Console.WriteLine("Aliquota del 38%(eccedenza dei 28k) + 6960$");
        }
        else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
        {
            imposta = 17220 + (RedditoAnnuale - 55000) * 0.41;
            Console.WriteLine("Rientri nella quarta categoria!");
            Console.WriteLine($"Imposta da versare: ${imposta}");
            Console.WriteLine("Aliquota del 41%(eccedenza dei 55k) + 17220$");
        }
        else if (RedditoAnnuale > 75000)
        {
            imposta = 25420 + (RedditoAnnuale - 75000) * 0.43;
            Console.WriteLine("Rientri nell ultima categoria!");
            Console.WriteLine($"Imposta da versare: ${imposta}");
            Console.WriteLine("Aliquota del 43%(eccedenza dei 75000k) + 25420$");
        }

        return imposta;
    }

    public void funzione()
    {
        Console.WriteLine("Calcolatore delle imposte, perfavore digita il tuo codice fiscale: ");
        string checkCodiceFiscale = Console.ReadLine();

        if (checkCodiceFiscale == CodiceFiscale)
        {
            Console.WriteLine($"Buongiorno {Nome}, digita qui il tuo reddito: ");
            if (!double.TryParse(Console.ReadLine(), out double reddito))
            {
                Console.WriteLine("Errore: Inserire un numero valido!");
                return;
            }

            SetReddito(reddito);
            Console.WriteLine("Calcolo in corso... premere ENTER per stampare il preventivo!");
            Console.ReadLine();

            Console.WriteLine("Ricevuta:");
            Console.WriteLine($"Contribuente: {Nome} {Cognome},");
            Console.WriteLine($"Nato il {DataNascita} ({Sesso}),");
            Console.WriteLine($"Residente in {ComuneResidenza},");
            Console.WriteLine($"Codice fiscale: {CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {RedditoAnnuale}$");
            CalcoloImposte();
        }
        else
        {
            Console.WriteLine("Errore: Codice fiscale non presente nel database o non valido.");
        }
    }
}
