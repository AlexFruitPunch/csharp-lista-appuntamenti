using ListaAppuntamenti;

//Introduzione
Console.WriteLine("------------ Agenda Elettronica ------------ ");
Console.WriteLine("Benvenuto . . . ");

//Corpo del programma

//dichiarazione della lista

List<Appuntamenti> listAppuntamenti = new List<Appuntamenti>();

Console.WriteLine("Quanti appuntamenti vuoi inserire ? ");
int? numeroAppuntamenti = int.Parse(Console.ReadLine());
while (numeroAppuntamenti == null)
{
    numeroAppuntamenti = int.Parse(Console.ReadLine());
}

for(int i = 0; i < numeroAppuntamenti; i++)
{
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

    //Appuntamenti mioAppuntamento = new Appuntamenti(miadataEOra, mioNome, miaLocalitaAppuntamento);

    bool isDataOk = false;

    while (isDataOk == false)
    {

        try
        {
            Appuntamenti appuntamentoInserito = new Appuntamenti(miadataEOra, mioNome, miaLocalitaAppuntamento);

            listAppuntamenti.Add(appuntamentoInserito);

            isDataOk = true;
        }
        catch (Exception ex)
        {

        }
    }

    //inserimento scelta se modificare o meno una data
    Console.WriteLine("La data inserita va bene? vuoi cambiarla ? [si/no]");
    string? siNoUtente = Console.ReadLine().ToLower();
    while (siNoUtente == null)
    {
        siNoUtente = Console.ReadLine();
    }

    //Controllo sulla scelta di modificare o no la data appena inserita
    bool controlloImput = false;
    while (controlloImput == false)
    {
        switch (siNoUtente)
        {
            case "si":
                Console.WriteLine("inserisci una nuova data");
                miadataEOra = DateTime.Parse(Console.ReadLine());
                listAppuntamenti[i].SetDataEOra(miadataEOra);
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
}

foreach(Appuntamenti appuntamenti in listAppuntamenti)
{
    appuntamenti.StampAppuntamento();
}