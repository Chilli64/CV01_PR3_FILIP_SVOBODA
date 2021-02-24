using System;

namespace CV01_PR3_FILIP_SVOBODA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš Rodné Číslo bez /");
            int Pohlaví = 0;
            for (int i = 0; i<10;i++)
            {
                int Číslo = Console.Read();
                if ((i == 2) && ((Číslo == 53) || (Číslo == 54))) 
                {
                    Pohlaví++;
                }
            }
            if (Pohlaví == 0) 
            {
                Console.WriteLine("Rodné číslo je mužské.");
            }
            if (Pohlaví == 1) 
            {
                Console.WriteLine("Rodné číslo je ženské.");
            }
            //string Rodné_Číslo = Console.ReadLine();
            //int RC = Int32.Parse(Rodné_Číslo);
            //int[] Pole = RC;
            //if () 
            { 
            
            }
        }
    }
}
