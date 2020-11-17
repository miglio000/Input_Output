using System;
using System.Collections.Generic;
using System.Text;

namespace Input_Output
{
    public class Output
    {
        public static void StampaIntero(int n)
        {
            Console.WriteLine($"Il numero intero è {n}");
        }
        public static void StampaDouble(double n)
        {
            Console.WriteLine($"Il numero decimale è {n}");          
        } 
        public static void StampaStringa(string s)
        {
            Console.WriteLine(s);
        }
        public static void StampaBool(string s)
        {
            Console.WriteLine(s);
        }
    }
}
