using LINQ;
using System;
using System.Linq;

namespace Final_Boss
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Vali siit midagi");
            Console.WriteLine("1. Any");
            Console.WriteLine("2. Average");
            Console.WriteLine("3. If else");
            Console.WriteLine("4. Püramiid");

            int valik = Convert.ToInt32(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    Any();
                    break;

                case 2:
                    AvarageLINQ();
                    break;
                case 3:
                    teine();
                    break;
                case 4:
                    puramiid();
                    break;
                default:
                    Console.WriteLine("valisid valesti");
                    break;
            }
        }


        static void Any() //Avarage, Any
        {
            Console.WriteLine("Any LINQ");
            bool isAnyPersonTeenager = PeopleList.peoples
                .Any(x => x.Age > 18);
            //kasvõi üks  andmerida vastab tingimustele, siis tuelb vastus
            Console.WriteLine(isAnyPersonTeenager);
        }

        public static void AvarageLINQ()
        {
            Console.WriteLine("Avarage LINQ");
            //teha Avarage LINQ
            //PeopleList Age kohta teha
            var avarageResult = PeopleList.peoples
                .Average(x => x.Age);

            Console.WriteLine(avarageResult);
        }

        static void teine()

        {
            Console.WriteLine("Kui url on vale, siis annab" +
                "veateate. Kui on õige, siis ütleb, " +
                "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/opilane/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/opilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }

        static void puramiid()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    //Console.Write("{0} ", t++);
                    Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");
            }


        }
    }
}