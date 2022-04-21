using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamenti
    {
        private DateTime dataEOra;
        private string nome;
        private string localitaAppuntamento;

        //costruttore
        public Appuntamenti(DateTime dataEOra, string nome, string localitaAppuntamento)
        {
            this.dataEOra = dataEOra;

            //Gestione Eccezione sulla data
            bool controlloImput = false;
            while (controlloImput == false)
            {
                try
                {
                    ControlloData();
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Reinserisci la data corretta");
                    this.dataEOra = DateTime.Parse(Console.ReadLine());
                }
            }

            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
        }

        //------------- Metodi -------------

        public void ControlloData()
        {
            DateTime dataOdierna = DateTime.Now;
            if (dataEOra <= dataOdierna)
            {
                throw new ArgumentOutOfRangeException("Non puoi inserire un appuntamento nel passato");
            }
        }

        //------------- Fine Metodi -------------

        //------------- Getters & Setters -------------

        //getters

        public DateTime GetDataEOra()
        {
            return dataEOra;
        }

        public string Getnome()
        {
            return nome;
        }

        public string GetlocalitaAppuntamento()
        {
            return localitaAppuntamento;
        }

        //setters

        public void SetDataEOra(DateTime dataEOra)
        {
            ControlloData();
            this.dataEOra = dataEOra;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetLocalita(string localitaAppuntamento)
        {
            this.localitaAppuntamento = localitaAppuntamento;
        }

        //------------- fine Setter & Getters -------------

    }
}
