using System;

namespace Input_Output
{
    public class Input
    {
        public static int InserisciIntero()
        {
            Console.Write("Inserisci un numero intero:");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        
            
        public static double InserisciDouble()
        {
            Console.Write("Inserisci un numero decimale:");
            double n = Convert.ToDouble(Console.ReadLine());
            return n;
      
        }
        public static string InserisciStringa()
        {
            Console.Write("Inserisci una stringa:");
            string s = Convert.ToString(Console.ReadLine());
            return s;
        }
        public static string InserisciBool()
        {
            Console.Write("Inserire vero o falso:");
            string condizione = Console.ReadLine();
            if (condizione == "true")
            {
                Console.WriteLine("true");
            }
            else if(condizione == "false")
            {
                Console.WriteLine("false");
            }
            return condizione;
        }
    }
}
