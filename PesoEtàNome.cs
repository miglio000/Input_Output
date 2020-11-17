using System;
using Input_Output;

namespace peso_età_nome
{
    class PesoEtàNome
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserisci il tuo nome: ");
            string nome = Input.InserisciStringa();
            Output.StampaStringa("Inserici età e peso: ");
            int età = Input.InserisciIntero();
            double peso = Input.InserisciDouble();
            string condizione = Input.InserisciBool();

            Output.StampaStringa($"Sei {nome}, ho {età} anni e peso: {peso} kg.{condizione}");
        }
    }
}
