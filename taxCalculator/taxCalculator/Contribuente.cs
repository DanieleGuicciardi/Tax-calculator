using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


internal class Contribuente
{
    private string Nome {  get; set; }
    private string Cognome { get; set; }
    private string DataNascita { get; set; }  
    private string CodiceFiscale { get; set; }  // key
    private string Sesso { get; set; }   
    private string ComuneResidenza { get; set; }
    private int RedditoAnnuale { get; set; }

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

    public void CalcoloImposte()
    {
        if ((RedditoAnnuale >= 0) || (RedditoAnnuale <= 15000))
        {
            //prima funzione
        }
        else if ((RedditoAnnuale > 15000) || (RedditoAnnuale <= 28000))
        {
            //seconda funzione
        }
        else if ((RedditoAnnuale > 28000) || (RedditoAnnuale <= 55000))
        {
            //terza funzione
        }
        else if ((RedditoAnnuale > 55000) || (RedditoAnnuale <= 75000))
        {
            //quarta funzione
        }
        else if (RedditoAnnuale > 75000)
        {
            //quinta funzione
        }
        else
        {
            Console.WriteLine("Errore! Ricontrollare la valuta immessa!");
        }
    }

        
    public void funzione()
    {
        Console.WriteLine("Calcolatore delle imposte, perfavore digita il tuo codice fiscale: ");
        string checkCodiceFiscale = Console.ReadLine();

        while (checkCodiceFiscale == CodiceFiscale)
        {
            Console.WriteLine($"Buongiorno {Nome}, digita qui il tuo reddito: ");
            int RedditoAnnuale = int.Parse(Console.ReadLine());
            CalcoloImposte();
        }

    }
    

}

