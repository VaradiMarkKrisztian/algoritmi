using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm_curs3 //vectori de numarare
    //parametrizare vector
    //daca e -n,n atunci punem vector de numarare (n+n) ca -n sa inceapa de la 0
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //ex1(); //se dau 2 nr int, afisati cifre comune
            // ex2(); //creati cel mai mare nr si cel mai mic nr format din cifrele sale
            ex3normal(); //sortati vector normal
        }

        private static void ex3normal()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] vn = new int[1001];
            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(1001);//vector poate sa aiba max 1000 elem deci adaugam 1001 pt a avea destule locuri

            for (int i = 0; i < n; i++)
                vn[v[i]]++;

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write(vn[i] + " ");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < vn[i]; j++)
                    Console.Write(i + " "); 
            Console.ReadKey();
        }

        private static void ex2()
        {
            ulong n = 828962000111;
            int[] v = new int[10];
            while(n!=0)
            {
                v[n % 10]++;
                n = n / 10;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v[i] + " ");
            }
            ulong tormax = 0;
            for (int i = 9; i >= 0; i--)
            {
                if(v[i]!=0)
                {
                    for (int j = 0; j < v[i]; j++)
                    {
                        tormax = tormax * 10 + (ulong)i;
                    }
                }
            } 
            ulong tormin = 0;
            if(v[0]!=0)
            {
                int nonzero = 1;
                while (v[nonzero] == 0) nonzero++;
                tormin = (ulong)nonzero;
                v[nonzero]--;
            }
           
            for (int i = 0; i <= 9; i++)
            {
                if (v[i] != 0)
                {
                    for (int j = 0; j < v[i]; j++)
                    {
                        tormin = tormin * 10 + (ulong)i;
                    }
                }
            }
            Console.WriteLine(tormax);
            Console.WriteLine(tormin);
            Console.ReadKey();
        }

        private static void ex1()
        {
            int n1, n2;
            bool[] v1 = new bool[10];
            bool[] v2 = new bool[10];
            n1 = 107538;
            n2 = 38749;
            while (n1 != 0)
            {
                v1[n1 % 10] = true;
                n1 = n1 / 10;
            }
            while(n2!=0)
            {
                v2[n2 % 10] = true;
                n2 = n2 / 10;
            }
            for(int i=0;i<10;i++)
            {
                if (v1[i] && v2[i]) Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
