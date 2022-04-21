using ListaAppuntamenti;

//Introduzione
Console.WriteLine("------------ Agenda Elettronica ------------ ");
Console.WriteLine("Benvenuto . . . ");

//Corpo del programma

//Data e Ora
Console.WriteLine("Inserisci la data e l'ora del tuo appuntamento");
DateTime miadataEOra = DateTime.Parse(Console.ReadLine());

//Nome
Console.WriteLine("Inserisci un nome all'appuntamento");
string? mioNome = Console.ReadLine();
while (mioNome == null)
{
   mioNome = Console.ReadLine();
}

//Località
Console.WriteLine("Inserisci il luogo dell'appuntamento");
string? miaLocalitaAppuntamento = Console.ReadLine();
while (miaLocalitaAppuntamento == null)
{
    miaLocalitaAppuntamento = Console.ReadLine();
}

Appuntamenti mieiAppuntamenti = new Appuntamenti(miadataEOra, mioNome, miaLocalitaAppuntamento);

/* cattura dell'eccezione sul controllo appuntamenti
bool controlloImput = false;
while(controlloImput == false){
    try
        {
        
        } 
    catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Reinserisci la data corretta");
            SetDataEOra(miadataEOra);
        }
}
*/

Console.WriteLine("La data inserita va bene? vuoi cambiarla ? [si/no]");
string? siNoUtente = Console.ReadLine().ToLower();
while (siNoUtente == null)
{
    siNoUtente = Console.ReadLine();
}

bool controlloImput = false;
while (controlloImput == false) { 
    switch (siNoUtente)
    {
        case "si":
            Console.WriteLine("inserisci una nuova data");
            miadataEOra = DateTime.Parse(Console.ReadLine());
            mieiAppuntamenti.SetDataEOra(miadataEOra);
            controlloImput = true;
            break;
        case "no":
            controlloImput = true;
            break;
        default:
            Console.WriteLine("imput errato, reinserisci la tua scelta");
            siNoUtente = Console.ReadLine().ToLower();
            while (siNoUtente == null)
            {
                siNoUtente = Console.ReadLine();
            }
            break;
    }
}