using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust;

            Console.WriteLine("sisesta eesnimi;");
            string userName = Console.ReadLine();

            Console.WriteLine("vali number 1-3");
            char userNumber = Convert.ToChar(Console.ReadLine());



            switch (userNumber)
            {
                case '1':
                    for (int i = userName.Length - 1; i >= 0; i--)
                    {
                        Console.Write(userName[i]);
                    }
                    break;
                case '2':
                    Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
                    break;
                case '3':
                    Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk.");
                    break;
                default:
                    Console.WriteLine("Vale number!");
                    break;

            }


        }   
        
    }
}
