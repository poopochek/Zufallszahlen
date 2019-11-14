using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Würfel");
            // Random r = new Random();
            // for (int i = 0; i < 10; i++) 
            //{
            //     int w = r.Next(1, 6);
            //     Console.WriteLine(w);
            //}

            // Console.WriteLine("Lottozahlen 6 aus 49:");  // ohne wiederholte Zahlen
            //Random r = new Random();
            //int[] s = new int[6];
            //for (int i = 0; i < s.Length; i++)
            //{
            //int w = r.Next(1, 50);                Erste Variante
            //if (s.Contains(w)) goto start;
            //   s[i] = w;


            // int w;                               Zweite Variante
            //do
            // {
            //    w = r.Next(1, 50);
            // } while (s.Contains(w));
            //s[i] = w;

            //Console.WriteLine(w);

            //Variabeln: int a;
            //Objekte: int[] a = new int [];  von alle Objekten wird genau irgendwelches bestimmtes Objekt erstellt ( in diesem Fall a)


            // }


            Console.WriteLine("Lottozahlen 6 aus 49:");
            int[] s = new int[49];
            for (int i = 0; i < s.Length; i++) s[i] = i + 1;
            Random r = new Random();
            int z;
            for (int i = 0; i > 6; i ++ )
            {
                z = r.Next(0, s.Length);
                Console.WriteLine();
                s[z] = s[s.Length - 1];
                Array.Resize(ref s, s.Length - 1);
            }




            
        }
    }
}
